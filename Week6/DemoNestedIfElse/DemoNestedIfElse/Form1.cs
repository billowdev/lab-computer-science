using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoNestedIfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("คุณเคยใช้งานอีเมลหรือไม่?", "E-mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                resp = MessageBox.Show("เคยพบอีเมลขยะหรือไม่?","Spam ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    MessageBox.Show("แนะนำให้คุณใช้โปรแกรม SpamKiller", "คำแนะนำ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("คุณควรติดตั้งโปรแกรมป้องกันสแปมเมลไว้ด้วย", "คำแนะนำ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("คุณน่าจะทดลองใช้อีเมลบ้างนะครับ", "Oh !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void btnEmailSafe_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("คุณเคยโดยสารเครื่องบินหรือไม่?", "Air", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                MessageBox.Show("คุณมั่นใจในความปลอดภัยของเครื่องบิน", "ความปลอดภัย", MessageBoxButtons.OK);
            }
            else
            {
                resp = MessageBox.Show("คุณคิดว่าเครื่องบินปลอดภัยหรือไม่", "Safety", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    MessageBox.Show("คุณมั่นใจในความปลอดภัยของเครื่องบิน", "ความปลอดภัย", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ที่จริงเครื่องบินมีระบบความปลอดภัยสูงมากนะครับ", "ความปลอดภัย", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
