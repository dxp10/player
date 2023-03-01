namespace Music
{
    partial class uAlbumDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uAlbumDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.Panel();
            this.btnPlayAll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalSong = new System.Windows.Forms.Label();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 158);
            this.label1.TabIndex = 81;
            // 
            // background
            // 
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Controls.Add(this.btnPlayAll);
            this.background.Controls.Add(this.btnBack);
            this.background.Controls.Add(this.label2);
            this.background.Controls.Add(this.lblTotalSong);
            this.background.Controls.Add(this.lblPlaylistName);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(158, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(692, 158);
            this.background.TabIndex = 82;
            // 
            // btnPlayAll
            // 
            this.btnPlayAll.Activecolor = System.Drawing.Color.Transparent;
            this.btnPlayAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPlayAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayAll.BorderRadius = 0;
            this.btnPlayAll.ButtonText = "Play all";
            this.btnPlayAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayAll.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlayAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPlayAll.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlayAll.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlayAll.Iconimage")));
            this.btnPlayAll.Iconimage_right = null;
            this.btnPlayAll.Iconimage_right_Selected = null;
            this.btnPlayAll.Iconimage_Selected = null;
            this.btnPlayAll.IconMarginLeft = 0;
            this.btnPlayAll.IconMarginRight = 0;
            this.btnPlayAll.IconRightVisible = false;
            this.btnPlayAll.IconRightZoom = 0D;
            this.btnPlayAll.IconVisible = true;
            this.btnPlayAll.IconZoom = 30D;
            this.btnPlayAll.IsTab = false;
            this.btnPlayAll.Location = new System.Drawing.Point(59, 121);
            this.btnPlayAll.Name = "btnPlayAll";
            this.btnPlayAll.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnPlayAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlayAll.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPlayAll.selected = false;
            this.btnPlayAll.Size = new System.Drawing.Size(107, 29);
            this.btnPlayAll.TabIndex = 91;
            this.btnPlayAll.Text = "Play all";
            this.btnPlayAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlayAll.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnPlayAll.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAll.Click += new System.EventHandler(this.btnPlayAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = global::Music.Properties.Resources.back;
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 42D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(6, 117);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBack.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(35, 35);
            this.btnBack.TabIndex = 90;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnBack.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(51, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 87;
            this.label2.Text = "songs";
            // 
            // lblTotalSong
            // 
            this.lblTotalSong.AutoEllipsis = true;
            this.lblTotalSong.AutoSize = true;
            this.lblTotalSong.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalSong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalSong.Location = new System.Drawing.Point(32, 67);
            this.lblTotalSong.Name = "lblTotalSong";
            this.lblTotalSong.Size = new System.Drawing.Size(21, 14);
            this.lblTotalSong.TabIndex = 86;
            this.lblTotalSong.Text = "69";
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoEllipsis = true;
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaylistName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPlaylistName.Location = new System.Drawing.Point(29, 18);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(98, 33);
            this.lblPlaylistName.TabIndex = 85;
            this.lblPlaylistName.Text = "Album";
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(3, 3);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(152, 152);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 70;
            this.image.TabStop = false;
            // 
            // uAlbumDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.background);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label1);
            this.Name = "uAlbumDetails";
            this.Size = new System.Drawing.Size(850, 158);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Label lblTotalSong;
        public System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlayAll;
    }
}
