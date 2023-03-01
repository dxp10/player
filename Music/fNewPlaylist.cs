using System;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace Music
{
    public partial class fNewPlaylist : Form
    {
        #region Properties & method statíc
        private static string shinTxt = string.Empty;
        private static string sbtnNew = string.Empty;
        private static string sbtnCancel = string.Empty;
        private string playlistName;
        public static void ShowLanguage(ResourceManager resource, CultureInfo culture)
        {
            shinTxt = resource.GetString("txbNewPlaylist", culture);
            sbtnNew = resource.GetString("btnNewPlaylist", culture);
            sbtnCancel = resource.GetString("btnCancel", culture);
        }
        #endregion

        #region Method
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbNewPlaylist.Text))
                playlistName = txbNewPlaylist.Text;
            else
                playlistName = "Playlist";
            MediaPlayer.Instance.CreatePlaylist(playlistName, playlistName);
            MessageBox.Show("Create playlist successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        public fNewPlaylist()
        {
            InitializeComponent();
            txbNewPlaylist.HintText = shinTxt;
            btnCancel.Text = sbtnCancel;
            btnNewPlaylist.Text = sbtnNew;
        }

        #endregion
    }
}
