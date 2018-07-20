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
        

        private void 蛋糕button_Click(object sender, EventArgs e)
        {
            int x = 100;
                sum = sum + x;
                金額label.Text = String.Format("{0}", sum);
            int a = 1;
            timesa = timesa + a;
            蛋糕label.Text = "蛋糕"+String.Format("{0}", timesa)+"份";
        }

        private void 牛肉button_Click(object sender, EventArgs e)
        {
            int y = 200;
                sum = sum + y;
                金額label.Text = String.Format("{0}", sum);
            int b = 1;
            timesb = timesb + b;
            牛肉label.Text ="牛肉"+ String.Format("{0}", timesb)+"份";
        }

        private void 西餐button_Click(object sender, EventArgs e)
        {
            int z = 250;
                sum = sum + z;
                金額label.Text = String.Format("{0}", sum);
            int c = 1;
            timesc = timesc + c;
            西餐label.Text = "西餐"+String.Format("{0}", timesc)+"份";
        }

        private void 沙拉button_Click(object sender, EventArgs e)
        {
            int w = 75;
            sum = sum + w;
                金額label.Text = String.Format("{0}", sum);
            int d = 1;
            timesd = timesd + d;
            沙拉label.Text = "沙拉"+String.Format("{0}", timesd)+"份";
        }

        private void 現金button_Click(object sender, EventArgs e)
        {
            金額label.Text = string.Format("{0:0}", sum* 0.95);
        }

        private void 信用卡button_Click(object sender, EventArgs e)
        {
            金額label.Text = string.Format("{0:0}" ,sum* 0.8);
        }

        private void 付款button_Click(object sender, EventArgs e)
        {



            int customer;
            customer = Convert.ToInt32(付現textBox.Text);
            customer = int.Parse(付現textBox.Text);
            double result;
            result = customer - sum;
            找零textBox.Text = string.Format("{0:0}", result);
            金額label.Text = string.Format("{0:0}", sum);
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

            千元張label.Text = string.Format("{0:F0}", tho )+"張";
            五百張label.Text = string.Format("{0:F0}",fh)+"張";
                一百張label.Text = string.Format("{0:F0}",oh)+"張";
                五十枚label.Text = string.Format("{0:F0}",ft)+"枚";
                十枚label.Text = string.Format("{0:F0}",ot)+"枚";
                五枚label.Text = string.Format("{0:F0}",fo)+"枚";
                一枚label.Text = string.Format("{0:F0}",oo)+"枚";
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1 = sender as Button;
            付現textBox.Text += button1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2 = sender as Button;
            付現textBox.Text += button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3 = sender as Button;
            付現textBox.Text += button3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4 = sender as Button;
            付現textBox.Text += button4.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5 = sender as Button;
            付現textBox.Text += button5.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button6 = sender as Button;
            付現textBox.Text += button6.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7 = sender as Button;
            付現textBox.Text += button7.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button8 = sender as Button;
            付現textBox.Text += button8.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button9 = sender as Button;
            付現textBox.Text += button9.Text;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            button0 = sender as Button;
            付現textBox.Text += button0.Text;
        }
        private void 下一位button_Click(object sender, EventArgs e)
        {
             sum = 0;
             timesa = 0;
             timesb = 0;
             timesc = 0;
             timesd = 0;
            金額label.Text = sum.ToString();
            蛋糕label.Text = "蛋糕";
            牛肉label.Text = "牛肉";
            西餐label.Text = "西餐";
            沙拉label.Text = "沙拉";
            付現textBox.Text = "";
            找零textBox.Text = "";
            千元張label.Text = "";
                五百張label.Text = "";
            一百張label.Text = "";
            五十枚label.Text = "";
            十枚label.Text = "";
            五枚label.Text = "";
            一枚label.Text = "";






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
