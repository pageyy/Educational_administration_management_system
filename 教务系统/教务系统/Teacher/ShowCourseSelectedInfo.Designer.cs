namespace 教务系统.Teacher
{
    partial class ShowCourseSelectedInfo
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
            this.dgvCourseElected = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCapicty = new System.Windows.Forms.Label();
            this.lblCapacityTxt = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblLeftTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseElected)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCourseElected
            // 
            this.dgvCourseElected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCourseElected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourseElected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseElected.Location = new System.Drawing.Point(6, 20);
            this.dgvCourseElected.Name = "dgvCourseElected";
            this.dgvCourseElected.ReadOnly = true;
            this.dgvCourseElected.RowTemplate.Height = 23;
            this.dgvCourseElected.Size = new System.Drawing.Size(815, 326);
            this.dgvCourseElected.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvCourseElected);
            this.groupBox1.Location = new System.Drawing.Point(0, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 352);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "【已选修该课程的学生】";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbName);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(6, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 90);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "【课程配置】";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(143, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "课程名称：";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(34, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(208, 36);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(175, 20);
            this.cmbName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLeftTxt);
            this.groupBox3.Controls.Add(this.lblLeft);
            this.groupBox3.Controls.Add(this.lblCapacityTxt);
            this.groupBox3.Controls.Add(this.lblCapicty);
            this.groupBox3.Location = new System.Drawing.Point(424, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 90);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "【课程配置】";
            // 
            // lblCapicty
            // 
            this.lblCapicty.AutoSize = true;
            this.lblCapicty.Location = new System.Drawing.Point(33, 39);
            this.lblCapicty.Name = "lblCapicty";
            this.lblCapicty.Size = new System.Drawing.Size(65, 12);
            this.lblCapicty.TabIndex = 0;
            this.lblCapicty.Text = "课程容量：";
            // 
            // lblCapacityTxt
            // 
            this.lblCapacityTxt.AutoSize = true;
            this.lblCapacityTxt.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCapacityTxt.Location = new System.Drawing.Point(112, 34);
            this.lblCapacityTxt.Name = "lblCapacityTxt";
            this.lblCapacityTxt.Size = new System.Drawing.Size(0, 19);
            this.lblCapacityTxt.TabIndex = 0;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(186, 39);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(65, 12);
            this.lblLeft.TabIndex = 0;
            this.lblLeft.Text = "剩余容量：";
            // 
            // lblLeftTxt
            // 
            this.lblLeftTxt.AutoSize = true;
            this.lblLeftTxt.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeftTxt.Location = new System.Drawing.Point(275, 36);
            this.lblLeftTxt.Name = "lblLeftTxt";
            this.lblLeftTxt.Size = new System.Drawing.Size(0, 19);
            this.lblLeftTxt.TabIndex = 0;
            // 
            // ShowCourseSelectedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 452);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowCourseSelectedInfo";
            this.Text = "【课程选修状态展示】";
            this.Load += new System.EventHandler(this.ShowCourseSelectedInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseElected)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourseElected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLeftTxt;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblCapacityTxt;
        private System.Windows.Forms.Label lblCapicty;
    }
}