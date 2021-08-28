using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_Ex1

{

    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // 112 อัครพล พิกุลศรี
        private void FrmMain_Load(object sender, EventArgs e)
        {
            rdbWhite.Enabled = false;
            rdbBlack.Enabled = false;
            rdbGray.Enabled = false;
        }

        private void btnChangeText_Click(object sender, EventArgs e)
        {
            this.Text = txtText.Text;
        }

        private void btnChangeBgColor_Click(object sender, EventArgs e)
        {
            rdbWhite.Enabled = true;
            rdbBlack.Enabled = true;
            rdbGray.Enabled = true;
        }

        private void rdbWhite_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.Text = "สีพื้นของฟอร์มขณะนี้คือ " + this.BackColor.ToString();
            rdbBlack.ForeColor = Color.Black;
            rdbGray.ForeColor = Color.Black;
            rdbWhite.ForeColor = Color.Black;
        }

        private void rdbBlack_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.Text = "สีพื้นของฟอร์มขณะนี้คือ" + this.BackColor.ToString();
            rdbBlack.ForeColor = Color.White;
            rdbGray.ForeColor = Color.White;
            rdbWhite.ForeColor = Color.White;

        }

        private void rdbGray_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            this.Text = "สีพื้นของฟอร์มขณะนี้คือ" + this.BackColor.ToString();
            rdbBlack.ForeColor = Color.White;
            rdbGray.ForeColor = Color.White;
            rdbWhite.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการจบการทำงาน ใช่หรือไม่", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("จบการทำงาน", "End");
                this.Close();
            }
            else
            {
                MessageBox.Show("คุณยังคงทำงานต่อไป", "Continue");
            }
        }

        // 112 อัครพล พิกุลศรี
        private void btnExMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("พบข้อผิดพลาดจากโปรแกรม", "ตัวอย่างที่ 4",   // Text, Caption
                           MessageBoxButtons.AbortRetryIgnore,   // Button
                           MessageBoxIcon.Error,                // Icon
                           MessageBoxDefaultButton.Button2);   // DefaultButton
        }
    }
}
