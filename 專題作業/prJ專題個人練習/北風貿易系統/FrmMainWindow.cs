using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 北風貿易系統
{
    public partial class FrmMainWindow : Form
    {
        public FrmMainWindow()
        {
            InitializeComponent();

        }

  

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products");
            dataGridView1.DataSource = query.ToList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            if (toolStripTextBox1.Text == "" && toolStripTextBox2.Text != "" && toolStripTextBox3.Text != "")
            {
                var query = ne.Products.SqlQuery("Select * from Products where Unitprice between '" + toolStripTextBox2.Text + "' and '" + toolStripTextBox3.Text + "'");
                dataGridView1.DataSource = query.ToList();

            }
            else if (toolStripTextBox1.Text != "" && toolStripTextBox2.Text == "" && toolStripTextBox3.Text == "")
            {
                var query = ne.Products.SqlQuery("select * from Products where ProductName like '%" + toolStripTextBox1.Text + "%'");
                dataGridView1.DataSource = query.ToList();
            }
            else if (toolStripTextBox1.Text != "" && toolStripTextBox2.Text != "" && toolStripTextBox3.Text != "")
            {
                var query = ne.Products.SqlQuery("select * from Products where ProductName like '%" + toolStripTextBox1.Text + "%' and  Unitprice between '" + toolStripTextBox2.Text + "' and '" + toolStripTextBox3.Text + "'");
                dataGridView1.DataSource = query.ToList();
            }
            else
            {
                MessageBox.Show("搜尋條件請填完整!");
            }
            

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            var query = from p in ne.Products
                        join c in ne.Categories
                        on p.CategoryID equals c.CategoryID
                        group p by c.CategoryName into g
                        select new
                        {
                            Key = g.Key,
                            Count = g.Count(),
                            MiniPrice = g.Min(ggg => ggg.UnitPrice),
                            MaxPrice = g.Max(ggg=>ggg.UnitPrice),
                            Group = g
                           
                        };
            dataGridView1.DataSource = query.ToList();
            //var query2 = from p in ne.Products
            //             join c in ne.Categories
            //             on p.CategoryID equals c.CategoryID
            //             group p by c.CategoryName into g
            //             select new
            //             {
            //                 Key = g.Key,
            //                 Count = g.Count(),
            //                 MiniPrice = g.Min(ggg => ggg.UnitPrice),
            //                 MaxPrice = g.Max(ggg => ggg.UnitPrice)

            //             };


            foreach (var group in query)
            {
                string s = string.Format("{0}-({1})", group.Key, group.Count);
                TreeNode x = this.treeView1.Nodes.Add(s);
                foreach (var item in group.Group)
                {

                    string s2 = string.Format("{0}-{1}-{2}", item.ProductID, item.ProductName, item.UnitPrice);
                    x.Nodes.Add(s2);
                }

            }


        }

        private void unitPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            
            ListColumnEdit();
            var query = from p in ne.Products
                        join c in ne.Categories
                        on p.CategoryID equals c.CategoryID
                        orderby p.UnitPrice
                        select new
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName,
                            CategoryName = c.CategoryName,
                            UnitPrice = p.UnitPrice,
                            Quantity = p.QuantityPerUnit
                        };
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text=group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.CategoryName);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.Quantity);
                listView1.Items.Add(item);

            }


            //ListViewItem liv = new ListViewItem(pro.ProductName);
            //liv.SubItems.Add(pro.UnitPrice.ToString());
        }

        private void ListColumnEdit()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("CategoryName", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("Quantity", 150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //northwndEntities ne = new northwndEntities();
            //Product pro = new Product();
            //listView1.Columns.Add("產品名稱",160);
            //listView1.Columns.Add("產品價錢",50);
            //ListViewItem liv = new ListViewItem(pro.ProductName);
            //liv.SubItems.Add(pro.UnitPrice.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            try
            {
                Product pro = new Product();
                pro.ProductName = toolStripTextBox1.Text;
                pro.UnitPrice = int.Parse(toolStripTextBox2.Text);
                ne.Products.Add(pro);
                ne.SaveChanges();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            try
            {
                var pro = ne.Products.Where(r => r.ProductName == toolStripTextBox1.Text).FirstOrDefault();
                if (ne == null)
                {
                    return;
                }
                ne.Products.Remove(pro);
                ne.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            try
            {
                var pro = ne.Products.Where(r => r.ProductName == toolStripTextBox1.Text).FirstOrDefault();
                if (ne == null)
                {
                    return;
                }
                pro.UnitPrice = int.Parse(toolStripTextBox2.Text);
                ne.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            Product pro = new Product();
            ListColumnEdit();
            var query = from p in ne.Products
                        join c in ne.Categories
                        on p.CategoryID equals c.CategoryID
                        orderby p.ProductName
                        select new
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName,
                            CategoryName = c.CategoryName,
                            UnitPrice = p.UnitPrice,
                            Quantity = p.QuantityPerUnit
                        };
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.CategoryName);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.Quantity);
                listView1.Items.Add(item);

            }
        }

        private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            Product pro = new Product();
            ListColumnEdit();
            var query = from p in ne.Products
                        join c in ne.Categories
                        on p.CategoryID equals c.CategoryID
                        orderby unitPriceToolStripMenuItem.Text descending
                        select new
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName,
                            CategoryName = c.CategoryName,
                            UnitPrice = p.UnitPrice,
                            Quantity = p.QuantityPerUnit
                        };
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.CategoryName);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.Quantity);
                listView1.Items.Add(item);

            }
        }

        private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            Product pro = new Product();
            ListColumnEdit();
            var query = from p in ne.Products
                        join c in ne.Categories
                        on p.CategoryID equals c.CategoryID
                        orderby unitPriceToolStripMenuItem.Text ascending
                        select new
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName,
                            CategoryName = c.CategoryName,
                            UnitPrice = p.UnitPrice,
                            Quantity = p.QuantityPerUnit
                        };
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.CategoryName);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.Quantity);
                listView1.Items.Add(item);

            }
        }

        private void categoryNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            ListColumnEdit();
            var query = from p in ne.Products
                        join c in ne.Categories
                        on p.CategoryID equals c.CategoryID
                        group p by c.CategoryName into g
                        select new
                        {
                            Key = g.Key,
                            Count = g.Count(),
                            MiniPrice = g.Min(ggg => ggg.UnitPrice),
                            MaxPrice = g.Max(ggg => ggg.UnitPrice),
                            Group = g

                        };
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text="";
                item.SubItems.Add("");
                item.SubItems.Add(group.Key);
                item.SubItems.Add(group.MaxPrice.ToString());
                item.SubItems.Add("");
                listView1.Items.Add(item);

            }

        }

        private void unitPriceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            ListColumnEdit();
            var query = from p in ne.Products
                        join c in ne.Categories
                        on p.CategoryID equals c.CategoryID
                        group c by p.UnitPrice into g
                        select new
                        {
                            Key = g.Key,
                            Count = g.Count(),
                            CategoryName = g.Select(gg=>gg.CategoryName),
                            MaxPrice = g.Key,
                            Group = g

                        };
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = "";
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add(group.Key.ToString());
                item.SubItems.Add("");
                listView1.Items.Add(item);

            }
        }

        private void FrmMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%a%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }
       

        private void label6_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%b%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%c%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%d%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%e%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%f%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%g%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%h%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%i%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%j%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%k%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%l%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%m%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%n%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%o%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%p%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%q%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%r%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%s%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%t%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%u%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%v%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%w%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%x%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%y%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }

        private void label30_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            listView1.Scrollable = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Columns.Add("ProductID", 160);
            listView1.Columns.Add("ProductName", 150);
            listView1.Columns.Add("SupplierID", 150);
            listView1.Columns.Add("CategoryID", 150);
            listView1.Columns.Add("QuantityPerUnit", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("UnitInStock", 150);
            listView1.Columns.Add("UnitOnOrder", 150);
            listView1.Columns.Add("RecorderLevel", 150);
            listView1.Columns.Add("Discontinued", 150);
            listView1.Columns.Add("Categories", 150);
            northwndEntities ne = new northwndEntities();
            var query = ne.Products.SqlQuery("Select * from Products where ProductName  LIKE '%z%'");
            foreach (var group in query)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = group.ProductID.ToString();
                item.SubItems.Add(group.ProductName);
                item.SubItems.Add(group.SupplierID.ToString());
                item.SubItems.Add(group.CategoryID.ToString());
                item.SubItems.Add(group.QuantityPerUnit);
                item.SubItems.Add(group.UnitPrice.ToString());
                item.SubItems.Add(group.UnitsInStock.ToString());
                item.SubItems.Add(group.UnitsOnOrder.ToString());
                item.SubItems.Add(group.ReorderLevel.ToString());
                item.SubItems.Add(group.Discontinued.ToString());
                item.SubItems.Add(group.Category.ToString());
                listView1.Items.Add(item);

            }
        }
    }
}
