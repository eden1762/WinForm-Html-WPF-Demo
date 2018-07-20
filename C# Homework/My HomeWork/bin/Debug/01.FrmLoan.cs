using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace My_HomeWork
{
    public partial class FrmLoan : Form
    {
        public FrmLoan()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            double PV= double.Parse(textBox1.Text);
            double NPer = double.Parse(textBox2.Text);
            double Rate = double.Parse(textBox3.Text);
            double answera=Financial.Pmt(
                Rate*0.01/12,
                NPer,
                -PV
                                );
            
            MessageBox.Show("每月得繳"+answera);
        //  PMT(3000000....) 
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double PV = double.Parse(textBox1.Text);
            double NPer = double.Parse(textBox2.Text);
            double Rate = double.Parse(textBox3.Text);
            double answerb = Financial.Pmt(
                Rate*0.01/12,
                NPer,
                -PV
                                )*NPer;
            MessageBox.Show("總金額"+answerb);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double PV = double.Parse(textBox1.Text);
            double NPer = double.Parse(textBox2.Text);
            double Rate = double.Parse(textBox3.Text);
            double answera = Financial.Pmt(
                Rate * 0.01 / 12,
                NPer,
                -PV
                                );
            FrmLoanReport f2 = new FrmLoanReport();
            


            FrmLoanReport.anl1 = (answera.ToString("F0"));
                        double answerb = Financial.Pmt(
                Rate * 0.01 / 12,
                NPer,
                -PV
                                ) * NPer;
            
            FrmLoanReport.anl2 = (answerb.ToString("F0"));
            FrmLoanReport.anl5 = textBox1.Text;
            FrmLoanReport.anl3 = textBox2.Text;
            FrmLoanReport.anl4 = textBox3.Text;
            f2.Show();

        }

        private void FrmLoan_Load(object sender, EventArgs e)
        {

        }

        private void FrmLoan_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double PV = double.Parse(textBox1.Text);
            double NPer = double.Parse(textBox2.Text);
            double Rate = double.Parse(textBox3.Text);
            double answera = Financial.Pmt(
                Rate * 0.01 / 12,
                NPer,
                -PV
                                );
            FrmLoanReport f2 = new FrmLoanReport();



            FrmLoanReport.anl1 = (answera.ToString("F0"));
            double answerb = Financial.Pmt(
    Rate * 0.01 / 12,
    NPer,
    -PV
                    ) * NPer;
            FrmLoanReport.anl2 = (answerb.ToString("F0"));
            FrmLoanReport.anl5 = textBox1.Text;
            FrmLoanReport.anl3 = textBox2.Text;
            FrmLoanReport.anl4 = textBox3.Text;
        }
    }
}
