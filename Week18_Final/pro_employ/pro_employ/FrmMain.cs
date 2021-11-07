using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb; // for connect to db

namespace pro_employ
{
    // 63102105112 Akkarapon Phikulsri
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;data source= ../../../db_employ.accdb";
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

            ShowAllEmployee();
            FormatDataEmployee();
        }

        private void ShowAllEmployee()
        {
            string sqlEmp = "select * from tb_employ";
            if (IsFind == true)
            {
                ds.Tables["tb_employ"].Clear();
            }

            da = new OleDbDataAdapter(sqlEmp, Conn);
            da.Fill(ds, "tb_employ");

            if (ds.Tables["tb_employ"].Rows.Count != 0)
            {
                IsFind = true;
                dgvAllEmployee.ReadOnly = true;
                dgvAllEmployee.DataSource = ds.Tables["tb_employ"];
            }
            else
            {
                IsFind = false;
            }

        }

        private void FormatDataEmployee()
        {
            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            dgvAllEmployee.ColumnHeadersDefaultCellStyle = cs;
            dgvAllEmployee.Columns[0].HeaderText = "รหัสพนักงาน";
            dgvAllEmployee.Columns[1].HeaderText = "ชื่อ";
            dgvAllEmployee.Columns[2].HeaderText = "นามสกุล";
            dgvAllEmployee.Columns[3].HeaderText = "วันเดือนปีเกิด";
            dgvAllEmployee.Columns[4].HeaderText = "แผนก";
            dgvAllEmployee.Columns[5].HeaderText = "เงินเดือน";

            dgvAllEmployee.Columns[0].Width = 120;
            dgvAllEmployee.Columns[1].Width = 190;
            dgvAllEmployee.Columns[2].Width = 190;
            dgvAllEmployee.Columns[3].Width = 140;
            dgvAllEmployee.Columns[4].Width = 180;
            dgvAllEmployee.Columns[5].Width = 160;

        }

        private void dgvAllEmployee_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == dgvAllEmployee.Rows.Count - 1)
            {
                return;
            }
            try
            {
                txtEmpId.Text = dgvAllEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvAllEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = dgvAllEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpBirthDate.Value = Convert.ToDateTime(dgvAllEmployee.Rows[e.RowIndex].Cells[3].Value);
                txtDepartment.Text = dgvAllEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSalary.Text = dgvAllEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error", "เกิดข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAllEmployee()
        {
            txtEmpId.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            dtpBirthDate.Value = DateTime.Now;
            txtDepartment.Text = "";
            txtSalary.Text = "";
          
            txtEmpId.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAllEmployee();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmpId.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "ผิดพลาด");
                txtEmpId.Focus();
                return;
            }

            string sqlAdd = "";
            OleDbCommand comAdd = new OleDbCommand();
            try
            {
                if (MessageBox.Show("เพิ่มข้อมูลใช่หรือไม่", "เพิ่มข้อมูล",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlAdd = "insert into tb_employ(em_id, em_name, em_surname, em_bdate, em_department, em_salary) values('"
                        + txtEmpId.Text + "','"
                        + txtName.Text + "','"
                        + txtLastName.Text + "','"
                        + dtpBirthDate.Value + "','"
                        + txtDepartment.Text + "','"
                        + txtSalary.Text + "')";

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
                    ClearAllEmployee();
                    ShowAllEmployee();

                }
            }
            catch
            {
                MessageBox.Show("ไม่สามารถติดต่อฐานข้อมูลได้", "ผิดพลาด");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลที่จะแก้ไขให้ครบ", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            string sqlEdit;
            OleDbCommand comEdit = new OleDbCommand();
            try
            {
                if (MessageBox.Show("คุณต้องการแก้ไขข้อมูลใช่หรือไม่", "ยืนยัน",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlEdit = "update tb_employ set em_name = '" + txtName.Text
                        + "',em_surname = '" + txtLastName.Text
                        + "',em_bdate = '" + dtpBirthDate.Value
                        + "',em_department = '" + txtDepartment.Text
                        + "',em_salary = '" + txtSalary.Text
                        + "'where em_id = '" + txtEmpId.Text + "'";

                    if (Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                    }
                    Conn.ConnectionString = strConn;
                    Conn.Open();

                    comEdit.CommandType = CommandType.Text;
                    comEdit.CommandText = sqlEdit;
                    comEdit.Connection = Conn;
                    comEdit.ExecuteNonQuery();

                    MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว");
                    ClearAllEmployee();
                    ShowAllEmployee();

                }
            }
            catch
            {
                MessageBox.Show("ข้อมูลผิดพลาด", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpId.Text == "")
                {
                    MessageBox.Show("กรุณาเลือกข้อมูลที่จะลบ", "ผิดพลาด");
                    return;
                }
                String sqlDel = "delete from tb_employ where em_id = '" + txtEmpId.Text + "'";
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }

                Conn.ConnectionString = strConn;
                Conn.Open();

                OleDbCommand comDel = new OleDbCommand(sqlDel, Conn);

                if (MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยัน",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    comDel.ExecuteNonQuery();
                    MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "ผลการดำเนินการ");
                    ClearAllEmployee();
                    ShowAllEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlEmp = "select * from tb_employ where em_id = '" + txtSearch.Text + "'";
            if (IsFind == true)
            {
                ds.Tables["tb_employ"].Clear();
            }

            da = new OleDbDataAdapter(sqlEmp, Conn);
            da.Fill(ds, "tb_employ");

            if (ds.Tables["tb_employ"].Rows.Count != 0)
            {
                IsFind = true;
                dgvAllEmployee.ReadOnly = true;
                dgvAllEmployee.DataSource = ds.Tables["tb_employ"];
            }
            else
            {
                IsFind = false;
            }
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            ShowAllEmployee();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการปิดโปรแกรมใช่หรือไม่ ?", "คุณต้องการจบการทำงาน",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("ขอบคุณที่ใช้โปรแกรมครับ : ) ", "จบการทำงาน",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("โปรแกรมยังทำงานต่อไป...", "กำลังทำงาน...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}




