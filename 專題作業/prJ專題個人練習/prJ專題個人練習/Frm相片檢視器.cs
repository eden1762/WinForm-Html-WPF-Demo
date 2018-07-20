using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prJ專題個人練習
{
    public partial class Frm相片檢視器 : Form
    {
        public Frm相片檢視器()
        {
            InitializeComponent();
        }
        List<photox> pp = FrmMyAlbum.pho;
        int num = FrmMyAlbum.phx;
        bool a=false;

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            a = !a;
            if(a==true)
            {
                truesize();
            }
            else         
            {
                ntruesize();
            }




        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (num >= pp.Count - 1)
            {
                num = 0;
                pictureBox1.Image = pp[num].Image;

            }
            else
            {
                num++;
                pictureBox1.Image = pp[num].Image;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = !this.timer1.Enabled;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (num <= 0)
            {
                num = pp.Count - 1;
                pictureBox1.Image = pp[num].Image;
            }
            else
            {
                num--;
                pictureBox1.Image = pp[num].Image;
            }

        }

        private void trackBar1_DragLeave(object sender, EventArgs e)
        {
            int a;
            int b;


            pictureBox1.Width = trackBar1.Value+608;
            pictureBox1.Height = trackBar1.Value+508;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num >= pp.Count - 1)
            {
                num = 0;
                pictureBox1.Image = pp[num].Image;
            }
            else
            {
                num++;
                pictureBox1.Image = pp[num].Image;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        internal void truesize()
        {
            pictureBox1.Width= pp[num].Image.Width;
            pictureBox1.Height= pp[num].Image.Height;
            this.Width = pp[num].Image.Width;
            this.Height = pp[num].Image.Height;
        }
        internal void ntruesize()
        {
            pictureBox1.Width = 608;
            pictureBox1.Height = 508;
            this.Width = 608;
            this.Height = 508;
        }

        private void trackBar1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void trackBar1_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}
