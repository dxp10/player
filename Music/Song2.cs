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
    public partial class Song2 : UserControl
    {
        Image pause;
        Image play;
        public Song2()
        {
            InitializeComponent();
            pause = Music.Properties.Resources.pause;
            play = Music.Properties.Resources.play;
            btnPlay.Image = pause;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(btnPlay.Image==pause)
            {
                btnPlay.Image = play;
            }
            else
            {
                btnPlay.Image = pause;
            }
        }
    }
}
