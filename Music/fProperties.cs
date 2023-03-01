using System;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace Music
{
    public partial class fProperties : Form
    {
        #region Method static
        private static string slbProperites = string.Empty; // Properties
        private static string slabel1 = string.Empty;// song title
        private static string slabel2 = string.Empty;//song artist
        private static string slabel3 = string.Empty;//album title
        private static string slabel4 = string.Empty;//album artist
        private static string slabel5 = string.Empty;// gerne
        private static string slabel6 = string.Empty;// Length
        private static string slabel7 = string.Empty;//Year
        private static string slabel8 = string.Empty;//Copyright
        private static string slabel9 = string.Empty;//file location
        private static string sbtnClose = string.Empty;// Close
        public static void ShowLanguage(ResourceManager resource, CultureInfo culture)
        {
            slbProperites = resource.GetString("Properites", culture); // Properties
            slabel1 = resource.GetString("label1", culture);// song title
            slabel2 = resource.GetString("label2", culture);//song artist
            slabel3 = resource.GetString("label3", culture);//album title
            slabel4 = resource.GetString("label4", culture);//album artist
            slabel5 = resource.GetString("label5", culture);// gerne
            slabel6 = resource.GetString("label6", culture);//Length
            slabel7 = resource.GetString("label7", culture);//Year
            slabel8 = resource.GetString("label8", culture);//Copyright
            slabel9 = resource.GetString("label9", culture);//file location
            sbtnClose = resource.GetString("btnClose", culture);// error
        }
        #endregion

        #region Method
        public fProperties(string mediaPath)
        {
            InitializeComponent();
            LoadProperties(mediaPath);
            lblSongName.Text = slbProperites;
            label1.Text = slabel1;
            label2.Text = slabel2;
            label3.Text = slabel3;
            label4.Text = slabel4;
            label5.Text = slabel5;
            label6.Text = slabel6;
            label7.Text = slabel7;
            label8.Text = slabel8;
            label9.Text = slabel9;
            btnClose.Text = sbtnClose;
        }
        public void LoadProperties(string mediaPath)
        {
            songTitle.Text = SongInfo.GetTitle(mediaPath);
            songArtist.Text = SongInfo.GetArtist(mediaPath);
            albumtitle.Text = SongInfo.GetAlbum(mediaPath);
            albumArtist.Text = SongInfo.GetAlbumArtist(mediaPath);
            genre.Text = SongInfo.GetGenrne(mediaPath);
            length.Text = SongInfo.GetLength(mediaPath);
            year.Text = SongInfo.GetYear(mediaPath);
            copyright.Text = SongInfo.GetCopyright(mediaPath);
            fileLocation.Text = mediaPath;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
