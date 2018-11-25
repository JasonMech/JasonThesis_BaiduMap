namespace BMAP1._0
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userControl11 = new WindowsFormsControlLibrary1.UserControl1();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Gauge1 = new LiveCharts.WinForms.SolidGauge();
            this.solidGauge2 = new LiveCharts.WinForms.SolidGauge();
            this.Gauge2 = new LiveCharts.WinForms.SolidGauge();
            this.Gauge4 = new LiveCharts.WinForms.SolidGauge();
            this.Gauge3 = new LiveCharts.WinForms.SolidGauge();
            this.Gauge6 = new LiveCharts.WinForms.SolidGauge();
            this.Gauge5 = new LiveCharts.WinForms.SolidGauge();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl11.Location = new System.Drawing.Point(369, 104);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(693, 426);
            this.userControl11.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(576, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 391);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 433);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 475);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 514);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label4";
            // 
            // Gauge1
            // 
            this.Gauge1.BackColor = System.Drawing.Color.Khaki;
            this.Gauge1.Location = new System.Drawing.Point(64, 59);
            this.Gauge1.Name = "Gauge1";
            this.Gauge1.Size = new System.Drawing.Size(90, 90);
            this.Gauge1.TabIndex = 10;
            this.Gauge1.Text = "solidGauge1";
            this.Gauge1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.Gauge1_ChildChanged);
            // 
            // solidGauge2
            // 
            this.solidGauge2.Location = new System.Drawing.Point(111, 216);
            this.solidGauge2.Name = "solidGauge2";
            this.solidGauge2.Size = new System.Drawing.Size(8, 8);
            this.solidGauge2.TabIndex = 11;
            this.solidGauge2.Text = "solidGauge2";
            // 
            // Gauge2
            // 
            this.Gauge2.BackColor = System.Drawing.Color.Khaki;
            this.Gauge2.Location = new System.Drawing.Point(186, 59);
            this.Gauge2.Name = "Gauge2";
            this.Gauge2.Size = new System.Drawing.Size(90, 90);
            this.Gauge2.TabIndex = 12;
            this.Gauge2.Text = "solidGauge1";
            // 
            // Gauge4
            // 
            this.Gauge4.BackColor = System.Drawing.Color.Khaki;
            this.Gauge4.Location = new System.Drawing.Point(186, 162);
            this.Gauge4.Name = "Gauge4";
            this.Gauge4.Size = new System.Drawing.Size(90, 90);
            this.Gauge4.TabIndex = 14;
            this.Gauge4.Text = "solidGauge3";
            // 
            // Gauge3
            // 
            this.Gauge3.BackColor = System.Drawing.Color.Khaki;
            this.Gauge3.Location = new System.Drawing.Point(64, 162);
            this.Gauge3.Name = "Gauge3";
            this.Gauge3.Size = new System.Drawing.Size(90, 90);
            this.Gauge3.TabIndex = 13;
            this.Gauge3.Text = "solidGauge1";
            // 
            // Gauge6
            // 
            this.Gauge6.BackColor = System.Drawing.Color.Khaki;
            this.Gauge6.Location = new System.Drawing.Point(186, 264);
            this.Gauge6.Name = "Gauge6";
            this.Gauge6.Size = new System.Drawing.Size(90, 90);
            this.Gauge6.TabIndex = 16;
            this.Gauge6.Text = "solidGauge5";
            // 
            // Gauge5
            // 
            this.Gauge5.BackColor = System.Drawing.Color.Khaki;
            this.Gauge5.Location = new System.Drawing.Point(64, 264);
            this.Gauge5.Name = "Gauge5";
            this.Gauge5.Size = new System.Drawing.Size(90, 90);
            this.Gauge5.TabIndex = 15;
            this.Gauge5.Text = "solidGauge1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1116, 556);
            this.Controls.Add(this.Gauge6);
            this.Controls.Add(this.Gauge5);
            this.Controls.Add(this.Gauge4);
            this.Controls.Add(this.Gauge3);
            this.Controls.Add(this.Gauge2);
            this.Controls.Add(this.solidGauge2);
            this.Controls.Add(this.Gauge1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.UserControl1 userControl11;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private LiveCharts.WinForms.SolidGauge Gauge1;
        private LiveCharts.WinForms.SolidGauge solidGauge2;
        private LiveCharts.WinForms.SolidGauge Gauge2;
        private LiveCharts.WinForms.SolidGauge Gauge4;
        private LiveCharts.WinForms.SolidGauge Gauge3;
        private LiveCharts.WinForms.SolidGauge Gauge6;
        private LiveCharts.WinForms.SolidGauge Gauge5;
    }
}

