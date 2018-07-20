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
    public partial class FrmPOS收銀機 : Form
    {
        public FrmPOS收銀機()
        {
            InitializeComponent();
        }
        
        double sum = 0;        
        int timesa = 0;
        int timesb = 0;
        int timesc = 0;
        int timesd = 0;
        string s;
        

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 100;
                sum = sum + x;
                label1.Text = String.Format("{0}", sum);
            int a = 1;
            timesa = timesa + a;
            label2.Text = "蛋糕"+String.Format("{0}", timesa)+"份";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int y = 200;
                sum = sum + y;
                label1.Text = String.Format("{0}", sum);
            int b = 1;
            timesb = timesb + b;
            label3.Text ="牛肉"+ String.Format("{0}", timesb)+"份";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int z = 250;
                sum = sum + z;
                label1.Text = String.Format("{0}", sum);
            int c = 1;
            timesc = timesc + c;
            label4.Text = "西餐"+String.Format("{0}", timesc)+"份";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int w = 75;
            sum = sum + w;
                label1.Text = String.Format("{0}", sum);
            int d = 1;
            timesd = timesd + d;
            label5.Text = "沙拉"+String.Format("{0}", timesd)+"份";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:0}", sum* 0.95);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:0}" ,sum* 0.8);
        }

        private void button7_Click(object sender, EventArgs e)
        {



            int customer;
            customer = Convert.ToInt32(textBox1.Text);
            customer = int.Parse(textBox1.Text);
            double result;
            result = customer - sum;
            textBox2.Text = string.Format("{0:0}", result);
            label1.Text = string.Format("{0:0}", sum);
            double tho;
            tho = Math.Floor(result / 1000);   
            
          double fh;
            fh = Math.Floor(result % 1000 / 500);
            double oh;
            oh = Math.Floor(result % 500 / 100);
            double ft;
            ft = Math.Floor(result % 100 / 50);
            double ot;
            ot = Math.Floor(result % 50 / 10);
            double fo;
            fo = Math.Floor(result % 10 / 5);
            double oo;
            oo = Math.Floor(result % 5 / 1);

            label15.Text = string.Format("{0:F0}", tho )+"張";
            label16.Text = string.Format("{0:F0}",fh)+"張";
                label17.Text = string.Format("{0:F0}",oh)+"張";
                label18.Text = string.Format("{0:F0}",ft)+"枚";
                label19.Text = string.Format("{0:F0}",ot)+"枚";
                label20.Text = string.Format("{0:F0}",fo)+"枚";
                label21.Text = string.Format("{0:F0}",oo)+"枚";
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8 = sender as Button;
            textBox1.Text += button8.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button9 = sender as Button;
            textBox1.Text += button9.Text;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            button10 = sender as Button;
            textBox1.Text += button10.Text;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            button11 = sender as Button;
            textBox1.Text += button11.Text;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            button12 = sender as Button;
            textBox1.Text += button12.Text;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            button13 = sender as Button;
            textBox1.Text += button13.Text;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            button14 = sender as Button;
            textBox1.Text += button14.Text;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            button15 = sender as Button;
            textBox1.Text += button15.Text;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            button16 = sender as Button;
            textBox1.Text += button16.Text;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            button17 = sender as Button;
            textBox1.Text += button17.Text;
        }
        private void button18_Click(object sender, EventArgs e)
        {
             sum = 0;
             timesa = 0;
             timesb = 0;
             timesc = 0;
             timesd = 0;
            label1.Text = sum.ToString();
            label2.Text = "蛋糕";
            label3.Text = "牛肉";
            label4.Text = "西餐";
            label5.Text = "沙拉";
            textBox1.Text = "";
            textBox2.Text = "";
            label15.Text = "";
                label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";






            //int customer;  
            //customer = Convert.ToInt32(textBox1.Text);
            //customer = int.Parse(textBox1.Text);
            //double result;
            //result = customer - sum;

            //customer = customer - customer;

            //textBox2.Text = string.Format("{0:0}", -result);
            //textBox1.Text = string.Format("{0:0}", customer);
            //label1.Text = string.Format("{0:0}", sum);
            //double tho;
            //tho = Math.Floor(-result / 1000);

            //double fh;
            //fh = Math.Floor(-result % 1000 / 500);
            //double oh;
            //oh = Math.Floor(-result % 500 / 100);
            //double ft;
            //ft = Math.Floor(-result % 100 / 50);
            //double ot;
            //ot = Math.Floor(-result % 50 / 10);
            //double fo;
            //fo = Math.Floor(-result % 10 / 5);
            //double oo;
            //oo = Math.Floor(-result % 5 / 1);
            //tho = tho - tho;

            //label15.Text = string.Format("{0:F0}", tho-tho) + "張";
            //label16.Text = string.Format("{0:F0}", fh-fh) + "張";
            //label17.Text = string.Format("{0:F0}", oh-oh) + "張";
            //label18.Text = string.Format("{0:F0}", ft-ft) + "枚";
            //label19.Text = string.Format("{0:F0}", ot-ot) + "枚";
            //label20.Text = string.Format("{0:F0}", fo-fo) + "枚";
            //label21.Text = string.Format("{0:F0}", oo - oo) + "枚";
            //    int x = 100;


            //label2.Text = "蛋糕" + String.Format("{0}", timesa- timesa) + "份";


            //label3.Text = "牛肉" + String.Format("{0}", timesb- timesb) + "份";


            //label4.Text = "西餐" + String.Format("{0}", timesc- timesc) + "份";


            //label5.Text = "沙拉" + String.Format("{0}", timesd- timesd) + "份";
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPOS收銀機_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
