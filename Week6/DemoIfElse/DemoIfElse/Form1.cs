using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoIfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            string strOut = "";
            DialogResult resp;
            resp = MessageBox.Show("ห้องพักถูกใจคุณหรือไม่", "Room",
                                     MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {
                strOut = "ขอบคุณครับ หวังว่าคุณจะมาใช้บริการในโอกาสหน้า";
                MessageBox.Show(strOut, "หรู เลิศ อินน์", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                strOut = "ขอบคุณ และขออภัย เราจะปรับปรุงให้ถูกใจคุณต่อไป";
                MessageBox.Show(strOut, "หรู เลิศ อินน์", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtFeedBack.Text == "")
            {
                MessageBox.Show("คุณไม่มีความเห็นเกี่ยวกับบริการ");
            }
            else
            {
                MessageBox.Show("ขอบคุณที่แสดงความคิดเห็นครับ", "หรู เลิศ อินน์",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
