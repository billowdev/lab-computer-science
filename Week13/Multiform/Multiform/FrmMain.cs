using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform
{
    // 112 อัครพล พิกุลศรี Form Main
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        UserFrm frmUser = new UserFrm();
        Frm3 frmComment = new Frm3();

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUser.ShowDialog();

        }

        private void btnOpinion_Click(object sender, EventArgs e)
        {
            frmComment.ShowDialog();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            string strOut = "";
            strOut += "ข้อมูลจาก : " + frmUser.UserName + "\n";
            strOut += "---------------------------------- \n ";
            strOut += "สิ่งที่ต้องการให้ปรับปรุง คือ " + frmComment.Improvement + "\n";
            strOut += "---------------------------------- \n ";
            strOut += "ความคิดเห็นเพิ่มเติม คือ " + frmComment.Comment;
            MessageBox.Show(strOut, "summary", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
