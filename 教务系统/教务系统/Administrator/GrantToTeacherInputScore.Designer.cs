namespace 教务系统.Administrator
{
    partial class GrantToTeacherInputScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrantToTeacherInputScore));
            this.gpbYes = new System.Windows.Forms.GroupBox();
            this.pbRevoke = new System.Windows.Forms.PictureBox();
            this.dgvYesGranted = new System.Windows.Forms.DataGridView();
            this.gpbNo = new System.Windows.Forms.GroupBox();
            this.pbGrant = new System.Windows.Forms.PictureBox();
            this.dgvNoGranted = new System.Windows.Forms.DataGridView();
            this.gpbYes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRevoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYesGranted)).BeginInit();
            this.gpbNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoGranted)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbYes
            // 
            this.gpbYes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbYes.Controls.Add(this.pbRevoke);
            this.gpbYes.Controls.Add(this.dgvYesGranted);
            this.gpbYes.Location = new System.Drawing.Point(1, 12);
            this.gpbYes.Name = "gpbYes";
            this.gpbYes.Size = new System.Drawing.Size(831, 235);
            this.gpbYes.TabIndex = 2;
            this.gpbYes.TabStop = false;
            this.gpbYes.Text = "已授权课程";
            // 
            // pbRevoke
            // 
            this.pbRevoke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRevoke.Image = ((System.Drawing.Image)(resources.GetObject("pbRevoke.Image")));
            this.pbRevoke.Location = new System.Drawing.Point(720, 84);
            this.pbRevoke.Name = "pbRevoke";
            this.pbRevoke.Size = new System.Drawing.Size(105, 90);
            this.pbRevoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRevoke.TabIndex = 1;
            this.pbRevoke.TabStop = false;
            this.pbRevoke.Click += new System.EventHandler(this.pbRevoke_Click);
            // 
            // dgvYesGranted
            // 
            this.dgvYesGranted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvYesGranted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYesGranted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYesGranted.Location = new System.Drawing.Point(11, 20);
            this.dgvYesGranted.Name = "dgvYesGranted";
            this.dgvYesGranted.RowTemplate.Height = 23;
            this.dgvYesGranted.Size = new System.Drawing.Size(699, 209);
            this.dgvYesGranted.TabIndex = 0;
            // 
            // gpbNo
            // 
            this.gpbNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbNo.Controls.Add(this.pbGrant);
            this.gpbNo.Controls.Add(this.dgvNoGranted);
            this.gpbNo.Location = new System.Drawing.Point(1, 253);
            this.gpbNo.Name = "gpbNo";
            this.gpbNo.Size = new System.Drawing.Size(831, 239);
            this.gpbNo.TabIndex = 3;
            this.gpbNo.TabStop = false;
            this.gpbNo.Text = "未授权课程";
            // 
            // pbGrant
            // 
            this.pbGrant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbGrant.Image = ((System.Drawing.Image)(resources.GetObject("pbGrant.Image")));
            this.pbGrant.Location = new System.Drawing.Point(720, 78);
            this.pbGrant.Name = "pbGrant";
            this.pbGrant.Size = new System.Drawing.Size(105, 90);
            this.pbGrant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGrant.TabIndex = 1;
            this.pbGrant.TabStop = false;
            this.pbGrant.Click += new System.EventHandler(this.pbGrant_Click);
            // 
            // dgvNoGranted
            // 
            this.dgvNoGranted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNoGranted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNoGranted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoGranted.Location = new System.Drawing.Point(11, 20);
            this.dgvNoGranted.Name = "dgvNoGranted";
            this.dgvNoGranted.RowTemplate.Height = 23;
            this.dgvNoGranted.Size = new System.Drawing.Size(699, 213);
            this.dgvNoGranted.TabIndex = 0;
            // 
            // GrantToTeacherInputScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 493);
            this.Controls.Add(this.gpbNo);
            this.Controls.Add(this.gpbYes);
            this.Name = "GrantToTeacherInputScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【授权录入成绩】";
            this.gpbYes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRevoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYesGranted)).EndInit();
            this.gpbNo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoGranted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbYes;
        private System.Windows.Forms.PictureBox pbRevoke;
        private System.Windows.Forms.DataGridView dgvYesGranted;
        private System.Windows.Forms.GroupBox gpbNo;
        private System.Windows.Forms.PictureBox pbGrant;
        private System.Windows.Forms.DataGridView dgvNoGranted;
    }
}