using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestArray
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //string[] strStudent = new string[5];
            //strStudent[0] = txtN1.Text;
            //strStudent[1] = txtN2.Text;
            //strStudent[2] = txtN3.Text;
            //strStudent[3] = txtN4.Text;
            //strStudent[4] = txtN5.Text;

            string[] strStudentName = { txtN1.Text, txtN2.Text, txtN3.Text, txtN4.Text, txtN5.Text };

            MessageBox.Show(strStudentName[0]);

            // ----------------------------------------------------------------- //
            string strOut = "";
            int idx = 1;
            foreach (string iTemp in strStudentName)
            {
                strOut += "นักศึกษาคนที่ " + idx.ToString() + " = " + iTemp.ToString() + "\n";
                idx++;
            }
            MessageBox.Show(strOut, "โชวข้อมูลในอาร์เรย์ strStudentName");
        }
    }
}
