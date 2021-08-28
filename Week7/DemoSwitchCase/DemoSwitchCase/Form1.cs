using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSwitchCase
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           
            int kilo = Convert.ToInt32(txtKg.Text);
            int numcase = 0;
            if (cbOrange.Checked)
            {
                numcase = 1;
            }
            if (cbMangoSteen.Checked)
            {
                numcase = 2;
            }
            if (cbLamud.Checked)
            {
                numcase = 3;
            }
            if (cbLambutan.Checked)
            {
                numcase = 4;
            }

            int result;
            switch (numcase)
            {   
                case 1:
                    lbPriceDetail.Text = "ส้มกิโลละ 30 บาท";
                    result = Convert.ToInt32(txtKg.Text) * 30;
                    txtBaht.Text = Convert.ToString(result);
                    lbLastResult.Text = "คุณซื้อส้ม" + txtKg.Text + "กิโลกรัม" + " คิดเป็นเงิน";
                    break;
                case 2:
                    lbPriceDetail.Text = "มังคุดกิโลละ 60 บาท";
                    result = Convert.ToInt32(txtKg.Text) * 60;
                    txtBaht.Text = Convert.ToString(result);
                    lbLastResult.Text = "คุณซื้อมังคุด" + txtKg.Text + "กิโลกรัม" + " คิดเป็นเงิน";
                    break;
                case 3:
                    lbPriceDetail.Text = "ละมุดกิโลละ 45 บาท";
                    result = Convert.ToInt32(txtKg.Text) * 45;
                    lbLastResult.Text = "คุณซื้อละมุด" + txtKg.Text + "กิโลกรัม" + " คิดเป็นเงิน";
                    txtBaht.Text = Convert.ToString(result);
                    break;
                case 4:
                    lbPriceDetail.Text = "ลำไยกิโลละ 5 บาท";
                    result = Convert.ToInt32(txtKg.Text) * 5;
                    lbLastResult.Text = "คุณซื้อลำไย" + txtKg.Text + "กิโลกรัม" + " คิดเป็นเงิน";
                    txtBaht.Text = Convert.ToString(result);
                    break;



                    //int num
                    // ---------------------------------
                    //List<CheckBox> chbList = this.Controls.OfType<CheckBox>().ToList();
                    //foreach (var chb in chbList)
                    //{
                    //    chb.Checked = true;
                    //    switch (chb)
                    //        case 0:

                    //}
                    //-----------------------------
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKg.Text = "";
            txtBaht.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากโปรแกรม", "ออกจากโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("จบการทำงาน", "Exit..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("โปรแกรมยังคงทำงานต่อไป", "Continue..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
