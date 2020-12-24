using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VkUp.Configs;
using VkUp.Engine;
using VkUp.Targets;

namespace VkUp.Tasks.Settings
{
    public class FlooderSettings
    {
        public Random _rnd = new Random();
        public List<FlooderTarget> Targets;
        private List<string> _phrases, _stickers, _images, _videos;

        // Settings
        public bool ExcludeRepet { get; set; }
        public bool AllTarget { get; set; }
        public bool ReadMessage { get; set; }
        public string TypeDelay { get; set; }
        public int DelayMin { get; set; }
        public int DelayMax { get; set; }
        public bool Enabled { get; set; }
        public bool SetActivity { get; set; }

        // StopWatch
        public bool EnabledStopWatch { get; set; }
        public string IdBound { get; set; }
        public string WatchDelay { get; set; }
        public string IdUser { get; set; }
        public string UserId { get; set; }

        // Обратный таймер
        public int DownCount { get; set; }

        public FlooderSettings()
        {
            Targets = new List<FlooderTarget>();
        }

        private class CounterContainer
        {
            public int PhIndex = 0;
            public string StickerId;
        }
        public void ReloadFrom(string file)
        {
            _phrases = new List<string>(File.ReadAllLines($"Txts\\Phrases\\Flooder\\{file}",
                Encoding.UTF8));
            _stickers = new List<string>(File.ReadAllLines($"Txts\\stickers.txt", Encoding.UTF8));
        }
        public void ReloadAttachmant()
        {
            _images = new List<string>(File.ReadAllLines("Txts\\images.txt"));
            _videos = new List<string>(File.ReadLines("Txts\\videos.txt"));
        }
        public string RandomImeges()
        {
            ReloadAttachmant();
            if (_images.Count == 0)
            {
                Log.Push("Отсутствуют изображения для флуда");
                return null;
            }

            return _images[_rnd.Next(_images.Count)];
        }

        public string RandomVideos()
        {
            ReloadAttachmant();
            if (_videos.Count == 0)
            {
                Log.Push("Отсутствуют видеозаписи для флуда");
                return null;
            }

            return _videos[_rnd.Next(_videos.Count)];
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
        public void ParseDataGridView(DataGridViewRowCollection view)
        {
            Targets.Clear();

            foreach (DataGridViewRow row in view)
            {
                if (row.Cells[0].Value != null)
                {
                    Targets.Add(new FlooderTarget()
                    {
                        Name = (row.Cells[0].Value ?? "").ToString(),
                        Link = (row.Cells[1].Value ?? "").ToString(),
                        NamePlace = (row.Cells[2].Value ?? "").ToString(),
                        Contains = (row.Cells[3].Value ?? "").ToString(),
                        Phrases = (row.Cells[4].Value ?? "").ToString()
                    });
                }
            }
        }
        public string RandomWall()
        {
            var walls = new List<string>(File.ReadAllLines("Txts\\walls.txt"));

            var pattern = new Regex("wall([0-9]+)_([0-9]+)").Match(walls[_rnd.Next(walls.Count)]);

            if (pattern.Success)
                return "wall" + pattern.Groups[1].Value + "_" + pattern.Groups[2].Value;
            else
                return "";
        }
        public dynamic GetConversations(Account acc)
        {
            dynamic conversations = JsonConvert.DeserializeObject(
                Server.APIRequest("messages.getConversations", "count=100&filter=all", acc.Token));
            return conversations;
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
    }
}
