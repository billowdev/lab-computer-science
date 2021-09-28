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
    public partial class UserFrm : Form
    {
        public UserFrm()
        {
            InitializeComponent();
        }
        // สามารถเรียกใช้ Property UserName โดยอ้างอิงถึง Frm2 ได้จาก Frm อื่น
        public string UserName
        {
            get
            {
                return txtName.Text;
            }
            set
            {
                // กำหนดค่า ให้กับ property
                txtName.Text = value;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string strInput = "";
            if (txtName.Text == "")
            {
                MessageBox.Show("กรุณากรอกชื่อ-นามสกุล", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            strInput += "ยืนยันข้อมูลอีกครั้ง \n";
            strInput += "ชื่อ - นามสกุล = " + txtName.Text + "\n";
            strInput += "เบอร์มือถือ = " + mtbPhone.Text + "\n";
            strInput += "อีเมล = " + txtEmail.Text;
            
            if ( MessageBox.Show(strInput, "ยืนยันข้อมูล", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information) == DialogResult.OK  )
            {
                this.Close();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            mtbPhone.Clear();
            txtEmail.Clear();
        }

        private void UserFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
