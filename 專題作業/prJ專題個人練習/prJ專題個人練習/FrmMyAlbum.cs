using prJ專題個人練習;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prJ專題個人練習
{
    public partial class FrmMyAlbum : Form
    {
        public FrmMyAlbum()
        {
            InitializeComponent();
            openFileDialog1.Multiselect = true;
        }
        internal static List<photox> pho = new List<photox>();
        internal static int phx;
        string fileName = string.Empty; //宣告一個存取拖曳檔案的路徑


        private void FrmMyAlbum_Load(object sender, EventArgs e)
        {
            MyAlbumEntities3 ae3 = new MyAlbumEntities3();
            var alQuery = from al in ae3.Photos
                          select al.Description;
            foreach (string com in alQuery)
            {
                comboBox1.Text = com;
            }
            相片管理 f = new 相片管理();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;

            f.Show();

            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            //允許pictureBox1接受拖曳檔案
            flowLayoutPanel2.AllowDrop = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            相片管理 相片 = new 相片管理();
            相片.Show();
        }

        
        private void label3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            MyAlbumEntities3 ae3 = new MyAlbumEntities3();
            var alQuery = from al in ae3.Photos
                          where al.Description == "London"
                          select al.Picture;
            foreach (byte[] phoo in alQuery)
            {
                MemoryStream mym = new MemoryStream(phoo,0,phoo.Length);
                photox pic = new photox();
                
                pic.Image =Image.FromStream(mym);
                pic.Width = 100;
                pic.Height = 80;
                pic.BorderStyle = BorderStyle.Fixed3D;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Padding = new Padding(5);
                this.flowLayoutPanel1.Controls.Add(pic);
                pic.Click += Pic_Click;
                pic.MouseEnter += Pic_MouseEnter;
                pic.MouseLeave += Pic_MouseLeave;
                pho.Add(pic);
                pic.px= phoo.Length-1;
                
                
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            MyAlbumEntities3 ae3 = new MyAlbumEntities3();
            var alQuery = from al in ae3.Photos
                          where al.Description == "Paris"
                          select al.Picture;
            foreach (byte[] phoo in alQuery)
            {
                MemoryStream mym = new MemoryStream(phoo, 0, phoo.Length);
                photox pic = new photox();
                pic.Image = Image.FromStream(mym);
                pic.Width = 100;
                pic.Height = 80;
                pic.BorderStyle = BorderStyle.Fixed3D;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Padding = new Padding(5);
                this.flowLayoutPanel1.Controls.Add(pic);

                pic.Click += Pic_Click;
                pic.MouseEnter += Pic_MouseEnter;
                pic.MouseLeave += Pic_MouseLeave;
                pho.Add(pic);
                pic.px = phoo.Length - 1;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            MyAlbumEntities3 ae3 = new MyAlbumEntities3();
            var alQuery = from al in ae3.Photos
                          where al.Description == "Munich"
                          select al.Picture;
            foreach (byte[] phoo in alQuery)
            {
                MemoryStream mym = new MemoryStream(phoo, 0, phoo.Length);
                photox pic = new photox();

                pic.Image = Image.FromStream(mym);
                pic.Width = 100;
                pic.Height = 80;
                pic.BorderStyle = BorderStyle.Fixed3D;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Padding = new Padding(5);
                this.flowLayoutPanel1.Controls.Add(pic);
                pic.Click += Pic_Click;
                pic.MouseEnter += Pic_MouseEnter;
                pic.MouseLeave += Pic_MouseLeave;
                pho.Add(pic);
                pic.px = phoo.Length - 1;




            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            //((PictureBox)sender).BackColor = Color.Blue;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //((PictureBox)sender).BackColor = Color.Pink;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
                    



                    this.flowLayoutPanel2.Controls.Add(pic);

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            if (comboBox1.SelectedItem == "慕尼黑")
            {
                MyAlbumEntities3 ae3 = new MyAlbumEntities3();
                var alQuery = from al in ae3.Photos
                              where al.Description == "Munich"
                              select al.Picture;
                foreach (byte[] phoo in alQuery)
                {
                    MemoryStream mym = new MemoryStream(phoo, 0, phoo.Length);
                    photox pic = new photox();

                    pic.Image = Image.FromStream(mym);
                    pic.Width = 100;
                    pic.Height = 80;
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Padding = new Padding(5);
                    this.flowLayoutPanel2.Controls.Add(pic);
                    pic.Click += Pic_Click;
                    pic.MouseEnter += Pic_MouseEnter;
                    pic.MouseLeave += Pic_MouseLeave;
                    pho.Add(pic);
                    pic.px = phoo.Length - 1;
                }
            }
            else if (comboBox1.SelectedItem == "倫敦")
            {
                MyAlbumEntities3 ae3 = new MyAlbumEntities3();
                var alQuery = from al in ae3.Photos
                              where al.Description == "London"
                              select al.Picture;
                foreach (byte[] phoo in alQuery)
                {
                    MemoryStream mym = new MemoryStream(phoo, 0, phoo.Length);
                    photox pic = new photox();

                    pic.Image = Image.FromStream(mym);
                    pic.Width = 100;
                    pic.Height = 80;
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Padding = new Padding(5);
                    this.flowLayoutPanel2.Controls.Add(pic);
                    pic.Click += Pic_Click;
                    pic.MouseEnter += Pic_MouseEnter;
                    pic.MouseLeave += Pic_MouseLeave;
                    pho.Add(pic);
                    pic.px = phoo.Length - 1;
                }
            }
            else if (comboBox1.SelectedItem == "巴黎")
            {
                MyAlbumEntities3 ae3 = new MyAlbumEntities3();
                var alQuery = from al in ae3.Photos
                              where al.Description == "Paris"
                              select al.Picture;
                foreach (byte[] phoo in alQuery)
                {
                    MemoryStream mym = new MemoryStream(phoo, 0, phoo.Length);
                    photox pic = new photox();

                    pic.Image = Image.FromStream(mym);
                    pic.Width = 100;
                    pic.Height = 80;
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Padding = new Padding(5);
                    this.flowLayoutPanel2.Controls.Add(pic);
                    pic.Click += Pic_Click;
                    pic.MouseEnter += Pic_MouseEnter;
                    pic.MouseLeave += Pic_MouseLeave;
                    pho.Add(pic);
                    pic.px = phoo.Length - 1;
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
           
        }
        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.White;
        }

        private void Pic_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Red;
        }
        private void Pic_Click(object sender, EventArgs e)
        {
            Frm相片檢視器 ff = new Frm相片檢視器();
            ff.pictureBox1.Image = ((photox)sender).Image;
            phx = ((photox)sender).px;
            ff.BackgroundImageLayout = ImageLayout.Stretch;
            ff.Show();

        }


        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void photox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void photox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void flowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                //拖曳檔案是否存在
                if (File.Exists(fileName))
                {
                    Bitmap img = new Bitmap(fileName);
                    photox pic = new photox();
                    //將圖片顯示在pictureBox1
                    
                   
                    pic.Image = img;
                    pic.Width = 100;
                    pic.Height = 80;
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Padding = new Padding(5);
                    this.flowLayoutPanel2.Controls.Add(pic);

                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Click += Pic_Click;
                    pic.MouseEnter += Pic_MouseEnter;
                    pic.MouseLeave += Pic_MouseLeave;
                    pho.Add(pic);
                    pic.px++;
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("不是有效的圖檔格式");
            }
        }

        private void flowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileNameW"))
            {
                string[] data = (e.Data.GetData("FileNameW") as string[]);
                fileName = data[0];
                e.Effect = DragDropEffects.All;
            }

        }
    }
}
