using System;
using System.Windows.Forms;

namespace VkUp.Forms
{
    public partial class MainForm : Form
    {
        public void LoadFormFromSettingsAutoans()
        {
            var account = Accounts[comboBox_accountsList.SelectedIndex];
            dataGrid_Autoans.Rows.Clear();

            foreach (var item in account.AutoansSettings.Targets)
                dataGrid_Autoans.Rows.Add(item.Name, item.Link, item.UsersId, item.Contains, item.Phrases);

            checkBox_EnabledAutoans.Checked = account.AutoansSettings.Enabled;
            numeric_autoansDelay.Value = account.AutoansSettings.Delay < 333 ? 333 : account.AutoansSettings.Delay;
            checkBox_AutoansSetActivity.Checked = account.AutoansSettings.SetActivity;
            checkBox_ReplyMessage.Checked = account.AutoansSettings.ReplyMessage;
            checkBox_RandomEditMessage.Checked = account.AutoansSettings.RandomEditMessage;
            checkBox_ExcludeRepetAutoans.Checked = account.AutoansSettings.ExcludeRepet;
            checkBox_RandomReplyMessage.Checked = account.AutoansSettings.RandomReplyMessage;
            checkBox_SendVoiseMessage.Checked = account.AutoansSettings.SendVoiseMessage;
        }
        private void button_SaveChangesAutoans_Click(object sender, EventArgs e)
        {
            if (comboBox_accountsList.SelectedIndex != -1)
            {
                var account = Accounts[comboBox_accountsList.SelectedIndex];
                account.AutoansSettings.ReplyMessage = checkBox_ReplyMessage.Checked;
                account.AutoansSettings.Enabled = checkBox_EnabledAutoans.Checked;
                account.AutoansSettings.SetActivity = checkBox_AutoansSetActivity.Checked;
                account.AutoansSettings.Delay = (int)numeric_autoansDelay.Value;
                account.AutoansSettings.ParseDataGridView(dataGrid_Autoans.Rows);
                account.AutoansSettings.RandomEditMessage = checkBox_RandomEditMessage.Checked;
                account.AutoansSettings.RandomReplyMessage = checkBox_RandomReplyMessage.Checked;
                account.AutoansSettings.ExcludeRepet = checkBox_ExcludeRepetAutoans.Checked;
                account.AutoansSettings.SendVoiseMessage = checkBox_SendVoiseMessage.Checked;
                account.SaveToDisk();
            }
        }
    }
}