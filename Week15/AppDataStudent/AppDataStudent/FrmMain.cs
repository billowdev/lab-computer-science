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
    // 112 อัครพล พิกุลศรี
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
    }
}
