using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkUp.Configs;
using VkUp.Engine;
using VkUp.Engine.Helpers;
using VkUp.Targets;
using VkUp.Tasks.Settings;

namespace VkUp.Tasks
{
    public class FlooderTask
    {
        private Random _rnd = new Random();
        public Stopwatch StopWatch = new Stopwatch();

        public FlooderTask(Account account)
        {
            StopWatch = new Stopwatch();
            AsyncWorker(account);
        }
        public void SendFlood(Account acc, FlooderTarget ft)
        {
            var fs = acc.FlooderSettings;
            var message = string.Empty;
            var exclude = new List<string>();
            var chatId = StrWrk.qSubstr(ft.Link, "im?sel=c");
            var userId = StrWrk.qSubstr(ft.Link, "im?sel=");

            if (ft.Name != null)
            {
                if (ft.Name.Contains(":"))
                {
                    var splits = ft.Name.Split(':');
                    var sName = new List<string>();
                    foreach (var item in splits)
                        sName.Add(item);
                    ft.Name = sName[_rnd.Next(sName.Count)];
                }

                if (ft.NamePlace == "Начало")
                    message = $"{ft.Name} {fs.RandomPhrase(ft.Phrases)}";
                else if (ft.NamePlace == "Конец")
                    message = $"{fs.RandomPhrase(ft.Phrases)} {ft.Name}";
            }
            message = WebUtility.UrlEncode(message);

            if (acc.FlooderSettings.ExcludeRepet)
                exclude.Add(message);
            if (acc.FlooderSettings.ExcludeRepet && exclude.Contains(message))
            {
                Log.Push("Обнаружен повтор");
                return;
            }
            if (acc.FlooderSettings.ReadMessage)
            {
                if (ft.Link.StartsWith("im?sel=c"))
                {
                    Server.APIRequest("messages.markAsRead", $"peer_id={2000000000 + int.Parse(chatId)}&mark_conversation_as_read=true", acc.Token);
                    Thread.Sleep(2000);
                }
                else if (ft.Link.StartsWith("im?sel="))
                {
                    Server.APIRequest("messages.markAsRead", $"peer_id={userId}&mark_conversation_as_read=true", acc.Token);
                    Thread.Sleep(2000);
                }
            }

            if (ft.Link.StartsWith("im?sel=c"))
            {
                if (acc.FlooderSettings.SetActivity)
                    Server.SetActivity(ft.Link, acc.Token);
                StartChecking(acc, chatId);

                switch (ft.Contains)
                {
                    case "Текст":
                        Server.APIRequest("messages.send", $"chat_id={chatId}&message={message}", acc.Token);
                        break;
                    case "Текст+стикер":
                        Server.APIRequest("messages.send", $"chat_id={chatId}&message={message}", acc.Token);
                        Thread.Sleep(_rnd.Next(4000, 7000));
                        Server.APIRequest("messages.send", $"chat_id={chatId}&sticker_id={fs.RandomStickers(ft.Phrases)}",
                            acc.Token);
                        break;
                    case "Рандом":
                        var randomContains = _rnd.Next(0, 7);
                        if (randomContains == 1 || randomContains == 3 || randomContains == 0)
                            Server.APIRequest("messages.send", $"chat_id={chatId}&message={message}", acc.Token);
                        else
                        {
                            Server.APIRequest("messages.send", $"chat_id={chatId}&message={message}", acc.Token);
                            Thread.Sleep(_rnd.Next(4000, 7000));
                            Server.APIRequest("messages.send",
                                $"chat_id={chatId}&sticker_id={fs.RandomStickers(ft.Phrases)}", acc.Token);
                        }
                        break;
                    case "Фото":
                        Server.APIRequest("messages.send", $"chat_id={chatId}&attachment={fs.RandomImeges()}", acc.Token);
                        break;
                    case "Текст+фото":
                        Server.APIRequest("messages.send", $"message={message}&chat_id={chatId}&attachment={fs.RandomImeges()}", acc.Token);
                        break;
                    case "Текст+фото+стикер":
                        Server.APIRequest("messages.send", $"message={message}&chat_id={chatId}&attachment={fs.RandomImeges()}", acc.Token);
                        Server.APIRequest("messages.send", $"chat_id={chatId}&sticker_id={fs.RandomStickers(ft.Phrases)}", acc.Token);
                        break;
                    case "Видео":
                        Server.APIRequest("messages.send", $"chat_id={chatId}&attachment={fs.RandomVideos()}", acc.Token);
                        break;
                    case "Текст+видео":
                        Server.APIRequest("messages.send", $"message={message}&chat_id={userId}&attachment={fs.RandomVideos()}", acc.Token);
                        break;
                    case "Текст+видео+стикер":
                        Server.APIRequest("messages.send", $"message={message}&chat_id={chatId}&attachment={fs.RandomVideos()}", acc.Token);
                        Server.APIRequest("messages.send", $"chat_id={chatId}&sticker_id={fs.RandomStickers(ft.Phrases)}", acc.Token);
                        break;
                    case "Запись":
                        Server.APIRequest("messages.send", $"chat_id={chatId}&attachment={fs.RandomWall()}", acc.Token);
                        break;
                }
              

                Log.Push($"[{acc.Login}]: сообщение \"{message}\" отправлено в {ft.Link}");
            }
            else if (ft.Link.StartsWith("im?sel="))
            {
                if (acc.FlooderSettings.SetActivity)
                    Server.SetActivity(ft.Link, acc.Token);

                switch (ft.Contains)
                {
                    case "Текст":
                        Server.APIRequest("messages.send", $"user_id={userId}&message={message}", acc.Token);
                        break;
                    case "Текст+стикер":
                        Server.APIRequest("messages.send", $"user_id={userId}&message={message}", acc.Token);
                        Thread.Sleep(_rnd.Next(4000, 7000));
                        Server.APIRequest("messages.send", $"user_id={userId}&sticker_id={fs.RandomStickers(ft.Phrases)}",
                            acc.Token);
                        break;
                    case "Рандом":
                        var randomContains = _rnd.Next(0, 7);
                        if (randomContains == 1 || randomContains == 3 || randomContains == 0)
                            Server.APIRequest("messages.send", $"user_id={userId}&message={message}", acc.Token);
                        else
                        {
                            Server.APIRequest("messages.send", $"user_id={userId}&message={message}", acc.Token);
                            Thread.Sleep(_rnd.Next(4000, 7000));
                            Server.APIRequest("messages.send",
                                $"user_id={userId}&sticker_id={fs.RandomStickers(ft.Phrases)}", acc.Token);
                        }
                        break;
                    case "Фото":
                        Server.APIRequest("messages.send", $"user_id={userId}&attachment={fs.RandomImeges()}", acc.Token);
                        break;
                    case "Текст+фото":
                        Server.APIRequest("messages.send", $"message={message}&user_id={userId}&attachment={fs.RandomImeges()}", acc.Token);
                        break;
                    case "Текст+фото+стикер":
                        Server.APIRequest("messages.send", $"message={message}&user_id={userId}&attachment={fs.RandomImeges()}", acc.Token);
                        Server.APIRequest("messages.send", $"user_id={userId}&sticker_id={fs.RandomStickers(ft.Phrases)}", acc.Token);
                        break;
                    case "Видео":
                        Server.APIRequest("messages.send", $"user_id={userId}&attachment={fs.RandomVideos()}", acc.Token);
                        break;
                    case "Текст+видео":
                        Server.APIRequest("messages.send", $"message={message}&user_id={userId}&attachment={fs.RandomVideos()}", acc.Token);
                        break;
                    case "Текст+видео+стикер":
                        Server.APIRequest("messages.send", $"message={message}&user_id={userId}&attachment={fs.RandomVideos()}", acc.Token);
                        Server.APIRequest("messages.send", $"user_id={userId}&sticker_id={fs.RandomStickers(ft.Phrases)}", acc.Token);
                        break;
                    case "Запись":
                        Server.APIRequest("messages.send", $"user_id={userId}&attachment={fs.RandomWall()}", acc.Token);
                        break;
                }
                message = WebUtility.UrlDecode(message);
                Log.Push($"[{acc.Login}]: сообщение \"{message}\" отправлено в {ft.Link}");
            }
            else
            {
                Log.Push($"[{acc.Login} флудер]: {ft.Link} — неверный формат ссылки");
            }
        }
        private void StartChecking(Account acc, string target)
        {
            if (acc.FlooderSettings.EnabledStopWatch)
            {
                dynamic history = JsonConvert.DeserializeObject(Server.APIRequest("messages.getHistory",
                        $"count=1&peer_id={2000000000 + int.Parse(target)}", acc.Token));
                var fromId = Convert.ToString(history["response"]["items"][0]["from_id"]);
                if (acc.FlooderSettings.IdBound == fromId)
                    StopWatch.Restart();
                foreach (var idsBound in acc.FlooderSettings.IdBound.Split(','))
                {
                    dynamic getUsers = JsonConvert.DeserializeObject(Server.APIRequest("users.get", $"user_ids={idsBound}", acc.Token));
                    var firstName = Convert.ToString(getUsers["response"][0]["first_name"]);
                    var lastName = Convert.ToString(getUsers["response"][0]["last_name"]);

                    if (acc.FlooderSettings.EnabledStopWatch && (int)StopWatch.Elapsed.TotalMilliseconds >= int.Parse(acc.FlooderSettings.WatchDelay)
                        && fromId != idsBound)
                    {
                        var watchMessage = $"Обнаружен игнор!\nПользователь: *id{idsBound} ({firstName} {lastName})\nВремя: {acc.FlooderSettings.WatchDelay}\nЧат: {target}";
                        Server.APIRequest("messages.send",
                            $"user_id={acc.FlooderSettings.UserId}&message={watchMessage}", acc.Token, null);
                        Log.Push($"[{acc.Login}]: Время игнора вышло... Обновляю счетчик");
                        StopWatch.Restart();
                    }
                }
            }
        }
        public void AsyncWorker(Account acc)
        {
            var fts = acc.FlooderSettings;
            if (fts.EnabledStopWatch)
                StopWatch.Start();
            var _rnd = new Random();
            var target = fts.Targets;
            fts.ReloadAttachmant();


            int index = -1;
            while (Account._accountsWork)
            {
                try
                {
                    index = (index + 1) % target.Count;
                    FlooderTarget ftg = target[index];

                    if (fts.AllTarget)
                    {
                        for (int i = 0; i < target.Count; i++)
                        {
                            var fIndex = target[i];
                            SendFlood(acc, fIndex);
                            Thread.Sleep(1000);
                        }
                    }
                    else
                        SendFlood(acc, ftg);

                    switch (fts.TypeDelay)
                    {
                        case "Обычная":
                            acc.FlooderSettings.DownCount = fts.DelayMin;
                            Thread.Sleep(fts.DelayMin);
                            break;
                        case "Рандомная":
                            var randomDelay = _rnd.Next(fts.DelayMin, fts.DelayMax);
                            acc.FlooderSettings.DownCount = randomDelay;
                            Thread.Sleep(randomDelay);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Log.Push($"[Флудер]: {ex.Message}");
                }
            }
        }
    }
}
