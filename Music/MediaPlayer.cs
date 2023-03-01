using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WMPLib;

namespace Music
{
    class MediaPlayer
    {
        #region Properties
        static MediaPlayer instance = new MediaPlayer();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private readonly string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Playlist";
        MediaPlayer()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);

            }
        }
        public static MediaPlayer Instance
        {
            get { return instance; }
            private set => instance = value;
        }

        #endregion

        #region Method meadia
        public double GetCurrentPosition()
        {
            return player.controls.currentPosition;
        }
        public void SetCurrentPosition(int value)
        {
            player.controls.currentPosition = value;
        }
        public void SetVolumn(int volumn)
        {
            player.settings.volume = volumn;
        }
        public int GetVolumn()
        {
            return player.settings.volume;
        }
        public string GetPlayState()
        {
            return player.playState.ToString();
        }
        public void Play()
        {
            player.controls.play();
        }
        public void Play(string path)
        {
            player.URL = path;
        }
        public void Pause()
        {
            player.controls.pause();
        }
        public void Stop()
        {
            player.controls.stop();
        }
        public void Repeat()
        {
            player.settings.setMode("loop", true);
        }
        public void RepeatOff()
        {
            player.settings.setMode("loop", false);
        }
        public void Mute()
        {
            player.settings.mute = true;
        }
        public void MuteOff()
        {
            player.settings.mute = false;
        }
        #endregion

        #region Load
        public string[] LoadLocalFile()
        {
            List<string> listFile = new List<string>();
            string[] listPath = fLocalFiles.ShowLocalFiles();
            if (listPath.Length > 0)
                for (int i = 0; i < listPath.Length; i++)
                {
                    listFile.AddRange(Directory.GetFiles(listPath[i], "*.mp3"));
                }
            return listFile.ToArray();

        }
        public List<string> LoadListPlaylist()
        {
            var listFile = Directory.GetFiles(path, "*.wpl").ToList();
            return listFile;
        }

        #endregion

        #region playlist
        public void CreatePlaylist(string fileName, string title, List<string> listMedia = null)
        {
            string filePath = path + @"\" + fileName + ".wpl";
            if (File.Exists(filePath))
            {
                int i = 1;
                while (File.Exists(path + @"\" + fileName + " (" + i + ").wpl"))
                {
                    i++;
                }
                filePath = path + @"\" + fileName + " (" + i + ").wpl";
            }
            FileStream fileStream = File.Create(filePath);
            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                try
                {
                    streamWriter.WriteLine("<?wpl version=\"1.0\"?>");
                    streamWriter.WriteLine("<smil>");

                    streamWriter.WriteLine("\t<head>");
                    streamWriter.WriteLine("\t\t<meta name=\"Generator\" content=\"Microsoft Windows Media Player-- 12.0.17134.48\"/>");
                    streamWriter.WriteLine("\t\t<meta name=\"ItemCount\" content=\"0\"/>");
                    streamWriter.WriteLine("\t\t<meta name=\"IsFavorite\"/>");
                    streamWriter.WriteLine("\t\t<meta name=\"ContentPartnerListID\"/>");
                    streamWriter.WriteLine("\t\t<meta name=\"ContentPartnerNameType\"/>");
                    streamWriter.WriteLine("\t\t<meta name=\"ContentPartnerName\"/>");
                    streamWriter.WriteLine("\t\t<meta name=\"Subtitle\"/>");
                    streamWriter.WriteLine("\t\t<author/>");
                    streamWriter.WriteLine("\t\t<title>" + title + "</title>");
                    streamWriter.WriteLine("\t</head>");

                    streamWriter.WriteLine("\t<body>");
                    streamWriter.WriteLine("\t\t<seq>");

                    if (listMedia != null)
                        foreach (string item in listMedia)
                            streamWriter.WriteLine("\t\t\t<media src=\"" + item + "\"/>");

                    streamWriter.WriteLine("\t\t</seq>");
                    streamWriter.WriteLine("\t</body>");
                    streamWriter.WriteLine("</smil>");
                }
                catch { }
                streamWriter.Flush();
            }
            fileStream.Close();
        }

        public List<string> ReadPlaylist(string filePath)
        {
            
            List<string> listMedia = new List<string>();
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("<media"))
                {
                    string result = lines[i].Split('"')[1];
                    listMedia.Add(result);
                }
            }
            return listMedia;
        }

        public string GetTitlePlaylist(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("<title>"))
                {
                    return (lines[i].Split('>')[1]).Split('<')[0];
                }
            }
            return null;
        }

        public void RenamePlaylist(string filePath,string newTitle)
        {
            
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("<title>"))
                {
                    lines[i] = "\t\t<title>" + newTitle + "</title>";
                    File.WriteAllLines(filePath, lines);
                    break;
                }
            }
            if (File.Exists(filePath))
            {
                int i = 1;
                while (File.Exists(path + @"\" + newTitle + " (" + i + ").wpl"))
                {
                    i++;
                }
                string newFilePath =path + @"\" + newTitle + " (" + i + ").wpl";
                File.Move(filePath, newFilePath);
            }
        }

        public bool IsMediaExists(string filePath, string mediaPath)
        {
            List<string> listMedia = ReadPlaylist(filePath);
            foreach (var item in listMedia)
            {
                if (item == mediaPath)
                    return true;
            }
            return false;
        }

        public void AddMediaOnPlayList(string filePath, string mediaPath)
        {
            if (!IsMediaExists(filePath, mediaPath))
            {
              
                var lines = File.ReadAllLines(filePath).ToList();
                int i = 0;
                foreach (var item in lines)
                {
                    if(item.Contains("<seq>"))
                    {
                        lines.Insert(i, "\t\t\t<media src=\"" + mediaPath + "\"/>");
                        break;
                    }
                    i++;
                }
                
                File.WriteAllLines(filePath, lines);
            }
        }

        public void RemoveMediaOnPlayList(string filePath, string mediaPath)
        {
            if (IsMediaExists(filePath, mediaPath))
            {
                var lines = File.ReadAllLines(filePath).ToList();
                foreach (var item in lines)
                {
                    if(item.Contains(mediaPath))
                    {
                        lines.Remove(item);
                        break;
                    }
                }
                File.WriteAllLines(filePath, lines);
            }
        }

        public string GetPlaylistPath(string title,List<string> listPlaylist)
        {
            foreach (var item in listPlaylist)
            {
                if (MediaPlayer.Instance.GetTitlePlaylist(item) == title)
                    return item;
            }
            return null;
        }

        public void DeletePlaylist(string filePath)
        {
            File.Delete(filePath);
        }
        #endregion
    }
}
