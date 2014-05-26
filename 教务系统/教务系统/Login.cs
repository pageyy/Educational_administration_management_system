using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JWSys.Model;
using JWSys.DAL;
using 教务系统.Student;
using 教务系统.Teacher;

namespace 教务系统
{
    public partial class Login : Form
    {
        //随机码长度
        private const int iVerifyCodeLength = 4;
        //随机码
        private String strVerifyCode = "";

        public Login()
        {
            InitializeComponent();
        }

        #region 验证码
        private string CreateRandomCode(int iLength)
        {
            int rand;
            char code;
            string randomCode = String.Empty;
            //生成一定长度的验证码
            Random random = new Random();
            for (int i = 0; i < iLength; i++)
            {
                rand = random.Next();

                if (rand % 3 == 0)
                {
                    code = (char)('A' + (char)(rand % 26));
                }
                else
                {
                    code = (char)('0' + (char)(rand % 10));
                }
                randomCode += code.ToString();
            }
            return randomCode;
        }

        
        private void Createimage(string strVerifyCode)
        {
            try
            {
                int iRandAngle = 45;//随机旋转角度
                int iMapWidth = (int)(strVerifyCode.Length * 21);
                Bitmap map = new Bitmap(iMapWidth, 28);//创建图片背景

                Graphics graph = Graphics.FromImage(map);
                graph.Clear(Color.AliceBlue);//清除画面，填充背景
                graph.DrawRectangle(new Pen(Color.Black, 0), 0, 0, map.Width - 1, map.Height - 1);
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//模式

                Random rand = new Random();

                //背景噪点生成
                Pen blackPen = new Pen(Color.LightGray, 0);
                for (int i = 0; i < 50; i++)
                {
                    int x = rand.Next(0, map.Width);
                    int y = rand.Next(0, map.Height);
                    graph.DrawRectangle(blackPen, x, y, 1, 1);
                }

                //验证码旋转，防止机器识别
                char[] chars = strVerifyCode.ToCharArray();//拆撒字符串成单字符组

                //文字居中
                StringFormat format = new StringFormat(StringFormatFlags.NoClip);
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                //定义颜色
                Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };
                //定义字体
                string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };

                for (int i = 0; i < chars.Length; i++)
                {
                    int cindex = rand.Next(7);
                    int findex = rand.Next(5);

                    Font f = new System.Drawing.Font(font[findex], 13, System.Drawing.FontStyle.Bold);//(字体样式)(参数2为字体大小)

                    Brush b = new System.Drawing.SolidBrush(c[cindex]);

                    Point dot = new Point(16, 16);
                    float angle = rand.Next(-iRandAngle, iRandAngle);//转动的角度
                    graph.TranslateTransform(dot.X, dot.Y);//移动贯标到指定位置
                    graph.RotateTransform(angle);
                    graph.DrawString(chars[i].ToString(), f, b, 1, 1, format);

                    graph.RotateTransform(-angle);//转回去
                    graph.TranslateTransform(2, -dot.Y);//移动光标到指定位置
                }
                pbVerifyCode.Image = map;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("创建图片错误!");
            }
        }
        
        private void UpdateVerifyCode()
        {
            strVerifyCode = CreateRandomCode(iVerifyCodeLength);
            Createimage(strVerifyCode);
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string test = txtTest.Text.Trim();
            int guaid = 0;//表示当前用户类型，1为管理员，2为学生，3为教师

            if (userName != "" && password != ""&&test!=""&&(rdobDepartment.Checked||rdobTeacher.Checked||rdobStudent.Checked||rdobPassengers.Checked))
            {
                if (test == strVerifyCode)
                {
                    Loger log = new Loger();
                    if (rdobDepartment.Checked)
                    {
                        //admin
                        log = new LogerDAL().GetByAdminName(userName);
                        guaid = 1;
                    }
                    else if (rdobStudent.Checked)
                    {
                        //student
                        log = new LogerDAL().GetByStudentName(userName);
                        guaid = 2;

                    }
                    else if (rdobTeacher.Checked)
                    {
                        //teacher
                        log = new LogerDAL().GetByTeacherName(userName);
                        guaid = 3;
                    }

                    if (log == null)
                    {
                        MessageBox.Show("用户名或密码错误！");
                    }
                    else
                    {
                        if (password != log.Password.Trim())
                        {
                            MessageBox.Show("用户名或密码错误！");
                        }
                        else
                        {
                            this.Hide();
                            if (guaid == 1)
                            {
                                MainForm adminmf = new MainForm();
                                adminmf.ShowDialog();
                            }
                            else if (guaid == 2)
                            {
                                StuMainForm stumf = new StuMainForm();
                                stumf.ShowDialog();
                            }
                            else if (guaid == 3)
                            {
                                TeaMainForm teamf = new TeaMainForm();
                                teamf.ShowDialog();
                            }
                            this.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("输入验证码有误！");
                    txtTest.Text = "";
                }
            }
            else
            {
                MessageBox.Show("请输入用户信息！");
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtTest.Text = "";
            UpdateVerifyCode();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            UpdateVerifyCode();
        }

        private void lblChange_Click(object sender, EventArgs e)
        {
            UpdateVerifyCode();
        }
    }
}
