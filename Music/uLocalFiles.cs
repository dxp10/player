using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class uLocalFiles : UserControl
    {
        public uLocalFiles()
        {
            InitializeComponent();
        }
        public event EventHandler LocalFiles_Click;
        public string Title
        {
            set
            {
                title.Text = value;
            }
            get
            {
                return title.Text;
            }
        }
        public string FolderPath
        {
            set
            {
                folderPath.Text = value;
            }
            get
            {
                return folderPath.Text;
            }
        }

        private void folderPath_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Start();
            timer.Tick += Timer_Tick;
            if (LocalFiles_Click != null)
                LocalFiles_Click(this,e);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
            Timer timer = sender as Timer;
            timer.Stop();
            timer.Dispose();
            
        }
    }
}
