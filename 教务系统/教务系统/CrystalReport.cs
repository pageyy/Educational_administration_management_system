using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 教务系统
{
    public partial class CrystalReport : Form
    {
        //用于保存报表打印窗体传递来的学号
        public static string studentID;

        public CrystalReport()
        {
            InitializeComponent();
        }

        private void CrystalReport_Load(object sender, EventArgs e)
        {
            
        }
    }
}
