using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform
{
    // 112 อัครพล พิกุลศรี Form 3
    public partial class Frm3 : Form
    {
        public Frm3()
        {
            InitializeComponent();
        }
        // Read Only property
        public string Improvement
        {
        
            get
            {
                if (lstComment.SelectedIndex == -1)
                {
                    return "";
                }
                else
                {
                    return lstComment.SelectedItem.ToString();
                }
            }
        }
        public string Comment
        {
            get
            {
                return txtOpinion.Text;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lstComment.SelectedIndex == -1)
            {
                MessageBox.Show("คุณยังไม่ได้บอกเราถึงข้อปรับปรุง", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show("เราได้จัดเก็บข้อมูลของท่านเรียบร้อยแล้ว", "Share ข้อมูล",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstComment.ClearSelected();
            txtOpinion.Clear();

        }
    }
}
