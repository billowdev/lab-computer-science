
namespace Week4_Ex1
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
            this.btnChangeText = new System.Windows.Forms.Button();
            this.btnChangeBgColor = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.rdbWhite = new System.Windows.Forms.RadioButton();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.rdbGray = new System.Windows.Forms.RadioButton();
            this.btnExMessageBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeText
            // 
            this.btnChangeText.Location = new System.Drawing.Point(30, 38);
            this.btnChangeText.Name = "btnChangeText";
            this.btnChangeText.Size = new System.Drawing.Size(175, 37);
            this.btnChangeText.TabIndex = 0;
            this.btnChangeText.Text = "เปลี่ยนข้อความ";
            this.btnChangeText.UseVisualStyleBackColor = true;
            this.btnChangeText.Click += new System.EventHandler(this.btnChangeText_Click);
            // 
            // btnChangeBgColor
            // 
            this.btnChangeBgColor.Location = new System.Drawing.Point(30, 97);
            this.btnChangeBgColor.Name = "btnChangeBgColor";
            this.btnChangeBgColor.Size = new System.Drawing.Size(175, 37);
            this.btnChangeBgColor.TabIndex = 0;
            this.btnChangeBgColor.Text = "เปลี่ยนสีพื้น";
            this.btnChangeBgColor.UseVisualStyleBackColor = true;
            this.btnChangeBgColor.Click += new System.EventHandler(this.btnChangeBgColor_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 37);
            this.button4.TabIndex = 0;
            this.button4.Text = "จบการทำงาน";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(255, 53);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(321, 22);
            this.txtText.TabIndex = 1;
            // 
            // rdbWhite
            // 
            this.rdbWhite.AutoSize = true;
            this.rdbWhite.Location = new System.Drawing.Point(273, 105);
            this.rdbWhite.Name = "rdbWhite";
            this.rdbWhite.Size = new System.Drawing.Size(57, 21);
            this.rdbWhite.TabIndex = 2;
            this.rdbWhite.TabStop = true;
            this.rdbWhite.Text = "สีขาว";
            this.rdbWhite.UseVisualStyleBackColor = true;
            this.rdbWhite.CheckedChanged += new System.EventHandler(this.rdbWhite_CheckedChanged);
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(273, 159);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(50, 21);
            this.rdbBlack.TabIndex = 2;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "สีดำ";
            this.rdbBlack.UseVisualStyleBackColor = true;
            this.rdbBlack.CheckedChanged += new System.EventHandler(this.rdbBlack_CheckedChanged);
            // 
            // rdbGray
            // 
            this.rdbGray.AutoSize = true;
            this.rdbGray.Location = new System.Drawing.Point(273, 217);
            this.rdbGray.Name = "rdbGray";
            this.rdbGray.Size = new System.Drawing.Size(54, 21);
            this.rdbGray.TabIndex = 2;
            this.rdbGray.TabStop = true;
            this.rdbGray.Text = "สีเทา";
            this.rdbGray.UseVisualStyleBackColor = true;
            this.rdbGray.CheckedChanged += new System.EventHandler(this.rdbGray_CheckedChanged);
            // 
            // btnExMessageBox
            // 
            this.btnExMessageBox.Location = new System.Drawing.Point(30, 201);
            this.btnExMessageBox.Name = "btnExMessageBox";
            this.btnExMessageBox.Size = new System.Drawing.Size(175, 37);
            this.btnExMessageBox.TabIndex = 3;
            this.btnExMessageBox.Text = "ตัวอย่าง MessageBox";
            this.btnExMessageBox.UseVisualStyleBackColor = true;
            this.btnExMessageBox.Click += new System.EventHandler(this.btnExMessageBox_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExMessageBox);
            this.Controls.Add(this.rdbGray);
            this.Controls.Add(this.rdbBlack);
            this.Controls.Add(this.rdbWhite);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnChangeBgColor);
            this.Controls.Add(this.btnChangeText);
            this.Name = "FrmMain";
            this.Text = "ตัวอย่างการแสดง Properties ของฟอร์ม";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeText;
        private System.Windows.Forms.Button btnChangeBgColor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.RadioButton rdbWhite;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.RadioButton rdbGray;
        private System.Windows.Forms.Button btnExMessageBox;
    }
}

