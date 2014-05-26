namespace 教务系统
{
    partial class ClassInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassInfo));
            this.tbClassInfo = new System.Windows.Forms.ToolBar();
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
            this.gpbClassInfoSearch = new System.Windows.Forms.GroupBox();
            this.lblBanJiName = new System.Windows.Forms.Label();
            this.lblNianJi = new System.Windows.Forms.Label();
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.lblClassNum = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dGVClassInfo = new System.Windows.Forms.DataGridView();
            this.gpBClassInfoShow = new System.Windows.Forms.GroupBox();
            this.txtb4 = new System.Windows.Forms.TextBox();
            this.lblBanjibianhao = new System.Windows.Forms.Label();
            this.txtb5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb6 = new System.Windows.Forms.TextBox();
            this.txtb9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtb8 = new System.Windows.Forms.TextBox();
            this.txtb7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.班级编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年级DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级简称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.人数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班主任DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eisbookDataSet = new 教务系统.eisbookDataSet();
            this.班级信息TableAdapter = new 教务系统.eisbookDataSetTableAdapters.班级信息TableAdapter();
            this.gpbClassInfoSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClassInfo)).BeginInit();
            this.gpBClassInfoShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.班级信息BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eisbookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbClassInfo
            // 
            this.tbClassInfo.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
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
            this.tbClassInfo.DropDownArrows = true;
            this.tbClassInfo.ImageList = this.imageList1;
            this.tbClassInfo.Location = new System.Drawing.Point(0, 0);
            this.tbClassInfo.Name = "tbClassInfo";
            this.tbClassInfo.ShowToolTips = true;
            this.tbClassInfo.Size = new System.Drawing.Size(728, 41);
            this.tbClassInfo.TabIndex = 0;
            this.tbClassInfo.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbClassInfo_ButtonClick);
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
            this.toolBarButton10.ImageIndex = 9;
            this.toolBarButton10.Name = "toolBarButton10";
            this.toolBarButton10.Text = "退出";
            this.toolBarButton10.ToolTipText = "退出";
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
            // 
            // gpbClassInfoSearch
            // 
            this.gpbClassInfoSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbClassInfoSearch.Controls.Add(this.lblBanJiName);
            this.gpbClassInfoSearch.Controls.Add(this.lblNianJi);
            this.gpbClassInfoSearch.Controls.Add(this.txtb3);
            this.gpbClassInfoSearch.Controls.Add(this.txtb2);
            this.gpbClassInfoSearch.Controls.Add(this.txtb1);
            this.gpbClassInfoSearch.Controls.Add(this.lblClassNum);
            this.gpbClassInfoSearch.Controls.Add(this.btnSearch);
            this.gpbClassInfoSearch.Location = new System.Drawing.Point(0, 48);
            this.gpbClassInfoSearch.Name = "gpbClassInfoSearch";
            this.gpbClassInfoSearch.Size = new System.Drawing.Size(726, 50);
            this.gpbClassInfoSearch.TabIndex = 1;
            this.gpbClassInfoSearch.TabStop = false;
            // 
            // lblBanJiName
            // 
            this.lblBanJiName.AutoSize = true;
            this.lblBanJiName.Location = new System.Drawing.Point(502, 23);
            this.lblBanJiName.Name = "lblBanJiName";
            this.lblBanJiName.Size = new System.Drawing.Size(53, 12);
            this.lblBanJiName.TabIndex = 5;
            this.lblBanJiName.Text = "班级名称";
            // 
            // lblNianJi
            // 
            this.lblNianJi.AutoSize = true;
            this.lblNianJi.Location = new System.Drawing.Point(325, 24);
            this.lblNianJi.Name = "lblNianJi";
            this.lblNianJi.Size = new System.Drawing.Size(29, 12);
            this.lblNianJi.TabIndex = 4;
            this.lblNianJi.Text = "年级";
            // 
            // txtb3
            // 
            this.txtb3.Location = new System.Drawing.Point(579, 20);
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(100, 21);
            this.txtb3.TabIndex = 3;
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(378, 19);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(100, 21);
            this.txtb2.TabIndex = 3;
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(201, 20);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(100, 21);
            this.txtb1.TabIndex = 2;
            // 
            // lblClassNum
            // 
            this.lblClassNum.AutoSize = true;
            this.lblClassNum.Location = new System.Drawing.Point(124, 25);
            this.lblClassNum.Name = "lblClassNum";
            this.lblClassNum.Size = new System.Drawing.Size(53, 12);
            this.lblClassNum.TabIndex = 1;
            this.lblClassNum.Text = "班级编号";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(12, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dGVClassInfo
            // 
            this.dGVClassInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVClassInfo.AutoGenerateColumns = false;
            this.dGVClassInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVClassInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVClassInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVClassInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.班级编号DataGridViewTextBoxColumn,
            this.年级DataGridViewTextBoxColumn,
            this.班级名称DataGridViewTextBoxColumn,
            this.班级简称DataGridViewTextBoxColumn,
            this.人数DataGridViewTextBoxColumn,
            this.班主任DataGridViewTextBoxColumn});
            this.dGVClassInfo.DataSource = this.班级信息BindingSource;
            this.dGVClassInfo.Location = new System.Drawing.Point(-6, 104);
            this.dGVClassInfo.Name = "dGVClassInfo";
            this.dGVClassInfo.RowTemplate.Height = 23;
            this.dGVClassInfo.Size = new System.Drawing.Size(731, 282);
            this.dGVClassInfo.TabIndex = 2;
            this.dGVClassInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVClassInfo_CellClick);
            // 
            // gpBClassInfoShow
            // 
            this.gpBClassInfoShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBClassInfoShow.Controls.Add(this.txtb4);
            this.gpBClassInfoShow.Controls.Add(this.lblBanjibianhao);
            this.gpBClassInfoShow.Controls.Add(this.txtb5);
            this.gpBClassInfoShow.Controls.Add(this.label5);
            this.gpBClassInfoShow.Controls.Add(this.label6);
            this.gpBClassInfoShow.Controls.Add(this.txtb6);
            this.gpBClassInfoShow.Controls.Add(this.txtb9);
            this.gpBClassInfoShow.Controls.Add(this.label7);
            this.gpBClassInfoShow.Controls.Add(this.label8);
            this.gpBClassInfoShow.Controls.Add(this.txtb8);
            this.gpBClassInfoShow.Controls.Add(this.txtb7);
            this.gpBClassInfoShow.Controls.Add(this.label9);
            this.gpBClassInfoShow.Location = new System.Drawing.Point(-6, 392);
            this.gpBClassInfoShow.Name = "gpBClassInfoShow";
            this.gpBClassInfoShow.Size = new System.Drawing.Size(732, 133);
            this.gpBClassInfoShow.TabIndex = 3;
            this.gpBClassInfoShow.TabStop = false;
            // 
            // txtb4
            // 
            this.txtb4.Location = new System.Drawing.Point(128, 50);
            this.txtb4.Name = "txtb4";
            this.txtb4.ReadOnly = true;
            this.txtb4.Size = new System.Drawing.Size(136, 21);
            this.txtb4.TabIndex = 8;
            // 
            // lblBanjibianhao
            // 
            this.lblBanjibianhao.Location = new System.Drawing.Point(128, 34);
            this.lblBanjibianhao.Name = "lblBanjibianhao";
            this.lblBanjibianhao.Size = new System.Drawing.Size(100, 16);
            this.lblBanjibianhao.TabIndex = 6;
            this.lblBanjibianhao.Text = "班级编号";
            // 
            // txtb5
            // 
            this.txtb5.Location = new System.Drawing.Point(296, 50);
            this.txtb5.Name = "txtb5";
            this.txtb5.ReadOnly = true;
            this.txtb5.Size = new System.Drawing.Size(136, 21);
            this.txtb5.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(296, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "年级";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(472, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "班级名称";
            // 
            // txtb6
            // 
            this.txtb6.Location = new System.Drawing.Point(472, 50);
            this.txtb6.Name = "txtb6";
            this.txtb6.ReadOnly = true;
            this.txtb6.Size = new System.Drawing.Size(136, 21);
            this.txtb6.TabIndex = 12;
            // 
            // txtb9
            // 
            this.txtb9.Location = new System.Drawing.Point(472, 98);
            this.txtb9.Name = "txtb9";
            this.txtb9.ReadOnly = true;
            this.txtb9.Size = new System.Drawing.Size(136, 21);
            this.txtb9.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(472, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "班主任";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(296, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "人数";
            // 
            // txtb8
            // 
            this.txtb8.Location = new System.Drawing.Point(296, 98);
            this.txtb8.Name = "txtb8";
            this.txtb8.ReadOnly = true;
            this.txtb8.Size = new System.Drawing.Size(136, 21);
            this.txtb8.TabIndex = 10;
            // 
            // txtb7
            // 
            this.txtb7.Location = new System.Drawing.Point(128, 98);
            this.txtb7.Name = "txtb7";
            this.txtb7.ReadOnly = true;
            this.txtb7.Size = new System.Drawing.Size(136, 21);
            this.txtb7.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(128, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "班级简称";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=HEIMINGX-PC\\SQLEXPRESS;Initial Catalog=eisbook;Integrated Security=Tr" +
                "ue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // 班级编号DataGridViewTextBoxColumn
            // 
            this.班级编号DataGridViewTextBoxColumn.DataPropertyName = "班级编号";
            this.班级编号DataGridViewTextBoxColumn.HeaderText = "班级编号";
            this.班级编号DataGridViewTextBoxColumn.Name = "班级编号DataGridViewTextBoxColumn";
            // 
            // 年级DataGridViewTextBoxColumn
            // 
            this.年级DataGridViewTextBoxColumn.DataPropertyName = "年级";
            this.年级DataGridViewTextBoxColumn.HeaderText = "年级";
            this.年级DataGridViewTextBoxColumn.Name = "年级DataGridViewTextBoxColumn";
            // 
            // 班级名称DataGridViewTextBoxColumn
            // 
            this.班级名称DataGridViewTextBoxColumn.DataPropertyName = "班级名称";
            this.班级名称DataGridViewTextBoxColumn.HeaderText = "班级名称";
            this.班级名称DataGridViewTextBoxColumn.Name = "班级名称DataGridViewTextBoxColumn";
            // 
            // 班级简称DataGridViewTextBoxColumn
            // 
            this.班级简称DataGridViewTextBoxColumn.DataPropertyName = "班级简称";
            this.班级简称DataGridViewTextBoxColumn.HeaderText = "班级简称";
            this.班级简称DataGridViewTextBoxColumn.Name = "班级简称DataGridViewTextBoxColumn";
            // 
            // 人数DataGridViewTextBoxColumn
            // 
            this.人数DataGridViewTextBoxColumn.DataPropertyName = "人数";
            this.人数DataGridViewTextBoxColumn.HeaderText = "人数";
            this.人数DataGridViewTextBoxColumn.Name = "人数DataGridViewTextBoxColumn";
            // 
            // 班主任DataGridViewTextBoxColumn
            // 
            this.班主任DataGridViewTextBoxColumn.DataPropertyName = "班主任";
            this.班主任DataGridViewTextBoxColumn.HeaderText = "班主任";
            this.班主任DataGridViewTextBoxColumn.Name = "班主任DataGridViewTextBoxColumn";
            // 
            // 班级信息BindingSource
            // 
            this.班级信息BindingSource.DataMember = "班级信息";
            this.班级信息BindingSource.DataSource = this.eisbookDataSet;
            // 
            // eisbookDataSet
            // 
            this.eisbookDataSet.DataSetName = "eisbookDataSet";
            this.eisbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 班级信息TableAdapter
            // 
            this.班级信息TableAdapter.ClearBeforeFill = true;
            // 
            // ClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 532);
            this.Controls.Add(this.gpBClassInfoShow);
            this.Controls.Add(this.dGVClassInfo);
            this.Controls.Add(this.gpbClassInfoSearch);
            this.Controls.Add(this.tbClassInfo);
            this.Name = "ClassInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【班级信息维护】";
            this.Load += new System.EventHandler(this.ClassInfo_Load);
            this.gpbClassInfoSearch.ResumeLayout(false);
            this.gpbClassInfoSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClassInfo)).EndInit();
            this.gpBClassInfoShow.ResumeLayout(false);
            this.gpBClassInfoShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.班级信息BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eisbookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolBar tbClassInfo;
        private System.Windows.Forms.ToolBarButton 首记录;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.ToolBarButton toolBarButton4;
        private System.Windows.Forms.ToolBarButton 新增;
        private System.Windows.Forms.ToolBarButton toolBarButton6;
        private System.Windows.Forms.ToolBarButton toolBarButton7;
        private System.Windows.Forms.ToolBarButton toolBarButton8;
        private System.Windows.Forms.ToolBarButton toolBarButton9;
        private System.Windows.Forms.ToolBarButton toolBarButton10;
        private System.Windows.Forms.GroupBox gpbClassInfoSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBanJiName;
        private System.Windows.Forms.Label lblNianJi;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Label lblClassNum;
        private System.Windows.Forms.DataGridView dGVClassInfo;
        private System.Windows.Forms.GroupBox gpBClassInfoShow;
        private System.Windows.Forms.TextBox txtb4;
        private System.Windows.Forms.Label lblBanjibianhao;
        private System.Windows.Forms.TextBox txtb5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb6;
        private System.Windows.Forms.TextBox txtb9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtb8;
        private System.Windows.Forms.TextBox txtb7;
        private System.Windows.Forms.Label label9;
        private eisbookDataSet eisbookDataSet;
        private System.Windows.Forms.BindingSource 班级信息BindingSource;
        private eisbookDataSetTableAdapters.班级信息TableAdapter 班级信息TableAdapter;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton toolBarButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年级DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级简称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 人数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班主任DataGridViewTextBoxColumn;



    }
}