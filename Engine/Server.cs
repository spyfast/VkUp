using AntiCaptcha.Exceptions;
using Newtonsoft.Json;
using System;
using System.Threading;
using VkUp.Captcha;
using VkUp.Configs;
using VkUp.Engine.Helpers;

namespace VkUp.Engine
{
    public class Server
    {
		public static string APIRequest(string method, string param, string token, string captcha_data = "")
		{
			var rnd = new Random();
			string response = Network.GET(
				$"https://api.vk.com/method/{method}?{param}&access_token={token}{captcha_data}&v=5.107&random_id={rnd.Next()}");

			if (response.Contains("Captcha needed"))
			{
				dynamic json = JsonConvert.DeserializeObject(response);
				Log.Push("Капча...");
				var captchaSid = Convert.ToString(json["error"]["captcha_sid"]);
				var captchaKey = Convert.ToString(json["error"]["captcha_img"]);
				string captcha = string.Empty;

				if (CaptchaSolver.Enabled)
				{
					try
					{
						Log.Push("Обработка капчи");
						captcha = CaptchaSolver.Solve(captchaKey, captchaSid);
					}
					catch (RuCaptchaException e)
					{
						Log.Push($"Ошибка обработки капчи: {e.Message}");
					}
					return APIRequest(method, param, token, $"&captcha_sid={captchaSid}&captcha_key={captchaKey}");
				}
				else
				{
					Log.Push("Изображение поставлено в очередь на ручной ввод");
					captcha = CaptchaSolver.SolveManual(captchaKey, captchaSid);
					return APIRequest(method, param, token, $"&captcha_sid={captchaSid}&captcha_key={captchaKey}");
				}
			}
			else
				return response;
		}

		public static void SetActivity(string text, string token)
		{
			var random = new Random();
			if (text.StartsWith("im?sel=c"))
			{
				var chat = StrWrk.qSubstr(text, "im?sel=c", false);
				APIRequest("messages.setActivity", $"chat_id={chat}&type=typing", token);
				Thread.Sleep(random.Next(2000, 7000));
			}
			else if (text.StartsWith("im?sel="))
			{
				var user = StrWrk.qSubstr(text, "im?sel=", false);
				APIRequest("messages.setActivity", $"user_id={user}&type=typing", token);
				Thread.Sleep(random.Next(2000, 7000));
			}
		}
	}
}
