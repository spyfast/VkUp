using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using VkUp.Configs;
using VkUp.Tasks;
using VkUp.Tasks.Settings;

namespace VkUp.Engine
{
    public class Account
    {
        // Settings
        public FlooderSettings FlooderSettings;
        public AutoansSettings AutoansSettings;
        public string Login { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string Info { get; set; }
        public string UserId { get; set; }
        public static bool _accountsWork { get; set; } = false;
        public bool _tokenStatus { get; set; } = false;

        public Account() { }
        public Account(string login, string password)
        {
            Login = login;
            Password = password;
            FlooderSettings = new FlooderSettings();
            AutoansSettings = new AutoansSettings();
        }

        public string Authorize()
        {
            try
            {
                var account = new AccountManager(Login, Password);
                Token = account.Authorize();
                Info = account.Info;
                UserId = account.UserId;
                _tokenStatus = true;
                return "ok";
            }
            catch
            {
                Log.Push($"[{Login}]: Возникла ошибка при попытке авторизации. Стоит двухфакторная аутентификация?");
                return "not auth";
            }
        }

        public void SaveToDisk()
        {
            var xml = new XmlSerializer(typeof(Account));
            var writer = new StreamWriter($"Accounts\\{Login}.xml");
            xml.Serialize(writer, this);
            writer.Close();
        }

        public void StartAllTask()
        {
            _accountsWork = true;
            if (FlooderSettings.Enabled)
                new Task(() => new FlooderTask(this)).Start();
            if (AutoansSettings.Enabled)
                new Task(() => new AutoansTask(this)).Start();
        }
        public void StopAllTask()
        {
            _accountsWork = false;
        }
    }
}
