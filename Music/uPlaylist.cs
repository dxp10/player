using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Linq;

namespace Music
{
    public partial class uPlaylist : UserControl
    {
        #region Properties
        public event EventHandler NewPlaylist_Click;
        public uPlaylist()
        {
            InitializeComponent();
        }
        #endregion

        #region Method 
        public void ShowLanguage(ResourceManager resourceManager, CultureInfo cultureInfo)
        {
            btnNewPlaylist.Text = resourceManager.GetString("btnNewPlaylist", cultureInfo);
            label1.Text = resourceManager.GetString("labelSort", cultureInfo);
        }
        public void AddMyplaylist(uMyplaylist value)
        {
            panelSongs.Controls.Add(value);
        }
        public void Clear()
        {
            panelSongs.Controls.Clear();
        }
        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            if (NewPlaylist_Click != null)
                NewPlaylist_Click(this, e);
        }
        #endregion

        #region Method sort
        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            switch (combo.SelectedIndex)
            {
                case 0:
                    Sort_AtoZ();
                    break;
                case 1:
                    Sort_ZtoA();
                    break;
                default:
                    Sort_AtoZ();
                    break;
            }
        }

        private void Sort_ZtoA()
        {
            List<uMyplaylist> controls = panelSongs.Controls.Cast<uMyplaylist>().ToList();
            controls.Sort(Sort.iCompareArtistZtoA);
            uMyMusic.ChangeColor(panelSongs, controls.ToArray());
        }

        private void Sort_AtoZ()
        {
            List<uMyplaylist> controls = panelSongs.Controls.Cast<uMyplaylist>().ToList();
            controls.Sort(Sort.iCompareArtistAtoZ);
            uMyMusic.ChangeColor(panelSongs, controls.ToArray());
        }
        #endregion


    }
}
