using AntiCaptcha.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using VkUp.Captcha;
using VkUp.Configs;
using VkUp.Engine;
using VkUp.Tasks.Other;

namespace VkUp.Forms
{
    public partial class MainForm : Form
    {
        private string CaptchaId { get; set; }
        private List<Account> Accounts;
        public MainForm()
        {
            InitializeComponent();

            if (!File.Exists("Newtonsoft.Json.dll") || !File.Exists("AntiCaptcha.dll"))
            {
                MessageBox.Show("Отсутствуют необходимые .dll для работы приложения: Newtonsoft.Json.dll, AntiCaptcha.dll");
                Environment.Exit(0);
            }

            Accounts = new List<Account>();
            if (!Directory.Exists("Accounts"))
                Directory.CreateDirectory("Accounts");
            if (!Directory.Exists("Audio"))
                Directory.CreateDirectory("Audio");
            if (!Directory.Exists("Txts"))
                Directory.CreateDirectory("Txts");
            if (!Directory.Exists("Txts\\Phrases"))
                Directory.CreateDirectory("Txts\\Phrases");
            if (!Directory.Exists("Txts\\Phrases\\Flooder"))
                Directory.CreateDirectory("Txts\\Phrases\\Flooder");
            if (!Directory.Exists("Txts\\Phrases\\Autoans"))
                Directory.CreateDirectory("Txts\\Phrases\\Autoans");
            if (!File.Exists("Txts\\captcha.txt"))
                File.Create("Txts\\captcha.txt").Close();
            if (!File.Exists("Txts\\accounts.txt"))
                File.Create("Txts\\accounts.txt").Close();
            if (!File.Exists("Txts\\stickers.txt"))
                File.Create("Txts\\stickers.txt").Close();
            if (!File.Exists("Txts\\images.txt"))
                File.Create("Txts\\images.txt").Close();
            if (!File.Exists("Txts\\videos.txt"))
                File.Create("Txts\\videos.txt").Close();
            if (!File.Exists("Txts\\Phrases\\editText.txt"))
                File.Create("Txts\\Phrases\\editText.txt").Close();
            if (!File.Exists("Txts\\walls.txt"))
                File.Create("Txts\\walls.txt").Close();

            LoadCaptcha();
            LoadTxtsFiles();
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            while (Log.Logs.Count != 0)
                richTextBox1.Text = Log.Logs.Dequeue() + "\n" + richTextBox1.Text;
        }
        private void LoadTxtsFiles()
        {
            var txt = new List<string>(Directory.GetFiles("Txts\\Phrases\\Flooder"));
            var txtAuto = new List<string>(Directory.GetFiles("Txts\\Phrases\\Autoans"));
            var dataGridColumnsAuto = (DataGridViewComboBoxColumn)dataGrid_Autoans.Columns[4];
            var dataGridColumns = (DataGridViewComboBoxColumn)dataGrid_flooder.Columns[4];
            foreach (var path in txtAuto)
                dataGridColumnsAuto.Items.Add(Path.GetFileName(path));
            foreach (var path in txt)
                dataGridColumns.Items.Add(Path.GetFileName(path));
        }
        private void radioButton_CaptManual_CheckedChanged(object sender, EventArgs e)
        {
            var array = File.ReadAllText("Txts\\captcha.txt").Split(':');
            if (array.Length != 3)
                array = new[] { "1", array[0], "" };
            if (sender == radioButton_CaptManual)
                array[0] = "0";
            else if (sender == radioButton_CaptRucaptcha)
            {
                array[0] = "1";
                ApiKeyTextBox.Text = array[1];
            }
            else
            {
                array[0] = "2";
                ApiKeyTextBox.Text = array[2];
            }

            if (array[0] == "0")
                CaptchaSolver.Enabled = false;
            else if (array[0] == "1")
            {
                CaptchaSolver.SetKeyAndProv(CaptchaWorksProvder.RuCaptcha, array[1]);
                ApiKeyTextBox.Text = array[1];
            }
            else
            {
                CaptchaSolver.SetKeyAndProv(CaptchaWorksProvder.AntiCaptcha, array[2]);
                ApiKeyTextBox.Text = array[2];
            }

            File.WriteAllText("Txts\\captcha.txt", string.Concat(array[0], ":", array[1], ":", array[2]));
            CaptchaSolver.Enabled = !radioButton_CaptManual.Checked;
            CaptAns.Visible = ManualCaptBox.Visible = CaptPic.Visible = !CaptchaSolver.Enabled;
            label4.Visible = ApiKeyTextBox.Visible = button_saveCaptcha.Visible = button_GetBalanceCaptcha.Visible = CaptchaSolver.Enabled;
        }
        private void LoadCaptcha()
        {
            var readApiKey = File.ReadAllText("Txts\\captcha.txt").Split(':');
            if ((!string.IsNullOrEmpty(readApiKey[0]) || readApiKey[0] == "") && readApiKey.Length == 3)
            {
                switch (readApiKey[0])
                {
                    case "0":
                        CaptchaSolver.Enabled = false;
                        radioButton_CaptManual.Checked = true;
                        break;
                    case "1":
                        CaptchaSolver.SetKeyAndProv(CaptchaWorksProvder.RuCaptcha, readApiKey[1]);
                        radioButton_CaptRucaptcha.Checked = true;
                        ApiKeyTextBox.Text = readApiKey[1];
                        break;
                    case "2":
                        CaptchaSolver.SetKeyAndProv(CaptchaWorksProvder.AntiCaptcha, readApiKey[2]);
                        radioButton_CaptAnticaptcha.Checked = true;
                        ApiKeyTextBox.Text = readApiKey[2];
                        break;
                }
            }
            else
            {
                File.WriteAllText(Path.Combine(
                    "Txts", "captcha.txt"),
                    $"1:{readApiKey[0]}:");
                CaptchaSolver.SetKeyAndProv(CaptchaWorksProvder.RuCaptcha, readApiKey[0]);
                ApiKeyTextBox.Text = readApiKey[0];
                radioButton_CaptRucaptcha.Checked = true;
            }
        }
        private void checkBox_OnOffLogger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_OnOffLogger.Checked)
            {
                richTextBox1.Enabled = false;
                TimerUpdate.Enabled = false;
            }
            else
            {
                richTextBox1.Enabled = true;
                TimerUpdate.Enabled = true;
                Log.Logs.Clear();
            }
        }

        private void TimerCaptcha_Tick(object sender, EventArgs e)
        {
            if (CaptPic.Image == null && CaptchaSolver.toSolve.Count != 0)
            {
                CaptchaId = CaptchaSolver.toSolve.Dequeue();
                var fileStream = new FileStream(CaptchaId + ".png", FileMode.Open);
                CaptPic.Image = Image.FromStream(fileStream);
                fileStream.Close();
                File.Delete(CaptchaId + ".png");
            }
        }

        private void ManualCaptBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                CaptAns_Click(null, null);
        }

        private void CaptAns_Click(object sender, EventArgs e)
        {
            if (ManualCaptBox.Text == "" || CaptchaId == null)
                return;
            CaptchaSolver.RegisterManual(CaptchaId, ManualCaptBox.Text);
            CaptPic.Image.Dispose();
            CaptPic.Image = null;
            CaptchaId = null;
            ManualCaptBox.Clear();
        }

        private void button_GetBalanceCaptcha_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Push($"[Капча]: Баланс капчи: {CaptchaSolver.GetBalance()}");
            }
            catch (Exception ex)
            {
                Log.Push("[Ошибка запроса баланса]: " + ex.Message);
            }
        }

        private void button_saveCaptcha_Click(object sender, EventArgs e)
        {
            if (ApiKeyTextBox.Text.Trim() != "")
            {
                var array = File.ReadAllText("Txts\\captcha.txt").Split(':');
                if (array.Length != 3)
                    array = new[] { "1", array[0], "" };

                if (radioButton_CaptRucaptcha.Checked)
                {
                    CaptchaSolver.SetKeyAndProv(CaptchaWorksProvder.RuCaptcha, ApiKeyTextBox.Text.Trim());
                    array[0] = "1";
                    array[1] = ApiKeyTextBox.Text.Trim();
                }
                else
                {
                    CaptchaSolver.SetKeyAndProv(CaptchaWorksProvder.AntiCaptcha, ApiKeyTextBox.Text.Trim());
                    array[0] = "2";
                    array[2] = ApiKeyTextBox.Text.Trim();
                }

                File.WriteAllText("Txts\\captcha.txt", string.Concat(array[0], ":", array[1], ":", array[2]));
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            var accs = File.ReadAllLines("Txts\\accounts.txt").ToList();

            for (int i = 0; i < accs.Count; i++)
            {
                var item = accs[i].Split(':');

                if (item.ToList().Count != 2)
                    Log.Push("Неверный формат загрузки аккаунтов");
                else
                {
                    Account account;

                    if (!File.Exists($"Accounts\\{item[0]}.xml"))
                        account = new Account(item[0], item[1]);
                    else
                    {
                        var xml = new XmlSerializer(typeof(Account));
                        var fileStr = new FileStream($"Accounts\\{item[0]}.xml", FileMode.Open);
                        var xmlRead = XmlReader.Create(fileStr);
                        account = (Account)xml.Deserialize(xmlRead);
                        fileStr.Close();
                        comboBox_accountsList.Items.Add($"{account.Login} ({account.Info})");
                    }

                    Accounts.Add(account);
                }
            }

            new Thread(delegate ()
            {
                Invoke(new Action(() =>
                {
                    comboBox_accountsList.Items.Clear();
                    foreach (var acc in Accounts)
                    {
                        var token = acc.Authorize();
                        if (!token.Contains("not auth"))
                        {
                            if (token.Contains("ok"))
                            {
                                comboBox_accountsList.Items.Add($"{acc.Login} ({acc.Info})");
                                comboBox_accountsList.SelectedIndex = 0;
                                tabControl.Enabled = true;
                                Log.Push($"Авторизация завершена: {acc.Login}");
                            }
                            else
                                comboBox_accountsList.Text = "Не было загружено ни одного аккаунта";
                        }
                    }
                }));
            })
            { IsBackground = true }.Start();

            if (comboBox_accountsList.Items.Count != 0)
                comboBox_accountsList_SelectedIndexChanged(null, null);
            else
                comboBox_accountsList.Text = "Не было загружено ни одного аккаунта";
        }

        private void comboBox_accountsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_accountsList.SelectedIndex != -1)
            {
                LoadFormFromSettingsFlooder();
                LoadFormFromSettingsIgnored();
                LoadFormFromSettingsAutoans();
            }
        }

        private void button_StartStopBot_Click(object sender, EventArgs e)
        {
            if (!Account._accountsWork)
            {
                Log.Push("Бот запущен");
                TimerCountDown.Start();
                button_StartStopBot.Text = "Стоп";
                foreach (var item in Accounts)
                    item.StartAllTask();
            }
            else
            {
                Log.Push("Бот остановлен");
                TimerCountDown.Stop();
                button_StartStopBot.Text = "Старт";
                foreach (var item in Accounts)
                    item.StopAllTask();
            }
        }
        private void button_getConversations_Click(object sender, EventArgs e)
        {
            new Task(() => Invoke(new Action(() => GetConversations()))).Start();
        }
        private void TimerCountDown_Tick(object sender, EventArgs e)
        {
            var acc = Accounts[comboBox_accountsList.SelectedIndex];
            acc.FlooderSettings.DownCount = acc.FlooderSettings.DownCount - 1000;
            label1.Text = $"След. Отправка через: {acc.FlooderSettings.DownCount} мс.";
        }

        private void button_GetIdUser_Click(object sender, EventArgs e)
        {
            var user = new UserInfo()
            {
                Account = Accounts[comboBox_accountsList.SelectedIndex],
                Domains = textBox_Domains.Text
            };
            new Task(() => 
            {
                Invoke(new Action(() => 
                {
                    textBox_Domains.Text = $"ID: {user.Get()}";
                }));
            }).Start();
        }
    }
}
