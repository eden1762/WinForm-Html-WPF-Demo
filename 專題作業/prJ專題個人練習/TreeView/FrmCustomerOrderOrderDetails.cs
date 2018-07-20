using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeView;

namespace Windows_AP.Lab_5_集合_與_集合控制項
{
    public partial class FrmCustomerOrderOrderDetails : Form
    {
        public FrmCustomerOrderOrderDetails()
        {
            InitializeComponent();
        }

        private void FrmCustomerOrderOrderDetails_Load(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            var query = from c in ne.Customers
                        join o in ne.Orders
                        on c.CustomerID equals o.CustomerID
                        group o by c.ContactName into g
                        select new { CName = g.Key, Group = g };

            foreach (var group in query)
            {
                string s = string.Format("{0}", group.CName);
                TreeNode x = this.treeView1.Nodes.Add(s);
                var s2 = group.Group.Select(gg => gg.OrderID.ToString());
                foreach (var group2 in s2)
                    
                    x.Nodes.Add(group2.ToString());
            }

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            listBox1.Items.Clear();
            int myNodeCount = int.Parse(e.Node.Text);
            northwndEntities ne = new northwndEntities();
            var query = from o in ne.Orders
                        where o.OrderID == myNodeCount
                        select o;
            foreach (var group in query)
            {    listBox1.Items.Add("OrderID:"+group.OrderID.ToString());
            listBox1.Items.Add("CustomerID:"+group.CustomerID.ToString());
            listBox1.Items.Add("EmployeeID:"+group.EmployeeID.ToString());
            listBox1.Items.Add("CustomerID:"+group.CustomerID.ToString());
            listBox1.Items.Add("OrderDate:"+group.OrderDate.ToString());
            listBox1.Items.Add("RequiredDate:"+group.RequiredDate.ToString());
            listBox1.Items.Add("ShippedDate:"+group.ShippedDate.ToString());
            listBox1.Items.Add("ShipVia:"+group.ShipVia.ToString());
            listBox1.Items.Add("Freight:"+group.Freight.ToString());
                listBox1.Items.Add("ShipName:"+group.ShipName.ToString());
                listBox1.Items.Add("ShipAddress:"+group.ShipAddress.ToString());
                listBox1.Items.Add("ShipCity:"+group.ShipCity.ToString());
                listBox1.Items.Add("ShipPostalCode:"+group.ShipPostalCode.ToString());
                listBox1.Items.Add("ShipCountry:"+group.ShipCountry.ToString());
            };
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
    }
}                     



