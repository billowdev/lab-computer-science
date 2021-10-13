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
            cs.Font = new Font("Ms Sans Serif", 9, FontStyle.Regular);
            dgvAllStduent.ColumnHeadersDefaultCellStyle = cs;
            dgvAllStduent.Columns[0].HeaderText = "รหัสนักศึกษา";
            dgvAllStduent.Columns[1].HeaderText = "ชื่อ";
            dgvAllStduent.Columns[2].HeaderText = "นามสกุล";
            dgvAllStduent.Columns[3].HeaderText = "วันเดือนปีเกิด";
            dgvAllStduent.Columns[4].HeaderText = "น้ำหนัก";

            dgvAllStduent.Columns[0].Width = 80;
            dgvAllStduent.Columns[1].Width = 120;
            dgvAllStduent.Columns[2].Width = 120;
            dgvAllStduent.Columns[3].Width = 100;
            dgvAllStduent.Columns[4].Width = 80;

        }

    }
}
