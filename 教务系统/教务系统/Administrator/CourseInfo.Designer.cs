namespace 教务系统
{
    partial class CourseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbCourseInfo = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
            this.dgvCourseInfo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.课程编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程简称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.拼音码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.本学期课程DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.教师DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开课系别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学分DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程信息bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eisbookDataSet = new 教务系统.eisbookDataSet();
            this.课程信息TableAdapter = new 教务系统.eisbookDataSetTableAdapters.课程信息TableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.课程信息bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eisbookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(0, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(536, 20);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 21);
            this.txt3.TabIndex = 12;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(360, 20);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 21);
            this.txt2.TabIndex = 11;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(175, 20);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 21);
            this.txt1.TabIndex = 10;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(489, 25);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(41, 12);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "拼音码";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(301, 25);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 12);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "课程名称";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(116, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 12);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "课程编号";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageKey = "搜索.bmp";
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(12, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "搜索";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "首记录.bmp");
            this.imageList1.Images.SetKeyName(1, "上记录.bmp");
            this.imageList1.Images.SetKeyName(2, "下记录.bmp");
            this.imageList1.Images.SetKeyName(3, "尾记录.bmp");
            this.imageList1.Images.SetKeyName(4, "新增.bmp");
            this.imageList1.Images.SetKeyName(5, "修改.bmp");
            this.imageList1.Images.SetKeyName(6, "删除.bmp");
            this.imageList1.Images.SetKeyName(7, "保存.bmp");
            this.imageList1.Images.SetKeyName(8, "取消.bmp");
            this.imageList1.Images.SetKeyName(9, "退出.bmp");
            this.imageList1.Images.SetKeyName(10, "搜索.bmp");
            // 
            // tbCourseInfo
            // 
            this.tbCourseInfo.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3,
            this.toolBarButton4,
            this.toolBarButton5,
            this.toolBarButton6,
            this.toolBarButton7,
            this.toolBarButton8,
            this.toolBarButton9,
            this.toolBarButton10});
            this.tbCourseInfo.DropDownArrows = true;
            this.tbCourseInfo.ImageList = this.imageList1;
            this.tbCourseInfo.Location = new System.Drawing.Point(0, 0);
            this.tbCourseInfo.Name = "tbCourseInfo";
            this.tbCourseInfo.ShowToolTips = true;
            this.tbCourseInfo.Size = new System.Drawing.Size(929, 41);
            this.tbCourseInfo.TabIndex = 1;
            this.tbCourseInfo.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbCourseInfo_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Text = "首记录";
            this.toolBarButton1.ToolTipText = "首记录";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Text = "上一记录";
            this.toolBarButton2.ToolTipText = "上一记录";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Text = "下一记录";
            this.toolBarButton3.ToolTipText = "下一记录";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.ImageIndex = 3;
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Text = "尾记录";
            this.toolBarButton4.ToolTipText = "尾记录";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.ImageIndex = 4;
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Text = "新增";
            this.toolBarButton5.ToolTipText = "新增";
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.ImageIndex = 5;
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.Text = "修改";
            this.toolBarButton6.ToolTipText = "修改";
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.ImageIndex = 6;
            this.toolBarButton7.Name = "toolBarButton7";
            this.toolBarButton7.Text = "删除";
            this.toolBarButton7.ToolTipText = "删除";
            // 
            // toolBarButton8
            // 
            this.toolBarButton8.ImageIndex = 7;
            this.toolBarButton8.Name = "toolBarButton8";
            this.toolBarButton8.Text = "提交";
            this.toolBarButton8.ToolTipText = "提交";
            // 
            // toolBarButton9
            // 
            this.toolBarButton9.ImageIndex = 8;
            this.toolBarButton9.Name = "toolBarButton9";
            this.toolBarButton9.Text = "取消";
            this.toolBarButton9.ToolTipText = "取消";
            // 
            // toolBarButton10
            // 
            this.toolBarButton10.ImageIndex = 9;
            this.toolBarButton10.Name = "toolBarButton10";
            this.toolBarButton10.Text = "退出";
            this.toolBarButton10.ToolTipText = "退出";
            // 
            // dgvCourseInfo
            // 
            this.dgvCourseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCourseInfo.AutoGenerateColumns = false;
            this.dgvCourseInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourseInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.课程编号DataGridViewTextBoxColumn,
            this.课程名称DataGridViewTextBoxColumn,
            this.课程简称DataGridViewTextBoxColumn,
            this.拼音码DataGridViewTextBoxColumn,
            this.本学期课程DataGridViewTextBoxColumn,
            this.教师DataGridViewTextBoxColumn,
            this.开课系别DataGridViewTextBoxColumn,
            this.学分DataGridViewTextBoxColumn});
            this.dgvCourseInfo.DataSource = this.课程信息bindingSource;
            this.dgvCourseInfo.Location = new System.Drawing.Point(0, 103);
            this.dgvCourseInfo.Name = "dgvCourseInfo";
            this.dgvCourseInfo.RowTemplate.Height = 23;
            this.dgvCourseInfo.Size = new System.Drawing.Size(927, 282);
            this.dgvCourseInfo.TabIndex = 2;
            this.dgvCourseInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourseInfo_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cmb1);
            this.groupBox2.Controls.Add(this.txt4);
            this.groupBox2.Controls.Add(this.txt5);
            this.groupBox2.Controls.Add(this.txt6);
            this.groupBox2.Controls.Add(this.txt9);
            this.groupBox2.Controls.Add(this.txt8);
            this.groupBox2.Controls.Add(this.txt7);
            this.groupBox2.Controls.Add(this.lbl4);
            this.groupBox2.Controls.Add(this.lbl5);
            this.groupBox2.Controls.Add(this.lbl6);
            this.groupBox2.Controls.Add(this.lbl7);
            this.groupBox2.Controls.Add(this.lbl8);
            this.groupBox2.Controls.Add(this.lbl9);
            this.groupBox2.Controls.Add(this.txt10);
            this.groupBox2.Controls.Add(this.lbl10);
            this.groupBox2.Controls.Add(this.lbl11);
            this.groupBox2.Location = new System.Drawing.Point(0, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(927, 145);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // cmb1
            // 
            this.cmb1.Enabled = false;
            this.cmb1.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cmb1.Location = new System.Drawing.Point(531, 95);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 20);
            this.cmb1.TabIndex = 30;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(75, 45);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(136, 21);
            this.txt4.TabIndex = 25;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(243, 45);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(216, 21);
            this.txt5.TabIndex = 24;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(483, 45);
            this.txt6.Name = "txt6";
            this.txt6.ReadOnly = true;
            this.txt6.Size = new System.Drawing.Size(168, 21);
            this.txt6.TabIndex = 23;
            // 
            // txt9
            // 
            this.txt9.Location = new System.Drawing.Point(291, 93);
            this.txt9.Name = "txt9";
            this.txt9.ReadOnly = true;
            this.txt9.Size = new System.Drawing.Size(136, 21);
            this.txt9.TabIndex = 29;
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(163, 93);
            this.txt8.Name = "txt8";
            this.txt8.ReadOnly = true;
            this.txt8.Size = new System.Drawing.Size(104, 21);
            this.txt8.TabIndex = 27;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(75, 93);
            this.txt7.Name = "txt7";
            this.txt7.ReadOnly = true;
            this.txt7.Size = new System.Drawing.Size(64, 21);
            this.txt7.TabIndex = 26;
            // 
            // lbl4
            // 
            this.lbl4.Location = new System.Drawing.Point(75, 29);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(100, 16);
            this.lbl4.TabIndex = 17;
            this.lbl4.Text = "课程编号";
            // 
            // lbl5
            // 
            this.lbl5.Location = new System.Drawing.Point(243, 29);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(100, 16);
            this.lbl5.TabIndex = 16;
            this.lbl5.Text = "课程名称";
            // 
            // lbl6
            // 
            this.lbl6.Location = new System.Drawing.Point(483, 29);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(100, 16);
            this.lbl6.TabIndex = 15;
            this.lbl6.Text = "课程简称";
            // 
            // lbl7
            // 
            this.lbl7.Location = new System.Drawing.Point(291, 79);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(100, 16);
            this.lbl7.TabIndex = 20;
            this.lbl7.Text = "开课系别";
            // 
            // lbl8
            // 
            this.lbl8.Location = new System.Drawing.Point(163, 79);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(100, 16);
            this.lbl8.TabIndex = 19;
            this.lbl8.Text = "教师";
            // 
            // lbl9
            // 
            this.lbl9.Location = new System.Drawing.Point(75, 79);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(82, 14);
            this.lbl9.TabIndex = 18;
            this.lbl9.Text = "拼音码";
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(451, 95);
            this.txt10.Name = "txt10";
            this.txt10.ReadOnly = true;
            this.txt10.Size = new System.Drawing.Size(56, 21);
            this.txt10.TabIndex = 28;
            // 
            // lbl10
            // 
            this.lbl10.Location = new System.Drawing.Point(451, 79);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(32, 16);
            this.lbl10.TabIndex = 21;
            this.lbl10.Text = "学分";
            // 
            // lbl11
            // 
            this.lbl11.Location = new System.Drawing.Point(531, 79);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(96, 16);
            this.lbl11.TabIndex = 22;
            this.lbl11.Text = "是否本学期课程";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=HEIMINGX-PC\\SQLEXPRESS;Initial Catalog=eisbook;Integrated Security=Tr" +
                "ue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // 课程编号DataGridViewTextBoxColumn
            // 
            this.课程编号DataGridViewTextBoxColumn.DataPropertyName = "课程编号";
            this.课程编号DataGridViewTextBoxColumn.HeaderText = "课程编号";
            this.课程编号DataGridViewTextBoxColumn.Name = "课程编号DataGridViewTextBoxColumn";
            // 
            // 课程名称DataGridViewTextBoxColumn
            // 
            this.课程名称DataGridViewTextBoxColumn.DataPropertyName = "课程名称";
            this.课程名称DataGridViewTextBoxColumn.HeaderText = "课程名称";
            this.课程名称DataGridViewTextBoxColumn.Name = "课程名称DataGridViewTextBoxColumn";
            // 
            // 课程简称DataGridViewTextBoxColumn
            // 
            this.课程简称DataGridViewTextBoxColumn.DataPropertyName = "课程简称";
            this.课程简称DataGridViewTextBoxColumn.HeaderText = "课程简称";
            this.课程简称DataGridViewTextBoxColumn.Name = "课程简称DataGridViewTextBoxColumn";
            // 
            // 拼音码DataGridViewTextBoxColumn
            // 
            this.拼音码DataGridViewTextBoxColumn.DataPropertyName = "拼音码";
            this.拼音码DataGridViewTextBoxColumn.HeaderText = "拼音码";
            this.拼音码DataGridViewTextBoxColumn.Name = "拼音码DataGridViewTextBoxColumn";
            // 
            // 本学期课程DataGridViewTextBoxColumn
            // 
            this.本学期课程DataGridViewTextBoxColumn.DataPropertyName = "本学期课程";
            this.本学期课程DataGridViewTextBoxColumn.HeaderText = "本学期课程";
            this.本学期课程DataGridViewTextBoxColumn.Name = "本学期课程DataGridViewTextBoxColumn";
            // 
            // 教师DataGridViewTextBoxColumn
            // 
            this.教师DataGridViewTextBoxColumn.DataPropertyName = "教师";
            this.教师DataGridViewTextBoxColumn.HeaderText = "教师";
            this.教师DataGridViewTextBoxColumn.Name = "教师DataGridViewTextBoxColumn";
            // 
            // 开课系别DataGridViewTextBoxColumn
            // 
            this.开课系别DataGridViewTextBoxColumn.DataPropertyName = "开课系别";
            this.开课系别DataGridViewTextBoxColumn.HeaderText = "开课系别";
            this.开课系别DataGridViewTextBoxColumn.Name = "开课系别DataGridViewTextBoxColumn";
            // 
            // 学分DataGridViewTextBoxColumn
            // 
            this.学分DataGridViewTextBoxColumn.DataPropertyName = "学分";
            this.学分DataGridViewTextBoxColumn.HeaderText = "学分";
            this.学分DataGridViewTextBoxColumn.Name = "学分DataGridViewTextBoxColumn";
            // 
            // 课程信息bindingSource
            // 
            this.课程信息bindingSource.AllowNew = true;
            this.课程信息bindingSource.DataMember = "课程信息";
            this.课程信息bindingSource.DataSource = this.eisbookDataSet;
            // 
            // eisbookDataSet
            // 
            this.eisbookDataSet.DataSetName = "eisbookDataSet";
            this.eisbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 课程信息TableAdapter
            // 
            this.课程信息TableAdapter.ClearBeforeFill = true;
            // 
            // CourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCourseInfo);
            this.Controls.Add(this.tbCourseInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "CourseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【课程信息维护】";
            this.Load += new System.EventHandler(this.CourseInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.课程信息bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eisbookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolBar tbCourseInfo;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.ToolBarButton toolBarButton4;
        private System.Windows.Forms.ToolBarButton toolBarButton5;
        private System.Windows.Forms.ToolBarButton toolBarButton6;
        private System.Windows.Forms.ToolBarButton toolBarButton7;
        private System.Windows.Forms.ToolBarButton toolBarButton8;
        private System.Windows.Forms.ToolBarButton toolBarButton9;
        private System.Windows.Forms.ToolBarButton toolBarButton10;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dgvCourseInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.BindingSource 课程信息bindingSource;
        private eisbookDataSet eisbookDataSet;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private eisbookDataSetTableAdapters.课程信息TableAdapter 课程信息TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程简称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 拼音码DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 本学期课程DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教师DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开课系别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学分DataGridViewTextBoxColumn;
    }
}