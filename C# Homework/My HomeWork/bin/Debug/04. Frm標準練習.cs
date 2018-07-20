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
    public partial class Frm標準練習 : Form
    {
        public Frm標準練習()
        {
            InitializeComponent();
        }

        //internal struct numbers
        //{
        //   internal int n1;
        //   internal int n2;
        //   internal int n3;
        //}

        //internal struct numbers
        //    {
        //    internal int odd;
        //    internal int even;
        //}
        //numbers[][] num = new numbers[3][];
        
        
        
        string[] names = new string[5] { "aaa", "bbbb", "ccc","ihohi","huiuh" };
        int[] nums = new int[10] { 12,14,15,45,78,98,62,65,45,98};
        int[] thr = new int[3] {56,95,45};
        int cnum = 0;

        private void button14_Click(object sender, EventArgs e)
        {
            string Max = names[0];
            for (int i = 0; i <= names.Length - 1; i++)
            {
                if (Max.Length < names[i].Length)
                {
                    Max = names[i];
                }
            label1.Text = "Max =" + Max;
            }
            
        }
        
        private void button13_Click(object sender, EventArgs e)
        {

            

            //string Max = names[0];
            for (int i = 0; i <= names.Length - 1; i++)
            {       
               
                if (names[i].Contains("c")| names[i].Contains("C"))
                {
                    cnum += 1;
                }
                
            }
            label1.Text = "C或c有" + cnum + "個";
            //                    )
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Min = nums[0];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (Min > nums[i]) 
                {
                    Min = nums[i];
                }

            }
            label1.Text = "Min =" + Min;
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            int a;
            
            bool x = int.TryParse(textBox4.Text, out a);
            

                    if (a % 2 == 1)
                    {
                        label1.Text = string.Format("{0} is odd.", a);

                    }
                    else
                    {
                        label1.Text = string.Format("{0} is even.", a);

                }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int Max = thr[0];
            for (int i = 0; i <= thr.Length - 1; i++)
            {
                if (Max<thr[i]  ) 
                {
                    Max = thr[i];
                }

            }
            label1.Text = "Max =" + Max;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Length="+nums.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                sum += nums[i];
            }
            label1.Text = "Avg=" + sum / nums.Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                sum += nums[i];
            }
            label1.Text = "Sum=" + sum;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Max = nums[0];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (Max < nums[i])
                {
                    Max = nums[i];
                }

            }
            label1.Text = "Max =" + Max;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    label1.Text += string.Format("\n{0} is odd.", nums[i]);

                }
                if (nums[i] % 2 == 0)
                {
                    label1.Text += string.Format("\n{0} is even.", nums[i]);

                }
            }
            int oddnum=1;
            int evennum=1;
            bool? IsOdd;
            
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    IsOdd = true;
                    oddnum += 1;

                }
                
                else
                {
                    IsOdd = false;
                    evennum += 1;
                }
                
            }
            label1.Text += string.Format("\n奇數有{0}個", oddnum);
            label1.Text += string.Format("\n偶數有{0}個", evennum);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] files = System.IO.Directory.GetFiles(@"c:\Logs");
            label1.Text = files.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            int a;
            int b;
            bool x = int.TryParse(textBox1.Text, out a);
            bool y = int.TryParse(textBox1.Text, out b);
            Swap(ref a, ref b);
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();  



        }
        internal static void Swap(ref int a, ref int b)
        {           
                    int temp;
                    temp = a;
                    a = b;
                    b = temp;
        }
        internal static void Swapt<T>(ref T a,ref T b )
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
            
        }
        internal static int counts(int[] nums)
        {
            
             return nums.Length;
        }
        internal static void avgs(int[] nums)
        {
            int sum = 0;
            int avg = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                sum += nums[i];
                avg = sum / nums.Length;
            }
            MessageBox.Show("avg=" + avg);
        }
        internal static void sums(int[] nums)
        {
            int sum=0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                sum += nums[i];
                }
            MessageBox.Show("sum="+sum);
        }
        internal static int maxs(int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (max < nums[i])
                { max = nums[i]; }
            }
            return max;
        }
        internal static int mins(int[] nums)
        {
            int min = nums[0];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (min < nums[i])
                { min = nums[i]; }
            }
            return min;
        }
        internal  static int pluss(int a, int b)
        { return a + b;
                   }
        internal static int minuss(int a, int b)
        {
            return a - b;
        }
        internal static int timess(int a, int b)
        {
            return a * b;
            
        }
        internal static double divideds(int a, int b)
        {
            return a / b;
            
        }
        private void button11_Click(object sender, EventArgs e)
        {

            int a;
            int b;
            bool x = int.TryParse(textBox1.Text, out a);
            bool y = int.TryParse(textBox1.Text, out b);
            Swapt(ref a, ref b);
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text = "Length=" + counts(nums).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            avgs(nums);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            sums(nums);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maxs(nums).ToString());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mins(nums).ToString());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            bool x = int.TryParse(textBox1.Text,out a);
            bool y = int.TryParse(textBox1.Text, out b);
            label2.Text="="+pluss(a,b).ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            bool x = int.TryParse(textBox1.Text, out a);
            bool y = int.TryParse(textBox1.Text, out b);
            label2.Text = "=" + minuss(a, b).ToString();
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            bool x = int.TryParse(textBox1.Text, out a);
            bool y = int.TryParse(textBox1.Text, out b);
            label2.Text = "=" + timess(a, b).ToString();
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            bool x = int.TryParse(textBox1.Text, out a);
            bool y = int.TryParse(textBox1.Text, out b);
            label2.Text = "=" + divideds(a, b).ToString();
            
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label1.Text += "\n";
            int[,] ninenine = new int[9, 9];
            for(int i = 1;i<= 9;i++)
            {
                
                //label1.Text += string.Format("\n{0}*{1}={2}", i, 2, i * 2);
                for (int j = 1; j <= 9; j++)
                {
                    label1.Text +=string.Format("{0}*{1}={2,2}"+"   ", j ,i , i * j );
                   


                }
                label1.Text += "\n";

            }

             
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text += "\n";
            int i=1;
            int j=1;

            for (i = 1; i < 11; i++)
            {
                for (int x = 10 - i; x > 0; x--)
                {
                    label1.Text += " ";
                }
                for (j = 1; j <= i * 2 - 1; j++)
                {
                    label1.Text += "*";
                }
                label1.Text += "\n";
            }
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    label1.Text+=" ";
                }

                for (j = 0; j < 3; j++)
                {
                    label1.Text += "*";
                }

                label1.Text += "\n";
            }

            label1.Text += "\n";

        }


        


            
                

        private void button25_Click(object sender, EventArgs e)
        {
            int a10 = int.Parse(textBox3.Text);
            label1.Text= Convert.ToString(a10, 2);
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int x ;
            string s2 = textBox3.Text;


            //if (int.TryParse(s2, out x))
            //{
            if (s2.Contains("1") && s2.Contains("0"))
            { label1.Text = Convert.ToInt32(s2, 2).ToString(); }
            else if(s2.Contains("1"))
                { label1.Text = Convert.ToInt32(s2, 2).ToString(); }
           
            else
                { MessageBox.Show("此數字不是二進位!"); }
            //}
            //else
            //{ MessageBox.Show("此數字不是二進位!"); }

}
    }
}

    

