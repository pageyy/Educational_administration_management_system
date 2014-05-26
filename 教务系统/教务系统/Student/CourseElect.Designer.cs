namespace 教务系统
{
    partial class CourseElect
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseElect));
            this.gbCourseElect = new System.Windows.Forms.GroupBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgvElectedCourse = new System.Windows.Forms.DataGridView();
            this.gbElect = new System.Windows.Forms.GroupBox();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.gpbShuru = new System.Windows.Forms.GroupBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnElect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.gbCourseElect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElectedCourse)).BeginInit();
            this.gbElect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.gpbShuru.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCourseElect
            // 
            this.gbCourseElect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCourseElect.Controls.Add(this.txt3);
            this.gbCourseElect.Controls.Add(this.txt2);
            this.gbCourseElect.Controls.Add(this.txt1);
            this.gbCourseElect.Controls.Add(this.lbl3);
            this.gbCourseElect.Controls.Add(this.lbl2);
            this.gbCourseElect.Controls.Add(this.lbl1);
            this.gbCourseElect.Location = new System.Drawing.Point(3, 3);
            this.gbCourseElect.Name = "gbCourseElect";
            this.gbCourseElect.Size = new System.Drawing.Size(721, 55);
            this.gbCourseElect.TabIndex = 0;
            this.gbCourseElect.TabStop = false;
            this.gbCourseElect.Text = "学生信息";
            // 
            // txt3
            // 
            this.txt3.Enabled = false;
            this.txt3.Location = new System.Drawing.Point(478, 21);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 21);
            this.txt3.TabIndex = 5;
            // 
            // txt2
            // 
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(291, 21);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 21);
            this.txt2.TabIndex = 4;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(111, 21);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 21);
            this.txt1.TabIndex = 3;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(443, 24);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(29, 12);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "班级";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(256, 24);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(29, 12);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "姓名";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(76, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(29, 12);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "学号";
            // 
            // dgvElectedCourse
            // 
            this.dgvElectedCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvElectedCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElectedCourse.Location = new System.Drawing.Point(3, 64);
            this.dgvElectedCourse.Name = "dgvElectedCourse";
            this.dgvElectedCourse.RowTemplate.Height = 23;
            this.dgvElectedCourse.Size = new System.Drawing.Size(721, 207);
            this.dgvElectedCourse.TabIndex = 1;
            // 
            // gbElect
            // 
            this.gbElect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbElect.Controls.Add(this.dgvCourse);
            this.gbElect.Controls.Add(this.gpbShuru);
            this.gbElect.Location = new System.Drawing.Point(3, 277);
            this.gbElect.Name = "gbElect";
            this.gbElect.Size = new System.Drawing.Size(721, 243);
            this.gbElect.TabIndex = 2;
            this.gbElect.TabStop = false;
            this.gbElect.Text = "课程信息";
            // 
            // dgvCourse
            // 
            this.dgvCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Location = new System.Drawing.Point(232, 20);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.RowTemplate.Height = 23;
            this.dgvCourse.Size = new System.Drawing.Size(483, 217);
            this.dgvCourse.TabIndex = 1;
            // 
            // gpbShuru
            // 
            this.gpbShuru.Controls.Add(this.txt7);
            this.gpbShuru.Controls.Add(this.txt6);
            this.gpbShuru.Controls.Add(this.txt5);
            this.gpbShuru.Controls.Add(this.txt4);
            this.gpbShuru.Controls.Add(this.btnView);
            this.gpbShuru.Controls.Add(this.btnDelete);
            this.gpbShuru.Controls.Add(this.btnElect);
            this.gpbShuru.Controls.Add(this.btnSearch);
            this.gpbShuru.Controls.Add(this.lbl7);
            this.gpbShuru.Controls.Add(this.lbl6);
            this.gpbShuru.Controls.Add(this.lbl5);
            this.gpbShuru.Controls.Add(this.lbl4);
            this.gpbShuru.Location = new System.Drawing.Point(11, 20);
            this.gpbShuru.Name = "gpbShuru";
            this.gpbShuru.Size = new System.Drawing.Size(215, 217);
            this.gpbShuru.TabIndex = 0;
            this.gpbShuru.TabStop = false;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(69, 97);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(100, 21);
            this.txt7.TabIndex = 8;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(69, 70);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(100, 21);
            this.txt6.TabIndex = 7;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(69, 43);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 21);
            this.txt5.TabIndex = 6;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(69, 16);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 21);
            this.txt4.TabIndex = 5;
            // 
            // btnView
            // 
            this.btnView.Enabled = false;
            this.btnView.ImageIndex = 3;
            this.btnView.ImageList = this.imageList1;
            this.btnView.Location = new System.Drawing.Point(112, 178);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(69, 24);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "看课表";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "搜索.bmp");
            this.imageList1.Images.SetKeyName(1, "保存.bmp");
            this.imageList1.Images.SetKeyName(2, "删除.bmp");
            this.imageList1.Images.SetKeyName(3, "查询选择.bmp");
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(12, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 25);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删课";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnElect
            // 
            this.btnElect.Enabled = false;
            this.btnElect.ImageIndex = 1;
            this.btnElect.ImageList = this.imageList1;
            this.btnElect.Location = new System.Drawing.Point(112, 138);
            this.btnElect.Name = "btnElect";
            this.btnElect.Size = new System.Drawing.Size(69, 25);
            this.btnElect.TabIndex = 4;
            this.btnElect.Text = "选课";
            this.btnElect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnElect.UseVisualStyleBackColor = true;
            this.btnElect.Click += new System.EventHandler(this.btnElect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(12, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(22, 100);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(41, 12);
            this.lbl7.TabIndex = 3;
            this.lbl7.Text = "课序号";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(10, 73);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(53, 12);
            this.lbl6.TabIndex = 2;
            this.lbl6.Text = "课程编号";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(10, 46);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(53, 12);
            this.lbl5.TabIndex = 1;
            this.lbl5.Text = "课程名称";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(10, 19);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(53, 12);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "课程拼音";
            // 
            // CourseElect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 532);
            this.Controls.Add(this.gbElect);
            this.Controls.Add(this.dgvElectedCourse);
            this.Controls.Add(this.gbCourseElect);
            this.Name = "CourseElect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【学生选课】";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CourseElect_Load);
            this.gbCourseElect.ResumeLayout(false);
            this.gbCourseElect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElectedCourse)).EndInit();
            this.gbElect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.gpbShuru.ResumeLayout(false);
            this.gpbShuru.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCourseElect;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dgvElectedCourse;
        private System.Windows.Forms.GroupBox gbElect;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.GroupBox gpbShuru;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnElect;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ImageList imageList1;
    }
}