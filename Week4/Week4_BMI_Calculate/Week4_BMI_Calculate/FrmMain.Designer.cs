
namespace Week4_BMI_Calculate
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
            this.labelUnit2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmBMIKgm2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInStandart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRisk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.labelUnit1 = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.labelSumary = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUnit2
            // 
            this.labelUnit2.AutoSize = true;
            this.labelUnit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit2.Location = new System.Drawing.Point(237, 199);
            this.labelUnit2.Name = "labelUnit2";
            this.labelUnit2.Size = new System.Drawing.Size(48, 25);
            this.labelUnit2.TabIndex = 24;
            this.labelUnit2.Text = "Cm.";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(459, 430);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 25);
            this.labelResult.TabIndex = 23;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmBMIKgm2,
            this.clmInStandart,
            this.clmRisk});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(315, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(784, 321);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
           
            // 
            // clmBMIKgm2
            // 
            this.clmBMIKgm2.Tag = "";
            this.clmBMIKgm2.Text = "BMI kg/m^2";
            this.clmBMIKgm2.Width = 214;
            // 
            // clmInStandart
            // 
            this.clmInStandart.Tag = "";
            this.clmInStandart.Text = "อยู่ในเกณฑ์";
            this.clmInStandart.Width = 181;
            // 
            // clmRisk
            // 
            this.clmRisk.Tag = "";
            this.clmRisk.Text = "ภาวะเสี่ยงต่อโรค";
            this.clmRisk.Width = 186;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(47, 203);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(184, 30);
            this.txtHeight.TabIndex = 19;
            // 
            // txtBMI
            // 
            this.txtBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMI.Location = new System.Drawing.Point(47, 390);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(184, 30);
            this.txtBMI.TabIndex = 20;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(47, 111);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(184, 30);
            this.txtWeight.TabIndex = 21;
            
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(76, 263);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 36);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "แปลง";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(106, 160);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(58, 25);
            this.labelHeight.TabIndex = 17;
            this.labelHeight.Text = "ส่วนสูง";
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMI.Location = new System.Drawing.Point(99, 342);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(71, 25);
            this.labelBMI.TabIndex = 14;
            this.labelBMI.Text = "ค่า BMI";
            // 
            // labelUnit1
            // 
            this.labelUnit1.AutoSize = true;
            this.labelUnit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit1.Location = new System.Drawing.Point(237, 108);
            this.labelUnit1.Name = "labelUnit1";
            this.labelUnit1.Size = new System.Drawing.Size(42, 25);
            this.labelUnit1.TabIndex = 15;
            this.labelUnit1.Text = "Kg.";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.Location = new System.Drawing.Point(99, 64);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(87, 25);
            this.labelWeight.TabIndex = 16;
            this.labelWeight.Text = "น้ำหนักตัว";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(924, 562);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(175, 41);
            this.btnEnd.TabIndex = 25;
            this.btnEnd.Text = "จบการทำงาน";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // labelSumary
            // 
            this.labelSumary.AutoSize = true;
            this.labelSumary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumary.Location = new System.Drawing.Point(57, 467);
            this.labelSumary.Name = "labelSumary";
            this.labelSumary.Size = new System.Drawing.Size(151, 25);
            this.labelSumary.TabIndex = 26;
            this.labelSumary.Text = "summary Result";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(738, 562);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 41);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 653);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelSumary);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.labelUnit2);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelBMI);
            this.Controls.Add(this.labelUnit1);
            this.Controls.Add(this.labelWeight);
            this.Name = "FrmMain";
            this.Text = "โปรแกรมคำนวณหาค่า BMI";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnit2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmBMIKgm2;
        private System.Windows.Forms.ColumnHeader clmInStandart;
        private System.Windows.Forms.ColumnHeader clmRisk;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelBMI;
        private System.Windows.Forms.Label labelUnit1;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label labelSumary;
        private System.Windows.Forms.Button btnClear;
    }
}

