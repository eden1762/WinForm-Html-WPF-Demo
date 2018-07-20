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

namespace My_HomeWork
{
    public partial class FrmEmployeeList : Form
    {
        public FrmEmployeeList()
        {
            InitializeComponent();
        }
        ArrayList emp = new ArrayList();
        List<Employee> empList = new List<Employee>();
        void ShowallEmployee()
        {
            label8.Text = "Empolyee Info\n\n";
            for (int i = 0; i <= emp.Count - 1; i++)
            {
                label8.Text += "Name:" + ((Employee)emp[i]).name
                    + "\nAge:" + ((Employee)emp[i]).age
                    + "\nHiredate:" + ((Employee)emp[i]).age
                    + "\nJobType:" + ((Employee)emp[i]).JobType
                    +"\n";
            }
        }
        void ShowallEmployee2()
        {
            label8.Text = "Empolyee Info\n\n";
            for (int i = 0; i <= emp.Count - 1; i++)
            {
                label8.Text += "Name:" + (empList[i]).name
                    + "\nAge:" + (empList[i]).age
                    + "\nHiredate:" + (empList[i]).age
                    + "\nJobType:" + (empList[i]).JobType
                    + "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emps = new Employee();
            emps.name = textBox1.Text;
            emps.age = int.Parse(textBox2.Text);
            emps.HireDate = DateTime.Now;
            emps.JobType = Job.Manager;
            emp.Add(emps);
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Employee emps = new Employee();
            emps.name = textBox1.Text;
            emps.age = int.Parse(textBox2.Text);
            emps.HireDate = DateTime.Now;
            emps.JobType = Job.Manager;
            emp.Insert(0,emps);
            ShowallEmployee();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emp.RemoveAt(0);
            ShowallEmployee();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            emp.Clear();
            ShowallEmployee();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowallEmployee();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //int b;
            //bool a = int.TryParse(textBox5.Text, out b);
            int b;
            bool  a=int.TryParse(textBox5.Text,out b);
            label8.Text = "Empolyee Info\n\n";
            for (int i = 0; i <= emp.Count - 1; i++)
            {
                if (i ==b)
                { 
                    label8.Text += "Name:" + ((Employee)emp[b]).name
                    + "\nAge:" + ((Employee)emp[b]).age
                    + "\nHiredate:" + ((Employee)emp[b]).age
                    + "\nJobType:" + ((Employee)emp[b]).JobType
                    + "\n";
                }
            }
            //label8.Text = "Name:" + ((Employee)emp[search]).name
            //    + "Age:" + ((Employee)emp[search]).age
            //    + "HireDate:" + ((Employee)emp[search]).HireDate
            //    + "JobType:" + ((Employee)emp[search]).JobType;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Employee emps = new Employee();
            emps.name = textBox1.Text;
            emps.age = int.Parse(textBox2.Text);
            emps.HireDate = DateTime.Now;
            emps.JobType = Job.Manager;
            empList.Add(emps);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Employee emps = new Employee();
            emps.name = textBox1.Text;
            emps.age = int.Parse(textBox2.Text);
            emps.HireDate = DateTime.Now;
            emps.JobType = Job.Manager;
            empList.Insert(0, emps);
            ShowallEmployee2();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            empList.RemoveAt(0);
            ShowallEmployee2();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            empList.Clear();
            ShowallEmployee2();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ShowallEmployee2();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int b;
            bool a = int.TryParse(textBox5.Text, out b);
            label8.Text = "Empolyee Info\n\n";
            for (int i = 0; i <= emp.Count - 1; i++)
            {
                if (i == b)
                {
                    label8.Text += "Name:" + (empList[b]).name
                    + "\nAge:" + (empList[b]).age
                    + "\nHiredate:" + (empList[b]).age
                    + "\nJobType:" + (empList[b]).JobType
                    + "\n";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List <Point>b = new List<Point>();
            b.Add(new Point(200, 300));
            b.Add(new Point(100, 400));
            b.Add(new Point(400, 500));
            MessageBox.Show(((Point)b[2]).X + "," + ((Point)b[2]).Y);
            ArrayList a = new ArrayList();
            a.Add(new Point(200, 300));
            a.Add(new Point(100, 400));
            a.Add(new Point(400, 500));
            a.Add(600);
            MessageBox.Show(((Point)a[2]).X+","+ ((Point)a[2]).Y);


        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool? b; 
               b = null;
            if(b.HasValue)
            { MessageBox.Show("b=" + b); }
            else
            { MessageBox.Show("b is null."); }


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int b;
            bool a = int.TryParse(textBox5.Text, out b);
            
            emp.RemoveAt(b);
            ShowallEmployee();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int x;
            int a = int.Parse(textBox7.Text);
            int b = int.Parse(textBox8.Text);
            for (int i = 0; i <= emp.Count - 1; i++)
                if (b >= ((Employee)emp[i]).age & ((Employee)emp[i]).age >= a)
                {
                    x = i;
                    label8.Text += "Name:" + ((Employee)emp[x]).name
                            + "\nAge:" + ((Employee)emp[x]).age
                            + "\nHiredate:" + ((Employee)emp[x]).age
                            + "\nJobType:" + ((Employee)emp[x]).JobType
                            + "\n";
                }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int b;
            bool a = int.TryParse(textBox5.Text, out b);

            empList.RemoveAt(b);
            ShowallEmployee2();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int x;
            int a = int.Parse(textBox7.Text);
            int b = int.Parse(textBox8.Text);
            for (int i = 0; i <= empList.Count - 1; i++)
                if (b >= empList[i].age & empList[i].age >= a)
                {
                    x = i;
                    label8.Text += "Name:" + (empList[x]).name
                            + "\nAge:" + (empList[x]).age
                            + "\nHiredate:" + (empList[x]).age
                            + "\nJobType:" + (empList[x]).JobType
                            + "\n";
                }
        }
    }
}
