namespace My_HomeWork
{
    partial class FrmStudentstrut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.中文textBox = new System.Windows.Forms.TextBox();
            this.英文textBox = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.中文label = new System.Windows.Forms.Label();
            this.英文label = new System.Windows.Forms.Label();
            this.數學label = new System.Windows.Forms.Label();
            this.數學textBox = new System.Windows.Forms.TextBox();
            this.addstudentbutton = new System.Windows.Forms.Button();
            this.showstudentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(250, 43);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 22);
            this.nametextBox.TabIndex = 0;
            // 
            // 中文textBox
            // 
            this.中文textBox.Location = new System.Drawing.Point(250, 83);
            this.中文textBox.Name = "中文textBox";
            this.中文textBox.Size = new System.Drawing.Size(100, 22);
            this.中文textBox.TabIndex = 1;
            // 
            // 英文textBox
            // 
            this.英文textBox.Location = new System.Drawing.Point(250, 123);
            this.英文textBox.Name = "英文textBox";
            this.英文textBox.Size = new System.Drawing.Size(100, 22);
            this.英文textBox.TabIndex = 2;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.namelabel.Location = new System.Drawing.Point(22, 40);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(52, 20);
            this.namelabel.TabIndex = 3;
            this.namelabel.Text = "name";
            // 
            // 中文label
            // 
            this.中文label.AutoSize = true;
            this.中文label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.中文label.Location = new System.Drawing.Point(22, 80);
            this.中文label.Name = "中文label";
            this.中文label.Size = new System.Drawing.Size(41, 20);
            this.中文label.TabIndex = 4;
            this.中文label.Text = "中文";
            // 
            // 英文label
            // 
            this.英文label.AutoSize = true;
            this.英文label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.英文label.Location = new System.Drawing.Point(22, 120);
            this.英文label.Name = "英文label";
            this.英文label.Size = new System.Drawing.Size(41, 20);
            this.英文label.TabIndex = 5;
            this.英文label.Text = "英文";
            this.英文label.Click += new System.EventHandler(this.label3_Click);
            // 
            // 數學label
            // 
            this.數學label.AutoSize = true;
            this.數學label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.數學label.Location = new System.Drawing.Point(22, 160);
            this.數學label.Name = "數學label";
            this.數學label.Size = new System.Drawing.Size(41, 20);
            this.數學label.TabIndex = 6;
            this.數學label.Text = "數學";
            // 
            // 數學textBox
            // 
            this.數學textBox.Location = new System.Drawing.Point(250, 163);
            this.數學textBox.Name = "數學textBox";
            this.數學textBox.Size = new System.Drawing.Size(100, 22);
            this.數學textBox.TabIndex = 7;
            // 
            // addstudentbutton
            // 
            this.addstudentbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addstudentbutton.Location = new System.Drawing.Point(26, 210);
            this.addstudentbutton.Name = "addstudentbutton";
            this.addstudentbutton.Size = new System.Drawing.Size(159, 35);
            this.addstudentbutton.TabIndex = 8;
            this.addstudentbutton.Text = "add student";
            this.addstudentbutton.UseVisualStyleBackColor = true;
            this.addstudentbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // showstudentbutton
            // 
            this.showstudentbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showstudentbutton.Location = new System.Drawing.Point(191, 210);
            this.showstudentbutton.Name = "showstudentbutton";
            this.showstudentbutton.Size = new System.Drawing.Size(159, 35);
            this.showstudentbutton.TabIndex = 9;
            this.showstudentbutton.Text = "show student";
            this.showstudentbutton.UseVisualStyleBackColor = true;
            this.showstudentbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmStudentstrut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 315);
            this.Controls.Add(this.showstudentbutton);
            this.Controls.Add(this.addstudentbutton);
            this.Controls.Add(this.數學textBox);
            this.Controls.Add(this.數學label);
            this.Controls.Add(this.英文label);
            this.Controls.Add(this.中文label);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.英文textBox);
            this.Controls.Add(this.中文textBox);
            this.Controls.Add(this.nametextBox);
            this.Name = "FrmStudentstrut";
            this.Text = "FrmStudentstrut";
            this.Load += new System.EventHandler(this.FrmStudentstrut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox 中文textBox;
        private System.Windows.Forms.TextBox 英文textBox;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label 中文label;
        private System.Windows.Forms.Label 英文label;
        private System.Windows.Forms.Label 數學label;
        private System.Windows.Forms.TextBox 數學textBox;
        private System.Windows.Forms.Button addstudentbutton;
        private System.Windows.Forms.Button showstudentbutton;
    }
}