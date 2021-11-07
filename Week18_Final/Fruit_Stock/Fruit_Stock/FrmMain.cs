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

namespace Fruit_Stock
{
    // 63102105112 Akkarapon Phikulsri

    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;data source= ../../../db_fruit.accdb";
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

            ShowAllFruitStock();
            FormatDataFruitStock();
        }

        private void ShowAllFruitStock()
        {
            string sqlEmp = "select * from tb_fruit";
            if (IsFind == true)
            {
                ds.Tables["tb_fruit"].Clear();
            }

            da = new OleDbDataAdapter(sqlEmp, Conn);
            da.Fill(ds, "tb_fruit");

            if (ds.Tables["tb_fruit"].Rows.Count != 0)
            {
                IsFind = true;
                dgvFruitStock.ReadOnly = true;
                dgvFruitStock.DataSource = ds.Tables["tb_fruit"];
            }
            else
            {
                IsFind = false;
            }

        }

        private void FormatDataFruitStock()
        {
            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            dgvFruitStock.ColumnHeadersDefaultCellStyle = cs;
            dgvFruitStock.Columns[0].HeaderText = "รหัสผลไม้";
            dgvFruitStock.Columns[1].HeaderText = "ชื่อผลไม้";
            dgvFruitStock.Columns[2].HeaderText = "จำนวน";
            dgvFruitStock.Columns[3].HeaderText = "ราคาต่อหน่วย";
            dgvFruitStock.Columns[4].HeaderText = "วันที่นำเข้า";
 
            dgvFruitStock.Columns[0].Width = 70;
            dgvFruitStock.Columns[1].Width = 200;
            dgvFruitStock.Columns[2].Width = 100;
            dgvFruitStock.Columns[3].Width = 100;
            dgvFruitStock.Columns[4].Width = 150;

        }

        private void dgvFruitStock_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == dgvFruitStock.Rows.Count - 1)
            {
                return;
            }
            try
            {
                txtFruitId.Text = dgvFruitStock.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFruitName.Text = dgvFruitStock.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuantity.Text = dgvFruitStock.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dgvFruitStock.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpDate.Value = Convert.ToDateTime(dgvFruitStock.Rows[e.RowIndex].Cells[4].Value);
                
            }
            catch
            {
                MessageBox.Show("Error", "เกิดข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAllFruitStock()
        {
            txtFruitId.Text = "";
            txtFruitName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            dtpDate.Value = DateTime.Now;

            txtFruitId.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAllFruitStock();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFruitId.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "ผิดพลาด");
                txtFruitId.Focus();
                return;
            }

            string sqlAdd = "";
            OleDbCommand comAdd = new OleDbCommand();
            try
            {
                if (MessageBox.Show("เพิ่มข้อมูลใช่หรือไม่", "เพิ่มข้อมูล",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlAdd = "insert into tb_fruit(fruit_id, fruit_name, fruit_quantity, fruit_price, fruit_stockdate) values('"
                        + txtFruitId.Text + "','"
                        + txtFruitName.Text + "','"
                        + txtQuantity.Text + "','"
                        + txtPrice.Text + "','"
                        + dtpDate.Value + "')";

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
                    ClearAllFruitStock();
                    ShowAllFruitStock();

                }
            }
            catch
            {
                MessageBox.Show("ไม่สามารถติดต่อฐานข้อมูลได้", "ผิดพลาด");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFruitName.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลที่จะแก้ไขให้ครบ", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFruitName.Focus();
                return;
            }
            string sqlEdit;
            OleDbCommand comEdit = new OleDbCommand();
            try
            {
                if (MessageBox.Show("คุณต้องการแก้ไขข้อมูลใช่หรือไม่", "ยืนยัน",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlEdit = "update tb_fruit set fruit_name = '" + txtFruitName.Text
                        + "',fruit_quantity = '" + txtQuantity.Text
                        + "',fruit_price = '" + txtPrice.Text
                        + "',fruit_stockdate = '" + dtpDate.Value
                        + "'where fruit_id = '" + txtFruitId.Text + "'";

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
                    ClearAllFruitStock();
                    ShowAllFruitStock();

                }
            }
            catch
            {
                MessageBox.Show("ข้อมูลผิดพลาด", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFruitId.Text == "")
                {
                    MessageBox.Show("กรุณาเลือกข้อมูลที่จะลบ", "ผิดพลาด");
                    return;
                }
                String sqlDel = "delete from tb_fruit where fruit_id = '" + txtFruitId.Text + "'";
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
                    ClearAllFruitStock();
                    ShowAllFruitStock();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlFruit = "select * from tb_fruit where fruit_id = '" + txtSearch.Text + "'";
            if (IsFind == true)
            {
                ds.Tables["tb_fruit"].Clear();
            }

            da = new OleDbDataAdapter(sqlFruit, Conn);
            da.Fill(ds, "tb_fruit");

            if (ds.Tables["tb_fruit"].Rows.Count != 0)
            {
                IsFind = true;
                dgvFruitStock.ReadOnly = true;
                dgvFruitStock.DataSource = ds.Tables["tb_fruit"];
            }
            else
            {
                IsFind = false;
            }
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            ShowAllFruitStock();
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
