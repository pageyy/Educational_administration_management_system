namespace 教务系统
{
    partial class CurriculumSchedule
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
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgCourseElected = new System.Windows.Forms.DataGrid();
            this.gbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseElected)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStudentInfo.Controls.Add(this.txt3);
            this.gbStudentInfo.Controls.Add(this.txt2);
            this.gbStudentInfo.Controls.Add(this.txt1);
            this.gbStudentInfo.Controls.Add(this.lbl3);
            this.gbStudentInfo.Controls.Add(this.lbl2);
            this.gbStudentInfo.Controls.Add(this.lbl1);
            this.gbStudentInfo.Location = new System.Drawing.Point(12, 3);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(704, 67);
            this.gbStudentInfo.TabIndex = 0;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "学生信息";
            // 
            // txt3
            // 
            this.txt3.Enabled = false;
            this.txt3.Location = new System.Drawing.Point(497, 31);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 21);
            this.txt3.TabIndex = 5;
            // 
            // txt2
            // 
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(301, 31);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 21);
            this.txt2.TabIndex = 4;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(101, 31);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 21);
            this.txt1.TabIndex = 3;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(462, 34);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(29, 12);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "班级";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(266, 34);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(29, 12);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "姓名";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(66, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(29, 12);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "学号";
            // 
            // dgCourseElected
            // 
            this.dgCourseElected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCourseElected.CaptionVisible = false;
            this.dgCourseElected.DataMember = "";
            this.dgCourseElected.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgCourseElected.Location = new System.Drawing.Point(12, 76);
            this.dgCourseElected.Name = "dgCourseElected";
            this.dgCourseElected.Size = new System.Drawing.Size(704, 444);
            this.dgCourseElected.TabIndex = 1;
            // 
            // CurriculumSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 532);
            this.Controls.Add(this.dgCourseElected);
            this.Controls.Add(this.gbStudentInfo);
            this.Name = "CurriculumSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【学生信息】";
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseElected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGrid dgCourseElected;
    }
}