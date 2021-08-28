using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoIfElseIfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalScore_Click(object sender, EventArgs e)
        {
            try
            {

            
                string strOut = "";
                int intScore = Convert.ToInt32(txtScore.Text);
                if ((intScore < 0) || (intScore > 100)) {
                    strOut = "กรอกคะแนนผิดพลาด, คุณต้องกรอกคะแนนระหว่าง 0 ถึง 100";
                }
                else if (intScore < 50){
                    strOut = "คะแนน = " + intScore.ToString() + " : เกรด 0 สอบตก"; 
                }
                else if (intScore < 60)
                {
                    strOut = "คะแนน = " + intScore.ToString() + " : เกรด 1 ผ่าน";
                }
                else if (intScore < 70)
                {
                    strOut = "คะแนน = " + intScore.ToString() + " : เกรด 2 พอใช้";
                }
                else if (intScore < 80)
                {
                    strOut = "คะแนน = " + intScore.ToString() + " : เกรด 3 ดี";
                }
                else
                { 
                    strOut = "คะแนน = " + intScore.ToString() + " : เกรด 4 คะแนนดีมาก";
                }
                MessageBox.Show(strOut, "Grading", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("กรุณากรอกเพียงตัวเลข", "กรอกเกรดใหม่!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("จบการทำงาน", "ปิดโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
   
        }
    }
}
