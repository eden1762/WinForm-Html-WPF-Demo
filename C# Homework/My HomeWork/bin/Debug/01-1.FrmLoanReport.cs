using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace My_HomeWork
{
    public partial class FrmLoanReport : Form
        
    {
        public FrmLoanReport()
        {
            InitializeComponent();
        }
        public static string anl1;
        public static string anl2;
        public static string anl3;
        public static string anl4;
        public static string anl5;

        public void FrmLoadReport_Load(object sender, EventArgs e)
        {
            label6.Text=anl1;
                label7.Text = anl2;
            label8.Text = anl3;
            label9.Text = anl4;
           label10.Text = anl5;


    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////System.Net.Mail.SmtpClient client  = new System.Net.Mail.SmtpClient();
            ////client.Host = "edenherorockybatman@gmail.com";
            ////client.Port = 587;
            ////client.Credentials = new NetworkCredential("edenherorockybatman@gmail.com",);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = anl1;
            label7.Text = anl2;
            label8.Text = anl3;
            label9.Text = anl4;
            label10.Text = anl5;
        }
    }
}
