using System;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace Music
{
    public partial class uSetting : UserControl
    {
        #region Properties
        private string on;
        private string off;
        private UpdateMusic update;
        public event EventHandler CloseForm;
        public event EventHandler ChangeLangue;
        private Timer ShutDownTimer;
        private int i = 0;

        public uSetting()
        {
            InitializeComponent();


            cbMinute.Text = "15";
            lblTime.Text = fMusic.ConvertToMinute(15 * 60);
            update = new UpdateMusic(label); ;
            update.CloseForm += Update_CloseForm;
        }
        #endregion

        #region Method
        public void ShowLanguage(ResourceManager resource, CultureInfo culture)
        {
            lblLanguage.Text = "     " + resource.GetString("btnLanguge", culture);
            bunifuFlatButton1.Text = "     " + resource.GetString("shutdown", culture);
            label3.Text = resource.GetString("Minutes", culture);
            btnLocalFiles.Text = "     " + resource.GetString("settingLocal", culture);
            btnUpdates.Text = "     " + resource.GetString("Update", culture);
            lbStatus.Text = resource.GetString("lbStatus", culture);
            metroComboBox1.Items.Clear();
            metroComboBox1.Items.Add(resource.GetString("English", culture));
            metroComboBox1.Items.Add(resource.GetString("Vietnam", culture));
            on = resource.GetString("lblStatusOn", culture);
            off = resource.GetString("lblStatusOff", culture);
            lblStatus.Text = off;
            lblWarning.Text = resource.GetString("lblWarning", culture);
            metroComboBox1.SelectedIndex = Properties.Settings.Default.languge;
            update.ShowLangugae(resource, culture);
        }

        private void Update_CloseForm(object sender, EventArgs e)
        {
            this.CloseForm?.Invoke(null, null);

        }

        private void ShutDownTimer_Tick(object sender, EventArgs e)
        {
            if (i >= 0)
            {
                lblTime.Text = fMusic.ConvertToMinute(i);
                i--;
            }
            else
            {
                Timer timer = sender as Timer;
                timer.Stop();
                timer.Dispose();
                Application.Exit();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            fLocalFiles fLocalFiles = new fLocalFiles();
            fLocalFiles.ShowDialog();
        }

        private void btnShutDown_OnValueChange(object sender, EventArgs e)
        {
            if (btnShutDown.Value)
            {

                lblStatus.Text = on;
                cbMinute.Enabled = true;
                lblTime.ForeColor = Color.FromArgb(239, 108, 1);
                ShutDownTimer = new Timer();
                ShutDownTimer.Interval = 1000;
                ShutDownTimer.Start();
                ShutDownTimer.Tick += ShutDownTimer_Tick;
                i = int.Parse(cbMinute.Text) * 60;
            }
            else
            {
                lblStatus.Text = off;
                lblTime.Text = "00:00";
                cbMinute.Enabled = false;
                lblTime.ForeColor = Color.FromArgb(92, 92, 92);
                ShutDownTimer.Stop();
                ShutDownTimer.Dispose();
            }
        }

        private void cbMinute_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            i = int.Parse(cbMinute.Text) * 60;
        }

        private void btnNowPlaying_Click(object sender, EventArgs e)
        {
            if (update.IsUpdating == false)
            {
                lbStatus.Visible = true;
                label.Visible = true;
                update.CheckInternet();
            }
            else return;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.languge != metroComboBox1.SelectedIndex)
            {
                Properties.Settings.Default.languge = metroComboBox1.SelectedIndex;
                Properties.Settings.Default.Save();
                ChangeLangue?.Invoke(sender, e);
            }

        }
        #endregion
    }
}
