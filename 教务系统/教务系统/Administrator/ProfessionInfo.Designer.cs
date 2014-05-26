namespace 教务系统.Administrator
{
    partial class ProfessionInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessionInfo));
            this.tbProfessionInfo = new System.Windows.Forms.ToolBar();
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
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.lblSearchPName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gpbProfessionShow = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.dgvProfessionInfo = new System.Windows.Forms.DataGridView();
            this.eisbookDataSet1 = new 教务系统.eisbookDataSet1();
            this.专业信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.专业信息表TableAdapter = new 教务系统.eisbookDataSet1TableAdapters.专业信息表TableAdapter();
            this.专业编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbSearch.SuspendLayout();
            this.gpbProfessionShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessionInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eisbookDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.专业信息表BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProfessionInfo
            // 
            this.tbProfessionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfessionInfo.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
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
            this.tbProfessionInfo.Dock = System.Windows.Forms.DockStyle.None;
            this.tbProfessionInfo.DropDownArrows = true;
            this.tbProfessionInfo.ImageList = this.imageList1;
            this.tbProfessionInfo.Location = new System.Drawing.Point(0, 0);
            this.tbProfessionInfo.Name = "tbProfessionInfo";
            this.tbProfessionInfo.ShowToolTips = true;
            this.tbProfessionInfo.Size = new System.Drawing.Size(728, 41);
            this.tbProfessionInfo.TabIndex = 1;
            this.tbProfessionInfo.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbProfessionInfo_ButtonClick);
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
            this.imageList1.Images.SetKeyName(0, "保存.bmp");
            this.imageList1.Images.SetKeyName(1, "查询选择.bmp");
            this.imageList1.Images.SetKeyName(2, "打印.BMP");
            this.imageList1.Images.SetKeyName(3, "取消.bmp");
            this.imageList1.Images.SetKeyName(4, "删除.bmp");
            this.imageList1.Images.SetKeyName(5, "上记录.bmp");
            this.imageList1.Images.SetKeyName(6, "首记录.bmp");
            this.imageList1.Images.SetKeyName(7, "搜索.bmp");
            this.imageList1.Images.SetKeyName(8, "退出.bmp");
            this.imageList1.Images.SetKeyName(9, "尾记录.bmp");
            this.imageList1.Images.SetKeyName(10, "下记录.bmp");
            this.imageList1.Images.SetKeyName(11, "新增.bmp");
            this.imageList1.Images.SetKeyName(12, "修改.bmp");
            // 
            // gpbSearch
            // 
            this.gpbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbSearch.Controls.Add(this.cmbSearch);
            this.gpbSearch.Controls.Add(this.lblSearchPName);
            this.gpbSearch.Controls.Add(this.btnSearch);
            this.gpbSearch.Location = new System.Drawing.Point(0, 47);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(726, 50);
            this.gpbSearch.TabIndex = 2;
            this.gpbSearch.TabStop = false;
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(194, 18);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(121, 20);
            this.cmbSearch.TabIndex = 2;
            // 
            // lblSearchPName
            // 
            this.lblSearchPName.AutoSize = true;
            this.lblSearchPName.Location = new System.Drawing.Point(130, 20);
            this.lblSearchPName.Name = "lblSearchPName";
            this.lblSearchPName.Size = new System.Drawing.Size(53, 12);
            this.lblSearchPName.TabIndex = 1;
            this.lblSearchPName.Text = "专业名称";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(25, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gpbProfessionShow
            // 
            this.gpbProfessionShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbProfessionShow.Controls.Add(this.txtName);
            this.gpbProfessionShow.Controls.Add(this.txtNo);
            this.gpbProfessionShow.Controls.Add(this.lblName);
            this.gpbProfessionShow.Controls.Add(this.lblNo);
            this.gpbProfessionShow.Location = new System.Drawing.Point(0, 391);
            this.gpbProfessionShow.Name = "gpbProfessionShow";
            this.gpbProfessionShow.Size = new System.Drawing.Size(726, 137);
            this.gpbProfessionShow.TabIndex = 4;
            this.gpbProfessionShow.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(390, 65);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(170, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(123, 65);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(100, 21);
            this.txtNo.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(326, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "专业名称";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(59, 68);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(53, 12);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "专业编号";
            // 
            // dgvProfessionInfo
            // 
            this.dgvProfessionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProfessionInfo.AutoGenerateColumns = false;
            this.dgvProfessionInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfessionInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessionInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.专业编号DataGridViewTextBoxColumn,
            this.专业名称DataGridViewTextBoxColumn});
            this.dgvProfessionInfo.DataSource = this.专业信息表BindingSource;
            this.dgvProfessionInfo.Location = new System.Drawing.Point(0, 103);
            this.dgvProfessionInfo.Name = "dgvProfessionInfo";
            this.dgvProfessionInfo.RowTemplate.Height = 23;
            this.dgvProfessionInfo.Size = new System.Drawing.Size(731, 282);
            this.dgvProfessionInfo.TabIndex = 3;
            // 
            // eisbookDataSet1
            // 
            this.eisbookDataSet1.DataSetName = "eisbookDataSet1";
            this.eisbookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 专业信息表BindingSource
            // 
            this.专业信息表BindingSource.DataMember = "专业信息表";
            this.专业信息表BindingSource.DataSource = this.eisbookDataSet1;
            // 
            // 专业信息表TableAdapter
            // 
            this.专业信息表TableAdapter.ClearBeforeFill = true;
            // 
            // 专业编号DataGridViewTextBoxColumn
            // 
            this.专业编号DataGridViewTextBoxColumn.DataPropertyName = "专业编号";
            this.专业编号DataGridViewTextBoxColumn.HeaderText = "专业编号";
            this.专业编号DataGridViewTextBoxColumn.Name = "专业编号DataGridViewTextBoxColumn";
            // 
            // 专业名称DataGridViewTextBoxColumn
            // 
            this.专业名称DataGridViewTextBoxColumn.DataPropertyName = "专业名称";
            this.专业名称DataGridViewTextBoxColumn.HeaderText = "专业名称";
            this.专业名称DataGridViewTextBoxColumn.Name = "专业名称DataGridViewTextBoxColumn";
            // 
            // ProfessionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 532);
            this.Controls.Add(this.gpbProfessionShow);
            this.Controls.Add(this.dgvProfessionInfo);
            this.Controls.Add(this.gpbSearch);
            this.Controls.Add(this.tbProfessionInfo);
            this.Name = "ProfessionInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【专业信息维护】";
            this.Load += new System.EventHandler(this.ProfessionInfo_Load);
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbProfessionShow.ResumeLayout(false);
            this.gpbProfessionShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessionInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eisbookDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.专业信息表BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolBar tbProfessionInfo;
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
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchPName;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.DataGridView dgvProfessionInfo;
        private System.Windows.Forms.GroupBox gpbProfessionShow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private eisbookDataSet1 eisbookDataSet1;
        private System.Windows.Forms.BindingSource 专业信息表BindingSource;
        private eisbookDataSet1TableAdapters.专业信息表TableAdapter 专业信息表TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业名称DataGridViewTextBoxColumn;
    }
}