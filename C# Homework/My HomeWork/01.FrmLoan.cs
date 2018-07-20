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

        
        private void 單月button_Click(object sender, EventArgs e)
        {

            double PV= double.Parse(貸款金額應繳金額textBox.Text);
            double NPer = double.Parse(分期數textBox.Text);
            double Rate = double.Parse(利息textBox.Text);
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

        private void 總金額button_Click(object sender, EventArgs e)
        {
            double PV = double.Parse(貸款金額應繳金額textBox.Text);
            double NPer = double.Parse(分期數textBox.Text);
            double Rate = double.Parse(利息textBox.Text);
            double answerb = Financial.Pmt(
                Rate*0.01/12,
                NPer,
                -PV
                                )*NPer;
            MessageBox.Show("總金額"+answerb);

        }

        private void Reportbutton_Click(object sender, EventArgs e)
        {
            double PV = double.Parse(貸款金額應繳金額textBox.Text);
            double NPer = double.Parse(分期數textBox.Text);
            double Rate = double.Parse(利息textBox.Text);
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
            FrmLoanReport.anl5 = 貸款金額應繳金額textBox.Text;
            FrmLoanReport.anl3 = 分期數textBox.Text;
            FrmLoanReport.anl4 = 利息textBox.Text;
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

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            double PV = double.Parse(貸款金額應繳金額textBox.Text);
            double NPer = double.Parse(分期數textBox.Text);
            double Rate = double.Parse(利息textBox.Text);
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
            FrmLoanReport.anl5 = 貸款金額應繳金額textBox.Text;
            FrmLoanReport.anl3 = 分期數textBox.Text;
            FrmLoanReport.anl4 = 利息textBox.Text;

            f2.Refresh();

        }
    }
}
