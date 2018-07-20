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
    public partial class FrmGuess : Form
    {
        public FrmGuess()
        {
            InitializeComponent();
        }
        public static int gu;
        public static string sg;
       private void button1_Click(object sender, EventArgs e)
        {
            Random rg = new Random();
            //for(int i=0;i <=10;i++)
            //{
                gu = rg.Next(1, 10);
            //    Gu = i;
            //}
            FrmGuessShow f = new FrmGuessShow();
            f.Show();
           
            

        }
    }
}
