using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VkUp.Configs;
using VkUp.Engine;
using VkUp.Engine.Helpers;
using VkUp.Targets;
using VkUp.Tasks.Settings;

namespace VkUp.Tasks
{
    public class AutoansTask
    {
        private Random _rnd = new Random();
        private int Index { get; set; }
        public AutoansTask(Account account)
        {
            AsyncWorker(account);
        }
        public void AutoansSendMessage(Account acc, AutoansTarget at)
        {
            var ast = new AutoansSettings();
            var message = string.Empty;
            var exclude = new List<string>();
            var idsMessage = new List<string>();

            if (!string.IsNullOrEmpty(at.Name))
            {
                if (at.Name.Contains(":"))
                {
                    var splits = at.Name.Split(':');
                    var sName = new List<string>();
                    foreach (var item in splits)
                        sName.Add(item);
                    at.Name = sName[_rnd.Next(sName.Count)];
                }

                message = $"{at.Name} {ast.RandomPhrase(at.Phrases)}";
            }

            message = WebUtility.UrlEncode(message);

            if (acc.FlooderSettings.ExcludeRepet)
                exclude.Add(message);
            if (acc.FlooderSettings.ExcludeRepet && exclude.Contains(message))
            {
                Log.Push("Обнаружен повтор");
                return;
            }


            if (at.Link.StartsWith("im?sel=c"))
            {
                var chat = StrWrk.qSubstr(at.Link, "im?sel=c");
                dynamic history = JsonConvert.DeserializeObject(
                    Server.APIRequest("messages.getHistory", $"peer_id={2000000000 + int.Parse(chat)}&count=1",
                        acc.Token));
                var fromId = history["response"]["items"][0]["from_id"];
                var idMessage = history["response"]["items"][0]["id"];

                if (acc.AutoansSettings.RandomReplyMessage)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (fromId == at.UsersId)
                        {
                            var ids = history["response"]["items"][0]["id"];
                            idsMessage.Add(ids.ToString());
                        }
                    }
                    if (idsMessage.Count != 0)
                        idMessage = idsMessage[new Random().Next(0, idsMessage.Count)];
                }
                else
                    idMessage = history["response"]["items"][0]["id"];

                if (acc.AutoansSettings.RandomEditMessage)
                {
                    var edit = new List<string>();

                    for (int i = 0; i < 20; i++)
                    {
                        if (fromId == acc.UserId)
                        {
                            var ids = history["response"]["items"][0]["id"];
                            edit.Add(ids.ToString());
                        }
                    }

                    if (edit.Count != 0 && Index == 20)
                    {
                        Thread.Sleep(5000);
                        var strings = edit[new Random().Next(Index)];
                        Server.APIRequest("messages.edit", $"message_id={strings}&peer_id={2000000000 + int.Parse(chat)}&message={ast.RandomTextForEditMessage()}", acc.Token);
                        Index = 0;
                    }
                }


