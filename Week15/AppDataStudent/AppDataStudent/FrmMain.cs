using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AppDataStudent
{

    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;data source=C:/GitHub/Computer-Science/Week15/db_student.accdb";
        public string sql;
        OleDbConnection Conn = new OleDbConnection();
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        bool IsFind = false;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.ConnectionString = strConn;
            Conn.Open();

            ShowAllStudent();
            FormatDataStudent();
        }

        private void ShowAllStudent()
        {
            string sqlStu = "select * from tb_hisstudent";
            if (IsFind == true)
            {
                ds.Tables["tb_hisstudent"].Clear();
            }

            da = new OleDbDataAdapter(sqlStu, Conn);
            da.Fill(ds, "tb_hisstudent");

            if (ds.Tables["tb_hisstudent"].Rows.Count != 0)
            {
                IsFind = true;
                dgvAllStduent.ReadOnly = true;
                dgvAllStduent.DataSource = ds.Tables["tb_hisstudent"];
            }
            else
            {
                IsFind = false;
            }
            
        }

        private void FormatDataStudent()
        {
            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            dgvAllStduent.ColumnHeadersDefaultCellStyle = cs;
            dgvAllStduent.Columns[0].HeaderText = "รหัสนักศึกษา";
            dgvAllStduent.Columns[1].HeaderText = "ชื่อ";
            dgvAllStduent.Columns[2].HeaderText = "นามสกุล";
            dgvAllStduent.Columns[3].HeaderText = "วันเดือนปีเกิด";
            dgvAllStduent.Columns[4].HeaderText = "น้ำหนัก";

            dgvAllStduent.Columns[0].Width = 120;
            dgvAllStduent.Columns[1].Width = 120;
            dgvAllStduent.Columns[2].Width = 120;
            dgvAllStduent.Columns[3].Width = 100;
            dgvAllStduent.Columns[4].Width = 70;

        }
        private void dgvAllStduent_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == dgvAllStduent.Rows.Count - 1)
            {
                return;
            }
            try
            {
                txtStdID.Text = dgvAllStduent.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvAllStduent.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = dgvAllStduent.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(dgvAllStduent.Rows[e.RowIndex].Cells[3].Value);
                txtWeight.Text = dgvAllStduent.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error", "Error krub",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ClearAllStudent()
        {
            txtStdID.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            dtpDOB.Value = DateTime.Now;
            txtWeight.Text = "";
            txtStdID.Focus();

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAllStudent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtStdID.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "ผิดพลาด");
                txtStdID.Focus();
                return;
            }
            string sqlAdd = "";
            OleDbCommand comAdd = new OleDbCommand();
            try
            {
                if (MessageBox.Show("เพิ่มข้อมูลใช่หรือไม่", "เพิ่มข้อมูล",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlAdd = "insert into tb_hisstudent(stu_id, stu_name, stu_surname, stu_bdate, stu_weight) values('"
                        + txtStdID.Text + "','" + txtName.Text + "','"
                        + txtLastName.Text + "','" + dtpDOB.Text + "','" + txtWeight.Text + "')";
                    if (Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                    }
                    Conn.ConnectionString = strConn;
                    Conn.Open();

                    comAdd.CommandType = CommandType.Text;
                    comAdd.CommandText = sqlAdd;
                    comAdd.Connection = Conn;
                    comAdd.ExecuteNonQuery();

                    MessageBox.Show("ได้บันทึกข้อมูลเรียบร้อยแล้ว", "ผลการดำเนินการ");
                    ClearAllStudent();
                    ShowAllStudent();
                      
                }
            }
            catch
            {
                MessageBox.Show("ไม่สามารถติดต่อฐานข้อมูลได้", "ผิดพลาด");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Exit", "ปิด", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
