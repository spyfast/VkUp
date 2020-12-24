using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkUp.Configs;
using VkUp.Engine;
using VkUp.Engine.Helpers;
using VkUp.Targets;

namespace VkUp.Tasks.Settings
{
    public class AutoansSettings
    {
        public List<AutoansTarget> Targets;
        public List<string> _phrases, _stickers, _images, _videos;
        private Random _rnd = new Random();
        public AutoansSettings()
        {
            Targets = new List<AutoansTarget>();
        }
        public bool Enabled { get; set; }
        public bool SetActivity { get; set; }
        public int Delay { get; set; }
        public bool ReplyMessage { get; set; }

        public bool ExcludeRepet { get; set; }
        public bool RandomReplyMessage { get; set; }
        public bool RandomEditMessage { get; set; }
        public bool SendVoiseMessage { get; set; }
        public void ReloadFrom(string file)
        {
            _phrases = new List<string>(File.ReadAllLines($"Txts\\Phrases\\Autoans\\{file}",
                Encoding.UTF8));
            _stickers = new List<string>(File.ReadAllLines($"Txts\\stickers.txt", Encoding.UTF8));
        }
        public void ReloadAttacmant()
        {
            _images = new List<string>(File.ReadAllLines("Txts\\images.txt"));
            _videos = new List<string>(File.ReadAllLines("Txts\\videos.txt"));
        }

        public void ParseDataGridView(DataGridViewRowCollection rows)
        {
            Targets.Clear();

            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells[1].Value != null)
                {
                    Targets.Add(new AutoansTarget
                    {
                        Name = (row.Cells[0].Value ?? "").ToString(),
                        Link = (row.Cells[1].Value ?? "").ToString(),
                        UsersId = (row.Cells[2].Value ?? "").ToString(),
                        Contains = (row.Cells[3].Value ?? "").ToString(),
                        Phrases = (row.Cells[4].Value ?? "").ToString()
                    });
                }
            }
        }
        public string RandomAudio()
        {
            var listAudio = new List<string>();
            var dir = new DirectoryInfo("Audio");
            var fileinfo = dir.GetFiles("*.mp3");

            if (fileinfo.Length == 0)
                return "Not files";
            else
            {
                foreach (var item in fileinfo)
                {
                    listAudio.Add(item.ToString());
                }
                return listAudio[_rnd.Next(listAudio.Count)];
            }
        }
        public void AutoansForKeywords(Account acc, AutoansTarget ft)
        {
            var target = ft.Link;
            var pattern = new Regex("im\\?sel=c([0-9]+)").Match(target);

            dynamic json = JsonConvert.DeserializeObject(Server.APIRequest(
                     "messages.getHistory", $"peer_id={2000000000 + int.Parse(pattern.Groups[1].Value)}&count=2",
                     acc.Token, ""));

            if (json["response"]["count"] != 0 && !RandomAudio().Contains("Not files"))
            {
                var text = Convert.ToString(json["response"]["items"][0]["text"]);

                if (Items.Contains(text))
                {
                    Log.Push($"[Флудер {acc.Login}]: Начинаю загрузку аудиозаписи на сервер");
                    dynamic url =
                    JsonConvert.DeserializeObject(Server.APIRequest("docs.getUploadServer", "type=audio_message",
                        acc.Token));

                    var file = JsonConvert.DeserializeObject(Network.HttpUploadFile(
                        Convert.ToString(url["response"]["upload_url"]), "Audio\\" + RandomAudio(), "file",
                        "audio/MP3"));
                    dynamic saveDocs =
                        JsonConvert.DeserializeObject(Server.APIRequest("docs.save", $"file={file["file"]}", acc.Token));

                    var id = Convert.ToString(saveDocs["response"]["audio_message"]["id"]);
                    var owner_id = Convert.ToString(saveDocs["response"]["audio_message"]["owner_id"]);
                    Log.Push($"[Флудер {acc.Login}]: Загрузка окончена. Подготовка к отправке");

                    if (target.StartsWith("im?sel="))
                    {
                        var users = StrWrk.qSubstr(target, "im?sel=");
                        Server.APIRequest("messages.send", $"user_id={users}&attachment=doc{owner_id}_{id}", acc.Token);
                    }

                    if (target.StartsWith("im?sel=c"))
                    {
                        var chat = StrWrk.qSubstr(target, "im?sel=c");
                        Server.APIRequest("messages.send", $"chat_id={chat}&attachment=doc{owner_id}_{id}", acc.Token);
                    }
                }
            }
        }

        public List<string> Items = new List<string>()
        {
            "актив",
            "кинь актив",
            "на боте",
            "+ если не бот"
        };
        private class CounterContainer
        {
            public int PhIndex = 0;
            public string StickerId;
        }
        public string RandomTextForEditMessage()
        {
            var file = new List<string>(File.ReadAllLines("Txts\\Phrases\\editText.txt"));

            if (file.Count == 0)
            {
                Log.Push("Отсуствуют фразы для редактирования");
                return "";
            }

            return file[_rnd.Next(file.Count)];
        }
        public string RandomPhrase(string file)
        {
            ReloadFrom(file);
            if (_phrases.Count == 0)
            {
                Log.Push("Нет доступных фраз для флуда");
                return null;
            }

            var cc = new CounterContainer();
            cc.PhIndex = _rnd.Next(_phrases.Count);
            return _phrases[cc.PhIndex];
        }
        public string RandomStickers(string file)
        {
            ReloadFrom(file);
            if (_stickers.Count == 0)
            {
                Log.Push("Отсутствуют стикеры для флуда");
                return null;
            }
            var cc = new CounterContainer();
            cc.StickerId = _stickers[_rnd.Next(_stickers.Count)];
            return cc.StickerId;
        }

        public string RandomImeges()
        {
            ReloadAttacmant();
            if (_images.Count == 0)
            {
                Log.Push("Отсутствуют изображения для автоответа");
                return null;
            }

            return _images[_rnd.Next(_images.Count)];
        }
    }
}
