using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoArray2D
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int[,] intArray = new int[4, 3];
            Random rndObj = new Random();
            string strOut = "";

            for (int j = intArray.GetLowerBound(1); j <= intArray.GetUpperBound(1); j++){

                for (int i = intArray.GetLowerBound(0); i <= intArray.GetUpperBound(0); i++)
                {

                    intArray[i, j] = rndObj.Next(10);
                    strOut += "intArray[" + i.ToString() + "," + j.ToString() + "] = " + intArray[i, j].ToString() + "  ";
                }
                strOut += "\n";
            }
            MessageBox.Show(strOut, "โชว์ข้อมูลในอาร์เรย์ 2 มิติ");
        }
    }
}
