using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_BMI_Calculate
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 112 อัครพล พิกุลศรี
            // ผมไปศึกษา listView กับ Array เพิ่มเติม ครับเลยอยากเอามาใส่ในโปรเจคนี้
            this.ActiveControl = txtWeight; // https://stackoverflow.com/questions/6597196/how-to-put-focus-on-textbox-when-the-form-load
            labelSumary.Hide();

            // ref : https://www.c-sharpcorner.com/UploadFile/mahesh/working-with-listview-in-C-Sharp/
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            // add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;

            // Add Item
            arr = new string[] { "น้อยกว่า 18.50", "น้ำหนักน้อย / ผอม", "มากกว่าคนปกติ" };
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            arr = new string[] { "ระหว่าง 18.50 - 22.90", "ปกติ (สุขภาพดี)", "เท่าคนปกติ" };
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            arr = new string[] { "ระหว่าง 23 - 24.90", "ท้วม / โรคอ้วนระดับ 1", "อันตรายระดับ 1" };
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            arr = new string[] { "ระหว่าง 25 - 29.90", "อ้วน / โรคอ้วนระดับ 2", "อันตรายระดับ 2" };
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            arr = new string[] { "มากกว่า 30", "อ้วนมาก / โรคอ้วนระดับ 3", "อันตรายระดับ 3" };
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            Double height, weight, resbmi;
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays
            string[,] bmiArr = new string[,] { { "น้อยกว่า 18.50", "น้ำหนักน้อย / ผอม", "มากกว่าคนปกติ"  },
                                               { "ระหว่าง 18.50 - 22.90", "ปกติ (สุขภาพดี)", "เท่าคนปกติ" },
                                               { "ระหว่าง 23 - 24.90", "ท้วม / โรคอ้วนระดับ 1", "อันตรายระดับ 1" },
                                               { "ระหว่าง 25 - 29.90", "อ้วน / โรคอ้วนระดับ 2", "อันตรายระดับ 2" },
                                               { "มากกว่า 30", "อ้วนมาก / โรคอ้วนระดับ 3", "อันตรายระดับ 3" } };
            try
            {   
                weight = Convert.ToDouble(txtWeight.Text);
                height = Convert.ToDouble(txtHeight.Text);
                height = height / 100; // cm to m.
                resbmi = weight / (height * height); //  BMI = weight / height pow 2
                txtBMI.Text = String.Format("{0:0.00}", resbmi); // .2f

                labelSumary.Show();
                Double BMICheck = Convert.ToDouble(resbmi); // for check bmi

                if (BMICheck <= 18.50 & !(BMICheck > 18.50))
                {
                    labelSumary.Text = "ค่า BMI ของคุณคือ " +
                                        txtBMI.Text + " kg/m^2" +
                                        " ซึ่ง" + bmiArr[0, 0] + 
                                        " และอยู่ในเกณท์ "+bmiArr[0, 1] +
                                        " มีภาวะเสี่ยงต่อโรค" + bmiArr[0, 2];
                }
                if(BMICheck > 18.50 & BMICheck <= 22.90)
                {
                    labelSumary.Text = "ค่า BMI ของคุณคือ " +
                                        txtBMI.Text + " kg/m^2" +
                                        " ซึ่งอยู่" + bmiArr[1, 0] +
                                        " และอยู่ในเกณท์ " + bmiArr[1, 1] +
                                        " มีภาวะเสี่ยงต่อโรค" + bmiArr[1, 2];
                }
                if(BMICheck > 23 & BMICheck <= 24.90)
                {
                    labelSumary.Text = "ค่า BMI ของคุณคือ " +
                                        txtBMI.Text + " kg/m^2" +
                                        " ซึ่งอยู่" + bmiArr[2, 0] +
                                        " และอยู่ในเกณท์ " + bmiArr[2, 1] +
                                        " มีภาวะเสี่ยงต่อโรค" + bmiArr[2, 2];
                }
                if(BMICheck > 25 & BMICheck <= 29.90)
                {
                    labelSumary.Text = "ค่า BMI ของคุณคือ " +
                                 txtBMI.Text + " kg/m^2" +
                                 " ซึ่งอยู่" + bmiArr[3, 0] +
                                 " และอยู่ในเกณท์ " + bmiArr[3, 1] +
                                 " มีภาวะเสี่ยงต่อโรค" + bmiArr[3, 2];
                }
                if(BMICheck > 30)
                {
                    labelSumary.Text = "ค่า BMI ของคุณคือ " +
                                     txtBMI.Text + " kg/m^2" +
                                     " ซึ่ง" + bmiArr[4, 0] +
                                     " และอยู่ในเกณท์ " + bmiArr[4, 1] +
                                     " มีภาวะเสี่ยงต่อโรค" + bmiArr[4, 2];
                }
                txtBMI.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("กรุณากรอกข้อมูล น้ำหนัก/ส่วนสูงใหม่", "พบข้อผิดพลาด", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากโปรแกรม", "ออกจากโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("จบการทำงาน", "Exit..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("โปรแกรมยังคงทำงานต่อไป", "Continue..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBMI.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            labelSumary.Text = "";
            txtWeight.Focus();
        }
    }
}
