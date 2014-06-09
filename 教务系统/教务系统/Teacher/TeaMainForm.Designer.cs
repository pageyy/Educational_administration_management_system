namespace 教务系统.Teacher
{
    partial class TeaMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sbEduTea = new System.Windows.Forms.StatusBar();
            this.statusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选课查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息维护ToolStripMenuItem,
            this.信息查询ToolStripMenuItem,
            this.成绩录入ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sbEduTea
            // 
            this.sbEduTea.Location = new System.Drawing.Point(0, 606);
            this.sbEduTea.Name = "sbEduTea";
            this.sbEduTea.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel4,
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.sbEduTea.ShowPanels = true;
            this.sbEduTea.Size = new System.Drawing.Size(955, 22);
            this.sbEduTea.TabIndex = 6;
            // 
            // statusBarPanel4
            // 
            this.statusBarPanel4.Name = "statusBarPanel4";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.MinWidth = 200;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 400;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.MinWidth = 100;
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 300;
            // 
            // 信息维护ToolStripMenuItem
            // 
            this.信息维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.信息维护ToolStripMenuItem.Name = "信息维护ToolStripMenuItem";
            this.信息维护ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.信息维护ToolStripMenuItem.Text = "信息维护";
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            this.个人信息ToolStripMenuItem.Click += new System.EventHandler(this.个人信息ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 信息查询ToolStripMenuItem
            // 
            this.信息查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.课表查询ToolStripMenuItem,
            this.选课查询ToolStripMenuItem});
            this.信息查询ToolStripMenuItem.Name = "信息查询ToolStripMenuItem";
            this.信息查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.信息查询ToolStripMenuItem.Text = "信息查询";
            // 
            // 课表查询ToolStripMenuItem
            // 
            this.课表查询ToolStripMenuItem.Name = "课表查询ToolStripMenuItem";
            this.课表查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.课表查询ToolStripMenuItem.Text = "课表查询";
            // 
            // 选课查询ToolStripMenuItem
            // 
            this.选课查询ToolStripMenuItem.Name = "选课查询ToolStripMenuItem";
            this.选课查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.选课查询ToolStripMenuItem.Text = "选课查询";
            // 
            // 成绩录入ToolStripMenuItem
            // 
            this.成绩录入ToolStripMenuItem.Name = "成绩录入ToolStripMenuItem";
            this.成绩录入ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成绩录入ToolStripMenuItem.Text = "成绩录入";
            this.成绩录入ToolStripMenuItem.Click += new System.EventHandler(this.成绩录入ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // TeaMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 628);
            this.Controls.Add(this.sbEduTea);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeaMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【教务管理系统-教师用户】";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusBar sbEduTea;
        private System.Windows.Forms.StatusBarPanel statusBarPanel4;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel2;
        private System.Windows.Forms.ToolStripMenuItem 信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课表查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}