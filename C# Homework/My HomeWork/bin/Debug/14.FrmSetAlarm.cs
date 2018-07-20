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

        private void FrmSetAlarm_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            if(s==DateTime.Now.ToString("HH時mm分ss秒"))
            {
                timer2.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
           
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            s = maskedTextBox1.Text;
            label2.Text = s;
        }



        private void timer2_Tick(object sender, EventArgs e)
                 {
            for (int i = 0; i < 2; i--)
            {
                i = i + 1;
                if (i == 1)
                {
                    this.BackColor = Color.Blue;
                    i = i - 1;
                }
                if (i == 0)
                {
                    this.BackColor = Color.Red;
                    i = i + 1;
                }


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
