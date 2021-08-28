using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace LabCh6._0_ArrayList
{
    // 112 อัครพล พิกุลศรี
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public struct MyStruct
        {
            public string NameFruit;
            public int Kilograms;
        }
        private ArrayList MyFruitStock = new ArrayList();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtNameFruit.Text == "") || (txtKg.Text == ""))
            {
                MessageBox.Show("คุณต้องเติมข้อมูลให้ครบ", "ผิดพลาดครับ");
            }
            else
            {
                MyStruct structFruitStock;
                structFruitStock.NameFruit = txtNameFruit.Text;
                structFruitStock.Kilograms = Convert.ToInt32(txtKg.Text);
                string strAL = "ผลไม้: " + structFruitStock.NameFruit + " มีสินค้า : " + Convert.ToString(structFruitStock.Kilograms) + "กิโลกรัม";

                MyFruitStock.Add(structFruitStock);
                lbShow.Items.Add(strAL);
                txtKg.Text = "";
                txtNameFruit.Text = "";

            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if ( lbShow.SelectedIndex == -1)
            {
                MessageBox.Show("คุณต้องเลือกรายการที่จะลบ", "ผิดพลาด");
            }
            else
            {
                MyFruitStock.Remove(lbShow.SelectedIndex);
                lbShow.Items.RemoveAt(lbShow.SelectedIndex);
            }
        }
    }
}
