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

        private void Loanbutton_Click(object sender, EventArgs e)
        {
            try { 
            FrmLoan f=new FrmLoan();
            
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            this.FrmsplitContainer.Panel1.Controls.Add(f);
            
            StreamReader sr = new StreamReader(@"01.FrmLoan.cs", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
                //FrmLoan f2 = new FrmLoan();

                //string s =
                //textBox1.Text = s.;



                //this.splitContainer3.Panel2.Controls.Clear();
                //this.splitContainer3.Panel2.Controls.Add(f2.Text);
            }
            catch(Exception ex)
            {

            }
        }

        private void FrmLoanReportbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmLoanReport f = new FrmLoanReport(); 
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            this.FrmsplitContainer.Panel1.Controls.Add(f);
            
            StreamReader sr = new StreamReader(@"02.FrmLoanReport", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmPOSbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPOS收銀機 f = new FrmPOS收銀機();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            this.FrmsplitContainer.Panel1.Controls.Add(f);
            
            StreamReader sr = new StreamReader(@"02.FrmPOS 收銀機.cs", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmStudentstrutbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmStudentstrut f = new FrmStudentstrut();
           f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            this.FrmsplitContainer.Panel1.Controls.Add(f);
            StreamReader sr = new StreamReader(@"03.FrmStudentstrut.cs", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
            }
            catch (Exception ex)
            {

            }


        }

        private void Frm標準練習button_Click(object sender, EventArgs e)
        {
            try
            {
                Frm標準練習 f = new Frm標準練習();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            this.FrmsplitContainer.Panel1.Controls.Add(f);
            
            StreamReader sr = new StreamReader(@"04. Frm標準練習.cs", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmStudentListbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmStudentList f = new FrmStudentList();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            this.FrmsplitContainer.Panel1.Controls.Add(f);
            StreamReader sr = new StreamReader(@"05. FrmStudentList.cs", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmEmployeeListbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEmployeeList f = new FrmEmployeeList();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            this.FrmsplitContainer.Panel1.Controls.Add(f);
            StreamReader sr = new StreamReader(@"06.FrmEmployeeList.cs", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
            }
            catch (Exception ex)
            {

            }

        }

        private void FrmLotoobutton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmLotoo f = new FrmLotoo();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            this.FrmsplitContainer.Panel1.Controls.Add(f);
            StreamReader sr = new StreamReader(@"07.FrmLotoo.cs", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmGamebutton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGame f = new FrmGame();
           f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            this.FrmsplitContainer.Panel1.Controls.Add(f);
            StreamReader sr = new StreamReader(@"08.FrmGame.cs", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
        }
             catch (Exception ex)
            {

            }

        }

        private void FrmScreenSaverbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmScreenSaver f = new FrmScreenSaver();
            f.TopLevel = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.WindowState = FormWindowState.Maximized;
            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            StreamReader sr = new StreamReader(@"09.FrmScreenSaver.cs", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
            }
            catch (Exception ex)
            {

            }

        }

        private void FrmPaintbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPaint f = new FrmPaint();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            this.FrmsplitContainer.Panel1.Controls.Add(f);
            StreamReader sr = new StreamReader(@"10.FrmPaint.cs", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmNotePadbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNotePad f = new FrmNotePad();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            this.FrmsplitContainer.Panel1.Controls.Add(f);
            StreamReader sr = new StreamReader(@"13.FrmNotePad.cs", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
            }
            catch (Exception ex)
            {

            }

        }

        private void FrmAlbumbutton_Click1(object sender, EventArgs e)
        {
            try
            {
                FrmAlbum f = new FrmAlbum();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            this.FrmsplitContainer.Panel1.Controls.Add(f);
            StreamReader sr = new StreamReader(@"12.FrmAlbum.cs", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
            }
            catch (Exception ex)
            {

            }

        }

        private void PanelCollapsedbutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.FrmsplitContainer.Panel2Collapsed = !this.FrmsplitContainer.Panel2Collapsed;
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmGuessbutton_Click(object sender, EventArgs e)
        {
            try
            {

                FrmGuess f = new FrmGuess();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.Sizable;

            f.Show();

            this.FrmsplitContainer.Panel1.Controls.Clear();
            this.FrmsplitContainer.Panel1.Controls.Add(f);
            StreamReader sr = new StreamReader(@"13.FrmGuess.cs", Encoding.Default);
            this.CodetextBox.Text = sr.ReadToEnd();
            sr.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmSetAlarmbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSetAlarm f = new FrmSetAlarm();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.Sizable;

                f.Show();

                this.FrmsplitContainer.Panel1.Controls.Clear();
                this.FrmsplitContainer.Panel1.Controls.Add(f);
                StreamReader sr = new StreamReader(@"14.FrmSetAlarm.cs", Encoding.Default);
                this.CodetextBox.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
