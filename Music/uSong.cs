using System;
using System.Drawing;
using System.Windows.Forms;

namespace Music
{
    public partial class uSong : UserControl
    {
        #region Construtor
        internal uSong()
        {
            InitializeComponent();
            btnPlay.Image = play;
        }

        #endregion

        #region Properties

        private event EventHandler ButtonPlay_Click;
        internal event EventHandler ButtonOption_Click;
        public event MouseEventHandler Mouse_Click;
        internal double Duration { get; set; }
        private string path;
        internal string SongName
        {
            get
            {
                return lblSongName.Text;
            }
            set
            {
                lblSongName.Text = value;
            }
        }
        internal string ArtistName
        {
            get
            {
                return lblArtistName.Text;
            }
            set
            {
                lblArtistName.Text = value;
            }

        }
        internal string CategoryName
        {
            get
            {
                return lblCategory.Text;
            }
            set
            {
                lblCategory.Text = value;
            }
        }
        internal string TotalTime
        {
            get
            {
                return lblTotalTime.Text;
            }
            set
            {
                lblTotalTime.Text = value;
            }
        }
        internal Image ImageSong
        {
            get
            {
                return pictureBoxSong.Image;
            }
            set
            {
                pictureBoxSong.Image = value;
            }
        }
        internal Image ImageButton
        {
            get
            {
                return btnPlay.Image;
            }
            set
            {
                btnPlay.Image = value;
            }
        }
        internal string Album
        {
            get; set;
        }
        internal string Path { get => path; private set => path = value; }
        #endregion

        #region Click
        private void btnOption_Click_1(object sender, EventArgs e)
        {
            if (ButtonOption_Click != null)
                ButtonOption_Click(this, e);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (ButtonPlay_Click != null)
                ButtonPlay_Click(this, e);
        }
        #endregion

        #region Method Static
        internal static uSong CreateSong(MediaFile file, SongInfo info, EventHandler click, int i,ContextMenuStrip menuStripSong,MouseEventHandler mouseClick)
        {
            uSong song = new uSong();
            info.SetPath(file.FilePath);
            song.Path = file.FilePath;
            info.SetPath(file.FilePath);
            song.ImageSong = info.LoadImageSong;
            song.SongName = info.Song;
            song.ArtistName = info.Artist;
            song.CategoryName = info.Genrne;
            song.Duration = info.Duration;
            song.TotalTime = fMusic.ConvertToMinute(song.Duration);
            song.BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
            song.ButtonPlay_Click += click;
            song.Mouse_Click += mouseClick;
            song.ContextMenuStrip = menuStripSong;
            song.Album = info.Album;
            return song;
        }

        #endregion

        #region Mouse
        private void pictureBoxSong_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Click?.Invoke(this, e);
        }
        #endregion

    }
}
