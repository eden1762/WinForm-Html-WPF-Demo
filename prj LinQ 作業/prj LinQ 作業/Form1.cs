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

namespace prj_LinQ_作業
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CDbManager.getConnectionString();
            con.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select CustomerID from Orders group by CustomerID  having count(CustomerID) >= 20";
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())

            {
                comboBox1.Items.Add(reader["CustomerID"].ToString());
            }

            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from Orders where CustomerID='" + comboBox1.SelectedItem + "'", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
