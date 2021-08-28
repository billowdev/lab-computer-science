using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_Assignment_ShadowArea
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtValueOfN.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 63102105112 อัครพล พิกุลศรี
            try
            {
                Double doubleN = Convert.ToDouble(txtValueOfN.Text);
                if (doubleN >= 0 & doubleN <= 1000.0)
                {                             // Square Area           // Cirecle Area
                    Double doubleShadowArea = Math.Pow(doubleN, 2) - (Math.PI * Math.Pow((doubleN / 2), 2));
                    txtShadowArea.Text = String.Format("{0:0.00}", doubleShadowArea);
                }
                else
                {
                    MessageBox.Show("กรุณากรอกจำนวนบวก ที่ <= 1000.0", "คำชี้แจง", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtShadowArea.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("กรุณากรอกเพียงตัวเลข", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการปิดโปรแกรมใช่หรือไม่ ?", "คุณต้องการจบการทำงาน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("โปรแกรมหยุดทำงาน !", "จบการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("โปรแกรมยังทำงานต่อไป...", "กำลังทำงาน...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
