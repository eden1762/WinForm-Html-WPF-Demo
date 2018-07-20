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
    public partial class FrmLotooShow : Form
    {
        public FrmLotooShow()
        {
            InitializeComponent();
        }
        public static int leb1;
        public static int leb2;
        public static int leb3;
        public static int leb4;
        public static int leb5;
        public static int leb6;
        public static int leb0;


        private void FrmLotooShow_Load(object sender, EventArgs e)
        {
            this.label7.Width=leb1;
            this.label8.Width = leb2;
            this.label9.Width = leb3;
            this.label10.Width = leb4;
            this.label11.Width = leb5;
            this.label12.Width=leb6;
            this.label13.Text = leb1.ToString()+"%";
            this.label14.Text = leb2.ToString() + "%";
            this.label15.Text = leb3.ToString() + "%";
            this.label16.Text = leb4.ToString() + "%";
            this.label17.Text = leb5.ToString() + "%";
            this.label18.Text = leb6.ToString() + "%";
            this.label20.Width = leb0;
            this.label21.Text = leb0.ToString() + "%";

        }
    }
}
