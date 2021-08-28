using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labch2DateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 112 Akkarapon Phikulsri
        private void btnShowTime_Click(object sender, EventArgs e)
        {
            string DtAndtime = DateTime.Now.ToString("dd'/'MM'/'yyyy' เวลา 'HH':'mm':'ss");

            
            MessageBox.Show("วัน และเวลาขณะนี้คือ.."+ DtAndtime, "Now !");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการจบการทำงานใช่หรือไม่ ?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("จบการทำงานครับ", "End");
                this.Close();
            }
            else
            {
                MessageBox.Show("คุณยังคงทำงานต่อไป", "Continue");
            }
        }
    }
}
