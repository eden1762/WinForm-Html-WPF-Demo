using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_HomeWork;



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
            
            StreamReader sr = new StreamReader(@"01.FrmLoan.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();
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
            
            StreamReader sr = new StreamReader(@"02.FrmLoanReport", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();
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
            
            StreamReader sr = new StreamReader(@"02.FrmPOS 收銀機.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();
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
            StreamReader sr = new StreamReader(@"03.FrmStudentstrut.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();

            
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
            
            StreamReader sr = new StreamReader(@"04. Frm標準練習.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();
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
            StreamReader sr = new StreamReader(@"05. FrmStudentList.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();
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
            StreamReader sr = new StreamReader(@"06.FrmEmployeeList.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();

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
            StreamReader sr = new StreamReader(@"07.FrmLotoo.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();
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
            StreamReader sr = new StreamReader(@"08.FrmGame.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();

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
            StreamReader sr = new StreamReader(@"09.FrmScreenSaver.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();

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
            StreamReader sr = new StreamReader(@"10.FrmPaint.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmNotePad f = new FrmNotePad();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            StreamReader sr = new StreamReader(@"11.FrmNotePad.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmAlbum f = new FrmAlbum();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            StreamReader sr = new StreamReader(@"12.FrmAlbum.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.splitContainer3.Panel2Collapsed = !this.splitContainer3.Panel2Collapsed;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmGuess f = new FrmGuess();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            StreamReader sr = new StreamReader(@"13.FrmGuess.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FrmSetAlarm f = new FrmSetAlarm();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.splitContainer3.Panel1.Controls.Clear();
            this.splitContainer3.Panel1.Controls.Add(f);
            StreamReader sr = new StreamReader(@"14.FrmSetAlarm.cs", Encoding.Default);
            this.textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
