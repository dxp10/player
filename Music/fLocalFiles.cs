using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace Music
{
    public partial class fLocalFiles : Form
    {
        #region Properties static

        public static string Folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\PlayPlist";
        public static string Path = Folder + @"\LocalFiles.txt";
        private static string slabel2 = string.Empty;
        private static string slabel1 = string.Empty;
        private static string sbtnDone = string.Empty;
        private static string deleteFolder = string.Empty;
        private static string captionDelete = string.Empty;
        public static void ShowLanguage(ResourceManager resource, CultureInfo culture)
        {
            slabel2 = resource.GetString("label_Add", culture);
            slabel1 = resource.GetString("label1_Add", culture);
            sbtnDone = resource.GetString("btnDone", culture);
            deleteFolder = resource.GetString("deleteFolder", culture);
            captionDelete = resource.GetString("captionDelete", culture);

        }
        #endregion

        #region Method
        public fLocalFiles()
        {
            InitializeComponent();
            label1.Text = slabel1;
            label2.Text = slabel2;
            btnDone.Text = sbtnDone;
            if (!Directory.Exists(Folder))
                Directory.CreateDirectory(Folder);
            if (!File.Exists(Path))
                File.Create(Path);
            LoadLocalFiles();
        }
        public void LoadLocalFiles()
        {
            panelLocalFiles.Controls.Clear();
            string[] arrLocalFile = ShowLocalFiles();
            for (int i = 0; i < arrLocalFile.Length; i++)
            {
                uLocalFiles localFiles = new uLocalFiles();
                localFiles.FolderPath = arrLocalFile[i];
                localFiles.Title = GetTitle(arrLocalFile[i]);
                panelLocalFiles.Controls.Add(localFiles);
                localFiles.LocalFiles_Click += LocalFiles_LocalFiles_Click;
            }
        }

        private void LocalFiles_LocalFiles_Click(object sender, EventArgs e)
        {
            uLocalFiles localFiles = sender as uLocalFiles;
            string title = deleteFolder.Replace("\"Music\"", "\"" + localFiles.Title + "\"");
            if (MessageBox.Show(title, captionDelete, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                RemovePath(localFiles.FolderPath);
                LoadLocalFiles();
            }
        }

        public static string[] ShowLocalFiles()
        {
            string filePath = Path;
            if (!Directory.Exists(Folder))
                Directory.CreateDirectory(Folder);
            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
            }
            return File.ReadAllLines(filePath);
        }
        public bool IsPathExists(string path, string folderPath)
        {
            var lines = File.ReadAllLines(folderPath).ToList();
            foreach (var item in lines)
            {
                if (item == path)
                    return true;
            }
            return false;
        }
        public void SaveLocalFiles(string path)
        {
            string folderPath = fLocalFiles.Path;
            var lines = File.ReadAllLines(folderPath).ToList();
            if (lines.Count() > 0)
            {
                if (!IsPathExists(path, folderPath))
                    lines.Insert(lines.Count() - 1, path);
                File.WriteAllLines(folderPath, lines);
            }
            else
                File.WriteAllLines(folderPath, new string[] { path });

        }
        public void RemovePath(string path)
        {
            string folderPath = fLocalFiles.Path;
            var lines = File.ReadAllLines(folderPath).ToList();
            foreach (var item in lines)
            {
                if (item == path)
                {
                    lines.Remove(item);
                    break;
                }
            }
            File.WriteAllLines(folderPath, lines);
        }
        public string GetTitle(string path)
        {
            string[] title = path.Split('\\');
            return title[title.Count() - 1];
        }
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

            Close();
        }
        private void addLocalFiles_AddLocalFiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = false;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                uLocalFiles localFiles = new uLocalFiles();
                localFiles.FolderPath = folder.SelectedPath;
                localFiles.LocalFiles_Click += LocalFiles_LocalFiles_Click;
                localFiles.Title = GetTitle(folder.SelectedPath);
                panelLocalFiles.Controls.Add(localFiles);
                SaveLocalFiles(folder.SelectedPath);
            }
        }
        private void addLocalFiles1_LocalFiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = false;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                uLocalFiles localFiles = new uLocalFiles();
                localFiles.FolderPath = folder.SelectedPath;
                localFiles.LocalFiles_Click += LocalFiles_LocalFiles_Click;
                localFiles.Title = GetTitle(folder.SelectedPath);
                panelLocalFiles.Controls.Add(localFiles);
                SaveLocalFiles(folder.SelectedPath);
            }
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
