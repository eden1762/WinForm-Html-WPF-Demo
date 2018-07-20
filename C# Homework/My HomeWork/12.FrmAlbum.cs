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
    public partial class FrmAlbum : Form
    {
        public FrmAlbum()
        {
            InitializeComponent();
            openFileDialog1.Multiselect = true;
        }
        internal static List<photox> pho = new List<photox>();
        internal static int phx;
        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.White;
        }

        private void Pic_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Red;
        }
            

        
        private void Pic_MouseClick(object sender, EventArgs e)
        {
            
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            FrmAlbumShow f2 = new FrmAlbumShow();
            f2.BackgroundImage = ((photox)sender).Image;
            phx = ((photox)sender).px;
            f2.BackgroundImageLayout = ImageLayout.Stretch;
            f2.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void FrmMyAlbum_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] filenames = this.openFileDialog1.FileNames;


                for (int i = 0; i <= filenames.Length - 1; i++)
                {
                    photox pic = new photox();

                    pic.Width = 100;
                    pic.Height = 80;
                    pic.BorderStyle = BorderStyle.Fixed3D;

                    pic.Image = Image.FromFile(filenames[i]);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;



                    pic.Padding = new Padding(5);

                    pic.Click += Pic_Click;
                    pic.MouseEnter += Pic_MouseEnter;
                    pic.MouseLeave += Pic_MouseLeave;
                    pic.px = i;
                    pho.Add(pic);



                    this.flowLayoutPanel1.Controls.Add(pic);

                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
