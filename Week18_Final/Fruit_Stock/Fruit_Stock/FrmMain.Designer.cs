
namespace Fruit_Stock
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
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFruitQuantity = new System.Windows.Forms.Label();
            this.lbFruitName = new System.Windows.Forms.Label();
            this.lbFruitId = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtFruitName = new System.Windows.Forms.TextBox();
            this.txtFruitId = new System.Windows.Forms.TextBox();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbAllProduct = new System.Windows.Forms.GroupBox();
            this.dgvFruitStock = new System.Windows.Forms.DataGridView();
            this.btnSeeAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbDetail.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbAllProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruitStock)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.dtpDate);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.lbFruitQuantity);
            this.gbDetail.Controls.Add(this.lbFruitName);
            this.gbDetail.Controls.Add(this.lbFruitId);
            this.gbDetail.Controls.Add(this.txtPrice);
            this.gbDetail.Controls.Add(this.txtQuantity);
            this.gbDetail.Controls.Add(this.txtFruitName);
            this.gbDetail.Controls.Add(this.txtFruitId);
            this.gbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetail.Location = new System.Drawing.Point(12, 12);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(1032, 360);
            this.gbDetail.TabIndex = 0;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "รายระเอียด";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(282, 275);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(264, 30);
            this.dtpDate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "วันที่นำเข้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "ราคาต่อหน่วย";
            // 
            // lbFruitQuantity
            // 
            this.lbFruitQuantity.AutoSize = true;
            this.lbFruitQuantity.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFruitQuantity.Location = new System.Drawing.Point(138, 154);
            this.lbFruitQuantity.Name = "lbFruitQuantity";
            this.lbFruitQuantity.Size = new System.Drawing.Size(56, 27);
            this.lbFruitQuantity.TabIndex = 1;
            this.lbFruitQuantity.Text = "จำนวน";
            // 
            // lbFruitName
            // 
            this.lbFruitName.AutoSize = true;
            this.lbFruitName.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFruitName.Location = new System.Drawing.Point(138, 98);
            this.lbFruitName.Name = "lbFruitName";
            this.lbFruitName.Size = new System.Drawing.Size(65, 27);
            this.lbFruitName.TabIndex = 1;
            this.lbFruitName.Text = "ชื่อผลไม้";
            // 
            // lbFruitId
            // 
            this.lbFruitId.AutoSize = true;
            this.lbFruitId.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFruitId.Location = new System.Drawing.Point(138, 45);
            this.lbFruitId.Name = "lbFruitId";
            this.lbFruitId.Size = new System.Drawing.Size(59, 27);
            this.lbFruitId.TabIndex = 1;
            this.lbFruitId.Text = "Fruit ID";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(282, 217);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(178, 34);
            this.txtPrice.TabIndex = 0;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(282, 149);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(133, 34);
            this.txtQuantity.TabIndex = 0;
            // 
            // txtFruitName
            // 
            this.txtFruitName.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFruitName.Location = new System.Drawing.Point(282, 93);
            this.txtFruitName.Name = "txtFruitName";
            this.txtFruitName.Size = new System.Drawing.Size(264, 34);
            this.txtFruitName.TabIndex = 0;
            // 
            // txtFruitId
            // 
            this.txtFruitId.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFruitId.Location = new System.Drawing.Point(282, 42);
            this.txtFruitId.Name = "txtFruitId";
            this.txtFruitId.Size = new System.Drawing.Size(142, 34);
            this.txtFruitId.TabIndex = 0;
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnExit);
            this.gbControl.Controls.Add(this.btnDelete);
            this.gbControl.Controls.Add(this.btnEdit);
            this.gbControl.Controls.Add(this.btnSave);
            this.gbControl.Controls.Add(this.btnNew);
            this.gbControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControl.Location = new System.Drawing.Point(1050, 13);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(286, 696);
            this.gbControl.TabIndex = 1;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(53, 596);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(204, 77);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "ออกจากโปรแกรม";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(53, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(204, 77);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "ลบ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(53, 282);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(204, 77);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "แก้ไข";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(53, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(204, 77);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(53, 53);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(204, 77);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "เพิ่มใหม่";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gbAllProduct
            // 
            this.gbAllProduct.Controls.Add(this.dgvFruitStock);
            this.gbAllProduct.Controls.Add(this.btnSeeAll);
            this.gbAllProduct.Controls.Add(this.btnSearch);
            this.gbAllProduct.Controls.Add(this.txtSearch);
            this.gbAllProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllProduct.Location = new System.Drawing.Point(13, 379);
            this.gbAllProduct.Name = "gbAllProduct";
            this.gbAllProduct.Size = new System.Drawing.Size(1031, 330);
            this.gbAllProduct.TabIndex = 2;
            this.gbAllProduct.TabStop = false;
            this.gbAllProduct.Text = "ข้อมูลทั้งหมด";
            // 
            // dgvFruitStock
            // 
            this.dgvFruitStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFruitStock.Location = new System.Drawing.Point(20, 75);
            this.dgvFruitStock.Name = "dgvFruitStock";
            this.dgvFruitStock.RowHeadersWidth = 51;
            this.dgvFruitStock.RowTemplate.Height = 24;
            this.dgvFruitStock.Size = new System.Drawing.Size(974, 249);
            this.dgvFruitStock.TabIndex = 0;
            this.dgvFruitStock.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFruitStock_CellMouseUp);
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAll.Location = new System.Drawing.Point(810, 27);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(171, 34);
            this.btnSeeAll.TabIndex = 0;
            this.btnSeeAll.Text = "ดูข้อมูลทั้งหมด";
            this.btnSeeAll.UseVisualStyleBackColor = true;
            this.btnSeeAll.Click += new System.EventHandler(this.btnSeeAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(707, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 34);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(20, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(681, 30);
            this.txtSearch.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.gbAllProduct);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbDetail);
            this.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "FrmMain";
            this.Text = "โปรแกรมสตีอคผลไม้";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbAllProduct.ResumeLayout(false);
            this.gbAllProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruitStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbFruitQuantity;
        private System.Windows.Forms.Label lbFruitName;
        private System.Windows.Forms.Label lbFruitId;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtFruitName;
        private System.Windows.Forms.TextBox txtFruitId;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.GroupBox gbAllProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvFruitStock;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSeeAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

