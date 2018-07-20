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
    public partial class FrmSetAlarm : Form
    {
        public FrmSetAlarm()
        {
            InitializeComponent();
        }
        string s;
        bool b = true;

        private void FrmSetAlarm_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH時mm分ss秒");
            if (label2.Text == label1.Text)
            {
                timer2.Enabled = true;
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            s = maskedTextBox1.Text;
            label2.Text = s;

        }


        int i;
        private void timer2_Tick(object sender, EventArgs e)
         {
            
            if (b== true)
                {
                    this.BackColor = Color.Blue;
                b = !b;
                }
                else
                {
                    this.BackColor = Color.Red;
                b = !b;
            }


            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
