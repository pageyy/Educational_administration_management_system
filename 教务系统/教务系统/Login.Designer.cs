namespace 教务系统
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.pbVerifyCode = new System.Windows.Forms.PictureBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.rdobPassengers = new System.Windows.Forms.RadioButton();
            this.rdobStudent = new System.Windows.Forms.RadioButton();
            this.rdobTeacher = new System.Windows.Forms.RadioButton();
            this.rdobDepartment = new System.Windows.Forms.RadioButton();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerifyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.pbVerifyCode);
            this.gbLogin.Controls.Add(this.lblChange);
            this.gbLogin.Controls.Add(this.btnReset);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.rdobPassengers);
            this.gbLogin.Controls.Add(this.rdobStudent);
            this.gbLogin.Controls.Add(this.rdobTeacher);
            this.gbLogin.Controls.Add(this.rdobDepartment);
            this.gbLogin.Controls.Add(this.txtUsername);
            this.gbLogin.Controls.Add(this.txtTest);
            this.gbLogin.Controls.Add(this.lblUsername);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.lblPassword);
            this.gbLogin.Controls.Add(this.lblTest);
            this.gbLogin.Location = new System.Drawing.Point(239, 48);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(377, 292);
            this.gbLogin.TabIndex = 5;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "用户登录/LOGIN";
            // 
            // pbVerifyCode
            // 
            this.pbVerifyCode.Location = new System.Drawing.Point(191, 125);
            this.pbVerifyCode.Name = "pbVerifyCode";
            this.pbVerifyCode.Size = new System.Drawing.Size(91, 35);
            this.pbVerifyCode.TabIndex = 7;
            this.pbVerifyCode.TabStop = false;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(289, 135);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(77, 12);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "看不清换一张";
            this.lblChange.Click += new System.EventHandler(this.lblChange_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(172, 219);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(64, 219);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // rdobPassengers
            // 
            this.rdobPassengers.AutoSize = true;
            this.rdobPassengers.Enabled = false;
            this.rdobPassengers.Location = new System.Drawing.Point(225, 184);
            this.rdobPassengers.Name = "rdobPassengers";
            this.rdobPassengers.Size = new System.Drawing.Size(47, 16);
            this.rdobPassengers.TabIndex = 4;
            this.rdobPassengers.TabStop = true;
            this.rdobPassengers.Text = "访客";
            this.rdobPassengers.UseVisualStyleBackColor = true;
            // 
            // rdobStudent
            // 
            this.rdobStudent.AutoSize = true;
            this.rdobStudent.Location = new System.Drawing.Point(172, 184);
            this.rdobStudent.Name = "rdobStudent";
            this.rdobStudent.Size = new System.Drawing.Size(47, 16);
            this.rdobStudent.TabIndex = 4;
            this.rdobStudent.TabStop = true;
            this.rdobStudent.Text = "学生";
            this.rdobStudent.UseVisualStyleBackColor = true;
            // 
            // rdobTeacher
            // 
            this.rdobTeacher.AutoSize = true;
            this.rdobTeacher.Location = new System.Drawing.Point(119, 184);
            this.rdobTeacher.Name = "rdobTeacher";
            this.rdobTeacher.Size = new System.Drawing.Size(47, 16);
            this.rdobTeacher.TabIndex = 4;
            this.rdobTeacher.TabStop = true;
            this.rdobTeacher.Text = "教师";
            this.rdobTeacher.UseVisualStyleBackColor = true;
            // 
            // rdobDepartment
            // 
            this.rdobDepartment.AutoSize = true;
            this.rdobDepartment.Location = new System.Drawing.Point(64, 184);
            this.rdobDepartment.Name = "rdobDepartment";
            this.rdobDepartment.Size = new System.Drawing.Size(47, 16);
            this.rdobDepartment.TabIndex = 4;
            this.rdobDepartment.TabStop = true;
            this.rdobDepartment.Text = "部门";
            this.rdobDepartment.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(98, 57);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(184, 21);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "admin";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(98, 132);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(89, 21);
            this.txtTest.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(39, 60);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 12);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "用户名：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 93);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(184, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "123456";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(39, 96);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 12);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "密  码：";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(39, 135);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(53, 12);
            this.lblTest.TabIndex = 2;
            this.lblTest.Text = "验证码：";
            // 
            // picLogin
            // 
            this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
            this.picLogin.Location = new System.Drawing.Point(12, 12);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(221, 349);
            this.picLogin.TabIndex = 6;
            this.picLogin.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 373);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.gbLogin);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerifyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton rdobPassengers;
        private System.Windows.Forms.RadioButton rdobStudent;
        private System.Windows.Forms.RadioButton rdobTeacher;
        private System.Windows.Forms.RadioButton rdobDepartment;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox pbVerifyCode;
    }
}