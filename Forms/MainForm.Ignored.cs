using System;
using System.Windows.Forms;

namespace VkUp.Forms
{
    public partial class MainForm : Form
    {
        public void LoadFormFromSettingsIgnored()
        {
            var account = Accounts[comboBox_accountsList.SelectedIndex];

            textbox_IdBound.Text = account.FlooderSettings.IdBound;
            textBox_FromId.Text = account.FlooderSettings.IdUser;
            numericWatch.Text = account.FlooderSettings.WatchDelay;
            check_Box_EnabledStopWatch.Checked = account.FlooderSettings.EnabledStopWatch;
        }
        private void button_SaveChangesWatch_Click(object sender, EventArgs e)
        {
            if (comboBox_accountsList.SelectedIndex != -1)
            {
                var account = Accounts[comboBox_accountsList.SelectedIndex];
                account.FlooderSettings.IdBound = textbox_IdBound.Text;
                account.FlooderSettings.IdUser = textBox_FromId.Text;
                account.FlooderSettings.WatchDelay = numericWatch.Text;
                account.FlooderSettings.EnabledStopWatch = check_Box_EnabledStopWatch.Checked;
                account.SaveToDisk();
            }
        }
    }
}