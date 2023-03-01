using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace Music
{
    public class UpdateMusic
    {
        #region Properties
        private static readonly Uri uriVersion = new Uri("https://drive.google.com/uc?export=download&id=1hCCUwe6QJijZXF-viQ7tWgn85QibDVeX");
        private static readonly Uri uriUpdate = new Uri("https://drive.google.com/uc?export=download&id=1g4rgesTuGIDkDVvr2DnL7W0DNeKHI97I");
        private static readonly string source = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Music";
        private static readonly string zipFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Music\Music.zip";
        public static readonly string installLink = Application.StartupPath + @"\InstallUpdate.exe";
        public bool IsUpdating = false;
        private Label label;
        private string lbupdate1 = string.Empty;//check version
        private string lbupdate2 = string.Empty;// download
        private string lbupdate3 = string.Empty;// install
        private string lbupdate4 = string.Empty;// no update
        private string noInternet = string.Empty; // no internet
        private string error = string.Empty; // error
        public event EventHandler CloseForm;
        #endregion

        #region Method
        public UpdateMusic(Label label)
        {
            this.label = label;
        }
        public void ShowLangugae(ResourceManager resource, CultureInfo culture)
        {
            lbupdate1 = resource.GetString("lbupdate1", culture);
            lbupdate2 = resource.GetString("lbupdate2", culture);
            lbupdate3 = resource.GetString("lbupdate3", culture);
            lbupdate4 = resource.GetString("lbupdate4", culture);
            noInternet = resource.GetString("noInternet", culture);
            error = resource.GetString("error", culture);
        }
        public void CheckInternet()
        {
            if (InternetConnection.IsConnectedToInternet() == false)
            {
                MessageBox.Show(noInternet, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else GetVersionAvailable();
        }
        public void GetVersionAvailable()
        {
            IsUpdating = true;
            if (Directory.Exists(source))
            {
                Directory.Delete(source, true);
            }
            Directory.CreateDirectory(source);
            Thread.Sleep(100);
            using (WebClient web = new WebClient())
            {
                web.DownloadStringCompleted += Web_DownloadStringCompleted;
                label.Visible = true;
                label.Text = lbupdate1;
                web.DownloadStringAsync(uriVersion);
            }
        }
        private void Web_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Result != Properties.Settings.Default.version)
            {
                label.Text = lbupdate2;
                Update_Click(sender, null);
            }
            else label.Text = lbupdate4;
        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (File.Exists(zipFile))
                File.Delete(zipFile);
            Thread.Sleep(200);
            using (WebClient web = new WebClient())
            {
                web.DownloadFileCompleted += Web_DownloadFileZipCompleted;
                web.DownloadFileAsync(uriUpdate, zipFile);
            }
        }
        private void Web_DownloadFileZipCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            label.Text = lbupdate3;
            CloseForm?.Invoke(null, null);
            IsUpdating = false;
        }
        #endregion
    }
}
