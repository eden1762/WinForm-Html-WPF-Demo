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
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();
            foreach (Button btn in this.Panel1.Controls)
            {
                btn.Click += Btn_Click;
                btn.Text = "";
                btn.BackColor = Color.PowderBlue;
                btn.ForeColor = Color.Red;
                



            }
        }
        bool Flag;
        private void Btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Start!");
            if (Flag)
            {
                ((Button)sender).Text = "X";
                ((Button)sender).BackColor = Color.PeachPuff;
                ((Button)sender).ForeColor = Color.Navy;
            }
            else
            {
                ((Button)sender).Text = "O";
                ((Button)sender).BackColor = Color.Olive;
                ((Button)sender).ForeColor = Color.MediumAquamarine;
            }
            Flag = !Flag;

            //if (Flag == true)
            //{
            //    ((Button)sender).Text = "O";
            //    ((Button)sender).BackColor = Color.Olive;
            //    ((Button)sender).ForeColor = Color.MediumAquamarine;
            //}
            //else
            //{

            //    ((Button)sender).Text = "X";
            //    ((Button)sender).BackColor = Color.PeachPuff;
            //    ((Button)sender).ForeColor = Color.Navy;
            //}
            //string s1 = button1.Text;
            //string s2 = button2.Text;
            //string s3 = button3.Text;
            //string s4 = button4.Text;
            //string s5 = button5.Text;
            //string s6 = button6.Text;
            //string s7 = button7.Text;
            //string s8 = button8.Text;
            //string s9 = button9.Text;
            if (button1.Text == button2.Text & button1.Text == button3.Text & button1.Text == "O")
            {
                MessageBox.Show(button1.Text + "!,You Win!");
            }            
            if (button1.Text == button2.Text & button1.Text == button3.Text & button1.Text=="O")
            { MessageBox.Show(button1.Text + "!,You Win!"); }
            if (button4.Text == button5.Text & button4.Text == button6.Text & button4.Text == "O")
            { MessageBox.Show(button4.Text + "!,You Win!"); }
            if (button7.Text == button8.Text & button7.Text == button9.Text & button7.Text == "O")
            { MessageBox.Show(button7.Text + "!,You Win!"); }
            if (button1.Text == button4.Text & button1.Text == button7.Text & button1.Text == "O")
            { MessageBox.Show(button1.Text + "!,You Win!"); }
            if (button2.Text == button5.Text & button2.Text == button8.Text & button2.Text == "O")
            { MessageBox.Show(button2.Text + "!,You Win!"); }
            if (button3.Text == button6.Text & button3.Text == button9.Text & button3.Text == "O")
            { MessageBox.Show(button3.Text + "!,You Win!"); }
            if (button1.Text == button5.Text & button1.Text == button9.Text & button1.Text == "O")
            { MessageBox.Show(button1.Text + "!,You Win!"); }
            if (button3.Text == button5.Text & button3.Text == button7.Text & button3.Text == "O")
            { MessageBox.Show(button3.Text + "!,You Win!"); }
            if (button1.Text == button2.Text & button1.Text == button3.Text & button1.Text == "O")
            {
                MessageBox.Show(button1.Text + "!,You Win!");
            }
            if (button1.Text == button2.Text & button1.Text == button3.Text & button1.Text == "X")
            { MessageBox.Show(button1.Text + "!,You Win!"); }
            if (button4.Text == button5.Text & button4.Text == button6.Text & button4.Text == "X")
            { MessageBox.Show(button4.Text + "!,You Win!"); }
            if (button7.Text == button8.Text & button7.Text == button9.Text & button7.Text == "X")
            { MessageBox.Show(button7.Text + "!,You Win!"); }
            if (button1.Text == button4.Text & button1.Text == button7.Text & button1.Text == "X")
            { MessageBox.Show(button1.Text + "!,You Win!"); }
            if (button2.Text == button5.Text & button2.Text == button8.Text & button2.Text == "X")
            { MessageBox.Show(button2.Text + "!,You Win!"); }
            if (button3.Text == button6.Text & button3.Text == button9.Text & button3.Text == "X")
            { MessageBox.Show(button3.Text + "!,You Win!"); }
            if (button1.Text == button5.Text & button1.Text == button9.Text & button1.Text == "X")
            { MessageBox.Show(button1.Text + "!,You Win!"); }
            if (button3.Text == button5.Text & button3.Text == button7.Text & button3.Text == "X")
            { MessageBox.Show(button3.Text + "!,You Win!"); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
              foreach(Button btnClear in this.Panel1.Controls)
                        {
                btnClear.Text = "";
                btnClear.BackColor = Color.PowderBlue;
                btnClear.ForeColor = Color.Red;




            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
            MessageBox.Show("Goodbye!");
        }
    }
}
