using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace Music
{
    public partial class uPlaylistDetail : UserControl
    {
        #region Properties
        public uPlaylistDetail()
        {
            InitializeComponent();
        }
        public event EventHandler PlayAll_Click;
        public event EventHandler Rename_Click;
        public event EventHandler Delete_Click;
        public event EventHandler Back_Click;
        #endregion

        #region Method 
        public void ShowLanguage(ResourceManager resource, CultureInfo culture)
        {
            label2.Text = resource.GetString("Songs", culture);
            btnPlayAll.Text = resource.GetString("btnPlayAll", culture);
            btnRename.Text = resource.GetString("btnRename", culture);
            btnDelete.Text = resource.GetString("btnDelete", culture);
        }
        public void AddSong(uSong value)
        {
            panelSongs.Controls.Add(value);
        }
        public static Image CropImage(Image img)
        {
            Rectangle cropArea = new Rectangle(Point.Empty, new Size(img.Size.Width, img.Size.Height / 4));
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }
        public Image PlaylistImage
        {
            get
            {
                return image.Image;
            }
            set
            {
                image.Image = value;
                background.BackgroundImage = new Bitmap(CropImage(value));
            }
        }
        public string PlaylistName
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
        public uSong Song
        {
            set
            {
                panelSongs.Controls.Add(value);
            }
        }
        public int TotalSong
        {
            set
            {
                lblTotalSong.Text = value.ToString();
            }
        }
        public List<uSong> ListSong
        {
            get
            {
                return panelSongs.Controls.Cast<uSong>().ToList();
            }
        }
        public void SetScrollControl(Control value)
        {
            panelSongs.ScrollControlIntoView(value);
        }
        public List<Control> GetControls
        {
            get
            {
                return panelSongs.Controls.Cast<Control>().ToList();
            }
        }
        public void Clear()
        {
            panelSongs.Controls.Clear();
        }


        private void btnPlayAll_Click_2(object sender, EventArgs e)
        {
            PlayAll_Click?.Invoke(this, e);
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            Rename_Click?.Invoke(this, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete_Click?.Invoke(this, e);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        #endregion

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
