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
    public partial class FrmGuessShow : Form
    {
        public FrmGuessShow()
        {
            InitializeComponent();
        }
        
        //public static int[] ig= { 1,2,3,4,5,6,7,8,9,10};
         
        FrmGuess f = new FrmGuess();
        private void button1_Click(object sender, EventArgs e)
           {
            string ssg;
            int gg;
            int gb = 10;
            int gs = 1;

            ssg = textBox1.Text ;
            gg = int.Parse(ssg);

            if (gg > FrmGuess.gu)
            {
                gb = gg;
            }
            if (gg < FrmGuess.gu)
            {
                gs = gg;
            }
            if(gb > FrmGuess.gu)
            { f.label1.Text = "Too high!" + "It's between " + gs + "and" + gb + "."; }
            if (gs < FrmGuess.gu)
            { f.label1.Text = "Too low!" + "It's between " + gs + "and" + gb + "."; }
            if (gg == FrmGuess.gu)
            { f.label1.Text = "You are correct!It's"+gg+"." ; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.label1.Text = "See you next time!";
            this.Close();
            

        }
    }
}
