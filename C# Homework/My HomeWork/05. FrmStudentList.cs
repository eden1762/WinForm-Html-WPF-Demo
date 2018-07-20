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
    public partial class FrmStudentList : Form
    {
        public FrmStudentList()
        {
            InitializeComponent();
        }
        List<Scores> scoreGL = new List<Scores>();
        ArrayList scoreAL = new ArrayList();

        Scores s = new Scores();
        int[,] score = new int[101, 3];



        //int x = 0;
        static int id = 0;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            bool beng = int.TryParse(textBox2.Text, out s.eng);
            bool bmat = int.TryParse(textBox3.Text, out s.mat);
            bool bchi = int.TryParse(textBox4.Text, out s.chi);
            int[] sco = { s.eng, s.mat, s.chi };
            if (beng && bmat && bchi)
            {
                score[id, 0] = sco[0];
                score[id, 1] = sco[1];
                score[id, 2] = sco[2];

                int sum = 0;
                for (int i = 0; i < sco.Length; i++)
                {
                    sum += sco[i];
                }
                int avg = sum / sco.Length;

                int max = sco[0];
                for (int i = 0; i < sco.Length; i++)
                {
                    if (sco[i] > max)
                    { max = sco[i]; }
                }
                int min = sco[0];
                for (int i = 0; i < sco.Length; i++)
                {
                    if (sco[i] < min)
                    { min = sco[i]; }
                }
                richTextBox1.Text += string.Format("{0,-19}{1,-19}{2,-19}{3,-19}{4,-19}{5,-19}{6,-19}{7,-19}\n", name, s.eng, s.mat, s.chi, sum, avg, max, min);
                id += 1;
            }
            else
            {
                MessageBox.Show("請輸入整數。");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
            //+1

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //+1r
            Random r = new Random();

            int[] sco = { s.eng, s.mat, s.chi };


            for (int i = 0; i <= sco.Length - 1; i++)
            {
                sco[i] = r.Next(0, 101);
            }
            score[id, 0] = sco[0];
            score[id, 1] = sco[1];
            score[id, 2] = sco[2];

            int sum = 0;
            for (int i = 0; i <= sco.Length - 1; i++)
            {
                sum += sco[i];
            }
            int avg = sum / sco.Length;

            int max = sco[0];
            for (int i = 0; i < sco.Length; i++)
            {
                if (sco[i] > max)
                { max = sco[i]; }
            }
            int min = sco[0];
            for (int i = 0; i < sco.Length; i++)
            {
                if (sco[i] < min)
                { min = sco[i]; }
            }
            id += 1;

            richTextBox1.Text += string.Format("{0,-22}{1,-22}{2,-22}{3,-22}{4,-22}{5,-22}{6,-22}{7,-22}\n", id, sco[0], sco[1], sco[2], sum, avg, max, min);



        }

        private void button5_Click(object sender, EventArgs e)
        {
            //r20
            Random r = new Random();
            int t = 20;
            for (t = 0; t <= 20; t++)
            {
                int[] sco = { s.eng, s.mat, s.chi };






                for (int i = 0; i <= sco.Length - 1; i++)
                {
                    sco[i] = r.Next(0, 101);
                }
                score[id, 0] = sco[0];
                score[id, 1] = sco[1];
                score[id, 2] = sco[2];

                int sum = 0;
                for (int i = 0; i <= sco.Length - 1; i++)
                {
                    sum += sco[i];
                }
                int avg = sum / sco.Length;

                int max = sco[0];
                for (int i = 0; i < sco.Length; i++)
                {
                    if (sco[i] > max)
                    { max = sco[i]; }
                }
                int min = sco[0];
                for (int i = 0; i < sco.Length; i++)
                {
                    if (sco[i] < min)
                    { min = sco[i]; }
                }
                id += 1;

                richTextBox1.Text += string.Format("{0,-22}{1,-22}{2,-22}{3,-22}{4,-22}{5,-22}{6,-22}{7,-22}\n", id, sco[0], sco[1], sco[2], sum, avg, max, min);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //reset
            richTextBox1.Text = string.Format("{0,-19}{1,-19}{2,-19}{3,-19}{4,-19}{5,-19}{6,-19}{7,-19}\n", "Name", "Eng", "Math", "Chi", "Sum", "Avg", "Max", "Min");
            id = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //s
            int seng = 0;
            for (int i = 0; i < id; i++)
            { seng += score[i, 0]; }
            int smat = 0;
            for (int i = 0; i < id; i++)
            { smat += score[i, 1]; }
            int schi = 0;
            for (int i = 0; i < id; i++)
            { schi += score[i, 2]; }
            int aeng = 0;
            for (int i = 0; i < id; i++)
            { aeng = seng / id; }
            int achi = 0;
            for (int i = 0; i < id; i++)
            { achi = schi / id; }
            int amat = 0;
            for (int i = 0; i < id; i++)
            { amat = smat / id; }
            int heng = score[0, 0];
            for (int i = 0; i < id; i++)
            {
                if (heng < score[i, 0])
                {
                    heng = score[i, 0];
                }
            }
            int hmat = score[0, 0];
            for (int i = 0; i < id; i++)
            {
                if (hmat < score[i, 1])
                {
                    hmat = score[i, 1];
                }
            }
            int hchi = score[0, 0];
            for (int i = 0; i < id; i++)
            {
                if (hchi < score[id, 2])
                {
                    hchi = score[id, 2];
                }



            }

            int bigavg = (seng + smat + schi) / (3 * id);

            richTextBox1.Text += string.Format(" ===========================================================================================\n英文最高分:{0,-25}數學最高分:{1,-25}國文最高分:{2,-25}\n英文平均分:{3,-25}數學平均分:{4,-19}國文平均分:{5,-19}\n總平均:{6,-19}", heng, hmat, hchi, aeng, amat, achi, bigavg);


        }

        private void button6_Click(object sender, EventArgs e)
        {

            bool beng = int.TryParse(textBox2.Text, out s.eng);
            bool bmat = int.TryParse(textBox3.Text, out s.mat);
            bool bchi = int.TryParse(textBox4.Text, out s.chi);

            if (beng && bmat && bchi)
            {

                s.name = textBox1.Text;
                scoreGL.Add(s);
                int sum = MyScore.SUM(s.eng, s.mat, s.chi);
                int avg = MyScore.AVG(s.eng, s.mat, s.chi);
                int max = MyScore.MAX(s.eng, s.mat, s.chi);
                int min = MyScore.MIN(s.eng, s.mat, s.chi);

                richTextBox1.Text += string.Format("{0,-22}{1,-22}{2,-22}{3,-22}{4,-22}{5,-22}{6,-22}{7,-22}\n", s.name, s.eng, s.mat, s.chi, sum, avg, max, min);
                id += 1;
            }
            else
            {
                MessageBox.Show("請輸入整數。");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
            //+1

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //+1r
            Random r = new Random();
            int[] num = new int[3];
            for (int i = 0; i <= num.Length - 1; i++)
            { num[i] = r.Next(0, 101); }
            id = id + 1;
            s.name = id.ToString();
            s.eng = num[0];
            s.mat = num[1];
            s.chi = num[2];
            scoreGL.Add(s);
            int sum = MyScore.SUM(s.eng, s.mat, s.chi);
            int avg = MyScore.AVG(s.eng, s.mat, s.chi);
            int max = MyScore.MAX(s.eng, s.mat, s.chi);
            int min = MyScore.MIN(s.eng, s.mat, s.chi);

            richTextBox1.Text += string.Format("{0,-22}{1,-22}{2,-22}{3,-22}{4,-22}{5,-22}{6,-22}{7,-22}\n", s.name, s.eng, s.mat, s.chi, sum, avg, max, min);


        }

        private void button10_Click(object sender, EventArgs e)
        {
            //s
            int[] engGL = new int[id];
            for (int i = 0; i <= id - 1; i++)
            { engGL[i] = scoreGL[i].eng; }
            int[] matGL = new int[id];
            for (int i = 0; i <= id - 1; i++)
            { matGL[i] = scoreGL[i].mat; }
            int[] chiGL = new int[id];
            for (int i = 0; i <= id - 1; i++)
            { chiGL[i] = scoreGL[i].chi; }

            int heng = MyScore.MAX(engGL);
            int hmat = MyScore.MAX(matGL);
            int hchi = MyScore.MAX(chiGL);
            int aeng = MyScore.AVG(engGL);
            int amat = MyScore.AVG(matGL);
            int achi = MyScore.AVG(chiGL);
            int bigavg = MyScore.AVG(aeng, amat, achi);


            richTextBox1.Text += string.Format(" ===========================================================================================\n英文最高分:{0,-25}數學最高分:{1,-25}國文最高分:{2,-25}\n英文平均分:{3,-25}數學平均分:{4,-19}國文平均分:{5,-19}\n總平均:{6,-19}", heng, hmat, hchi, aeng, amat, achi, bigavg);


        }

        private void button9_Click(object sender, EventArgs e)
        {
            //reset
            richTextBox1.Text = string.Format("{0,-19}{1,-19}{2,-19}{3,-19}{4,-19}{5,-19}{6,-19}{7,-19}\n", "Name", "Eng", "Math", "Chi", "Sum", "Avg", "Max", "Min");
            List<Scores> scoreGL = new List<Scores>();
            id = 0;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            //r20
            Random r = new Random();
            int[] num = new int[3];
            int t = 0;
            for (t = 0; t < 20; t++)
            {

                for (int i = 0; i <= num.Length - 1; i++)
                { num[i] = r.Next(0, 101); }
                id = id + 1;
                s.name = id.ToString();
                s.eng = num[0];
                s.mat = num[1];
                s.chi = num[2];
                scoreGL.Add(s);
                int sum = MyScore.SUM(s.eng, s.mat, s.chi);
                int avg = MyScore.AVG(s.eng, s.mat, s.chi);
                int max = MyScore.MAX(s.eng, s.mat, s.chi);
                int min = MyScore.MIN(s.eng, s.mat, s.chi);

                richTextBox1.Text += string.Format("{0,-22}{1,-22}{2,-22}{3,-22}{4,-22}{5,-22}{6,-22}{7,-22}\n", s.name, s.eng, s.mat, s.chi, sum, avg, max, min);
            }

        }

        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Format("{0,-19}{1,-19}{2,-19}{3,-19}{4,-19}{5,-19}{6,-19}{7,-19}\n", "Name", "Eng", "Math", "Chi", "Sum", "Avg", "Max", "Min");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //a
            bool beng = int.TryParse(textBox2.Text, out s.eng);
            bool bmat = int.TryParse(textBox3.Text, out s.mat);
            bool bchi = int.TryParse(textBox4.Text, out s.chi);

            if (beng && bmat && bchi)
            {

                s.name = textBox1.Text;
                scoreAL.Add(s);
                int sum = MyScore.SUM(s.eng, s.mat, s.chi);
                int avg = MyScore.AVG(s.eng, s.mat, s.chi);
                int max = MyScore.MAX(s.eng, s.mat, s.chi);
                int min = MyScore.MIN(s.eng, s.mat, s.chi);

                richTextBox1.Text += string.Format("{0,-22}{1,-22}{2,-22}{3,-22}{4,-22}{5,-22}{6,-22}{7,-22}\n", s.name, s.eng, s.mat, s.chi, sum, avg, max, min);
                id += 1;
            }
            else
            {
                MessageBox.Show("請輸入整數。");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //s1
            Random r = new Random();
            int[] num = new int[3];
            for (int i = 0; i <= num.Length - 1; i++)
            { num[i] = r.Next(0, 101); }
            id = id + 1;
            s.name = id.ToString();
            s.eng = num[0];
            s.mat = num[1];
            s.chi = num[2];
            scoreAL.Add(s);
            int sum = MyScore.SUM(s.eng, s.mat, s.chi);
            int avg = MyScore.AVG(s.eng, s.mat, s.chi);
            int max = MyScore.MAX(s.eng, s.mat, s.chi);
            int min = MyScore.MIN(s.eng, s.mat, s.chi);

            richTextBox1.Text += string.Format("{0,-22}{1,-22}{2,-22}{3,-22}{4,-22}{5,-22}{6,-22}{7,-22}\n", s.name, s.eng, s.mat, s.chi, sum, avg, max, min);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //s
            int[] engGL = new int[id];
            for (int i = 0; i <= id - 1; i++)
            { engGL[i] = ((Scores)scoreAL[i]).eng; }
            int[] matGL = new int[id];
            for (int i = 0; i <= id - 1; i++)
            { matGL[i] = ((Scores)scoreAL[i]).mat; }
            int[] chiGL = new int[id];
            for (int i = 0; i <= id - 1; i++)
            { chiGL[i] = ((Scores)scoreAL[i]).chi; }

            int heng = MyScore.MAX(engGL);
            int hmat = MyScore.MAX(matGL);
            int hchi = MyScore.MAX(chiGL);
            int aeng = MyScore.AVG(engGL);
            int amat = MyScore.AVG(matGL);
            int achi = MyScore.AVG(chiGL);
            int bigavg = MyScore.AVG(aeng, amat, achi);


            richTextBox1.Text += string.Format(" ===========================================================================================\n英文最高分:{0,-25}數學最高分:{1,-25}國文最高分:{2,-25}\n英文平均分:{3,-25}數學平均分:{4,-19}國文平均分:{5,-19}\n總平均:{6,-19}", heng, hmat, hchi, aeng, amat, achi, bigavg);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //re
            richTextBox1.Text = string.Format("{0,-19}{1,-19}{2,-19}{3,-19}{4,-19}{5,-19}{6,-19}{7,-19}\n", "Name", "Eng", "Math", "Chi", "Sum", "Avg", "Max", "Min");
            ArrayList scoreAL = new ArrayList();
            id = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //r20
            Random r = new Random();
            int[] num = new int[3];
            int t = 0;
            for (t = 0; t < 20; t++)
            {

                for (int i = 0; i <= num.Length - 1; i++)
                { num[i] = r.Next(0, 101); }
                id = id + 1;
                s.name = id.ToString();
                s.eng = num[0];
                s.mat = num[1];
                s.chi = num[2];
                scoreAL.Add(s);
                int sum = MyScore.SUM(s.eng, s.mat, s.chi);
                int avg = MyScore.AVG(s.eng, s.mat, s.chi);
                int max = MyScore.MAX(s.eng, s.mat, s.chi);
                int min = MyScore.MIN(s.eng, s.mat, s.chi);

                richTextBox1.Text += string.Format("{0,-22}{1,-22}{2,-22}{3,-22}{4,-22}{5,-22}{6,-22}{7,-22}\n", s.name, s.eng, s.mat, s.chi, sum, avg, max, min);
            }
        }
    }
}
