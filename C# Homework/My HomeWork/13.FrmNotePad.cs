using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            this.richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;

            this.richTextBox1.WordWrap = true;
            this.自動換行ToolStripMenuItem.Checked = this.richTextBox1.WordWrap;
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
                this.richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = openFileDialog1.FileName;


            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);
                sw.Write(richTextBox1.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);
                sw.Write(richTextBox1.Text);
                sw.Flush();
                sw.Close();
            }

        }

        private void 列印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }

        private void 預覽列印VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.ShowDialog();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void 取消復原RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int u = 0;
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.WordWrap = !this.richTextBox1.WordWrap;

            this.自動換行ToolStripMenuItem.Checked = this.richTextBox1.WordWrap;
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "RTF文字檔(*.rtf)|*.rtf|文字檔(*.txt)|*.txt|所有檔案(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);
                this.richTextBox1.Text = sr.ReadToEnd();
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

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void 列印PToolStripButton_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);
                sw.Write(richTextBox1.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void 自訂CToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 選項OToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 內容CToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 索引IToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 搜尋SToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        bool FontBoldBool;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (FontBoldBool == true)
                {
                    toolStripButton1.Font = new Font(toolStripButton1.Font.FontFamily, this.toolStripButton1.Font.Size, FontStyle.Bold);
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.FontFamily, this.richTextBox1.Font.Size, FontStyle.Bold);

                    FontBoldBool = !FontBoldBool;
                }
                else
                {
                    toolStripButton1.Font = new Font(toolStripButton1.Font.FontFamily, this.toolStripButton1.Font.Size, FontStyle.Regular);
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.FontFamily, this.richTextBox1.Font.Size, FontStyle.Regular);

                    FontBoldBool = !FontBoldBool;
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("出現異常：" + ex, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool FontItalicsBool;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (FontItalicsBool == true)
                {
                    toolStripButton2.Font = new Font(toolStripButton2.Font.FontFamily, this.toolStripButton2.Font.Size, FontStyle.Italic);
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.FontFamily, this.richTextBox1.Font.Size, FontStyle.Italic);

                    FontItalicsBool = !FontItalicsBool;
                }
                else
                {
                    toolStripButton2.Font = new Font(toolStripButton2.Font.FontFamily, this.toolStripButton2.Font.Size, FontStyle.Regular);
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.FontFamily, this.richTextBox1.Font.Size, FontStyle.Regular);

                    FontItalicsBool = !FontItalicsBool;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出現異常：" + ex, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool FontBaselineBool;
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (FontBaselineBool == true)
                {
                    toolStripButton3.Font = new Font(toolStripButton3.Font.FontFamily, this.toolStripButton3.Font.Size, FontStyle.Underline);
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.FontFamily, this.richTextBox1.Font.Size, FontStyle.Underline);

                    FontBaselineBool = !FontBaselineBool;
                }
                else
                {
                    toolStripButton3.Font = new Font(toolStripButton3.Font.FontFamily, this.toolStripButton3.Font.Size, FontStyle.Regular);
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font.FontFamily, this.richTextBox1.Font.Size, FontStyle.Regular);

                    FontBaselineBool = !FontBaselineBool;
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("出現異常：" + ex, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog cld = new ColorDialog();
                if (cld.ShowDialog() == DialogResult.OK)
                {
                    toolStripButton4.BackColor = cld.Color;
                    richTextBox1.SelectionColor = cld.Color;
                    this.richTextBox1.Refresh();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出現異常：" + ex, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
 
        }


        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            try
            {

                this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont.FontFamily, FontSize[this.toolStripComboBox2.SelectedIndex], this.richTextBox1.SelectionFont.Style);
                this.richTextBox1.Refresh();


                

            }
            catch (Exception ex)
            {
                MessageBox.Show("出現異常：" + ex, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public float[] FontSize =
            {
                8,9,10,12,14,16,18,20,22,24,26,28,36,48,72
            };
        public string[] FontSizeStringArray =
   {
                "8","9","10","12","14","16","18","20","22","24","26","28","36","48","72"
            };
        private void FrmNotePad_Load(object sender, EventArgs e)
        {
            try
            {
                InstalledFontCollection fontCol = new InstalledFontCollection();
                foreach (FontFamily ffly in fontCol.Families)
                {
                    toolStripComboBox1.Items.Add(ffly.Name);
                    toolStripComboBox1.SelectedItem = "新細明體";
                }
                foreach (string FontSizeString in FontSizeStringArray)
                {
                    toolStripComboBox2.Items.Add(FontSizeString);
                    toolStripComboBox2.SelectedItem = "10";
                }
            }
            catch (Exception ex)//捕獲並顯示異常內容
            {
                MessageBox.Show("出現異常：" + ex, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {
            try
            {

                this.richTextBox1.SelectionFont = new Font(this.toolStripComboBox1.Text, this.richTextBox1.SelectionFont.Size, this.richTextBox1.SelectionFont.Style);
                this.richTextBox1.Refresh();




            }
            catch (Exception ex)//捕獲並顯示異常內容
            {
                MessageBox.Show("出現異常：" + ex, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





       



