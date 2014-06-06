namespace 教务系统
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem51 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem52 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.mainMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem1,
            this.MenuItem2,
            this.MenuItem3,
            this.MenuItem4,
            this.MenuItem5,
            this.MenuItem6});
            this.mainMenu1.Location = new System.Drawing.Point(0, 0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(955, 25);
            this.mainMenu1.TabIndex = 0;
            this.mainMenu1.Text = "menuStrip1";
            // 
            // MenuItem1
            // 
            this.MenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem12,
            this.MenuItem13});
            this.MenuItem1.Name = "MenuItem1";
            this.MenuItem1.Size = new System.Drawing.Size(92, 21);
            this.MenuItem1.Text = "行政单位管理";
            // 
            // MenuItem12
            // 
            this.MenuItem12.Name = "MenuItem12";
            this.MenuItem12.Size = new System.Drawing.Size(148, 22);
            this.MenuItem12.Text = "专业信息维护";
            this.MenuItem12.Click += new System.EventHandler(this.MenuItem12_Click);
            // 
            // MenuItem13
            // 
            this.MenuItem13.Name = "MenuItem13";
            this.MenuItem13.Size = new System.Drawing.Size(148, 22);
            this.MenuItem13.Text = "班级信息维护";
            this.MenuItem13.Click += new System.EventHandler(this.MenuItem13_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.Name = "MenuItem2";
            this.MenuItem2.Size = new System.Drawing.Size(92, 21);
            this.MenuItem2.Text = "教师信息管理";
            this.MenuItem2.Click += new System.EventHandler(this.MenuItem2_Click);
            // 
            // MenuItem3
            // 
            this.MenuItem3.Name = "MenuItem3";
            this.MenuItem3.Size = new System.Drawing.Size(92, 21);
            this.MenuItem3.Text = "学生信息管理";
            this.MenuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
            // 
            // MenuItem4
            // 
            this.MenuItem4.Name = "MenuItem4";
            this.MenuItem4.Size = new System.Drawing.Size(92, 21);
            this.MenuItem4.Text = "课程信息管理";
            // 
            // MenuItem5
            // 
            this.MenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem51,
            this.MenuItem52});
            this.MenuItem5.Name = "MenuItem5";
            this.MenuItem5.Size = new System.Drawing.Size(68, 21);
            this.MenuItem5.Text = "授权管理";
            // 
            // MenuItem51
            // 
            this.MenuItem51.Name = "MenuItem51";
            this.MenuItem51.Size = new System.Drawing.Size(152, 22);
            this.MenuItem51.Text = "教师授权管理";
            // 
            // MenuItem52
            // 
            this.MenuItem52.Name = "MenuItem52";
            this.MenuItem52.Size = new System.Drawing.Size(152, 22);
            this.MenuItem52.Text = "学生授权管理";
            // 
            // MenuItem6
            // 
            this.MenuItem6.Name = "MenuItem6";
            this.MenuItem6.Size = new System.Drawing.Size(68, 21);
            this.MenuItem6.Text = "退出系统";
            this.MenuItem6.Click += new System.EventHandler(this.MenuItem6_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 606);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(955, 22);
            this.statusBar1.TabIndex = 5;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.MinWidth = 200;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = " 教务管理系统";
            this.statusBarPanel1.Width = 500;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(955, 628);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.mainMenu1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【教务管理系统】";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu1.ResumeLayout(false);
            this.mainMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem12;
        private System.Windows.Forms.ToolStripMenuItem MenuItem13;
        private System.Windows.Forms.ToolStripMenuItem MenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuItem4;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel2;
        private System.Windows.Forms.ToolStripMenuItem MenuItem5;
        private System.Windows.Forms.ToolStripMenuItem MenuItem51;
        private System.Windows.Forms.ToolStripMenuItem MenuItem6;
        private System.Windows.Forms.ToolStripMenuItem MenuItem52;
    }
}

