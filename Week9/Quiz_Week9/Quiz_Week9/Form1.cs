using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 112 อัครพล พิกุลศรี
namespace Quiz_Week9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int intScore = Convert.ToInt32(txtScore.Text);
            if (intScore >= 50)
            {
                MessageBox.Show("สอบผ่าน ", "ผลสอบ");
            }
            else
            {
                MessageBox.Show("สอบไม่ผ่าน", "ผลสอบ");
            }
        }
    }
}
