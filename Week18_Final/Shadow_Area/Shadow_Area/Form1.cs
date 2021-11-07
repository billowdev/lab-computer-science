using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shadow_Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 63102015112 Akkarapon Phikulsri
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Double doubleDistance = Convert.ToDouble(txtDistance.Text);
                if (doubleDistance >= 0 & doubleDistance <= 1000.0)
                {                             // Square Area           // Cirecle Area
                    Double doubleShadowArea = Math.Pow(doubleDistance, 2) - (Math.PI * Math.Pow((doubleDistance / 2), 2));
                    txtResult.Text = String.Format("{0:0.00}", doubleShadowArea);
                }
                else
                {
                    MessageBox.Show("กรุณากรอกจำนวนบวก ที่น้อยกว่าหรือเท่ากับ 1000.0", "คำชี้แจง", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtDistance.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("กรุณากรอกเพียงตัวเลข", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDistance.Text = "";
            txtResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการปิดโปรแกรมใช่หรือไม่ ?", "คุณต้องการจบการทำงาน", 
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("ขอบคุณที่ใช้โปรแกรมครับ : ) ", "จบการทำงาน", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("โปรแกรมยังทำงานต่อไป...", "กำลังทำงาน...", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
