namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BMap1 = new System.Windows.Forms.WebBrowser();
            this.LoadMap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BMap1
            // 
            this.BMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BMap1.Location = new System.Drawing.Point(0, 0);
            this.BMap1.MinimumSize = new System.Drawing.Size(20, 20);
            this.BMap1.Name = "BMap1";
            this.BMap1.Size = new System.Drawing.Size(702, 429);
            this.BMap1.TabIndex = 0;
            this.BMap1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // LoadMap
            // 
            this.LoadMap.Location = new System.Drawing.Point(299, 403);
            this.LoadMap.Name = "LoadMap";
            this.LoadMap.Size = new System.Drawing.Size(75, 23);
            this.LoadMap.TabIndex = 1;
            this.LoadMap.Text = "LoadMap";
            this.LoadMap.UseVisualStyleBackColor = true;
            this.LoadMap.Click += new System.EventHandler(this.LoadMap_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.LoadMap);
            this.Controls.Add(this.BMap1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(702, 429);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser BMap1;
        private System.Windows.Forms.Button LoadMap;
    }
}