                foreach (var id in at.UsersId.Split(','))
                {
                    if (fromId == id)
                    {
                        if (acc.AutoansSettings.SetActivity)
                        {
                            Server.APIRequest("messages.setActivity", $"chat_id={chat}&type=typing", acc.Token);
                            Thread.Sleep(2000);
                        }

                        if (at.Contains == "Текст")
                        {
                            if (ast.ReplyMessage)
                                Server.APIRequest("messages.send",
                                    $"chat_id={chat}&message={message}&reply_to={idMessage}", acc.Token);
                            else
                                Server.APIRequest("messages.send", $"chat_id={chat}&message={message}", acc.Token);
                            Index += 1;
                        }
                        else if (at.Contains == "Текст+стикер")
                        {
                            if (acc.AutoansSettings.ReplyMessage)
                            {
                                Server.APIRequest("messages.send",
                                    $"chat_id={chat}&message={message}&reply_to={idMessage}", acc.Token);
                                Thread.Sleep(4000);
                                Server.APIRequest("messages.send",
                                    $"chat_id={chat}&sticker_id={ast.RandomStickers(at.Phrases)}", acc.Token);
                            }
                            else
                            {
                                Server.APIRequest("messages.send", $"chat_id={chat}&message={message}", acc.Token);
                                Thread.Sleep(4000);
                                Server.APIRequest("messages.send",
                                    $"chat_id={chat}&sticker_id={ast.RandomStickers(at.Phrases)}", acc.Token);
                            }
                            Index += 1;
                        }
                        else if (at.Contains == "Фото")
                        {
                            if (acc.AutoansSettings.ReplyMessage)
                                Server.APIRequest("messages.send", $"chat_id={chat}&attachment={ast.RandomImeges()}&reply_to={idMessage}", acc.Token);
                            else
                                Server.APIRequest("messages.send", $"chat_id={chat}&attachment={ast.RandomImeges()}", acc.Token);
                            Index += 1;
                        }
                    }
                }
            }
            else if (at.Link.StartsWith("im?sel="))
            {
                if (at.UsersId.Contains(","))
                {
                    Log.Push("Невозможно указать несколько ID для личных сообщений.");
                    return;
                }

                var user = StrWrk.qSubstr(at.Link, "im?sel=");
                dynamic json = JsonConvert.DeserializeObject(
                    Server.APIRequest("messages.getHistory", $"user_id={user}&count=1", acc.Token));
                var id = string.Empty;
                var fromId = Convert.ToString(json["response"]["items"][0]["from_id"]);

                if (acc.AutoansSettings.RandomReplyMessage)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (fromId == at.UsersId)
                        {
                            var ids = json["response"]["items"][0]["id"];
                            idsMessage.Add(ids.ToString());
                        }
                    }
                    if (idsMessage.Count != 0)
                        id = idsMessage[new Random().Next(0, idsMessage.Count)];
                }
                else
                    id = json["response"]["items"][0]["id"];

                if (acc.AutoansSettings.RandomEditMessage)
                {
                    var edit = new List<string>();

                    for (int i = 0; i < 20; i++)
                    {
                        if (fromId == acc.UserId)
                        {
                            var ids = json["response"]["items"][0]["id"];
                            edit.Add(ids.ToString());
                        }
                    }

                    Log.Push(Index.ToString() + edit.Count.ToString());
                    if (edit.Count != 0 && Index == 20)
                    {
                        var strings = edit[new Random().Next(Index)];
                        Server.APIRequest("messages.edit", $"message_id={strings}&peer_id={user}&message={ast.RandomTextForEditMessage()}", acc.Token);
                        Index = 0;
                    }
                }

                if (fromId != at.UsersId)
                {
                    if (acc.AutoansSettings.SetActivity)
                    {
                        Server.APIRequest("messages.setActivity", $"user_id={user}&type=typing", acc.Token);
                        Thread.Sleep(2000);
                    }

                    if (at.Contains == "Текст")
                    {
                        if (acc.AutoansSettings.ReplyMessage)
                            Server.APIRequest("messages.send", $"user_id={user}&message={message}&reply_to={id}", acc.Token);
                        else
                            Server.APIRequest("messages.send", $"user_id={user}&message={message}", acc.Token);
                        Index += 1;
                    }
                    else if (at.Contains == "Текст+стикер")
                    {
                        if (acc.AutoansSettings.ReplyMessage)
                        {
                            Server.APIRequest("messages.send", $"user_id={user}&message={message}&reply_to={id}", acc.Token);
                            Thread.Sleep(4000);
                            Server.APIRequest("messages.send", $"user_id={user}&sticker_id={ast.RandomStickers(at.Phrases)}", acc.Token);
                        }
                        else
                        {
                            Server.APIRequest("messages.send", $"user_id={user}&message={message}", acc.Token);
                            Thread.Sleep(4000);
                            Server.APIRequest("messages.send", $"user_id={user}&sticker_id={ast.RandomStickers(at.Phrases)}", acc.Token);
                        }
                        Index += 1;
                    }
                }
                else if (at.Contains == "Фото")
                {
                    if (acc.AutoansSettings.ReplyMessage)
                        Server.APIRequest("messages.send", $"user_id={user}&attachment={ast.RandomImeges()}&reply_to={id}", acc.Token);
                    else
                        Server.APIRequest("messages.send", $"user_id={user}&attachment={ast.RandomImeges()}", acc.Token);
                    Index += 1;
                }
            }
        }
        public void AsyncWorker(Account acc)
        {
            var ast = acc.AutoansSettings;
            var target = ast.Targets;
            int index = -1;
            if (target.Count == 0)
            {
                Log.Push("Отсутствуют цели автоответчика");
                return;
            }

            while (Account._accountsWork)
            {
                try
                {
                    index = (index + 1) % target.Count;
                    AutoansTarget at = target[index];

                    if (!ast.RandomAudio().Contains("Not files") && acc.AutoansSettings.SendVoiseMessage)
                    {
                        ast.AutoansForKeywords(acc, at);

                        AutoansSendMessage(acc, at);
                    }
                    else
                        AutoansSendMessage(acc, at);

                    Thread.Sleep(ast.Delay);
                }
                catch (Exception ex)
                {
                    Log.Push($"[Автоответчик]: {ex.Message}");
                }
            }
        }
    }
}
