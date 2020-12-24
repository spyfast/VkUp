using System;
using System.Windows.Forms;

namespace VkUp.Forms
{
    public partial class MainForm : Form
    {
        public void LoadFormFromSettingsFlooder()
        {
            var account = Accounts[comboBox_accountsList.SelectedIndex];
            dataGrid_flooder.Rows.Clear();

            foreach (var item in account.FlooderSettings.Targets)
                dataGrid_flooder.Rows.Add(item.Name, item.Link, item.NamePlace, item.Contains, item.Phrases);

            checkBox_EnabledFlooder.Checked = account.FlooderSettings.Enabled;
            numeric_DelayFlooderMin.Value = account.FlooderSettings.DelayMin < 333 ? 333 : account.FlooderSettings.DelayMin;
            numeric_DelayFlooderMax.Value = account.FlooderSettings.DelayMax < 333 ? 333 : account.FlooderSettings.DelayMax;
            checkBox_setActivity.Checked = account.FlooderSettings.SetActivity;
            comboBox_TypeDelay.Text = account.FlooderSettings.TypeDelay;
            checkBox_ReadMessage.Checked = account.FlooderSettings.ReadMessage;
            checkBox_ExcludeRepetFlooder.Checked = account.FlooderSettings.ExcludeRepet;
            checkBox_AllTarget.Checked = account.FlooderSettings.AllTarget;
        }
        private void checkBox_RandomReplyMessage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_RandomReplyMessage.Checked)
                checkBox_ReplyMessage.Checked = true;
            else
                checkBox_ReplyMessage.Checked = false;

        }
        private void button_SaveChangesFlooder_Click(object sender, EventArgs e)
        {
            if (comboBox_accountsList.SelectedIndex != -1)
            {
                var account = Accounts[comboBox_accountsList.SelectedIndex];
                account.FlooderSettings.DelayMin = (int)numeric_DelayFlooderMin.Value;
                account.FlooderSettings.DelayMax = (int)numeric_DelayFlooderMax.Value;
                account.FlooderSettings.TypeDelay = comboBox_TypeDelay.Text;
                account.FlooderSettings.SetActivity = checkBox_setActivity.Checked;
                account.FlooderSettings.Enabled = checkBox_EnabledFlooder.Checked;
                account.FlooderSettings.ParseDataGridView(dataGrid_flooder.Rows);
                account.FlooderSettings.ReadMessage = checkBox_ReadMessage.Checked;
                account.FlooderSettings.ExcludeRepet = checkBox_ExcludeRepetFlooder.Checked;
                account.FlooderSettings.AllTarget = checkBox_AllTarget.Checked;
                account.SaveToDisk();

                //label1.Text = $"Следующая отправка смс: {account.FlooderSettings.DelayMin} мс.";
            }
        }
        private void comboBox_TypeDelay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TypeDelay.SelectedIndex == 0)
                numeric_DelayFlooderMax.Enabled = false;
            else
                numeric_DelayFlooderMax.Enabled = true;
        }
    }
}