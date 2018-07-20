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
            this.Win1numbersdisplaylabel.Width=leb1;
            this.Win2numbersdisplaylabel.Width = leb2;
            this.Win3numbersdisplaylabel.Width = leb3;
            this.Win4numbersdisplaylabel.Width = leb4;
            this.Win5numbersdisplaylabel.Width = leb5;
            this.Win6numbersdisplaylabel.Width=leb6;
            this.label13.Text = leb1.ToString()+"%";
            this.label14.Text = leb2.ToString() + "%";
            this.label15.Text = leb3.ToString() + "%";
            this.label16.Text = leb4.ToString() + "%";
            this.label17.Text = leb5.ToString() + "%";
            this.label18.Text = leb6.ToString() + "%";
            this.Win0numbersdisplaylabel.Width = leb0;
            this.Win0numberscountlabel.Text = leb0.ToString() + "%";

        }
    }
}
