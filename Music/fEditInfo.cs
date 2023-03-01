using System;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace Music
{
    public partial class fEditInfo : Form
    {
        #region Properties & method static
        private string _mediaPath;
        private static string slblInfo = string.Empty; // edit info
        private static string slabel1 = string.Empty;// song title
        private static string slabel2 = string.Empty;//song artist
        private static string slabel3 = string.Empty;//album title
        private static string slabel4 = string.Empty;//album artist
        private static string slabel5 = string.Empty;// gerne
        private static string slabel7 = string.Empty;//Year
        private static string slabel9 = string.Empty;//file location
        private static string question1 = string.Empty;// edtit question ?
        private static string question2 = string.Empty;//question
        private static string edit1 = string.Empty;// edit successfully
        private static string edit2 = string.Empty;// notify
        private static string editerror = string.Empty;// error
        private static string sbtnSave = string.Empty;//save
        private static string sbtnClose = string.Empty;//close

        public static void ShowLanguage(ResourceManager resource, CultureInfo culture)
        {
            slblInfo = resource.GetString("lblInfo", culture); // edit info
            slabel1 = resource.GetString("label1", culture);// song title
            slabel2 = resource.GetString("label2", culture);//song artist
            slabel3 = resource.GetString("label3", culture);//album title
            slabel4 = resource.GetString("label4", culture);//album artist
            slabel5 = resource.GetString("label5", culture);// gerne
            slabel7 = resource.GetString("label7", culture);//Year
            slabel9 = resource.GetString("label9", culture);//file location
            question1 = resource.GetString("question1", culture);// edtit question ?
            question2 = resource.GetString("question2", culture);//question
            edit1 = resource.GetString("edit1", culture);// edit successfully
            edit2 = resource.GetString("edit2", culture);// notify
            editerror = resource.GetString("editerror", culture);// error
            sbtnSave = resource.GetString("btnSave", culture);// error
            sbtnClose = resource.GetString("btnClose", culture);// error
        }
        #endregion

        #region Method
        public fEditInfo(string mediaPath)
        {
            InitializeComponent();
            _mediaPath = mediaPath;
            LoadProperties(mediaPath);
            lblSongName.Text = slblInfo;
            label1.Text = slabel1;
            label2.Text = slabel2;
            label3.Text = slabel3;
            label4.Text = slabel4;
            label5.Text = slabel5;
            label7.Text = slabel7;
            label9.Text = slabel9;
            bunifuFlatButton2.Text = sbtnSave;
            bunifuFlatButton1.Text = sbtnClose;
        }
        public void LoadProperties(string mediaPath)
        {
            txbSongtitle.Text = SongInfo.GetTitle(mediaPath);
            txbSongArtist.Text = SongInfo.GetArtist(mediaPath);
            txbAlbumTitle.Text = SongInfo.GetAlbum(mediaPath);
            txbAlbumArtist.Text = SongInfo.GetAlbumArtist(mediaPath);
            txbGerne.Text = SongInfo.GetGenrne(mediaPath);
            txbYear.Text = SongInfo.GetYear(mediaPath);
            fileLocation.Text = mediaPath;
        }
        public void EditInfo()
        {
            SongInfo.Save(_mediaPath, txbSongtitle.Text, txbSongArtist.Text, txbAlbumTitle.Text, txbAlbumArtist.Text, txbGerne.Text, uint.Parse(txbYear.Text));
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(question1, question2, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EditInfo();
                    MessageBox.Show(edit1, edit2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                catch
                {
                    MessageBox.Show(editerror, edit2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
    }
}
