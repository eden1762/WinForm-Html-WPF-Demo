using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_HomeWork
{
    public partial class FrmScreenSaver : Form
    {
        public FrmScreenSaver()
        {
            InitializeComponent();
        }
        

        private void FrmScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + "," + e.Y;
        }

        private void FrmScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine(e.KeyCode);
        }

        private void FrmScreenSaver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Left += 10;
            this.label1.Text = "Screen Saver" + DateTime.Now.ToString();
            if(this.label1.Left> this.Width)
            { this.label1.Left = 0; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = !this.timer1.Enabled;
        }

        private void FrmScreenSaver_Load(object sender, EventArgs e)
        {

        }
    }
}
