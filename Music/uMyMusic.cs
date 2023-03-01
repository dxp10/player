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
    public partial class uMyMusic : UserControl
    {
        #region Properties
        private List<uSong> songs;
        private List<uMyplaylist> artists = new List<uMyplaylist>();
        private List<uMyplaylist> albums = new List<uMyplaylist>();
        public List<uMyplaylist> ListAlbums
        {
            get => albums;
        }
        public List<uMyplaylist> ListArtists
        {
            get => artists;
        }
        public event EventHandler SongsClick;
        public event EventHandler Artist_Click;
        public event EventHandler Album_Click;
        public event EventHandler SongsSorted;
        public event EventHandler Shuff_Click;
        public event EventHandler PlayAll_Click;
        public uMyMusic()
        {
            InitializeComponent();
            btnShuufleAllArtists.IconVisible = true;
            btnShuffAlbum.IconVisible = true;
            btnShuffleAllSongs.IconVisible = true;
        }
        #endregion

        #region Method
        public void ShowLanguage(ResourceManager resource, CultureInfo culture)
        {
            Songs.Text = resource.GetString("Songs", culture);
            Albums.Text = resource.GetString("Albums", culture);
            Artists.Text = resource.GetString("Artists", culture);
            label1.Text = resource.GetString("labelSort", culture);
            label4.Text = resource.GetString("labelSort", culture);
            label2.Text = resource.GetString("labelSort", culture);
            comboBoxSortBySongs.Items.RemoveAt(0);
            string none = resource.GetString("None", culture);
            comboBoxSortBySongs.Items.Insert(0, none);
            btnShuffAlbum.Text =  resource.GetString("btnShuffleAllAlbums", culture);
            btnShuffleAllSongs.Text = btnShuffAlbum.Text;
            btnShuufleAllArtists.Text = "      " + btnShuffAlbum.Text;
            btnShuffAlbum.Text = btnShuufleAllArtists.Text;
            //label4.Text = resource.GetString("labelSort", culture);
            //label4.Text = resource.GetString("labelSort", culture);

        }
        public bool SelectIndexChange()
        {
            if (metroTabControl1.SelectedIndex == 0)
                return false;
            else
            {
                this.metroTabControl1.SelectedIndex = 0;
                return true;
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Shuff_Click?.Invoke(sender, e);
        }
        public static void ChangeColor(FlowLayoutPanel panel, uSong[] controls)
        {
            //panel.contr;
            panel.Visible = false;
            panel.Controls.Clear();
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
                panel.Controls.Add(controls[i]);
            }
            panel.Visible = true;
        }
        public static void ChangeColor(FlowLayoutPanel panel, uMyplaylist[] controls)
        {
            //panel.contr;
            panel.Visible = false;
            panel.Controls.Clear();
            for (int i = 0; i < controls.Length; i++)
            {
                panel.Controls.Add(controls[i]);
            }
            panel.Visible = true;
        }
        public void SetSongs(List<uSong> songs)
        {
            this.songs = songs;
            panelSongs.Tag = songs;
        }
        private void MetroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab == metroTabControl1.TabPages[0])
                Songs_Enter(sender, e);
            else if (metroTabControl1.SelectedTab == metroTabControl1.TabPages[1])
                Artists_Enter(sender, e);
            else Albums_Enter(sender, e);
        }

        #endregion

        #region Method Songs
        private void Songs_Enter(object sender, EventArgs e)
        {
            SongsClick?.Invoke(sender, e);
            panel1.Visible = false; 
            for (int i = 0; i < songs.Count; i++)
            {
                songs[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
            }
            AddSongs(songs.ToArray());
            panel1.Visible = true;

        }
        public void AddSong(uSong value)
        {
            panelSongs.Controls.Add(value);
        }
        public void AddSongs(uSong[] value)
        {
            panelSongs.Controls.Clear();
            panelSongs.Controls.AddRange(value);
        }
        public void SetScrollSongInSongs(Control value)
        {
            panelSongs.ScrollControlIntoView(value);
        }
        public void SongsClear()
        {
            panelSongs.Controls.Clear();
        }
        public List<uSong> ListSongs
        {
            get
            {
                return panelSongs.Controls.Cast<uSong>().ToList();
            }
        }


        #endregion

        #region Method artists
        private void Artists_Enter(object sender, EventArgs e)
        {
            ShowArtits();
        }
        public void AddArtist(uMyplaylist artist)
        {
            if (artist.Songs.Count < 2)
            {
                panelArtists.Controls.Add(artist);
                this.artists.Add(artist);
                artist.BtnImage_Click += Artist_BtnImage_Click;
                artist.fDetails.Back_Click += Artists_Enter;
                artist.fDetails.PlayALl_Click += FDetails_PlayALl_Click_Artist;
            }
            else return;
        }
        private void FDetails_PlayALl_Click_Artist(object sender, EventArgs e)
        {

            PlayAll_Click?.Invoke(GetSongsInArtist(), e);
        }
        private List<uSong> GetSongsInArtist()
        {
            return panelArtists.Controls.Cast<uSong>().ToList();
        }
        private void Artist_BtnImage_Click(object sender, EventArgs e)
        {
            uMyplaylist artist = sender as uMyplaylist;
            ShowSongInArtist(artist);
            Artist_Click?.Invoke(sender, e);

        }
        public void ShowArtits()
        {
            panel2.Visible = true;
            panelArtists.Visible = false;
            Artists.Controls.Clear();
            panelArtists.Controls.Clear();

            panelArtists.Controls.AddRange(artists.ToArray());

            Artists.Controls.Add(panel2);
            panel2.Dock = DockStyle.Top;
            panel2.BringToFront();

            Artists.Controls.Add(panelArtists);
            panelArtists.Dock = DockStyle.Fill;
            panelArtists.BringToFront();
            panelArtists.Visible = true;

        }
        private void ShowSongInArtist(uMyplaylist artist)
        {
            panel2.Visible = false;
            panelArtists.Visible = false;
            panelArtists.Controls.Clear();
            Artists.Controls.Clear();


            panelArtists.Controls.AddRange(artist.Songs.ToArray());
            for (int i = 0; i < artist.Songs.Count; i++)
            {
                artist.Songs[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
            }

            #region clear tab artist // add details
            Artists.Controls.Add(artist.fDetails);
            artist.fDetails.Dock = DockStyle.Top;
            artist.fDetails.BringToFront();

            Artists.Controls.Add(panelArtists);
            panelArtists.Dock = DockStyle.Fill;
            panelArtists.BringToFront();
            #endregion

            panelArtists.Visible = true;
        }
        public void SetScrollSongInArtists(Control value)
        {
            panelArtists.ScrollControlIntoView(value);
        }
        public void HideSongs()
        {
            panelSongs.Visible = false;
            panelArtists.Visible = false;
            panelAlbums.Visible = false;
        }
        public void ShowSongs()
        {
            panelSongs.Visible = true;
            panelArtists.Visible = true;
            panelAlbums.Visible = true;
        }
        #endregion

        #region Method Albums
        private void Albums_Enter(object sender, EventArgs e)
        {
            ShowAlbums();
        }
        public void AddAlbum(uMyplaylist album)
        {
            if (album.Songs.Count < 2)
            {
                panelAlbums.Controls.Add(album);
                this.albums.Add(album);
                album.BtnImage_Click += Album_BtnImage_Click;
                album.fDetails.Back_Click += Albums_Enter;
                album.fDetails.PlayALl_Click += FDetails_PlayALl_Click_Album;
            }
            else return;
        }

        private void FDetails_PlayALl_Click_Album(object sender, EventArgs e)
        {
            PlayAll_Click?.Invoke(GetSongsInAlbum(), e);
        }
        private List<uSong> GetSongsInAlbum()
        {
            return panelAlbums.Controls.Cast<uSong>().ToList();
        }
        private void Album_BtnImage_Click(object sender, EventArgs e)
        {
            uMyplaylist album = sender as uMyplaylist;
            ShowSongInAlbum(album);
            Album_Click?.Invoke(sender, e);
        }
        private void ShowSongInAlbum(uMyplaylist album)
        {
            panelAlbums.Visible = false;
            panel3.Visible = false;
            Albums.Controls.Clear();
            panelAlbums.Controls.Clear();
            panelAlbums.Controls.AddRange(album.Songs.ToArray());
            for (int i = 0; i < album.Songs.Count; i++)
            {
                album.Songs[i].BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
            }
            Albums.Controls.Add(album.fDetails);
            album.fDetails.Dock = DockStyle.Top;
            album.fDetails.BringToFront();

            Albums.Controls.Add(panelAlbums);
            panelAlbums.Dock = DockStyle.Fill;
            panelAlbums.BringToFront();

            panelAlbums.Visible = true;
        }
        public void ShowAlbums()
        {
            panel3.Visible = true;
            panelAlbums.Visible = false;
            Albums.Controls.Clear();
            panelAlbums.Controls.Clear();
            panelAlbums.Controls.AddRange(albums.ToArray());

            Albums.Controls.Add(panel3);
            panel3.Dock = DockStyle.Top;
            panel3.BringToFront();
            Albums.Controls.Add(panelAlbums);
            panelAlbums.Dock = DockStyle.Fill;
            panelAlbums.BringToFront();
            panelAlbums.Visible = true;

        }

        public void SetScrollSongInAlbums(Control value)
        {
            panelAlbums.ScrollControlIntoView(value);
        }



        #endregion

        #region Sort Songs
        private void ComboBoxSortBySongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSortBySongs.SelectedIndex)
            {
                case 0:
                    SortNone();
                    break;
                case 1:
                    SortSongsAtoZ();
                    break;
                case 2:
                    SortSongsZtoA();
                    break;
                default:
                    SortSongsAtoZ();
                    break;
            }
        }

        private void SortNone()
        {
            songs = (List<uSong>)panelSongs.Tag;
            ChangeColor(panelSongs, songs.ToArray());
            SongsSorted?.Invoke(songs, null);
        }

        private void SortSongsZtoA()
        {
            songs?.Sort(Sort.iCompareZToA);
            ChangeColor(panelSongs, songs.ToArray());
            SongsSorted?.Invoke(songs, null);
        }

        private void SortSongsAtoZ()
        {
            songs?.Sort(Sort.iCompareAToZ);
            ChangeColor(panelSongs, songs.ToArray());
            SongsSorted?.Invoke(songs, null);

        }


        #endregion

        #region Sort Albums
        private void ComboBoxSortAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            switch (combo.SelectedIndex)
            {
                case 0:
                    SortAlbums_AtoZ();
                    break;
                case 1:
                    SortAblums_ZtoA();
                    break;
                default:
                    SortAlbums_AtoZ();
                    break;
            }
        }

        private void SortAblums_ZtoA()
        {
            albums.Sort(Sort.iCompareAlbumZtoA);
            ChangeColor(panelAlbums, albums.ToArray());
        }

        private void SortAlbums_AtoZ()
        {
            albums.Sort(Sort.iCompareAlbumAtoZ);
            ChangeColor(panelAlbums, albums.ToArray());
        }
        #endregion

        #region Sort Artist
        private void comboBoxSortByArtists_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            switch (combo.SelectedIndex)
            {
                case 0:
                    SortArtists_AtoZ();
                    break;
                case 1:
                    SortArtists_ZtoA();
                    break;
                default:
                    SortArtists_AtoZ();
                    break;
            }
        }

        private void SortArtists_ZtoA()
        {
            artists.Sort(Sort.iCompareArtistZtoA);
            ChangeColor(panelArtists, artists.ToArray());
        }

        private void SortArtists_AtoZ()
        {
            artists.Sort(Sort.iCompareArtistAtoZ);
            ChangeColor(panelArtists, artists.ToArray());
        }

        #endregion
    }
}
