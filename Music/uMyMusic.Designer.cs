using System.Drawing;

namespace Music
{
    partial class uMyMusic
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uMyMusic));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Songs = new System.Windows.Forms.TabPage();
            this.panelSongs = new TFlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShuffleAllSongs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBoxSortBySongs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Artists = new System.Windows.Forms.TabPage();
            this.panelArtists = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShuufleAllArtists = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSortByArtists = new System.Windows.Forms.ComboBox();
            this.Albums = new System.Windows.Forms.TabPage();
            this.panelAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShuffAlbum = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboboxAlbums = new System.Windows.Forms.ComboBox();
            this.metroTabControl1.SuspendLayout();
            this.Songs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Artists.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Albums.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Songs);
            this.metroTabControl1.Controls.Add(this.Artists);
            this.metroTabControl1.Controls.Add(this.Albums);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.ShowToolTips = true;
            this.metroTabControl1.Size = new System.Drawing.Size(850, 474);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.MetroTabControl1_SelectedIndexChanged);
            // 
            // Songs
            // 
            this.Songs.BackColor = System.Drawing.Color.White;
            this.Songs.Controls.Add(this.panelSongs);
            this.Songs.Controls.Add(this.panel1);
            this.Songs.Location = new System.Drawing.Point(4, 38);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(842, 432);
            this.Songs.TabIndex = 0;
            this.Songs.Text = "Songs";
            // 
            // panelSongs
            // 
            this.panelSongs.AutoScroll = true;
            this.panelSongs.AutoSize = true;
            this.panelSongs.BackColor = System.Drawing.Color.White;
            this.panelSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSongs.Location = new System.Drawing.Point(0, 42);
            this.panelSongs.Margin = new System.Windows.Forms.Padding(0);
            this.panelSongs.Name = "panelSongs";
            this.panelSongs.Size = new System.Drawing.Size(842, 390);
            this.panelSongs.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnShuffleAllSongs);
            this.panel1.Controls.Add(this.comboBoxSortBySongs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 42);
            this.panel1.TabIndex = 5;
            // 
            // btnShuffleAllSongs
            // 
            this.btnShuffleAllSongs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnShuffleAllSongs.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffleAllSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShuffleAllSongs.BorderRadius = 0;
            this.btnShuffleAllSongs.ButtonText = "    Shuffle all";
            this.btnShuffleAllSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffleAllSongs.DisabledColor = System.Drawing.Color.Gray;
            this.btnShuffleAllSongs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShuffleAllSongs.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShuffleAllSongs.Iconimage")));
            this.btnShuffleAllSongs.Iconimage_right = null;
            this.btnShuffleAllSongs.Iconimage_right_Selected = null;
            this.btnShuffleAllSongs.Iconimage_Selected = null;
            this.btnShuffleAllSongs.IconMarginLeft = 0;
            this.btnShuffleAllSongs.IconMarginRight = 0;
            this.btnShuffleAllSongs.IconRightVisible = false;
            this.btnShuffleAllSongs.IconRightZoom = 0D;
            this.btnShuffleAllSongs.IconVisible = false;
            this.btnShuffleAllSongs.IconZoom = 30D;
            this.btnShuffleAllSongs.IsTab = false;
            this.btnShuffleAllSongs.Location = new System.Drawing.Point(10, 7);
            this.btnShuffleAllSongs.Name = "btnShuffleAllSongs";
            this.btnShuffleAllSongs.Normalcolor = System.Drawing.Color.Transparent;
            this.btnShuffleAllSongs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShuffleAllSongs.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShuffleAllSongs.selected = false;
            this.btnShuffleAllSongs.Size = new System.Drawing.Size(107, 29);
            this.btnShuffleAllSongs.TabIndex = 50;
            this.btnShuffleAllSongs.Text = "    Shuffle all";
            this.btnShuffleAllSongs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShuffleAllSongs.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShuffleAllSongs.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // comboBoxSortBySongs
            // 
            this.comboBoxSortBySongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSortBySongs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboBoxSortBySongs.FormattingEnabled = true;
            this.comboBoxSortBySongs.Items.AddRange(new object[] {
            "None",
            "A-Z",
            "Z-A"});
            this.comboBoxSortBySongs.Location = new System.Drawing.Point(235, 10);
            this.comboBoxSortBySongs.Name = "comboBoxSortBySongs";
            this.comboBoxSortBySongs.Size = new System.Drawing.Size(107, 25);
            this.comboBoxSortBySongs.TabIndex = 45;
            this.comboBoxSortBySongs.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSortBySongs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(140, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sort by";
            // 
            // Artists
            // 
            this.Artists.BackColor = System.Drawing.Color.White;
            this.Artists.Controls.Add(this.panelArtists);
            this.Artists.Controls.Add(this.panel2);
            this.Artists.Location = new System.Drawing.Point(4, 38);
            this.Artists.Name = "Artists";
            this.Artists.Size = new System.Drawing.Size(842, 432);
            this.Artists.TabIndex = 1;
            this.Artists.Text = "Artists";
            // 
            // panelArtists
            // 
            this.panelArtists.AutoScroll = true;
            this.panelArtists.BackColor = System.Drawing.Color.White;
            this.panelArtists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelArtists.Location = new System.Drawing.Point(0, 42);
            this.panelArtists.Name = "panelArtists";
            this.panelArtists.Size = new System.Drawing.Size(842, 390);
            this.panelArtists.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnShuufleAllArtists);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBoxSortByArtists);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 42);
            this.panel2.TabIndex = 6;
            // 
            // btnShuufleAllArtists
            // 
            this.btnShuufleAllArtists.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnShuufleAllArtists.BackColor = System.Drawing.Color.Transparent;
            this.btnShuufleAllArtists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShuufleAllArtists.BorderRadius = 0;
            this.btnShuufleAllArtists.ButtonText = "    Shuffle all";
            this.btnShuufleAllArtists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuufleAllArtists.DisabledColor = System.Drawing.Color.Gray;
            this.btnShuufleAllArtists.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShuufleAllArtists.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShuufleAllArtists.Iconimage")));
            this.btnShuufleAllArtists.Iconimage_right = null;
            this.btnShuufleAllArtists.Iconimage_right_Selected = null;
            this.btnShuufleAllArtists.Iconimage_Selected = null;
            this.btnShuufleAllArtists.IconMarginLeft = 0;
            this.btnShuufleAllArtists.IconMarginRight = 0;
            this.btnShuufleAllArtists.IconRightVisible = false;
            this.btnShuufleAllArtists.IconRightZoom = 0D;
            this.btnShuufleAllArtists.IconVisible = false;
            this.btnShuufleAllArtists.IconZoom = 30D;
            this.btnShuufleAllArtists.IsTab = false;
            this.btnShuufleAllArtists.Location = new System.Drawing.Point(10, 7);
            this.btnShuufleAllArtists.Name = "btnShuufleAllArtists";
            this.btnShuufleAllArtists.Normalcolor = System.Drawing.Color.Transparent;
            this.btnShuufleAllArtists.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShuufleAllArtists.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShuufleAllArtists.selected = false;
            this.btnShuufleAllArtists.Size = new System.Drawing.Size(107, 29);
            this.btnShuufleAllArtists.TabIndex = 49;
            this.btnShuufleAllArtists.Text = "    Shuffle all";
            this.btnShuufleAllArtists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShuufleAllArtists.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShuufleAllArtists.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(140, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Sort by";
            // 
            // comboBoxSortByArtists
            // 
            this.comboBoxSortByArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSortByArtists.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboBoxSortByArtists.FormattingEnabled = true;
            this.comboBoxSortByArtists.Items.AddRange(new object[] {
            "A-Z",
            "Z-A"});
            this.comboBoxSortByArtists.Location = new System.Drawing.Point(235, 10);
            this.comboBoxSortByArtists.Name = "comboBoxSortByArtists";
            this.comboBoxSortByArtists.Size = new System.Drawing.Size(107, 25);
            this.comboBoxSortByArtists.TabIndex = 45;
            this.comboBoxSortByArtists.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortByArtists_SelectedIndexChanged);
            // 
            // Albums
            // 
            this.Albums.BackColor = System.Drawing.Color.White;
            this.Albums.Controls.Add(this.panelAlbums);
            this.Albums.Controls.Add(this.panel3);
            this.Albums.Location = new System.Drawing.Point(4, 38);
            this.Albums.Name = "Albums";
            this.Albums.Size = new System.Drawing.Size(842, 432);
            this.Albums.TabIndex = 2;
            this.Albums.Text = "Albums";
            // 
            // panelAlbums
            // 
            this.panelAlbums.AutoScroll = true;
            this.panelAlbums.BackColor = System.Drawing.Color.White;
            this.panelAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlbums.Location = new System.Drawing.Point(0, 42);
            this.panelAlbums.Margin = new System.Windows.Forms.Padding(0);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(842, 390);
            this.panelAlbums.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnShuffAlbum);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboboxAlbums);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(842, 42);
            this.panel3.TabIndex = 10;
            // 
            // btnShuffAlbum
            // 
            this.btnShuffAlbum.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnShuffAlbum.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShuffAlbum.BorderRadius = 0;
            this.btnShuffAlbum.ButtonText = "    Shuffle all";
            this.btnShuffAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffAlbum.DisabledColor = System.Drawing.Color.Gray;
            this.btnShuffAlbum.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShuffAlbum.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShuffAlbum.Iconimage")));
            this.btnShuffAlbum.Iconimage_right = null;
            this.btnShuffAlbum.Iconimage_right_Selected = null;
            this.btnShuffAlbum.Iconimage_Selected = null;
            this.btnShuffAlbum.IconMarginLeft = 0;
            this.btnShuffAlbum.IconMarginRight = 0;
            this.btnShuffAlbum.IconRightVisible = false;
            this.btnShuffAlbum.IconRightZoom = 0D;
            this.btnShuffAlbum.IconVisible = false;
            this.btnShuffAlbum.IconZoom = 30D;
            this.btnShuffAlbum.IsTab = false;
            this.btnShuffAlbum.Location = new System.Drawing.Point(10, 7);
            this.btnShuffAlbum.Name = "btnShuffAlbum";
            this.btnShuffAlbum.Normalcolor = System.Drawing.Color.Transparent;
            this.btnShuffAlbum.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShuffAlbum.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShuffAlbum.selected = false;
            this.btnShuffAlbum.Size = new System.Drawing.Size(107, 29);
            this.btnShuffAlbum.TabIndex = 49;
            this.btnShuffAlbum.Text = "    Shuffle all";
            this.btnShuffAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShuffAlbum.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShuffAlbum.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(140, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Sort by";
            // 
            // comboboxAlbums
            // 
            this.comboboxAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxAlbums.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboboxAlbums.FormattingEnabled = true;
            this.comboboxAlbums.Items.AddRange(new object[] {
            "A-Z",
            "Z-A"});
            this.comboboxAlbums.Location = new System.Drawing.Point(235, 10);
            this.comboboxAlbums.Name = "comboboxAlbums";
            this.comboboxAlbums.Size = new System.Drawing.Size(107, 25);
            this.comboboxAlbums.TabIndex = 45;
            this.comboboxAlbums.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSortAlbums_SelectedIndexChanged);
            // 
            // uMyMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroTabControl1);
            this.DoubleBuffered = true;
            this.Name = "uMyMusic";
            this.Size = new System.Drawing.Size(850, 474);
            this.metroTabControl1.ResumeLayout(false);
            this.Songs.ResumeLayout(false);
            this.Songs.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Artists.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Albums.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage Songs;
        private System.Windows.Forms.TabPage Artists;
        private System.Windows.Forms.TabPage Albums;
        private System.Windows.Forms.FlowLayoutPanel panelArtists;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnShuufleAllArtists;
        private System.Windows.Forms.Label label4;
        private TFlowLayoutPanel panelSongs;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnShuffleAllSongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSortBySongs;
        private System.Windows.Forms.ComboBox comboBoxSortByArtists;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnShuffAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboboxAlbums;
        private System.Windows.Forms.FlowLayoutPanel panelAlbums;
    }
}
