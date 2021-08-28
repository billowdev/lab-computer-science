using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apcs001_BEtoFE
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // 112 อัครพล พิกุลศรี

            int thai_year, english_year;
            try
            {/*      ( ใช้ FormatException แทนแล้ว )
                if (txtEnglishYear.Text == "")
                {
                    MessageBox.Show("กรุณากรอกปี ค.ศ. ด้วยครับ");
                    return;
                }
                */
                english_year = Convert.ToInt32(txtEnglishYear.Text);
                if (english_year >= 0)
                {
                    thai_year = english_year + 543;
                    txtThaiYear.Text = thai_year.ToString();
                } else
                {
                    MessageBox.Show("ท่านกรอกปี ค.ศ ไม่ถูกต้อง");
                }
                
            } catch(FormatException)
            {
                MessageBox.Show("กรุณากรอกปีค.ศ.ที่ถูกต้อง ด้วยครับ เช่น 2001");
            }
            
            
        }
    }
}
