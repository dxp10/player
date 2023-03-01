namespace Music
{
    partial class uPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uPlaylist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewPlaylist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBoxSortBySongs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSongs = new TFlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNewPlaylist);
            this.panel1.Controls.Add(this.comboBoxSortBySongs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 42);
            this.panel1.TabIndex = 6;
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.Activecolor = System.Drawing.Color.Transparent;
            this.btnNewPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewPlaylist.BorderRadius = 0;
            this.btnNewPlaylist.ButtonText = "New playlist";
            this.btnNewPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPlaylist.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewPlaylist.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewPlaylist.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewPlaylist.Iconimage")));
            this.btnNewPlaylist.Iconimage_right = null;
            this.btnNewPlaylist.Iconimage_right_Selected = null;
            this.btnNewPlaylist.Iconimage_Selected = null;
            this.btnNewPlaylist.IconMarginLeft = 0;
            this.btnNewPlaylist.IconMarginRight = 0;
            this.btnNewPlaylist.IconRightVisible = false;
            this.btnNewPlaylist.IconRightZoom = 0D;
            this.btnNewPlaylist.IconVisible = true;
            this.btnNewPlaylist.IconZoom = 30D;
            this.btnNewPlaylist.IsTab = false;
            this.btnNewPlaylist.Location = new System.Drawing.Point(10, 7);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNewPlaylist.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNewPlaylist.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewPlaylist.selected = false;
            this.btnNewPlaylist.Size = new System.Drawing.Size(169, 29);
            this.btnNewPlaylist.TabIndex = 48;
            this.btnNewPlaylist.Text = "New playlist";
            this.btnNewPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewPlaylist.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewPlaylist.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);
            // 
            // comboBoxSortBySongs
            // 
            this.comboBoxSortBySongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSortBySongs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboBoxSortBySongs.FormattingEnabled = true;
            this.comboBoxSortBySongs.Items.AddRange(new object[] {
            "A-Z",
            "Z-A"});
            this.comboBoxSortBySongs.Location = new System.Drawing.Point(276, 10);
            this.comboBoxSortBySongs.Name = "comboBoxSortBySongs";
            this.comboBoxSortBySongs.Size = new System.Drawing.Size(107, 25);
            this.comboBoxSortBySongs.TabIndex = 45;
            this.comboBoxSortBySongs.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(177, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sort by";
            // 
            // panelSongs
            // 
            this.panelSongs.AutoScroll = true;
            this.panelSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSongs.Location = new System.Drawing.Point(0, 42);
            this.panelSongs.Name = "panelSongs";
            this.panelSongs.Size = new System.Drawing.Size(850, 432);
            this.panelSongs.TabIndex = 7;
            // 
            // uPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSongs);
            this.Controls.Add(this.panel1);
            this.Name = "uPlaylist";
            this.Size = new System.Drawing.Size(850, 474);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewPlaylist;
        private System.Windows.Forms.ComboBox comboBoxSortBySongs;
        private System.Windows.Forms.Label label1;
        private TFlowLayoutPanel panelSongs;
    }
}
