using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System;

namespace Music
{
    public partial class uAlbumDetails : UserControl
    {
        private static ResourceManager resource;
        private static CultureInfo culture;
        public event EventHandler Back_Click;
        public event EventHandler PlayALl_Click;
        public static void ShowLanguage(ResourceManager resources, CultureInfo cultures)
        {
            culture = cultures;
            resource = resources;
        }
        public uAlbumDetails()
        {
            InitializeComponent();
            label2.Text = resource.GetString("Songs", culture);

        }
        public Image ImageShow
        {
            get
            {
                return image.Image;
            }
            set
            {
                image.Image = value;
                background.BackgroundImage= new Bitmap(uPlaylistDetail.CropImage(value));
            }
        }
        public string NameFull
        {
            get
            {
                return lblPlaylistName.Text;
            }
            set
            {
                lblPlaylistName.Text = value;
            }
        }
        public int TotalSong
        {
            set
            {
                lblTotalSong.Text = value.ToString();
            }
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            Back_Click?.Invoke(sender, e);
        }

        private void btnPlayAll_Click(object sender, EventArgs e)
        {
            PlayALl_Click?.Invoke(sender, e);
        }
    }
}
