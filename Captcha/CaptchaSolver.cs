using AntiCaptcha.CClient;
using AntiCaptcha.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using VkUp.Configs;

namespace VkUp.Captcha
{
    internal static class CaptchaSolver
    {
        private static CaptchaClient RCC = null;

        public static bool Enabled = false;

        public static Queue<string> toSolve = new Queue<string>();

        private static readonly Dictionary<string, string> answs = new Dictionary<string, string>();
        public static void SetKeyAndProv(CaptchaWorksProvder prov, string key)
        {
            if (prov == CaptchaWorksProvder.RuCaptcha)
            {
                RCC = new CaptchaClient("https://rucaptcha.com", key);
                return;
            }
            RCC = new CaptchaClient("https://anti-captcha.com", key);
        }

        public static string GetBalance()
        {
            if (RCC != null)
            {
                return RCC.GetBalance().ToString();
            }
            return "?";
        }

        public static string Solve(string url, string id)
        {
            var captchaId = string.Empty;
            string text = string.Empty;
            new WebClient().DownloadFile(url, id + ".png");

            try
            {
                captchaId = RCC.UploadCaptchaFile(id + ".png");
            }
            finally
            {
                File.Delete(id + ".png");
            }

            while (string.IsNullOrEmpty(text))
            {
                try
                {
                    text = RCC.GetCaptcha(captchaId);
                }
                catch (Exception ex)
                {
                    if (!ex.Message.Contains("CAPCHA_NOT_READY"))
                    {
                        Log.Push("[Ошибка обработки капчи]: " + ex.Message);
                    }
                }
                Thread.Sleep(1000);
            }
            Log.Push("[Капча]: распознавание завершено");
            return text;
        }

        public static void RegisterManual(string key, string ans)
        {
            answs.Add(key, ans);
        }

        public static string SolveManual(string url, string id)
        {
            new WebClient().DownloadFile(url, id + ".png");
            toSolve.Enqueue(id);
            while (!answs.ContainsKey(id))
            {
                Thread.Sleep(1000);
            }
            string result = answs[id];
            answs.Remove(id);
            return result;
        }
    }
}
