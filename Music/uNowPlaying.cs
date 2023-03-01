using System.Windows.Forms;

namespace Music
{
    public partial class uNowPlaying : UserControl
    {
        #region Method
        public uNowPlaying()
        {
            InitializeComponent();
        }
        public void AddSong(uSong value)
        {
            panelSongs.Controls.Add(value);
        }
        public void AddHeadSong(uSong song)
        {
            panelSongs.Controls.Add(song);
            panelSongs.Controls.SetChildIndex(song, 0);
        }
        public void AddSongs(uSong[] value)
        {
            panelSongs.Controls.Clear();
            panelSongs.Controls.AddRange(value);
        }
        public void SetScrollControl(uSong value)
        {
            panelSongs.ScrollControlIntoView(value);
        }
        public void Clear()
        {
            panelSongs.Controls.Clear();
        }
        #endregion
    }
}
