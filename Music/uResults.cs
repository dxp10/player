using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace Music
{
    public partial class uResults : UserControl
    {
        private string text = string.Empty;

        public uResults()
        {
            InitializeComponent();
        }
        public void ShowLanguage(ResourceManager resource, CultureInfo culture)
        {
            text = resource.GetString("lblSongSearch", culture);
        }
        public string Title
        {
            set
            {
                lblResults.Text = text + value + "\"";
            }
        }
        public void AddSongs(List<uSong> songs)
        {
            foreach (var item in songs)
            {
                panelSongs.Controls.Add(item);
            }
        }
        public void Clear()
        {
            panelSongs.Controls.Clear();
        }
    }
}
