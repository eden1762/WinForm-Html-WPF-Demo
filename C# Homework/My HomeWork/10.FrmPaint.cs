using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_HomeWork
{
    public partial class FrmPaint : Form
    {
        public FrmPaint()
        {
            InitializeComponent();
            this.MouseMove += FrmIrrgular_MouseMove;
            this.MouseUp += FrmIrrgular_MouseUp;
            this.MouseDown += FrmIrrgular_MouseDown;
            g = this.CreateGraphics();

        }
        
        
        Graphics g;
        List<Point> po = new List<Point>();
        ///*        Point po*/;
        //SmoothingMode s;
        

        
///        
        int x;
        int y;

        //int Start_x;
        //int Start_y;
        int n = 0;
        bool isMousedown;
        Pen pen = new Pen(Color.Black,12);

        internal void FrmIrrgular_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (isMousedown)
            {
                g.SmoothingMode =
        System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                g.DrawLine(pen, x, y, e.X, e.Y);
                    x = e.X;
                    y = e.Y;
                 Point p = new Point(x,y);
                po.Add(p);





            }
        }

        internal void FrmIrrgular_MouseUp(object sender, MouseEventArgs e)
        {
            isMousedown = false;
        }

        internal void FrmIrrgular_MouseDown(object sender, MouseEventArgs e)
        {
            isMousedown = true;
            
            x = e.X;
            y = e.Y;
            Point p = new Point(x, y);
            po.Add(p);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen.Color=Color.Blue;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            pen.Color = Color.Red;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
            List<Point> po = new List<Point>();
            x = 0;
            y = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Point

            int j = int.Parse(textBox1.Text);
            pen = new Pen(Color.Black, j);




        }

        private void button6_Click(object sender, EventArgs e)
        {
            //p.Add()
            for (int i = 1; i < po.Count; i++)
            { g.DrawLine(pen, po[i-1].X, po[i-1].Y, po[i].X, po[i].Y); }

        }
    }
}
