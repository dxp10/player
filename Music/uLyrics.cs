using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class uLyrics : UserControl
    {
        public uLyrics()
        {
            InitializeComponent();
        }
        public string SongName
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
        public string ArtistName
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
        public Image SongImage
        {
            get
            {
                return (Image)pictureBoxSong.Image;
            }
            set
            {
                pictureBoxSong.Image = value;
            }
        }
        public string LyricsText
        {
            get
            {
                return lblLyrics.Text;
            }
            set
            {
                lblLyrics.Text = value;
            }
        }
       
        public event EventHandler btnBack_click;

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnBack_click != null)
                btnBack_click(this, e);
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            btnBack_click?.Invoke(this, e);
        }

        private void pictureBoxSong_Click(object sender, EventArgs e)
        {

        }
    }
}
