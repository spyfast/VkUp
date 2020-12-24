using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using VkUp.Forms;

namespace VkUp.Engine
{
    public class AccountManager
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string UserId { get; set; }
        public string Info { get; set; }
        private WebClient WebClient { get; set; }
        private Random Random { get; set; }

        public AccountManager(string login, string password)
        {
            Login = login;
            Password = password;
            WebClient = new WebClient() { Encoding = Encoding.UTF8 };
            Random = new Random();
        }

        public string Authorize()
        {
            var token = string.Empty;
            dynamic json =
                JsonConvert.DeserializeObject(WebClient.UploadString(
                    $"https://oauth.vk.com/token?grant_type=password&client_id=3697615&client_secret=AlVXZFMUqyrnABp8ncuU&username={Login}&password={Password}&v=5.107&2fa_supported=1&force_sms=1", "get"));
            token = Convert.ToString(json["access_token"]);
            UserId = Convert.ToString(json["user_id"]);
            GetUser(UserId, token);
            return token;
        }
        public void GetUser(string userId, string token)
        {
            dynamic json = JsonConvert.DeserializeObject(
                Server.APIRequest("users.get", $"user_ids={userId}", token));
            Info = $"{json["response"][0]["first_name"]} {json["response"][0]["last_name"]}";
        }
    }
}
