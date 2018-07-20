using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace My_HomeWork
{
    public partial class FrmLotoo : Form
    {
        public FrmLotoo()
        {
            InitializeComponent();
        }

        List<PictureBox> lol = new List<PictureBox>();

        internal static int[] lop= new int [6];
        internal static int[] lab= new int [6];
        //internal List<int> op=new List<int>();
        //internal static int[] w2;
        //internal static int[] w3;
        //internal static int[] w4;
        //internal static int[] w5;
        //internal static int[] w6;
        internal static int ww0;
        internal static int ww1;
        internal static int ww2;
        internal static int ww3;
        internal static int ww4;
        internal static int ww5;
        internal static int ww6;



        private void button1_Click(object sender, EventArgs e)
        {

            this.timer1.Enabled = true;
            //Random r = new Random();


            //for (int i =0 ; i < lab.Length; i++)
            //{
            //    lab[i] = r.Next(1, 42);
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (lab[i] == lab[j])
            //        {
            //            j =0;
            //            lab[i] = r.Next(1, 42);
            //        }
            //    }


            //}
            //label1.Text = lab[0].ToString();
            //label2.Text = lab[1].ToString();
            //label3.Text = lab[2].ToString();
            //label4.Text = lab[3].ToString();
            //label5.Text = lab[4].ToString();
            //label6.Text = lab[5].ToString();





        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random r = new Random();


            for (int i = 0; i < lab.Length; i++)
            {

                lab[i] = r.Next(1, 42);
                for (int j = 0; j < i; j++)
                {
                    if (lab[i] == lab[j])
                    {
                        j = 0;
                        lab[i] = r.Next(1, 42);

                    }

                }


            }
            this.pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\樂透彩號碼圖\\" + lab[0].ToString() + ".jpg");
            this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\樂透彩號碼圖\\" + lab[1].ToString() + ".jpg");
            this.pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\樂透彩號碼圖\\" + lab[2].ToString() + ".jpg");
            this.pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\樂透彩號碼圖\\" + lab[3].ToString() + ".jpg");
            this.pictureBox5.Image = Image.FromFile(Application.StartupPath + "\\樂透彩號碼圖\\" + lab[4].ToString() + ".jpg");
            this.pictureBox6.Image = Image.FromFile(Application.StartupPath + "\\樂透彩號碼圖\\" + lab[5].ToString() + ".jpg");
            this.domainUpDown1.Text= lab[0].ToString();
            this.domainUpDown2.Text = lab[1].ToString();
            this.domainUpDown3.Text = lab[2].ToString();
            this.domainUpDown4.Text = lab[3].ToString();
            this.domainUpDown5.Text = lab[4].ToString();
            this.domainUpDown6.Text = lab[5].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            Random r = new Random();


            for (int i = 0; i < lab.Length; i++)
            {

                lab[i] = r.Next(1, 42);
                for (int j = 0; j < i; j++)
                {
                    if (lab[i] == lab[j])
                    {
                        j = 0;
                        lab[i] = r.Next(1, 42);

                    }

                }


            }
            this.pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\樂透彩號碼圖\\" + lab[0].ToString() + ".jpg");
            this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\樂透彩號碼圖\\" + lab[1].ToString() + ".jpg");
            this.pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\樂透彩號碼圖\\" + lab[2].ToString() + ".jpg");
            this.pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\樂透彩號碼圖\\" + lab[3].ToString() + ".jpg");
            this.pictureBox5.Image = Image.FromFile(Application.StartupPath + "\\樂透彩號碼圖\\" + lab[4].ToString() + ".jpg");
            this.pictureBox6.Image = Image.FromFile(Application.StartupPath + "\\樂透彩號碼圖\\" + lab[5].ToString() + ".jpg");
            this.domainUpDown1.Text = lab[0].ToString();
            this.domainUpDown2.Text = lab[1].ToString();
            this.domainUpDown3.Text = lab[2].ToString();
            this.domainUpDown4.Text = lab[3].ToString();
            this.domainUpDown5.Text = lab[4].ToString();
            this.domainUpDown6.Text = lab[5].ToString();
            MessageBox.Show(lab[0].ToString() + "," + lab[1].ToString() + "," + lab[2].ToString() + "," + lab[3].ToString() + "," + lab[4].ToString() + "," + lab[5].ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            Random r = new Random();


            for (int i = 0; i < lop.Length; i++)
            {

                lop[i] = r.Next(1, 42);
                for (int j = 0; j < i; j++)
                {
                    if (lop[i] == lop[j])
                    {
                        j = 0;
                        lop[i] = r.Next(1, 42);

                    }

                }


            }
            MessageBox.Show(lop[0].ToString() + "," + lop[1].ToString() + "," + lop[2].ToString() + "," + lop[3].ToString() + "," + lop[4].ToString() + "," + lop[5].ToString());
        }

        private void button4_Click(object sender, EventArgs e)
               {
            int a1 = lab[0];
            int a2 = lab[1];
            int a3 = lab[2];
            int a4 = lab[3];
            int a5 = lab[4];
            int a6 = lab[5];
            int b1 = lop[0];
            int b2 = lop[1];
            int b3 = lop[2];
            int b4 = lop[3];
            int b5 = lop[4];
            int b6 = lop[5];
            int[] out1 = {a1,a2,a3,a4,a5,a6 };
            int[] out2 = { b1, b2, b3, b4, b5, b6 };
            int win=0;
            for (int i=0;i<=lab.Length-1;i++)
            {
                for (int j = 0; j <= lab.Length - 1; j++)
                {
                        if (out1[i] == out2[j])
                    {
                        win += 1;
                    }
                }
            }
            MessageBox.Show("總共中了" + win + "個號碼");
        }
        //int a1 = 0;
        //int a2 = 0;
        //int a3 = 0;
        //int a4 = 0;
        //int a5 = 0;
        //int a6 = 0;
        //int b1 = 0;
        //int b2 = 0;
        //int b3 = 0;
        //int b4 = 0;
        //int b5 = 0;
        //int b6 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {

            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            int a5 = 0;
            int a6 = 0;
            int b1 = 0;
            int b2 = 0;
            int b3 = 0;
            int b4 = 0;
            int b5 = 0;
            int b6 = 0;

            Random ra = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < lab.Length; i++)
            {

                lab[i] = ra.Next(1, 42);
                for (int j = 0; j < i; j++)
                {
                    if (lab[i] == lab[j])
                    {
                        j = 0;
                        lab[i] = ra.Next(1, 42);

                    }

                }


            }
            a1 = lab[0];
            a2 = lab[1];
            a3 = lab[2];
            a4 = lab[3];
            a5 = lab[4];
            a6 = lab[5];

            Random rb = new Random(Guid.NewGuid().GetHashCode());

            for (int m = 0; m < lop.Length; m++)
            {

                lop[m] = rb.Next(1, 42);
                for (int n = 0; n < m; n++)
                {
                    if (lop[m] == lop[n])
                    {
                        n = 0;
                        lop[m] = rb.Next(1, 42);
                    }

                }


            }


            b1 = lop[0];
            b2 = lop[1];
            b3 = lop[2];
            b4 = lop[3];
            b5 = lop[4];
            b6 = lop[5];
            int[] out1 = { a1, a2, a3, a4, a5, a6 };
    
            int[] out2 = { b1, b2, b3, b4, b5, b6 };
            
            int win = 0;
            for (int q = 0; q <= lab.Length - 1; q++)
            {
                for (int r = 0; r <= lab.Length - 1; r++)
                {
                    if (out1[q] == out2[r])
                    {
                        win += 1;
                    }
                    
                }
               
            }


            richTextBox1.Text += "總共中了" + win + "個號碼" + "\n";
            if (win == 0)
            { ww0 += 1; }
            if (win == 1)
            { ww1 += 1; }
            if (win == 2)
            { ww2 += 1; }
            if (win == 3)
            { ww3 += 1; }
            if (win == 4)
            { ww4 += 1; }
            if (win == 5)
            { ww5 += 1; }
            if (win == 6)
            { ww6 += 1; }



        }
        private void button5_Click(object sender, EventArgs e)
         {
            this.timer2.Enabled = true;
            
        }



        private void button6_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmLotooShow f2 = new FrmLotooShow();
            FrmLotooShow.leb0=  ww0 * 100 / (ww0 + ww1 + ww2 + ww3 + ww4 + ww5 + ww6);
            FrmLotooShow.leb1 = ww1 * 100 / (ww0 + ww1 + ww2 + ww3 + ww4 + ww5 + ww6);
            FrmLotooShow.leb2 = ww2 * 100 / (ww0 + ww1 + ww2 + ww3 + ww4 + ww5 + ww6);
            FrmLotooShow.leb3 = ww3 * 100 / (ww0 + ww1 + ww2 + ww3 + ww4 + ww5 + ww6);
            FrmLotooShow.leb4 = ww4 * 100 / (ww0 + ww1 + ww2 + ww3 + ww4 + ww5 + ww6);
            FrmLotooShow.leb5= ww5 * 100 / (ww0 + ww1 + ww2 + ww3 + ww4 + ww5 + ww6);
            FrmLotooShow.leb6 = ww6 * 100 / (ww0 + ww1 + ww2 + ww3 + ww4 + ww5 + ww6);
            f2.Show();

        }


    }
    }




