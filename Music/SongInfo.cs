using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Music
{
    public class SongInfo
    {
        #region constructor      
        public static readonly Image ImageDefault = Properties.Resources.myMusic;
        internal SongInfo(string filePath) { this.file = TagLib.File.Create(filePath); }
        internal SongInfo() { }
        #endregion

        #region Properties
        private TagLib.File file;

        public string Title
        {
            get
            {
                if (file.Tag.Title is null)
                    return null;
                else return file.Tag.Title.Trim();
            }
        }
        public string Artist
        {
            get
            {
                if (file.Tag.FirstPerformer is null)
                    return string.Empty;
                else
                    return file.Tag.FirstPerformer.Trim();
            }
        }
        public string Song
        {
            get
            {
                if (file.Tag.Title is null)
                    return null;
                else return file.Tag.Title.Trim();
            }
        }
        public string Album
        {
            get
            {
                if (file.Tag.Album is null)
                    return string.Empty;
                else
                    return file.Tag.Album.Trim();
            }
        }
        public string Genrne
        {
            get
            {
                if (file.Tag.FirstGenre is null)
                    return null;
                else return
                    file.Tag.FirstGenre.Trim();
            }
        }
        public string Lyrics
        {
            get
            {
                if (file.Tag.Lyrics is null)
                    return null;
                else
                    return file.Tag.Lyrics.Trim();
            }
            set { file.Tag.Lyrics = value; }
        }
        public System.Drawing.Image LoadImageSong
        {
            get
            {
                TagLib.IPicture firstPicture = file.Tag.Pictures.FirstOrDefault();
                System.Drawing.Image image;

                if (firstPicture != null && firstPicture.Data.Data.Length != 0)
                {
                    var mStream = new MemoryStream();
                    byte[] pData = firstPicture.Data.Data;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    image = System.Drawing.Image.FromStream(mStream);
                    mStream.Dispose();
                }
                else
                {
                    image = ImageDefault;// 
                }
                return image;
            }
        }
        public double Duration
        {
            get => file.Properties.Duration.TotalSeconds;
        }
        #endregion

        #region Method

        internal void SetPath(string filePath)
        {
            if (file != null)
                file.Dispose();
            try
            {
                this.file = TagLib.File.Create(filePath);
            }catch
            {

            }
        }

        #endregion

        #region Method Static
        public void Save()
        {
            file.Save();
        }
        public static void SaveLyrics(string path, string lyrics)
        {
            using (TagLib.File file = TagLib.File.Create(path))
            {
                file.Tag.Lyrics = lyrics;
                file.Save();
            }
        }

        public static void Save(string filePath, string songTitle, string songArtist, string albumTitle, string albumArtist, string gerne, uint year)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
            {
                if (songTitle != null)
                    file.Tag.Title = songTitle;
                if (songArtist != null)
                    file.Tag.Performers = new string[] { songArtist };
                if (albumTitle != null)
                    file.Tag.Album = albumTitle;
                if (albumArtist != null)
                    file.Tag.AlbumArtists = new string[] { albumArtist };
                if (gerne != null)
                    file.Tag.Genres =new string[] { gerne };
                if (year > 1993)
                    file.Tag.Year = year;
                file.Save();
            }
        }
        internal static string GetTitle(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.Title;
        }
        internal static string GetArtist(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.FirstPerformer;
        }
        internal static string GetSong(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.Title;
        }
        internal static string GetAlbum(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.Album;
        }
        internal static string GetGenrne(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.FirstGenre;
        }
        internal static string GetLyrics(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.Lyrics;
        }
        internal static string GetAlbumArtist(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.FirstAlbumArtist;
        }
        internal static string GetYear(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.Year.ToString();
        }
        internal static string GetCopyright(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.Copyright;
        }
        public static string ConvertToMinute(double Second)
        {
            uint minute = (uint)Second / 60;
            uint second = (uint)Second % 60;
            return minute.ToString("00") + ":" + second.ToString("00");
        }
        internal static string GetLength(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return ConvertToMinute(file.Properties.Duration.TotalSeconds);
        }
        internal static System.Drawing.Image GetImageSong(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
            {
                TagLib.IPicture firstPicture = file.Tag.Pictures.FirstOrDefault();
                System.Drawing.Image image;

                if (firstPicture != null && firstPicture.Data.Data.Length != 0)
                {
                    var mStream = new MemoryStream();
                    byte[] pData = firstPicture.Data.Data;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    var bm = new Bitmap(mStream, false);
                    mStream.Dispose();
                    image = bm;
                }
                else
                {
                    image = Music.Properties.Resources.myMusic;
                }
                return image;
            }
        }
        #endregion
    }
}
