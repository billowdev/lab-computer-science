using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 112 อัครพล พิกุลศรี
        private void btnCal_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text == "" || txtVat.Text == "")
            {
                MessageBox.Show("คุณต้องระบุข้อมูลให้ครบ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double dbPrice = Convert.ToDouble(txtPrice.Text);
            double dbVat = Convert.ToDouble(txtVat.Text);
            string ttp = CalTotalPrice(dbPrice, dbVat);
            MessageBox.Show("ราคาสินค้า = " + ttp, "คำนวณราคา" );
               
        }
        private string CalTotalPrice(double pr, double vt)
        {
            if ( (pr > 0) && (vt > 0))
            {
                double TotalPrice = pr * ( 1 + (vt / 100));
                return TotalPrice.ToString("#,##0.00#") + " บาท";
            }
            else
            {
                return "ผิดพลาด ไม่สามารถคำนวณได้";
            }
        }
    }
}
