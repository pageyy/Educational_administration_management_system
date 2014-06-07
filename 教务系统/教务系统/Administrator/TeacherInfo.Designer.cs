namespace 教务系统.Administrator
{
    partial class TeacherInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherInfo));
            this.tbTeacherInfo = new System.Windows.Forms.ToolBar();
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbStudentsInfo = new System.Windows.Forms.GroupBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchNo = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblSearchNo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTeacherInfo = new System.Windows.Forms.DataGridView();
            this.gpbTeacherInfo = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teachersInfoDateSet = new 教务系统.TeachersInfoDateSet();
            this.教师信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.教师信息TableAdapter = new 教务系统.TeachersInfoDateSetTableAdapters.教师信息TableAdapter();
            this.职工号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职称编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.政治面貌编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.民族编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.籍贯编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblZhiGongHao = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblZhiChen = new System.Windows.Forms.Label();
            this.cmbZhiChen = new System.Windows.Forms.ComboBox();
            this.cmbZhengzhimianmao = new System.Windows.Forms.ComboBox();
            this.lblZhengZhiMianMao = new System.Windows.Forms.Label();
            this.cmbMinzu = new System.Windows.Forms.ComboBox();
            this.lblMinzu = new System.Windows.Forms.Label();
            this.cmbJiguan = new System.Windows.Forms.ComboBox();
            this.lblJiguan = new System.Windows.Forms.Label();
            this.txtShenfenzheng = new System.Windows.Forms.TextBox();
            this.lblShenfenzheng = new System.Windows.Forms.Label();
            this.gbStudentsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherInfo)).BeginInit();
            this.gpbTeacherInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersInfoDateSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.教师信息BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTeacherInfo
            // 
            this.tbTeacherInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTeacherInfo.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
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
            this.tbTeacherInfo.Dock = System.Windows.Forms.DockStyle.None;
            this.tbTeacherInfo.DropDownArrows = true;
            this.tbTeacherInfo.ImageList = this.imageList1;
            this.tbTeacherInfo.Location = new System.Drawing.Point(0, 0);
            this.tbTeacherInfo.Name = "tbTeacherInfo";
            this.tbTeacherInfo.ShowToolTips = true;
            this.tbTeacherInfo.Size = new System.Drawing.Size(991, 41);
            this.tbTeacherInfo.TabIndex = 1;
            this.tbTeacherInfo.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbTeacherInfo_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageKey = "首记录.bmp";
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Text = "首记录";
            this.toolBarButton1.ToolTipText = "首记录";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageKey = "上记录.bmp";
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Text = "上一记录";
            this.toolBarButton2.ToolTipText = "上一记录";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageKey = "下记录.bmp";
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Text = "下一记录";
            this.toolBarButton3.ToolTipText = "下一记录";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.ImageKey = "尾记录.bmp";
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Text = "尾记录";
            this.toolBarButton4.ToolTipText = "尾记录";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.ImageKey = "新增.bmp";
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Text = "新增";
            this.toolBarButton5.ToolTipText = "新增";
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.ImageKey = "修改.bmp";
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.Text = "修改";
            this.toolBarButton6.ToolTipText = "修改";
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.ImageKey = "删除.bmp";
            this.toolBarButton7.Name = "toolBarButton7";
            this.toolBarButton7.Text = "删除";
            this.toolBarButton7.ToolTipText = "删除";
            // 
            // toolBarButton8
            // 
            this.toolBarButton8.ImageKey = "保存.bmp";
            this.toolBarButton8.Name = "toolBarButton8";
            this.toolBarButton8.Text = "提交";
            this.toolBarButton8.ToolTipText = "提交";
            // 
            // toolBarButton9
            // 
            this.toolBarButton9.ImageKey = "取消.bmp";
            this.toolBarButton9.Name = "toolBarButton9";
            this.toolBarButton9.Text = "取消";
            this.toolBarButton9.ToolTipText = "取消";
            // 
            // toolBarButton10
            // 
            this.toolBarButton10.ImageKey = "退出.bmp";
            this.toolBarButton10.Name = "toolBarButton10";
            this.toolBarButton10.Text = "退出";
            this.toolBarButton10.ToolTipText = "退出";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "保存.bmp");
            this.imageList1.Images.SetKeyName(1, "查询选择.bmp");
            this.imageList1.Images.SetKeyName(2, "取消.bmp");
            this.imageList1.Images.SetKeyName(3, "删除.bmp");
            this.imageList1.Images.SetKeyName(4, "上记录.bmp");
            this.imageList1.Images.SetKeyName(5, "首记录.bmp");
            this.imageList1.Images.SetKeyName(6, "搜索.bmp");
            this.imageList1.Images.SetKeyName(7, "退出.bmp");
            this.imageList1.Images.SetKeyName(8, "尾记录.bmp");
            this.imageList1.Images.SetKeyName(9, "下记录.bmp");
            this.imageList1.Images.SetKeyName(10, "新增.bmp");
            this.imageList1.Images.SetKeyName(11, "修改.bmp");
            // 
            // gbStudentsInfo
            // 
            this.gbStudentsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStudentsInfo.Controls.Add(this.txtSearchName);
            this.gbStudentsInfo.Controls.Add(this.txtSearchNo);
            this.gbStudentsInfo.Controls.Add(this.lblSearchName);
            this.gbStudentsInfo.Controls.Add(this.lblSearchNo);
            this.gbStudentsInfo.Controls.Add(this.btnSearch);
            this.gbStudentsInfo.Location = new System.Drawing.Point(2, 47);
            this.gbStudentsInfo.Name = "gbStudentsInfo";
            this.gbStudentsInfo.Size = new System.Drawing.Size(989, 50);
            this.gbStudentsInfo.TabIndex = 2;
            this.gbStudentsInfo.TabStop = false;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(371, 20);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(100, 21);
            this.txtSearchName.TabIndex = 5;
            // 
            // txtSearchNo
            // 
            this.txtSearchNo.Location = new System.Drawing.Point(210, 20);
            this.txtSearchNo.Name = "txtSearchNo";
            this.txtSearchNo.Size = new System.Drawing.Size(100, 21);
            this.txtSearchNo.TabIndex = 4;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(336, 25);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(29, 12);
            this.lblSearchName.TabIndex = 2;
            this.lblSearchName.Text = "姓名";
            // 
            // lblSearchNo
            // 
            this.lblSearchNo.AutoSize = true;
            this.lblSearchNo.Location = new System.Drawing.Point(166, 24);
            this.lblSearchNo.Name = "lblSearchNo";
            this.lblSearchNo.Size = new System.Drawing.Size(41, 12);
            this.lblSearchNo.TabIndex = 1;
            this.lblSearchNo.Text = "职工号";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageIndex = 6;
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
            // dgvTeacherInfo
            // 
            this.dgvTeacherInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeacherInfo.AutoGenerateColumns = false;
            this.dgvTeacherInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.职工号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.职称编号DataGridViewTextBoxColumn,
            this.政治面貌编号DataGridViewTextBoxColumn,
            this.民族编号DataGridViewTextBoxColumn,
            this.籍贯编号DataGridViewTextBoxColumn,
            this.身份证号DataGridViewTextBoxColumn});
            this.dgvTeacherInfo.DataSource = this.教师信息BindingSource;
            this.dgvTeacherInfo.Location = new System.Drawing.Point(0, 103);
            this.dgvTeacherInfo.Name = "dgvTeacherInfo";
            this.dgvTeacherInfo.RowTemplate.Height = 23;
            this.dgvTeacherInfo.Size = new System.Drawing.Size(991, 285);
            this.dgvTeacherInfo.TabIndex = 3;
            this.dgvTeacherInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacherInfo_CellClick);
            // 
            // gpbTeacherInfo
            // 
            this.gpbTeacherInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbTeacherInfo.Controls.Add(this.txtShenfenzheng);
            this.gpbTeacherInfo.Controls.Add(this.lblShenfenzheng);
            this.gpbTeacherInfo.Controls.Add(this.cmbJiguan);
            this.gpbTeacherInfo.Controls.Add(this.lblJiguan);
            this.gpbTeacherInfo.Controls.Add(this.cmbMinzu);
            this.gpbTeacherInfo.Controls.Add(this.lblMinzu);
            this.gpbTeacherInfo.Controls.Add(this.cmbZhengzhimianmao);
            this.gpbTeacherInfo.Controls.Add(this.lblZhengZhiMianMao);
            this.gpbTeacherInfo.Controls.Add(this.cmbZhiChen);
            this.gpbTeacherInfo.Controls.Add(this.lblZhiChen);
            this.gpbTeacherInfo.Controls.Add(this.cmbGender);
            this.gpbTeacherInfo.Controls.Add(this.lblGender);
            this.gpbTeacherInfo.Controls.Add(this.txtName);
            this.gpbTeacherInfo.Controls.Add(this.lblName);
            this.gpbTeacherInfo.Controls.Add(this.txtNo);
            this.gpbTeacherInfo.Controls.Add(this.lblZhiGongHao);
            this.gpbTeacherInfo.Location = new System.Drawing.Point(2, 394);
            this.gpbTeacherInfo.Name = "gpbTeacherInfo";
            this.gpbTeacherInfo.Size = new System.Drawing.Size(989, 126);
            this.gpbTeacherInfo.TabIndex = 4;
            this.gpbTeacherInfo.TabStop = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.teachersInfoDateSet;
            this.bindingSource1.Position = 0;
            // 
            // teachersInfoDateSet
            // 
            this.teachersInfoDateSet.DataSetName = "TeachersInfoDateSet";
            this.teachersInfoDateSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 教师信息BindingSource
            // 
            this.教师信息BindingSource.DataMember = "教师信息";
            this.教师信息BindingSource.DataSource = this.bindingSource1;
            // 
            // 教师信息TableAdapter
            // 
            this.教师信息TableAdapter.ClearBeforeFill = true;
            // 
            // 职工号DataGridViewTextBoxColumn
            // 
            this.职工号DataGridViewTextBoxColumn.DataPropertyName = "职工号";
            this.职工号DataGridViewTextBoxColumn.HeaderText = "职工号";
            this.职工号DataGridViewTextBoxColumn.Name = "职工号DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            // 
            // 职称编号DataGridViewTextBoxColumn
            // 
            this.职称编号DataGridViewTextBoxColumn.DataPropertyName = "职称编号";
            this.职称编号DataGridViewTextBoxColumn.HeaderText = "职称编号";
            this.职称编号DataGridViewTextBoxColumn.Name = "职称编号DataGridViewTextBoxColumn";
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
            // lblZhiGongHao
            // 
            this.lblZhiGongHao.AutoSize = true;
            this.lblZhiGongHao.Location = new System.Drawing.Point(43, 21);
            this.lblZhiGongHao.Name = "lblZhiGongHao";
            this.lblZhiGongHao.Size = new System.Drawing.Size(41, 12);
            this.lblZhiGongHao.TabIndex = 0;
            this.lblZhiGongHao.Text = "职工号";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(43, 36);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(115, 21);
            this.txtNo.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 36);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(115, 21);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(193, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名";
            // 
            // cmbGender
            // 
            this.cmbGender.Enabled = false;
            this.cmbGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbGender.Location = new System.Drawing.Point(346, 36);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(135, 20);
            this.cmbGender.TabIndex = 30;
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(346, 20);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 15);
            this.lblGender.TabIndex = 29;
            this.lblGender.Text = "性别";
            // 
            // lblZhiChen
            // 
            this.lblZhiChen.AutoSize = true;
            this.lblZhiChen.Location = new System.Drawing.Point(509, 20);
            this.lblZhiChen.Name = "lblZhiChen";
            this.lblZhiChen.Size = new System.Drawing.Size(29, 12);
            this.lblZhiChen.TabIndex = 31;
            this.lblZhiChen.Text = "职称";
            // 
            // cmbZhiChen
            // 
            this.cmbZhiChen.Enabled = false;
            this.cmbZhiChen.FormattingEnabled = true;
            this.cmbZhiChen.Location = new System.Drawing.Point(510, 36);
            this.cmbZhiChen.Name = "cmbZhiChen";
            this.cmbZhiChen.Size = new System.Drawing.Size(121, 20);
            this.cmbZhiChen.TabIndex = 32;
            // 
            // cmbZhengzhimianmao
            // 
            this.cmbZhengzhimianmao.Enabled = false;
            this.cmbZhengzhimianmao.FormattingEnabled = true;
            this.cmbZhengzhimianmao.Location = new System.Drawing.Point(43, 89);
            this.cmbZhengzhimianmao.Name = "cmbZhengzhimianmao";
            this.cmbZhengzhimianmao.Size = new System.Drawing.Size(121, 20);
            this.cmbZhengzhimianmao.TabIndex = 34;
            // 
            // lblZhengZhiMianMao
            // 
            this.lblZhengZhiMianMao.AutoSize = true;
            this.lblZhengZhiMianMao.Location = new System.Drawing.Point(43, 73);
            this.lblZhengZhiMianMao.Name = "lblZhengZhiMianMao";
            this.lblZhengZhiMianMao.Size = new System.Drawing.Size(53, 12);
            this.lblZhengZhiMianMao.TabIndex = 33;
            this.lblZhengZhiMianMao.Text = "政治面貌";
            // 
            // cmbMinzu
            // 
            this.cmbMinzu.Enabled = false;
            this.cmbMinzu.FormattingEnabled = true;
            this.cmbMinzu.Location = new System.Drawing.Point(191, 89);
            this.cmbMinzu.Name = "cmbMinzu";
            this.cmbMinzu.Size = new System.Drawing.Size(121, 20);
            this.cmbMinzu.TabIndex = 36;
            // 
            // lblMinzu
            // 
            this.lblMinzu.AutoSize = true;
            this.lblMinzu.Location = new System.Drawing.Point(191, 73);
            this.lblMinzu.Name = "lblMinzu";
            this.lblMinzu.Size = new System.Drawing.Size(29, 12);
            this.lblMinzu.TabIndex = 35;
            this.lblMinzu.Text = "民族";
            // 
            // cmbJiguan
            // 
            this.cmbJiguan.Enabled = false;
            this.cmbJiguan.FormattingEnabled = true;
            this.cmbJiguan.Location = new System.Drawing.Point(344, 89);
            this.cmbJiguan.Name = "cmbJiguan";
            this.cmbJiguan.Size = new System.Drawing.Size(137, 20);
            this.cmbJiguan.TabIndex = 38;
            // 
            // lblJiguan
            // 
            this.lblJiguan.AutoSize = true;
            this.lblJiguan.Location = new System.Drawing.Point(344, 73);
            this.lblJiguan.Name = "lblJiguan";
            this.lblJiguan.Size = new System.Drawing.Size(29, 12);
            this.lblJiguan.TabIndex = 37;
            this.lblJiguan.Text = "籍贯";
            // 
            // txtShenfenzheng
            // 
            this.txtShenfenzheng.Location = new System.Drawing.Point(511, 88);
            this.txtShenfenzheng.Name = "txtShenfenzheng";
            this.txtShenfenzheng.ReadOnly = true;
            this.txtShenfenzheng.Size = new System.Drawing.Size(120, 21);
            this.txtShenfenzheng.TabIndex = 40;
            // 
            // lblShenfenzheng
            // 
            this.lblShenfenzheng.AutoSize = true;
            this.lblShenfenzheng.Location = new System.Drawing.Point(511, 73);
            this.lblShenfenzheng.Name = "lblShenfenzheng";
            this.lblShenfenzheng.Size = new System.Drawing.Size(41, 12);
            this.lblShenfenzheng.TabIndex = 39;
            this.lblShenfenzheng.Text = "身份证";
            // 
            // TeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 532);
            this.Controls.Add(this.gpbTeacherInfo);
            this.Controls.Add(this.dgvTeacherInfo);
            this.Controls.Add(this.gbStudentsInfo);
            this.Controls.Add(this.tbTeacherInfo);
            this.Name = "TeacherInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【教师信息维护】";
            this.Load += new System.EventHandler(this.TeacherInfo_Load);
            this.gbStudentsInfo.ResumeLayout(false);
            this.gbStudentsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherInfo)).EndInit();
            this.gpbTeacherInfo.ResumeLayout(false);
            this.gpbTeacherInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersInfoDateSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.教师信息BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolBar tbTeacherInfo;
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
        private System.Windows.Forms.GroupBox gbStudentsInfo;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchNo;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblSearchNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTeacherInfo;
        private System.Windows.Forms.GroupBox gpbTeacherInfo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private TeachersInfoDateSet teachersInfoDateSet;
        private System.Windows.Forms.BindingSource 教师信息BindingSource;
        private TeachersInfoDateSetTableAdapters.教师信息TableAdapter 教师信息TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职工号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职称编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 政治面貌编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 民族编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 籍贯编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblZhiGongHao;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbJiguan;
        private System.Windows.Forms.Label lblJiguan;
        private System.Windows.Forms.ComboBox cmbMinzu;
        private System.Windows.Forms.Label lblMinzu;
        private System.Windows.Forms.ComboBox cmbZhengzhimianmao;
        private System.Windows.Forms.Label lblZhengZhiMianMao;
        private System.Windows.Forms.ComboBox cmbZhiChen;
        private System.Windows.Forms.Label lblZhiChen;
        private System.Windows.Forms.TextBox txtShenfenzheng;
        private System.Windows.Forms.Label lblShenfenzheng;
    }
}