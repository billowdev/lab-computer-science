
namespace pro_employ
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.gbEmployForm = new System.Windows.Forms.GroupBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lbEmpSalary = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbEmpBirthDate = new System.Windows.Forms.Label();
            this.lbEmpLastName = new System.Windows.Forms.Label();
            this.lbEmpName = new System.Windows.Forms.Label();
            this.lbEmpId = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAllEmployee = new System.Windows.Forms.DataGridView();
            this.btnSeeAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbEmployForm.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEmployForm
            // 
            this.gbEmployForm.BackgroundImage = global::pro_employ.Properties.Resources.background;
            this.gbEmployForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbEmployForm.Controls.Add(this.dtpBirthDate);
            this.gbEmployForm.Controls.Add(this.txtSalary);
            this.gbEmployForm.Controls.Add(this.txtDepartment);
            this.gbEmployForm.Controls.Add(this.txtLastName);
            this.gbEmployForm.Controls.Add(this.txtName);
            this.gbEmployForm.Controls.Add(this.txtEmpId);
            this.gbEmployForm.Controls.Add(this.lbEmpSalary);
            this.gbEmployForm.Controls.Add(this.lbDepartment);
            this.gbEmployForm.Controls.Add(this.lbEmpBirthDate);
            this.gbEmployForm.Controls.Add(this.lbEmpLastName);
            this.gbEmployForm.Controls.Add(this.lbEmpName);
            this.gbEmployForm.Controls.Add(this.lbEmpId);
            this.gbEmployForm.Font = new System.Drawing.Font("TH Sarabun New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmployForm.Location = new System.Drawing.Point(39, 13);
            this.gbEmployForm.Name = "gbEmployForm";
            this.gbEmployForm.Size = new System.Drawing.Size(1062, 408);
            this.gbEmployForm.TabIndex = 0;
            this.gbEmployForm.TabStop = false;
            this.gbEmployForm.Text = "รายการข้อมูลพนักงาน";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(367, 216);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(283, 43);
            this.dtpBirthDate.TabIndex = 2;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSalary.Location = new System.Drawing.Point(367, 339);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(223, 43);
            this.txtSalary.TabIndex = 1;
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDepartment.Location = new System.Drawing.Point(367, 275);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(347, 43);
            this.txtDepartment.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLastName.Location = new System.Drawing.Point(367, 159);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(347, 43);
            this.txtLastName.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(367, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(347, 43);
            this.txtName.TabIndex = 1;
            // 
            // txtEmpId
            // 
            this.txtEmpId.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEmpId.Location = new System.Drawing.Point(367, 48);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(223, 43);
            this.txtEmpId.TabIndex = 1;
            // 
            // lbEmpSalary
            // 
            this.lbEmpSalary.AutoSize = true;
            this.lbEmpSalary.Font = new System.Drawing.Font("TH Sarabun New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpSalary.Location = new System.Drawing.Point(216, 339);
            this.lbEmpSalary.Name = "lbEmpSalary";
            this.lbEmpSalary.Size = new System.Drawing.Size(90, 37);
            this.lbEmpSalary.TabIndex = 0;
            this.lbEmpSalary.Text = "เงินเดือน";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("TH Sarabun New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment.Location = new System.Drawing.Point(216, 269);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(68, 37);
            this.lbDepartment.TabIndex = 0;
            this.lbDepartment.Text = "แผนก";
            // 
            // lbEmpBirthDate
            // 
            this.lbEmpBirthDate.AutoSize = true;
            this.lbEmpBirthDate.Font = new System.Drawing.Font("TH Sarabun New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpBirthDate.Location = new System.Drawing.Point(206, 216);
            this.lbEmpBirthDate.Name = "lbEmpBirthDate";
            this.lbEmpBirthDate.Size = new System.Drawing.Size(132, 37);
            this.lbEmpBirthDate.TabIndex = 0;
            this.lbEmpBirthDate.Text = "วันเดือนปีเกิด";
            // 
            // lbEmpLastName
            // 
            this.lbEmpLastName.AutoSize = true;
            this.lbEmpLastName.Font = new System.Drawing.Font("TH Sarabun New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpLastName.Location = new System.Drawing.Point(206, 153);
            this.lbEmpLastName.Name = "lbEmpLastName";
            this.lbEmpLastName.Size = new System.Drawing.Size(89, 37);
            this.lbEmpLastName.TabIndex = 0;
            this.lbEmpLastName.Text = "นามสกุล";
            // 
            // lbEmpName
            // 
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Font = new System.Drawing.Font("TH Sarabun New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpName.Location = new System.Drawing.Point(209, 94);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(42, 37);
            this.lbEmpName.TabIndex = 0;
            this.lbEmpName.Text = "ชื่อ";
            // 
            // lbEmpId
            // 
            this.lbEmpId.AutoSize = true;
            this.lbEmpId.Font = new System.Drawing.Font("TH Sarabun New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpId.Location = new System.Drawing.Point(206, 48);
            this.lbEmpId.Name = "lbEmpId";
            this.lbEmpId.Size = new System.Drawing.Size(127, 37);
            this.lbEmpId.TabIndex = 0;
            this.lbEmpId.Text = "รหัสพนักงาน";
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnExit);
            this.gbControl.Controls.Add(this.btnDel);
            this.gbControl.Controls.Add(this.btnEdit);
            this.gbControl.Controls.Add(this.btnSave);
            this.gbControl.Controls.Add(this.btnNew);
            this.gbControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControl.Location = new System.Drawing.Point(1122, 13);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(214, 696);
            this.gbControl.TabIndex = 1;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(23, 591);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 63);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "ออกจากโปรแกรม";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(23, 428);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(174, 63);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "ลบ";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(23, 286);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(174, 63);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "แก้ไข";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 63);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(23, 46);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(174, 63);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "เพิ่มใหม่";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAllEmployee);
            this.groupBox3.Controls.Add(this.btnSeeAll);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(39, 427);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1062, 296);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ข้อมูลพนักงานทั้งหมด";
            // 
            // dgvAllEmployee
            // 
            this.dgvAllEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllEmployee.Location = new System.Drawing.Point(18, 71);
            this.dgvAllEmployee.Name = "dgvAllEmployee";
            this.dgvAllEmployee.RowHeadersWidth = 51;
            this.dgvAllEmployee.RowTemplate.Height = 24;
            this.dgvAllEmployee.Size = new System.Drawing.Size(1026, 211);
            this.dgvAllEmployee.TabIndex = 2;
            this.dgvAllEmployee.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllEmployee_CellMouseUp);
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.Font = new System.Drawing.Font("TH Sarabun New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAll.Location = new System.Drawing.Point(862, 24);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(182, 41);
            this.btnSeeAll.TabIndex = 1;
            this.btnSeeAll.Text = "ดูข้อมูลทั้งหมด";
            this.btnSeeAll.UseVisualStyleBackColor = true;
            this.btnSeeAll.Click += new System.EventHandler(this.btnSeeAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("TH Sarabun New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(726, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 41);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(18, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(696, 34);
            this.txtSearch.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbEmployForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "FrmMain";
            this.Text = "โปรแกรม pro employ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbEmployForm.ResumeLayout(false);
            this.gbEmployForm.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmployForm;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbEmpSalary;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Label lbEmpBirthDate;
        private System.Windows.Forms.Label lbEmpLastName;
        private System.Windows.Forms.Label lbEmpName;
        private System.Windows.Forms.Label lbEmpId;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSeeAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAllEmployee;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
    }
}

