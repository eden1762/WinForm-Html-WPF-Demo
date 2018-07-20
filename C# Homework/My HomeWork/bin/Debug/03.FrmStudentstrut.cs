﻿using System;
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
    public partial class FrmStudentstrut : Form
    {
        public FrmStudentstrut()
        {
            InitializeComponent();
        }

        Student_grades stu;
        internal struct Student_grades
        {
            internal string name;
            internal int  Chinese ;
            internal int English;
            internal int Mathematics;
            internal int sum;
            internal int avg;
            internal string highest;
            internal string lowest;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            stu.name = textBox1.Text;
            int chi;

            if (int.TryParse(textBox2.Text, out chi))
            {
                stu.Chinese = chi;
            }
            else
            {
                MessageBox.Show("國文成績未輸入");
            }
            int eng;

            if (int.TryParse(textBox3.Text, out eng))
            {
                stu.English = eng;
            }
            else
            {
                MessageBox.Show("英文成績未輸入");
            }

            int mat;

            if (int.TryParse(textBox4.Text, out mat))
            {
                stu.Mathematics = mat;
            }
            else
            {
                MessageBox.Show("數學成績未輸入");
            }

            stu.sum = chi + eng + mat;
            stu.avg = stu.sum / 3;
            //max
            if (chi > eng & chi > mat& mat<eng)
            {
                stu.highest = label2.Text;
                stu.lowest = label4.Text;
            }
            else
            {
                if (eng  > mat & eng > chi & chi<mat)
                {
                    stu.highest = label3.Text;
                    stu.lowest = label2.Text;
                }
                else
                {
                    stu.highest = label4.Text;
                    stu.lowest=label3.Text;
                }

            }

            //min

            if (chi < eng & chi < mat)
            {
                stu.lowest = label2.Text;
            }

            else
            {
                if (mat <  chi)
                {
                    stu.lowest = label4.Text;
                }
                else
                { stu.lowest = label3.Text; }
            }




        }
        private void button2_Click(object sender, EventArgs e)
        {


            MessageBox.Show("姓名：" +stu.name+"\n"+ "中文："+stu.Chinese + "\n" + "英文：" +stu.English+ "\n" + "數學："+stu.Mathematics + "\n" + "平均："+stu.avg + "\n" + "總分："+stu.sum + "\n" + "最高："+stu.highest + "\n" + "最低："+stu.lowest);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmStudentstrut_Load(object sender, EventArgs e)
        {

        }
    }
}