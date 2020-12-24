using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkUp.Engine;

namespace VkUp.Tasks.Other
{
    public class UserInfo
    {
        private string Id { get; set; }
        public string Domains { get; set; }
        public Account Account { get; set; }
        public string Get()
        {
            try
            {
                if (string.IsNullOrEmpty(Domains))
                    return "";
                dynamic json = JsonConvert.DeserializeObject(Server.APIRequest(
                    "users.get", $"user_ids={Domains}", Account.Token));
                Id = Convert.ToString(json["response"][0]["id"]);
                return Id;
            }
            catch
            {
                return "Ошибка при получении ID";
            }
        }
    }
}
