using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_AP.Lab_5_集合_與_集合控制項;

namespace TreeView
{
    public partial class TreeView : Form
    {
        public TreeView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategoryProducts f1 = new FrmCategoryProducts();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCustomerOrderOrderDetails f2 = new FrmCustomerOrderOrderDetails();
            f2.Show();
        }
    }
}
