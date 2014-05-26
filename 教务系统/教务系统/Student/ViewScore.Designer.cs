namespace 教务系统
{
    partial class ViewScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewScore));
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.da1 = new System.Data.SqlClient.SqlDataAdapter();
            this.DataSetGradeList = new 教务系统.eisbookDataSet();
            this.gbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetGradeList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStudentInfo.Controls.Add(this.txt3);
            this.gbStudentInfo.Controls.Add(this.txt2);
            this.gbStudentInfo.Controls.Add(this.txt1);
            this.gbStudentInfo.Controls.Add(this.btnPrint);
            this.gbStudentInfo.Controls.Add(this.label3);
            this.gbStudentInfo.Controls.Add(this.label2);
            this.gbStudentInfo.Controls.Add(this.label1);
            this.gbStudentInfo.Location = new System.Drawing.Point(12, 12);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(704, 81);
            this.gbStudentInfo.TabIndex = 0;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "学生信息输入";
            // 
            // txt3
            // 
            this.txt3.Enabled = false;
            this.txt3.Location = new System.Drawing.Point(422, 38);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 21);
            this.txt3.TabIndex = 6;
            // 
            // txt2
            // 
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(251, 38);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 21);
            this.txt2.TabIndex = 5;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(89, 38);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 21);
            this.txt1.TabIndex = 4;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.ImageIndex = 0;
            this.btnPrint.ImageList = this.imageList1;
            this.btnPrint.Location = new System.Drawing.Point(570, 30);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 34);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "打印";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "打印.BMP");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "班级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // dgvGrade
            // 
            this.dgvGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrade.Location = new System.Drawing.Point(12, 99);
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.RowTemplate.Height = 23;
            this.dgvGrade.Size = new System.Drawing.Size(704, 421);
            this.dgvGrade.TabIndex = 1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=HEIMINGX-PC\\SQLEXPRESS;Initial Catalog=eisbook;Integrated Security=Tr" +
                "ue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "select a.学号,c.姓名,b.课程名称,b.开课系别,b.教师,a.成绩\r\nfrom 成绩表 a,课程信息 b,学生信息 c\r\nwhere (a.课程编号" +
                " = b.课程编号) and (a.学号=c.学号)\r\nand (a.学号= \'?\')";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // da1
            // 
            this.da1.SelectCommand = this.sqlSelectCommand1;
            this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "成绩表", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("学号", "学号"),
                        new System.Data.Common.DataColumnMapping("姓名", "姓名"),
                        new System.Data.Common.DataColumnMapping("课程名称", "课程名称"),
                        new System.Data.Common.DataColumnMapping("开课系别", "开课系别"),
                        new System.Data.Common.DataColumnMapping("教师", "教师"),
                        new System.Data.Common.DataColumnMapping("成绩", "成绩")})});
            // 
            // DataSetGradeList
            // 
            this.DataSetGradeList.DataSetName = "DataSetGradeList";
            this.DataSetGradeList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 532);
            this.Controls.Add(this.dgvGrade);
            this.Controls.Add(this.gbStudentInfo);
            this.Name = "ViewScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【成绩单打印】";
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetGradeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvGrade;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter da1;
        private eisbookDataSet DataSetGradeList;
    }
}