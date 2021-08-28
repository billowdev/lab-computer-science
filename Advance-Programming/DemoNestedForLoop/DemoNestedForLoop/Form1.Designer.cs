
namespace DemoNestedForLoop
{
    partial class Form1
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
            this.btnDrawTable = new System.Windows.Forms.Button();
            this.btnDrawTriangleUp = new System.Windows.Forms.Button();
            this.btnDrawTriangleDown = new System.Windows.Forms.Button();
            this.nudRow = new System.Windows.Forms.NumericUpDown();
            this.nudColumn = new System.Windows.Forms.NumericUpDown();
            this.nudTriRow = new System.Windows.Forms.NumericUpDown();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.labelRow = new System.Windows.Forms.Label();
            this.labelColumn = new System.Windows.Forms.Label();
            this.labelRow2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriRow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDrawTable
            // 
            this.btnDrawTable.Location = new System.Drawing.Point(28, 41);
            this.btnDrawTable.Name = "btnDrawTable";
            this.btnDrawTable.Size = new System.Drawing.Size(185, 33);
            this.btnDrawTable.TabIndex = 0;
            this.btnDrawTable.Text = "วาดตาราง";
            this.btnDrawTable.UseVisualStyleBackColor = true;
            this.btnDrawTable.Click += new System.EventHandler(this.btnDrawTable_Click);
            // 
            // btnDrawTriangleUp
            // 
            this.btnDrawTriangleUp.Location = new System.Drawing.Point(28, 185);
            this.btnDrawTriangleUp.Name = "btnDrawTriangleUp";
            this.btnDrawTriangleUp.Size = new System.Drawing.Size(185, 33);
            this.btnDrawTriangleUp.TabIndex = 0;
            this.btnDrawTriangleUp.Text = "วาดรูปสามเหลี่ยม Up";
            this.btnDrawTriangleUp.UseVisualStyleBackColor = true;
            this.btnDrawTriangleUp.Click += new System.EventHandler(this.btnDrawTriangleUp_Click);
            // 
            // btnDrawTriangleDown
            // 
            this.btnDrawTriangleDown.Location = new System.Drawing.Point(28, 236);
            this.btnDrawTriangleDown.Name = "btnDrawTriangleDown";
            this.btnDrawTriangleDown.Size = new System.Drawing.Size(185, 33);
            this.btnDrawTriangleDown.TabIndex = 0;
            this.btnDrawTriangleDown.Text = "วาดรูปสามเหลี่ยม Down";
            this.btnDrawTriangleDown.UseVisualStyleBackColor = true;
            this.btnDrawTriangleDown.Click += new System.EventHandler(this.btnDrawTriangleDown_Click);
            // 
            // nudRow
            // 
            this.nudRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRow.Location = new System.Drawing.Point(121, 92);
            this.nudRow.Name = "nudRow";
            this.nudRow.Size = new System.Drawing.Size(60, 30);
            this.nudRow.TabIndex = 1;
            this.nudRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudColumn
            // 
            this.nudColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudColumn.Location = new System.Drawing.Point(121, 128);
            this.nudColumn.Name = "nudColumn";
            this.nudColumn.Size = new System.Drawing.Size(60, 30);
            this.nudColumn.TabIndex = 1;
            this.nudColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudTriRow
            // 
            this.nudTriRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTriRow.Location = new System.Drawing.Point(121, 288);
            this.nudTriRow.Name = "nudTriRow";
            this.nudTriRow.Size = new System.Drawing.Size(60, 30);
            this.nudTriRow.TabIndex = 1;
            this.nudTriRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtOut
            // 
            this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(276, 41);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(807, 516);
            this.txtOut.TabIndex = 2;
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRow.Location = new System.Drawing.Point(53, 97);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(40, 25);
            this.labelRow.TabIndex = 3;
            this.labelRow.Text = "แถว";
            // 
            // labelColumn
            // 
            this.labelColumn.AutoSize = true;
            this.labelColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumn.Location = new System.Drawing.Point(28, 133);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(65, 25);
            this.labelColumn.TabIndex = 3;
            this.labelColumn.Text = "คอลัมน์";
            // 
            // labelRow2
            // 
            this.labelRow2.AutoSize = true;
            this.labelRow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRow2.Location = new System.Drawing.Point(53, 293);
            this.labelRow2.Name = "labelRow2";
            this.labelRow2.Size = new System.Drawing.Size(40, 25);
            this.labelRow2.TabIndex = 3;
            this.labelRow2.Text = "แถว";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 569);
            this.Controls.Add(this.labelColumn);
            this.Controls.Add(this.labelRow2);
            this.Controls.Add(this.labelRow);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.nudTriRow);
            this.Controls.Add(this.nudColumn);
            this.Controls.Add(this.nudRow);
            this.Controls.Add(this.btnDrawTriangleDown);
            this.Controls.Add(this.btnDrawTriangleUp);
            this.Controls.Add(this.btnDrawTable);
            this.Name = "Form1";
            this.Text = "ตัวอย่างการใช้งาน for แบบซ้อนกัน";
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDrawTable;
        private System.Windows.Forms.Button btnDrawTriangleUp;
        private System.Windows.Forms.Button btnDrawTriangleDown;
        private System.Windows.Forms.NumericUpDown nudRow;
        private System.Windows.Forms.NumericUpDown nudColumn;
        private System.Windows.Forms.NumericUpDown nudTriRow;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.Label labelRow2;
    }
}

