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
        public static int throwanswer;
        int buttomint;
        int topint;

        FrmGuess f = new FrmGuess();
        private void button1_Click(object sender, EventArgs e)
           {
            string myguess;
            int myguesstoint;
            
            myguess = textBox1.Text ;
            myguesstoint = int.Parse(myguess);

            if (myguesstoint > FrmGuess.guessanswer)
            {
                topint  = myguesstoint;
            }
            else if (myguesstoint < FrmGuess.guessanswer)
            {
               buttomint  = myguesstoint;
            }
            if(myguesstoint > FrmGuess.guessanswer && buttomint == 0)
            { label1.Text = "Too high!" + "It's between " + 1 + "and" + topint + "."; }
           else if (myguesstoint < FrmGuess.guessanswer&& topint==0)
            { label1.Text = "Too low!" + "It's between " + buttomint + "and" + 10 + "."; }
            else if(myguesstoint > FrmGuess.guessanswer && buttomint != null)
            { label1.Text = "Too high!" + "It's between " + buttomint + "and" + topint + "."; }
            else if(myguesstoint < FrmGuess.guessanswer && topint != null)
            { label1.Text = "Too low!" + "It's between " + buttomint + "and" + topint + "."; }
            else if (myguesstoint == FrmGuess.guessanswer)
            { label1.Text = "You are correct!It's"+myguesstoint+"." ; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.label1.Text = "See you next time!";
            this.Close();
            

        }

        private void FrmGuessShow_Load(object sender, EventArgs e)
        {
            
        }

    }
}
