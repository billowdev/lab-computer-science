
namespace DemoSwitchCase
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
            this.lbPriceDetail = new System.Windows.Forms.Label();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.lbKg = new System.Windows.Forms.Label();
            this.txtBaht = new System.Windows.Forms.TextBox();
            this.lbLastResult = new System.Windows.Forms.Label();
            this.lbBaht = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cbOrange = new System.Windows.Forms.CheckBox();
            this.cbMangoSteen = new System.Windows.Forms.CheckBox();
            this.cbLamud = new System.Windows.Forms.CheckBox();
            this.cbLambutan = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPriceDetail
            // 
            this.lbPriceDetail.AutoSize = true;
            this.lbPriceDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceDetail.Location = new System.Drawing.Point(340, 104);
            this.lbPriceDetail.Name = "lbPriceDetail";
            this.lbPriceDetail.Size = new System.Drawing.Size(196, 25);
            this.lbPriceDetail.TabIndex = 2;
            this.lbPriceDetail.Text = "ผลไม้..กิโลกรัมละ...บาท...";
            // 
            // txtKg
            // 
            this.txtKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKg.Location = new System.Drawing.Point(361, 199);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(137, 30);
            this.txtKg.TabIndex = 3;
            // 
            // lbKg
            // 
            this.lbKg.AutoSize = true;
            this.lbKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKg.Location = new System.Drawing.Point(378, 157);
            this.lbKg.Name = "lbKg";
            this.lbKg.Size = new System.Drawing.Size(98, 25);
            this.lbKg.TabIndex = 2;
            this.lbKg.Text = "ซื้อกี่กิโลกรัม";
            // 
            // txtBaht
            // 
            this.txtBaht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaht.Location = new System.Drawing.Point(350, 318);
            this.txtBaht.Name = "txtBaht";
            this.txtBaht.Size = new System.Drawing.Size(189, 30);
            this.txtBaht.TabIndex = 4;
            // 
            // lbLastResult
            // 
            this.lbLastResult.AutoSize = true;
            this.lbLastResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastResult.Location = new System.Drawing.Point(68, 321);
            this.lbLastResult.Name = "lbLastResult";
            this.lbLastResult.Size = new System.Drawing.Size(260, 25);
            this.lbLastResult.TabIndex = 2;
            this.lbLastResult.Text = "คุณซื้อผลไม้ ... กิโลกรัม คิดเป็นเงิน";
            // 
            // lbBaht
            // 
            this.lbBaht.AutoSize = true;
            this.lbBaht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaht.Location = new System.Drawing.Point(559, 321);
            this.lbBaht.Name = "lbBaht";
            this.lbBaht.Size = new System.Drawing.Size(43, 25);
            this.lbBaht.TabIndex = 2;
            this.lbBaht.Text = "บาท";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(515, 199);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(85, 30);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "ยืนยัน";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cbOrange
            // 
            this.cbOrange.AutoSize = true;
            this.cbOrange.Location = new System.Drawing.Point(94, 87);
            this.cbOrange.Name = "cbOrange";
            this.cbOrange.Size = new System.Drawing.Size(45, 21);
            this.cbOrange.TabIndex = 0;
            this.cbOrange.Text = "ส้ม";
            this.cbOrange.UseVisualStyleBackColor = true;
            // 
            // cbMangoSteen
            // 
            this.cbMangoSteen.AutoSize = true;
            this.cbMangoSteen.Location = new System.Drawing.Point(94, 144);
            this.cbMangoSteen.Name = "cbMangoSteen";
            this.cbMangoSteen.Size = new System.Drawing.Size(60, 21);
            this.cbMangoSteen.TabIndex = 0;
            this.cbMangoSteen.Text = "มังคุด";
            this.cbMangoSteen.UseVisualStyleBackColor = true;
            // 
            // cbLamud
            // 
            this.cbLamud.AutoSize = true;
            this.cbLamud.Location = new System.Drawing.Point(94, 198);
            this.cbLamud.Name = "cbLamud";
            this.cbLamud.Size = new System.Drawing.Size(59, 21);
            this.cbLamud.TabIndex = 0;
            this.cbLamud.Text = "ละมุด";
            this.cbLamud.UseVisualStyleBackColor = true;
            // 
            // cbLambutan
            // 
            this.cbLambutan.AutoSize = true;
            this.cbLambutan.Location = new System.Drawing.Point(94, 257);
            this.cbLambutan.Name = "cbLambutan";
            this.cbLambutan.Size = new System.Drawing.Size(57, 21);
            this.cbLambutan.TabIndex = 0;
            this.cbLambutan.Text = "ลำไย";
            this.cbLambutan.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(549, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(661, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtBaht);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.lbBaht);
            this.Controls.Add(this.lbLastResult);
            this.Controls.Add(this.lbKg);
            this.Controls.Add(this.lbPriceDetail);
            this.Controls.Add(this.cbLambutan);
            this.Controls.Add(this.cbLamud);
            this.Controls.Add(this.cbMangoSteen);
            this.Controls.Add(this.cbOrange);
            this.Name = "FrmMain";
            this.Text = "โปรแกรมคำนวณราคาผลไม้ ณ ร้านแห่งหนึ่ง";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPriceDetail;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Label lbKg;
        private System.Windows.Forms.TextBox txtBaht;
        private System.Windows.Forms.Label lbLastResult;
        private System.Windows.Forms.Label lbBaht;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.CheckBox cbOrange;
        private System.Windows.Forms.CheckBox cbMangoSteen;
        private System.Windows.Forms.CheckBox cbLamud;
        private System.Windows.Forms.CheckBox cbLambutan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

