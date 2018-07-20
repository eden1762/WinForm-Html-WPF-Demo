namespace My_HomeWork
{
    partial class FrmLoan
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.貸款金額應繳金額label = new System.Windows.Forms.Label();
            this.貸款金額應繳金額textBox = new System.Windows.Forms.TextBox();
            this.分期數textBox = new System.Windows.Forms.TextBox();
            this.分期數label = new System.Windows.Forms.Label();
            this.利息textBox = new System.Windows.Forms.TextBox();
            this.利息label = new System.Windows.Forms.Label();
            this.單月button = new System.Windows.Forms.Button();
            this.總金額button = new System.Windows.Forms.Button();
            this.Reportbutton = new System.Windows.Forms.Button();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 貸款金額應繳金額label
            // 
            this.貸款金額應繳金額label.AutoSize = true;
            this.貸款金額應繳金額label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.貸款金額應繳金額label.Location = new System.Drawing.Point(24, 33);
            this.貸款金額應繳金額label.Name = "貸款金額應繳金額label";
            this.貸款金額應繳金額label.Size = new System.Drawing.Size(148, 20);
            this.貸款金額應繳金額label.TabIndex = 0;
            this.貸款金額應繳金額label.Text = "貸款金額/ 應繳金額";
            this.貸款金額應繳金額label.Click += new System.EventHandler(this.label1_Click);
            // 
            // 貸款金額應繳金額textBox
            // 
            this.貸款金額應繳金額textBox.Location = new System.Drawing.Point(183, 33);
            this.貸款金額應繳金額textBox.Name = "貸款金額應繳金額textBox";
            this.貸款金額應繳金額textBox.Size = new System.Drawing.Size(100, 22);
            this.貸款金額應繳金額textBox.TabIndex = 1;
            this.貸款金額應繳金額textBox.Text = "3000000";
            // 
            // 分期數textBox
            // 
            this.分期數textBox.Location = new System.Drawing.Point(183, 98);
            this.分期數textBox.Name = "分期數textBox";
            this.分期數textBox.Size = new System.Drawing.Size(100, 22);
            this.分期數textBox.TabIndex = 3;
            // 
            // 分期數label
            // 
            this.分期數label.AutoSize = true;
            this.分期數label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.分期數label.Location = new System.Drawing.Point(26, 98);
            this.分期數label.Name = "分期數label";
            this.分期數label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.分期數label.Size = new System.Drawing.Size(57, 20);
            this.分期數label.TabIndex = 2;
            this.分期數label.Text = "分期數";
            // 
            // 利息textBox
            // 
            this.利息textBox.Location = new System.Drawing.Point(183, 163);
            this.利息textBox.Name = "利息textBox";
            this.利息textBox.Size = new System.Drawing.Size(100, 22);
            this.利息textBox.TabIndex = 5;
            this.利息textBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // 利息label
            // 
            this.利息label.AutoSize = true;
            this.利息label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.利息label.Location = new System.Drawing.Point(24, 165);
            this.利息label.Name = "利息label";
            this.利息label.Size = new System.Drawing.Size(41, 20);
            this.利息label.TabIndex = 4;
            this.利息label.Text = "利息";
            // 
            // 單月button
            // 
            this.單月button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.單月button.Location = new System.Drawing.Point(2, 242);
            this.單月button.Name = "單月button";
            this.單月button.Size = new System.Drawing.Size(75, 29);
            this.單月button.TabIndex = 6;
            this.單月button.Text = "單月";
            this.單月button.UseVisualStyleBackColor = true;
            this.單月button.Click += new System.EventHandler(this.單月button_Click);
            // 
            // 總金額button
            // 
            this.總金額button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.總金額button.Location = new System.Drawing.Point(83, 242);
            this.總金額button.Name = "總金額button";
            this.總金額button.Size = new System.Drawing.Size(75, 29);
            this.總金額button.TabIndex = 7;
            this.總金額button.Text = "總金額";
            this.總金額button.UseVisualStyleBackColor = true;
            this.總金額button.Click += new System.EventHandler(this.總金額button_Click);
            // 
            // Reportbutton
            // 
            this.Reportbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Reportbutton.Location = new System.Drawing.Point(164, 242);
            this.Reportbutton.Name = "Reportbutton";
            this.Reportbutton.Size = new System.Drawing.Size(75, 29);
            this.Reportbutton.TabIndex = 8;
            this.Reportbutton.Text = "Report";
            this.Reportbutton.UseVisualStyleBackColor = true;
            this.Reportbutton.Click += new System.EventHandler(this.Reportbutton_Click);
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Refreshbutton.Location = new System.Drawing.Point(246, 242);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(75, 29);
            this.Refreshbutton.TabIndex = 9;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // FrmLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 283);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.Reportbutton);
            this.Controls.Add(this.總金額button);
            this.Controls.Add(this.單月button);
            this.Controls.Add(this.利息textBox);
            this.Controls.Add(this.利息label);
            this.Controls.Add(this.分期數textBox);
            this.Controls.Add(this.分期數label);
            this.Controls.Add(this.貸款金額應繳金額textBox);
            this.Controls.Add(this.貸款金額應繳金額label);
            this.Name = "FrmLoan";
            this.Text = "FrmLoanReport";
            this.Load += new System.EventHandler(this.FrmLoan_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLoan_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 貸款金額應繳金額label;
        private System.Windows.Forms.TextBox 貸款金額應繳金額textBox;
        private System.Windows.Forms.TextBox 分期數textBox;
        private System.Windows.Forms.Label 分期數label;
        private System.Windows.Forms.TextBox 利息textBox;
        private System.Windows.Forms.Label 利息label;
        private System.Windows.Forms.Button 單月button;
        private System.Windows.Forms.Button 總金額button;
        private System.Windows.Forms.Button Reportbutton;
        private System.Windows.Forms.Button Refreshbutton;
    }
}

