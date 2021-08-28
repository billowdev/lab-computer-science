using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForLoop
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLoopForward_Click(object sender, EventArgs e)
        {
            int cnt = 14;
            string strOut = "วนซ้ำรอบทั้งหมด = " + cnt.ToString() + " รอบ" + "\r\n";
            strOut += "----------------------------------------" + "\r\n";
            for (int i = 1; i <= cnt; i++)
            {
                strOut += "วนรอบที่ :" + i.ToString() + "\r\n";
            }
            txtOut.Text = strOut;
        }

        private void btnLoopBackward_Click(object sender, EventArgs e)
        {
            int cnt = 14;
            string strOut = "วนซ้ำรอบทั้งหมด = " + cnt.ToString() + " รอบ" + "\r\n";
            strOut += "----------------------------------------" + "\r\n";
            for (int i = cnt; i >= 1; i--)
            {
                strOut += "นับถอยหลัง :" + i.ToString() + "\r\n";
            }
            txtOut.Text = strOut;
        }

        private void btnChangeStepLoop_Click(object sender, EventArgs e)
        {
            int cnt = 25;
            string strOut = "วนซ้ำแบบ Strp, ค่าตัวแปรวนซ้ำ = " + cnt.ToString() + " รอบ, สเต็ปละ 3" + "\r\n";
            strOut += "----------------------------------------" + "\r\n";
            for (int i = 0; i <= cnt; i += 3)
            {
                strOut += "ค่าที่ได้จากการเพิ่มสเต็ป :" + i.ToString() + "\r\n";
            }
            txtOut.Text = strOut;
        }
    }
}
