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

namespace DemoArrayList

{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct MyStruct
        {
            public string Name;
            public string Phone;
            public string Email;
        }
        private ArrayList MyRecord = new ArrayList();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( (txtName.Text == "") || (txtPhone.Text=="") || (txtEmail.Text == "") ){
                MessageBox.Show("คุณต้องเติมข้อมูลให้ครบ", "ผิดพลาดครับ");
            }
            else
            {
                MyStruct structX;
                structX.Name = txtName.Text;
                structX.Phone = txtPhone.Text;
                structX.Email = txtEmail.Text;
                string strAL = structX.Name + ":" + structX.Phone + ":" + structX.Email;

                MyRecord.Add(structX);
                lstRecord.Items.Add(strAL);
                txtName.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if ( lstRecord.SelectedIndex == -1)
            {
                MessageBox.Show("คุณต้องเบือกรายการที่จะลบ หรือไม่มีรายการให้ลบแล้ว", "ผิดพลาดครับ");
            }
            else
            {
                MyRecord.Remove(lstRecord.SelectedIndex);
                lstRecord.Items.RemoveAt(lstRecord.SelectedIndex);
            }
        }
    }
}
