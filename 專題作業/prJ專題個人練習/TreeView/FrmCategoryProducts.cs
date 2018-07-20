using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeView;

namespace Windows_AP.Lab_5_集合_與_集合控制項
{
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();
        }
        //DataView dvCustomer;
        DataView dvProduct;
        private void FrmCategoryProducts_Load(object sender, EventArgs e)
        {
            northwndEntities ne = new northwndEntities();
            //var query2 = ne.Products.SqlQuery("Select * from Products");
            //var query2 = ne.Products.SqlQuery("Select ProductID from Products");
            //comboBox1.DataSource = ne.Products;
            //comboBox1.DisplayMember = "ProductName";
            //comboBox1.ValueMember = "ProductID";
            var query = from c in ne.Categories
                        select new { Name = c.CategoryName, ID =c.CategoryID };
            //dataGridView1.DataSource = query.ToList();
            comboBox1.DataSource = query.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            //dataGridView1.DataSource = query2.ToList();
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=.;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
            //con.Open();
            //SqlDataAdapter adp = new SqlDataAdapter("select * from Products", con);
            //DataSet ds = new DataSet();
            //adp.Fill(ds, "P");
            ////adp = new SqlDataAdapter("select * from Customer", con);
            ////adp.Fill(ds, "T");
            ////con.Close();


            //dvProduct = new DataView(ds.Tables["P"]);
            ////dvCustomer = new DataView(ds.Tables["T"]);

            //comboBox1.DataSource = dvProduct;
            //comboBox1.DisplayMember = "ProductName";
            //comboBox1.ValueMember = "ProductID";
            ////cboProduct.DataSource = dvProduct;
            ////cboProduct.DisplayMember = "fName";
            ////cboProduct.ValueMember = "fid";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            northwndEntities ne = new northwndEntities();
            var query = from p in ne.Products
                        join c in ne.Categories
                        on p.CategoryID equals c.CategoryID
                        where c.CategoryName == comboBox1.Text 
                        select new { Name = p.ProductName ,ID=p.ProductID};
            listBox1.DataSource = query.ToList();
            listBox1.DisplayMember= "Name";
            listBox1.ValueMember = "ID";
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=.;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
            //con.Open();
            //SqlDataAdapter adp = new SqlDataAdapter("select * from Products where ProductName='"+comboBox1.Text+"'", con);
            //DataSet ds = new DataSet();
            //adp.Fill(ds, "P");
            //dataGridView1.DataSource = ds.Tables["P"];
            //(comboBox1.Text);
            //DataSet myData = new DataSet();
            // fill with query results
            //adp.Fill(ds, "Products");
            //listBox1.DataSource = ds.Tables["P"];
            //int count = ds.Tables[0].Rows.Count;
            //for (int i = 0; i < count; i++)
            //{
            //listBox1.DataSource = ds;
            //listBox1.DisplayMember = "ProductName";
            //listBox1.ValueMember = "ProductName";
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    listBox1.Items.Add(ds.Tables.Rows[.ToString());
            //}

            //listBox1.Text=ds.Tables["P"].ToString();
            //}

            //listBox1.DataValueField = "CustomerId";
            //listBox1.DataBind();
            //var query = "select itemtag from tbl_inventory order by itemtag";
            //    DataTable dt = con.DataTable(query);
            //    int count = dt.Rows.Count;
            //    if (count > 0)
            //    {
            //        //listView1.Items.Clear();
            //        listBox1.Items.Clear();

            //        for (int i = 0; i < count; i++)
            //        {
            //            //listView1.Items.Add(dt);
            //            listBox1.Items.Add(dt.Rows[i].ToString());
            //        }
            //    }
            //    *![As you see I am getting output like "System.Data.DataRow", where I have something else in my database][1]


        }
    }
}
