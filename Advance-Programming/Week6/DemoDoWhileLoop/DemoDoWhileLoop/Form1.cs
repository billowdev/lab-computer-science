using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDoWhileLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int i;
            i = 20;
            lstShow.Items.Clear();
            do
            {
                lstShow.Items.Add("วนลูปครั้งที่ " + i);
                i--;
            } while (i > 0);
        }
    }
}
