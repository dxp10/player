using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Music
{
    public partial class uMyplaylist : UserControl
    {
        #region Propeties
        private List<uSong> songs = new List<uSong>();
        public List<uSong> Songs { get => songs; }
        private uAlbumDetails albumDetails = new uAlbumDetails();
        public uAlbumDetails fDetails { get { albumDetails.TotalSong = songs.Count; return albumDetails; } }
        public uMyplaylist()
        {
            InitializeComponent();
        }
        #endregion

        #region Method
        public event EventHandler BtnImage_Click;
        public Image PlaylistImage
        {
            get
            {
                return btnImage.BackgroundImage;
            }
            set
            {
                btnImage.BackgroundImage = value;
            }
        }
        public string PlaylistName
        {
            get
            {
                return labelPlaylistName.Text;
            }
            set
            {
                labelPlaylistName.Text = value;
            }
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            BtnImage_Click?.Invoke(this, e);
        }
        #endregion

        #region Method static
        public static uMyplaylist CreateArtist(uSong song)
        {
            uMyplaylist artist = new uMyplaylist();
            artist.songs.Add(song);
            artist.labelPlaylistName.Text = song.ArtistName;
            artist.btnImage.BackgroundImage = song.ImageSong;
            artist.albumDetails.ImageShow = song.ImageSong;
            artist.albumDetails.NameFull = song.ArtistName;

            return artist;
        }

        public static uMyplaylist CreateAlbum(uSong song)
        {
            uMyplaylist album = new uMyplaylist();
            album.songs.Add(song);
            album.labelPlaylistName.Text = song.Album;
            album.btnImage.BackgroundImage = song.ImageSong;
            album.albumDetails.ImageShow = song.ImageSong;
            album.albumDetails.NameFull = song.ArtistName;
            return album;
        }
        #endregion
    }
}
