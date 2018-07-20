using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_HomeWork
{
    public partial class FrmNotePad : Form
    {
        public FrmNotePad()
        {
            InitializeComponent();
            this.textBox1.ScrollBars = ScrollBars.Both;

            this.textBox1.WordWrap = true;
            this.自動換行ToolStripMenuItem.Checked = this.textBox1.WordWrap;
            this.toolStripStatusLabel1.Text = this.Name;
            this.toolStripStatusLabel1.Text = openFileDialog1.FileName.ToString();
            this.toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotePad f = new FrmNotePad();
            f.Show();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "RTF文字檔(*.rtf)|*.rtf|文字檔(*.txt)|*.txt|所有檔案(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                this.textBox1.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = openFileDialog1.FileName;


            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);
                sw.Write(textBox1.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 列印PToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 預覽列印VToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 取消復原RToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int u = 0;
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.WordWrap = !this.textBox1.WordWrap;

            this.自動換行ToolStripMenuItem.Checked = this.textBox1.WordWrap;
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "RTF文字檔(*.rtf)|*.rtf|文字檔(*.txt)|*.txt|所有檔案(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                this.textBox1.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = openFileDialog1.FileName;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            FrmNotePad f = new FrmNotePad();
            f.Show();
        }
    }
}





       



