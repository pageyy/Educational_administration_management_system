namespace 教务系统
{
    partial class StudentsInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsInfo));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbStudentsInfo = new System.Windows.Forms.ToolBar();
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
            this.gbStudentsInfo = new System.Windows.Forms.GroupBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dgvStudentsInfo = new System.Windows.Forms.DataGridView();
            this.学号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年级DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.政治面貌编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.民族编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.籍贯编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学籍编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eisbookDataSet = new 教务系统.eisbookDataSet();
            this.学生信息TableAdapter = new 教务系统.eisbookDataSetTableAdapters.学生信息TableAdapter();
            this.gbShow = new System.Windows.Forms.GroupBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb5 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb6 = new System.Windows.Forms.ComboBox();
            this.gbStudentsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生信息BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eisbookDataSet)).BeginInit();
            this.gbShow.SuspendLayout();
            this.SuspendLayout();
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
            // tbStudentsInfo
            // 
            this.tbStudentsInfo.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
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
            this.tbStudentsInfo.DropDownArrows = true;
            this.tbStudentsInfo.ImageList = this.imageList1;
            this.tbStudentsInfo.Location = new System.Drawing.Point(0, 0);
            this.tbStudentsInfo.Name = "tbStudentsInfo";
            this.tbStudentsInfo.ShowToolTips = true;
            this.tbStudentsInfo.Size = new System.Drawing.Size(728, 41);
            this.tbStudentsInfo.TabIndex = 0;
            this.tbStudentsInfo.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbStudentsInfo_ButtonClick);
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
            // gbStudentsInfo
            // 
            this.gbStudentsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStudentsInfo.Controls.Add(this.txt3);
            this.gbStudentsInfo.Controls.Add(this.txt2);
            this.gbStudentsInfo.Controls.Add(this.txt1);
            this.gbStudentsInfo.Controls.Add(this.lbl3);
            this.gbStudentsInfo.Controls.Add(this.lbl2);
            this.gbStudentsInfo.Controls.Add(this.lbl1);
            this.gbStudentsInfo.Controls.Add(this.btnSearch);
            this.gbStudentsInfo.Location = new System.Drawing.Point(0, 47);
            this.gbStudentsInfo.Name = "gbStudentsInfo";
            this.gbStudentsInfo.Size = new System.Drawing.Size(726, 50);
            this.gbStudentsInfo.TabIndex = 1;
            this.gbStudentsInfo.TabStop = false;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(535, 20);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 21);
            this.txt3.TabIndex = 6;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(371, 20);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 21);
            this.txt2.TabIndex = 5;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(210, 20);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 21);
            this.txt1.TabIndex = 4;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(500, 25);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(29, 12);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "年级";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(336, 25);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(29, 12);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "姓名";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(175, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(29, 12);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "学号";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageIndex = 10;
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(29, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "搜索";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=HEIMINGX-PC\\SQLEXPRESS;Initial Catalog=eisbook;Integrated Security=Tr" +
                "ue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dgvStudentsInfo
            // 
            this.dgvStudentsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudentsInfo.AutoGenerateColumns = false;
            this.dgvStudentsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.班级编号DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.年级DataGridViewTextBoxColumn,
            this.政治面貌编号DataGridViewTextBoxColumn,
            this.民族编号DataGridViewTextBoxColumn,
            this.籍贯编号DataGridViewTextBoxColumn,
            this.身份证号DataGridViewTextBoxColumn,
            this.学籍编号DataGridViewTextBoxColumn});
            this.dgvStudentsInfo.DataSource = this.学生信息BindingSource;
            this.dgvStudentsInfo.Location = new System.Drawing.Point(0, 103);
            this.dgvStudentsInfo.Name = "dgvStudentsInfo";
            this.dgvStudentsInfo.RowTemplate.Height = 23;
            this.dgvStudentsInfo.Size = new System.Drawing.Size(726, 282);
            this.dgvStudentsInfo.TabIndex = 2;
            this.dgvStudentsInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentsInfo_CellClick);
            // 
            // 学号DataGridViewTextBoxColumn
            // 
            this.学号DataGridViewTextBoxColumn.DataPropertyName = "学号";
            this.学号DataGridViewTextBoxColumn.HeaderText = "学号";
            this.学号DataGridViewTextBoxColumn.Name = "学号DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 班级编号DataGridViewTextBoxColumn
            // 
            this.班级编号DataGridViewTextBoxColumn.DataPropertyName = "班级编号";
            this.班级编号DataGridViewTextBoxColumn.HeaderText = "班级编号";
            this.班级编号DataGridViewTextBoxColumn.Name = "班级编号DataGridViewTextBoxColumn";
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            // 
            // 年级DataGridViewTextBoxColumn
            // 
            this.年级DataGridViewTextBoxColumn.DataPropertyName = "年级";
            this.年级DataGridViewTextBoxColumn.HeaderText = "年级";
            this.年级DataGridViewTextBoxColumn.Name = "年级DataGridViewTextBoxColumn";
            // 
            // 政治面貌编号DataGridViewTextBoxColumn
            // 
            this.政治面貌编号DataGridViewTextBoxColumn.DataPropertyName = "政治面貌编号";
            this.政治面貌编号DataGridViewTextBoxColumn.HeaderText = "政治面貌编号";
            this.政治面貌编号DataGridViewTextBoxColumn.Name = "政治面貌编号DataGridViewTextBoxColumn";
            // 
            // 民族编号DataGridViewTextBoxColumn
            // 
            this.民族编号DataGridViewTextBoxColumn.DataPropertyName = "民族编号";
            this.民族编号DataGridViewTextBoxColumn.HeaderText = "民族编号";
            this.民族编号DataGridViewTextBoxColumn.Name = "民族编号DataGridViewTextBoxColumn";
            // 
            // 籍贯编号DataGridViewTextBoxColumn
            // 
            this.籍贯编号DataGridViewTextBoxColumn.DataPropertyName = "籍贯编号";
            this.籍贯编号DataGridViewTextBoxColumn.HeaderText = "籍贯编号";
            this.籍贯编号DataGridViewTextBoxColumn.Name = "籍贯编号DataGridViewTextBoxColumn";
            // 
            // 身份证号DataGridViewTextBoxColumn
            // 
            this.身份证号DataGridViewTextBoxColumn.DataPropertyName = "身份证号";
            this.身份证号DataGridViewTextBoxColumn.HeaderText = "身份证号";
            this.身份证号DataGridViewTextBoxColumn.Name = "身份证号DataGridViewTextBoxColumn";
            // 
            // 学籍编号DataGridViewTextBoxColumn
            // 
            this.学籍编号DataGridViewTextBoxColumn.DataPropertyName = "学籍编号";
            this.学籍编号DataGridViewTextBoxColumn.HeaderText = "学籍编号";
            this.学籍编号DataGridViewTextBoxColumn.Name = "学籍编号DataGridViewTextBoxColumn";
            // 
            // 学生信息BindingSource
            // 
            this.学生信息BindingSource.DataMember = "学生信息";
            this.学生信息BindingSource.DataSource = this.eisbookDataSet;
            // 
            // eisbookDataSet
            // 
            this.eisbookDataSet.DataSetName = "eisbookDataSet";
            this.eisbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 学生信息TableAdapter
            // 
            this.学生信息TableAdapter.ClearBeforeFill = true;
            // 
            // gbShow
            // 
            this.gbShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbShow.Controls.Add(this.cmb1);
            this.gbShow.Controls.Add(this.txt4);
            this.gbShow.Controls.Add(this.label4);
            this.gbShow.Controls.Add(this.txt5);
            this.gbShow.Controls.Add(this.label5);
            this.gbShow.Controls.Add(this.label6);
            this.gbShow.Controls.Add(this.txt7);
            this.gbShow.Controls.Add(this.txt6);
            this.gbShow.Controls.Add(this.label9);
            this.gbShow.Controls.Add(this.label7);
            this.gbShow.Controls.Add(this.cmb2);
            this.gbShow.Controls.Add(this.label8);
            this.gbShow.Controls.Add(this.label10);
            this.gbShow.Controls.Add(this.cmb3);
            this.gbShow.Controls.Add(this.label11);
            this.gbShow.Controls.Add(this.cmb4);
            this.gbShow.Controls.Add(this.label12);
            this.gbShow.Controls.Add(this.cmb5);
            this.gbShow.Controls.Add(this.label13);
            this.gbShow.Controls.Add(this.cmb6);
            this.gbShow.Location = new System.Drawing.Point(0, 387);
            this.gbShow.Name = "gbShow";
            this.gbShow.Size = new System.Drawing.Size(726, 145);
            this.gbShow.TabIndex = 3;
            this.gbShow.TabStop = false;
            // 
            // cmb1
            // 
            this.cmb1.Enabled = false;
            this.cmb1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmb1.Location = new System.Drawing.Point(303, 46);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(88, 20);
            this.cmb1.TabIndex = 28;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(23, 46);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(112, 21);
            this.txt4.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "学号";
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(159, 46);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(120, 21);
            this.txt5.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(159, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "姓名";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(303, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "性别";
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(23, 94);
            this.txt7.Name = "txt7";
            this.txt7.ReadOnly = true;
            this.txt7.Size = new System.Drawing.Size(136, 21);
            this.txt7.TabIndex = 24;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(423, 46);
            this.txt6.Name = "txt6";
            this.txt6.ReadOnly = true;
            this.txt6.Size = new System.Drawing.Size(136, 21);
            this.txt6.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(423, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "年级";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(23, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "身份证编号";
            // 
            // cmb2
            // 
            this.cmb2.Enabled = false;
            this.cmb2.Location = new System.Drawing.Point(575, 46);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(128, 20);
            this.cmb2.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(575, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "班级";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(191, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "政治面貌";
            // 
            // cmb3
            // 
            this.cmb3.Enabled = false;
            this.cmb3.Location = new System.Drawing.Point(191, 94);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(128, 20);
            this.cmb3.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(351, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "民族";
            // 
            // cmb4
            // 
            this.cmb4.Enabled = false;
            this.cmb4.Location = new System.Drawing.Point(351, 94);
            this.cmb4.Name = "cmb4";
            this.cmb4.Size = new System.Drawing.Size(88, 20);
            this.cmb4.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(471, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "籍贯";
            // 
            // cmb5
            // 
            this.cmb5.Enabled = false;
            this.cmb5.Location = new System.Drawing.Point(471, 94);
            this.cmb5.Name = "cmb5";
            this.cmb5.Size = new System.Drawing.Size(104, 20);
            this.cmb5.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(599, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "学籍";
            // 
            // cmb6
            // 
            this.cmb6.Enabled = false;
            this.cmb6.Location = new System.Drawing.Point(599, 94);
            this.cmb6.Name = "cmb6";
            this.cmb6.Size = new System.Drawing.Size(104, 20);
            this.cmb6.TabIndex = 26;
            // 
            // StudentsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 532);
            this.Controls.Add(this.gbShow);
            this.Controls.Add(this.dgvStudentsInfo);
            this.Controls.Add(this.gbStudentsInfo);
            this.Controls.Add(this.tbStudentsInfo);
            this.Name = "StudentsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【学生信息维护】";
            this.Load += new System.EventHandler(this.StudentsInfo_Load);
            this.gbStudentsInfo.ResumeLayout(false);
            this.gbStudentsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生信息BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eisbookDataSet)).EndInit();
            this.gbShow.ResumeLayout(false);
            this.gbShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBar tbStudentsInfo;
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
        private System.Windows.Forms.GroupBox gbStudentsInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.DataGridView dgvStudentsInfo;
        private eisbookDataSet eisbookDataSet;
        private System.Windows.Forms.BindingSource 学生信息BindingSource;
        private eisbookDataSetTableAdapters.学生信息TableAdapter 学生信息TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年级DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 政治面貌编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 民族编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 籍贯编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学籍编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbShow;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb6;
    }
}