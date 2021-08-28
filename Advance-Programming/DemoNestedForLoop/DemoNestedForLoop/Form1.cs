using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoNestedForLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDrawTable_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
            for (int row = 1; row < nudRow.Value; row++)
            {
                for (int column = 1; column <= nudColumn.Value; column++)
                {
                    txtOut.Text += column.ToString() + " | ";
                }
                txtOut.Text += "\r\n";
            }
        }

        private void btnDrawTriangleUp_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
            for (int j = 1; j <= (int)nudTriRow.Value; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    txtOut.Text += i.ToString() + "  ";
                }
                txtOut.Text += "\r\n";
            }
        }

        private void btnDrawTriangleDown_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
            for (int j = (int)nudTriRow.Value; j >= 1; j--)
            {
                for (int i = 1; i <= j; i++)
                {
                    txtOut.Text += i.ToString() + "  ";
                }
                txtOut.Text += "\r\n";
            }
        }
    }
}
