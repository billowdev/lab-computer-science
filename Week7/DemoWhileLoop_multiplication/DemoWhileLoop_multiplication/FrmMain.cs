using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWhileLoop_multiplication
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lstShow.Items.Clear();
            int numMultiply = Convert.ToInt32(txtNum.Text);
            int i = 1;
            while (i <= 12)
            {
                int resInt = i * numMultiply;
                string resString = Convert.ToString(numMultiply) + "x" + Convert.ToString(i) + "   =   " + Convert.ToString(resInt);
                lstShow.Items.Add(resString);
                i++;
                
            }
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            lstShow.Items.Clear();
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
