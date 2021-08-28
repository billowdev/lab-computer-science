using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_break_continue_return_goto
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            Random rndObj = new Random();
            int num = rndObj.Next(10);
            txtOut.Text = "";
            for (int i = 1; i <= 10; i++)
            {
                txtOut.Text += "วนรอบที่ " + i.ToString() + "\r\n";
                if (i == num)
                {
                    txtOut.Text += "สุ่มตัวเลขมา = " + num.ToString();
                    break;
                }
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Random rndObj = new Random();
            int num = rndObj.Next(10);
            txtOut.Text = "";
            for (int i = 1; i <= 10; i++)
            {
                txtOut.Text += "วนรอบที่ " + i.ToString() + "\r\n";
                if (i == num)
                {
                    txtOut.Text += "สุ่มตัวเลขมา = " + num.ToString();
                    continue;
                }
                txtOut.Text += "\r\n";
            }
        }

        private void btnGoto_Click(object sender, EventArgs e)
        {
            Random rndObj = new Random();
            int num = rndObj.Next(10);
            switch (num)
            {
                case 0:
                txtOut.Text += "สุ่มได้เลข 0 " + "\r\n";
                break;
                case 1:
                    txtOut.Text += "สุ่มได้เลข คี่ " + "\r\n";
                    break;
                case 2:
                    txtOut.Text += "สุ่มได้เลข คู่ " + "\r\n";
                    break;
                case 3:
                    txtOut.Text += "สุ่มได้เลข สาม " + "\r\n";
                    goto case 1;
                case 4:
                    txtOut.Text += "สุ่มได้เลข สี่ " + "\r\n";
                    goto case 2;
                case 5:
                    txtOut.Text += "สุ่มได้เลข สี่ " + "\r\n";
                    goto case 1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
        }
    }
}
