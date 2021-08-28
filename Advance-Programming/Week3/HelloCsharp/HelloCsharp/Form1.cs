using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCsharp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        // 112 Akkarapon Phikulsri
        private void btnGreeting_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtName.Text);
        }
        private void btnGreeting_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("คุณต้องการจบการทำงานใช่หรือไม่", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("จบการทำงาน", "End");
                this.Close();
            }
            else
            {
                MessageBox.Show("คุณยังคงทำงานต่อไป", "Continue");
            }

            

        }


    }
}
