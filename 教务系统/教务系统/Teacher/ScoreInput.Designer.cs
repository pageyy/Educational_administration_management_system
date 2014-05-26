namespace 教务系统
{
    partial class ScoreInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreInput));
            this.gbEndScoreInput = new System.Windows.Forms.GroupBox();
            this.btnEndScoreElect = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbCourseElect = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvScore = new System.Windows.Forms.DataGridView();
            this.gbEndScoreInput.SuspendLayout();
            this.gbCourseElect.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEndScoreInput
            // 
            this.gbEndScoreInput.Controls.Add(this.btnEndScoreElect);
            this.gbEndScoreInput.Location = new System.Drawing.Point(12, 12);
            this.gbEndScoreInput.Name = "gbEndScoreInput";
            this.gbEndScoreInput.Size = new System.Drawing.Size(270, 122);
            this.gbEndScoreInput.TabIndex = 0;
            this.gbEndScoreInput.TabStop = false;
            this.gbEndScoreInput.Text = "结束选课，生成空成绩单";
            // 
            // btnEndScoreElect
            // 
            this.btnEndScoreElect.ImageIndex = 0;
            this.btnEndScoreElect.ImageList = this.imageList1;
            this.btnEndScoreElect.Location = new System.Drawing.Point(95, 47);
            this.btnEndScoreElect.Name = "btnEndScoreElect";
            this.btnEndScoreElect.Size = new System.Drawing.Size(116, 34);
            this.btnEndScoreElect.TabIndex = 0;
            this.btnEndScoreElect.Text = "结束选课";
            this.btnEndScoreElect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEndScoreElect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEndScoreElect.UseVisualStyleBackColor = true;
            this.btnEndScoreElect.Click += new System.EventHandler(this.btnEndScoreElect_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "退出.bmp");
            this.imageList1.Images.SetKeyName(1, "查询选择.bmp");
            this.imageList1.Images.SetKeyName(2, "保存.bmp");
            this.imageList1.Images.SetKeyName(3, "修改.bmp");
            // 
            // gbCourseElect
            // 
            this.gbCourseElect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCourseElect.Controls.Add(this.button2);
            this.gbCourseElect.Controls.Add(this.btnSelect);
            this.gbCourseElect.Controls.Add(this.txt3);
            this.gbCourseElect.Controls.Add(this.txt2);
            this.gbCourseElect.Controls.Add(this.txt1);
            this.gbCourseElect.Controls.Add(this.label3);
            this.gbCourseElect.Controls.Add(this.label2);
            this.gbCourseElect.Controls.Add(this.label1);
            this.gbCourseElect.Location = new System.Drawing.Point(288, 12);
            this.gbCourseElect.Name = "gbCourseElect";
            this.gbCourseElect.Size = new System.Drawing.Size(428, 122);
            this.gbCourseElect.TabIndex = 1;
            this.gbCourseElect.TabStop = false;
            this.gbCourseElect.Text = "选择课程";
            // 
            // button2
            // 
            this.button2.ImageIndex = 2;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(293, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "最终提交";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.ImageIndex = 1;
            this.btnSelect.ImageList = this.imageList1;
            this.btnSelect.Location = new System.Drawing.Point(293, 25);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(108, 32);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "查询";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(92, 84);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 21);
            this.txt3.TabIndex = 5;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(92, 55);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 21);
            this.txt2.TabIndex = 4;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(92, 25);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 21);
            this.txt1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "课程名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "课程编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程拼音";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvScore);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Location = new System.Drawing.Point(12, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 390);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程成绩输入";
            // 
            // txt4
            // 
            this.txt4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt4.Location = new System.Drawing.Point(385, 359);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 21);
            this.txt4.TabIndex = 1;
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ImageIndex = 3;
            this.btnUpdate.ImageList = this.imageList1;
            this.btnUpdate.Location = new System.Drawing.Point(507, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "修改成绩";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvScore
            // 
            this.dgvScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScore.Location = new System.Drawing.Point(6, 20);
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.RowTemplate.Height = 23;
            this.dgvScore.Size = new System.Drawing.Size(692, 317);
            this.dgvScore.TabIndex = 2;
            // 
            // ScoreInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCourseElect);
            this.Controls.Add(this.gbEndScoreInput);
            this.Name = "ScoreInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【成绩输入】";
            this.Load += new System.EventHandler(this.ScoreInput_Load);
            this.gbEndScoreInput.ResumeLayout(false);
            this.gbCourseElect.ResumeLayout(false);
            this.gbCourseElect.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEndScoreInput;
        private System.Windows.Forms.Button btnEndScoreElect;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox gbCourseElect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvScore;
    }
}