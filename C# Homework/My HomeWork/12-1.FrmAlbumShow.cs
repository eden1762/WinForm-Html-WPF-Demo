using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_HomeWork
{
    public partial class FrmAlbumShow : Form
    {
        public FrmAlbumShow()
        {
            InitializeComponent();
        }
        List<photox> pp = FrmAlbum.pho;
        int num = FrmAlbum.phx;
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num >= pp.Count-1)
            {
                num = 0;
                BackgroundImage = pp[num].Image;
            }
            else 
            {
                num++;
                BackgroundImage = pp[num].Image;
            }

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if (num >= pp.Count - 1)
            {
                num = 0;
                BackgroundImage = pp[num].Image;
            }
            else
            {
                num++;
                BackgroundImage = pp[num].Image;
            }
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            this.timer1.Enabled = !this.timer1.Enabled;
        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {
            if (num <= 0)
            {
                num = pp.Count - 1;
                BackgroundImage = pp[num].Image;
            }
            else
            {
                num--;
                BackgroundImage = pp[num].Image;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAlbumShow_Load(object sender, EventArgs e)
        {
            
        }
    }
}
