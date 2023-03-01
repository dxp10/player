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
    public partial class uAddLocalFiles : UserControl
    {
        public uAddLocalFiles()
        {
            InitializeComponent();
        }
        public event EventHandler LocalFiles_Click;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Start();
            timer.Tick += Timer_Tick;

            LocalFiles_Click?.Invoke(this, e);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
            Timer timer = sender as Timer;
            timer.Stop();
            timer.Dispose();
        }

        private void AddLocalFiles_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Start();
            timer.Tick += Timer_Tick;

            LocalFiles_Click?.Invoke(this, e);
        }
    }
}
