using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForeach
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            int[] intArray = new int[6] { 2, 4, 6, 8, 10, 12 };

            string[] strArray;
            strArray = new string[3];
            strArray[0] = "กรุงเทพ";
            strArray[1] = "มุกดาหาร";
            strArray[2] = "ลอนดอน";

            string strOut = "";
            int idx = 0;
            foreach (int iTemp in intArray)
            {
                strOut += "intArray[" + idx.ToString() + "] = " + iTemp.ToString() + "\n";
                idx++;
            }
            MessageBox.Show(strOut, "โชวข้อมูลในอาร์เรย์ intArray");

            strOut = "";
            idx = 0;
            foreach (string sTemp in strArray)
            {
                strOut += "strArray[" + idx.ToString() + "]=" + '\"' + sTemp + '\"' + "\n";
                idx++;
            }
             MessageBox.Show(strOut, "โชว์ข้อมูลใน strArray");
        }
    }
}
