using System;
using System.Windows.Forms;

namespace Music
{
    public partial class fRenamePlaylist : Form
    {
        private string PlaylistPath;
        public fRenamePlaylist(string playlistPath)
        {
            InitializeComponent();
            PlaylistPath = playlistPath;
            txbNewPlaylist.Text = MediaPlayer.Instance.GetTitlePlaylist(playlistPath);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            string newName="";
            try
            {
                if (txbNewPlaylist.Text != string.Empty)
                {
                    newName = txbNewPlaylist.Text;
                    MediaPlayer.Instance.RenamePlaylist(PlaylistPath, newName);
                    MessageBox.Show("Rename playlist successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    MediaPlayer.Instance.LoadListPlaylist();
                }
                else
                    MessageBox.Show("This name is not valid.\nPlease retype!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }catch
            {
                MessageBox.Show("This name is not valid.\nPlease retype!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
