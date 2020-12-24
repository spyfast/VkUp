using System;
using System.Windows.Forms;
using VkUp.Configs;

namespace VkUp.Forms
{
    public partial class MainForm : Form
    {
        private void GetConversations()
        {
            try
            {
                comboBox_conversationsList.Items.Clear();
                var account = Accounts[comboBox_accountsList.SelectedIndex];
                dynamic convertsations = account.FlooderSettings.GetConversations(account);

                for (int i = 0; i < 101; i++)
                {
                    if (Convert.ToString(convertsations["response"]["items"][i]["conversation"]["peer"]["type"]) == "user")
                        continue;
                    var titleConversations = Convert.ToString(convertsations["response"]["items"][i]["conversation"]["chat_settings"]["title"]);
                    var localID = Convert.ToString(convertsations["response"]["items"][i]["conversation"]["peer"]["local_id"]);
                    comboBox_conversationsList.Items.Add($"im?sel=c{localID} ({titleConversations})");
                    comboBox_conversationsList.SelectedIndex = 0;
                }
            }
            catch { }
        }
    }
}