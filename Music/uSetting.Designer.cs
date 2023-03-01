namespace Music
{
    partial class uSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uSetting));
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.btnLocalFiles = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdates = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblLanguage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.cbMinute = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnShutDown = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.BackColor = System.Drawing.Color.White;
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.ForeColor = System.Drawing.Color.White;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "English",
            "Vietnamese"});
            this.metroComboBox1.Location = new System.Drawing.Point(84, 100);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(242, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroComboBox1.TabIndex = 36;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroComboBox1.UseCustomBackColor = true;
            this.metroComboBox1.UseCustomForeColor = true;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.UseStyleColors = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // btnLocalFiles
            // 
            this.btnLocalFiles.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnLocalFiles.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalFiles.BorderRadius = 0;
            this.btnLocalFiles.ButtonText = "     Your local music files";
            this.btnLocalFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalFiles.DisabledColor = System.Drawing.Color.Gray;
            this.btnLocalFiles.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLocalFiles.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLocalFiles.Iconimage")));
            this.btnLocalFiles.Iconimage_right = null;
            this.btnLocalFiles.Iconimage_right_Selected = null;
            this.btnLocalFiles.Iconimage_Selected = null;
            this.btnLocalFiles.IconMarginLeft = 0;
            this.btnLocalFiles.IconMarginRight = 0;
            this.btnLocalFiles.IconRightVisible = true;
            this.btnLocalFiles.IconRightZoom = 0D;
            this.btnLocalFiles.IconVisible = true;
            this.btnLocalFiles.IconZoom = 45D;
            this.btnLocalFiles.IsTab = false;
            this.btnLocalFiles.Location = new System.Drawing.Point(75, 230);
            this.btnLocalFiles.Name = "btnLocalFiles";
            this.btnLocalFiles.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLocalFiles.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLocalFiles.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnLocalFiles.selected = false;
            this.btnLocalFiles.Size = new System.Drawing.Size(239, 40);
            this.btnLocalFiles.TabIndex = 90;
            this.btnLocalFiles.Text = "     Your local music files";
            this.btnLocalFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalFiles.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnLocalFiles.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalFiles.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnUpdates
            // 
            this.btnUpdates.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnUpdates.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdates.BorderRadius = 0;
            this.btnUpdates.ButtonText = "     Check for Updates";
            this.btnUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdates.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdates.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdates.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdates.Iconimage")));
            this.btnUpdates.Iconimage_right = null;
            this.btnUpdates.Iconimage_right_Selected = null;
            this.btnUpdates.Iconimage_Selected = null;
            this.btnUpdates.IconMarginLeft = 0;
            this.btnUpdates.IconMarginRight = 0;
            this.btnUpdates.IconRightVisible = true;
            this.btnUpdates.IconRightZoom = 0D;
            this.btnUpdates.IconVisible = true;
            this.btnUpdates.IconZoom = 45D;
            this.btnUpdates.IsTab = false;
            this.btnUpdates.Location = new System.Drawing.Point(75, 297);
            this.btnUpdates.Name = "btnUpdates";
            this.btnUpdates.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUpdates.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdates.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnUpdates.selected = false;
            this.btnUpdates.Size = new System.Drawing.Size(239, 40);
            this.btnUpdates.TabIndex = 89;
            this.btnUpdates.Text = "     Check for Updates";
            this.btnUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdates.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnUpdates.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdates.Click += new System.EventHandler(this.btnNowPlaying_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.Activecolor = System.Drawing.Color.Transparent;
            this.lblLanguage.BackColor = System.Drawing.Color.Transparent;
            this.lblLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblLanguage.BorderRadius = 0;
            this.lblLanguage.ButtonText = "     Language";
            this.lblLanguage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLanguage.DisabledColor = System.Drawing.Color.Transparent;
            this.lblLanguage.Enabled = false;
            this.lblLanguage.Iconcolor = System.Drawing.Color.Transparent;
            this.lblLanguage.Iconimage = ((System.Drawing.Image)(resources.GetObject("lblLanguage.Iconimage")));
            this.lblLanguage.Iconimage_right = null;
            this.lblLanguage.Iconimage_right_Selected = null;
            this.lblLanguage.Iconimage_Selected = null;
            this.lblLanguage.IconMarginLeft = 0;
            this.lblLanguage.IconMarginRight = 0;
            this.lblLanguage.IconRightVisible = true;
            this.lblLanguage.IconRightZoom = 0D;
            this.lblLanguage.IconVisible = true;
            this.lblLanguage.IconZoom = 45D;
            this.lblLanguage.IsTab = false;
            this.lblLanguage.Location = new System.Drawing.Point(74, 58);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Normalcolor = System.Drawing.Color.Transparent;
            this.lblLanguage.OnHovercolor = System.Drawing.Color.Transparent;
            this.lblLanguage.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lblLanguage.selected = false;
            this.lblLanguage.Size = new System.Drawing.Size(174, 40);
            this.lblLanguage.TabIndex = 34;
            this.lblLanguage.Text = "     Language";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLanguage.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lblLanguage.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblWarning
            // 
            this.lblWarning.AutoEllipsis = true;
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblWarning.Location = new System.Drawing.Point(82, 275);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(238, 15);
            this.lblWarning.TabIndex = 94;
            this.lblWarning.Text = "* You must restart your app to apply.";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoEllipsis = true;
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbStatus.Location = new System.Drawing.Point(83, 340);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(51, 15);
            this.lbStatus.TabIndex = 91;
            this.lbStatus.Text = "Status:";
            this.lbStatus.Visible = false;
            // 
            // label
            // 
            this.label.AutoEllipsis = true;
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.label.Location = new System.Drawing.Point(151, 340);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 15);
            this.label.TabIndex = 92;
            this.label.Visible = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblStatus);
            this.panel.Controls.Add(this.lblTime);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.cbMinute);
            this.panel.Controls.Add(this.btnShutDown);
            this.panel.Controls.Add(this.bunifuFlatButton1);
            this.panel.Location = new System.Drawing.Point(71, 135);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(272, 89);
            this.panel.TabIndex = 91;
            // 
            // cbMinute
            // 
            this.cbMinute.BackColor = System.Drawing.Color.White;
            this.cbMinute.Enabled = false;
            this.cbMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMinute.ForeColor = System.Drawing.Color.White;
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.ItemHeight = 23;
            this.cbMinute.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.cbMinute.Location = new System.Drawing.Point(15, 53);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(88, 29);
            this.cbMinute.TabIndex = 90;
            this.cbMinute.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbMinute.UseCustomBackColor = true;
            this.cbMinute.UseCustomForeColor = true;
            this.cbMinute.UseSelectable = true;
            this.cbMinute.UseStyleColors = true;
            this.cbMinute.SelectedIndexChanged += new System.EventHandler(this.cbMinute_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.label3.Location = new System.Drawing.Point(109, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 91;
            this.label3.Text = "Minutes";
            // 
            // lblTime
            // 
            this.lblTime.AutoEllipsis = true;
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lblTime.Location = new System.Drawing.Point(192, 58);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 18);
            this.lblTime.TabIndex = 92;
            this.lblTime.Text = "15:06";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lblStatus.Location = new System.Drawing.Point(224, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(26, 17);
            this.lblStatus.TabIndex = 93;
            this.lblStatus.Text = "On";
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.Color.Transparent;
            this.btnShutDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShutDown.BackgroundImage")));
            this.btnShutDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShutDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutDown.Location = new System.Drawing.Point(176, 15);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.OffColor = System.Drawing.Color.Gray;
            this.btnShutDown.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(1)))));
            this.btnShutDown.Size = new System.Drawing.Size(43, 25);
            this.btnShutDown.TabIndex = 89;
            this.btnShutDown.Value = false;
            this.btnShutDown.OnValueChange += new System.EventHandler(this.btnShutDown_OnValueChange);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     Shut down timer";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Enabled = false;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 45D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 7);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(174, 40);
            this.bunifuFlatButton1.TabIndex = 88;
            this.bunifuFlatButton1.Text = "     Shut down timer";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // uSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnLocalFiles);
            this.Controls.Add(this.btnUpdates);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.lblLanguage);
            this.Name = "uSetting";
            this.Size = new System.Drawing.Size(850, 474);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.Framework.UI.BunifuFlatButton lblLanguage;
        public MetroFramework.Controls.MetroComboBox metroComboBox1;
        public Bunifu.Framework.UI.BunifuFlatButton btnUpdates;
        public Bunifu.Framework.UI.BunifuFlatButton btnLocalFiles;
        public System.Windows.Forms.Label lblWarning;

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cbMinute;
        private Bunifu.Framework.UI.BunifuiOSSwitch btnShutDown;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}
