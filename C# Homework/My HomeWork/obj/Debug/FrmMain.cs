using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_AP;
using Windows_AP.Lab_3_xxxStrip;
using Windows_AP.Lab_6_Windows_AP_設定_與_表單繼承;

namespace My_HomeWork
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLoan f=new FrmLoan();
            
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            this.textBox1.Text = f.Text;
            //FrmLoan f2 = new FrmLoan();

            //string s =
            //textBox1.Text = s.;



            //this.splitContainer3.Panel2.Controls.Clear();
            //this.splitContainer3.Panel2.Controls.Add(f2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLoanReport f = new FrmLoanReport(); 
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            this.textBox1.Text = f.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPOS收銀機 f = new FrmPOS收銀機();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            this.textBox1.Text = f.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmStudentstrut f = new FrmStudentstrut();
           f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            string[] files = System.IO.Directory.GetFiles(@"FrmStudentstrut.cs");
           textBox1.Text = files.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm標準練習 f = new Frm標準練習();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            this.textBox1.Text = f.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStudentList f = new FrmStudentList();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            this.textBox1.Text = f.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmEmployeeList f = new FrmEmployeeList();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            this.textBox1.Text = f.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmLotoo f = new FrmLotoo();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            this.textBox1.Text = f.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmGame f = new FrmGame();
           f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            this.textBox1.Text = f.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmScreenSaver f = new FrmScreenSaver();
            f.TopLevel = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.WindowState = FormWindowState.Maximized;
            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.textBox1.Text = f.Text;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmPaint f = new FrmPaint();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            this.textBox1.Text = f.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmMyNotePad f = new FrmMyNotePad();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            this.textBox1.Text = f.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmMyAlbum f = new FrmMyAlbum();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            this.textBox1.Text = f.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.splitContainer3.Panel2Collapsed = !this.splitContainer3.Panel2Collapsed;
        }
    }
}
