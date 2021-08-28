
namespace HelloCsharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGreeting = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "กรุณาระบุชื่อ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(178, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 22);
            this.txtName.TabIndex = 1;
            // 
            // btnGreeting
            // 
            this.btnGreeting.Location = new System.Drawing.Point(187, 125);
            this.btnGreeting.Name = "btnGreeting";
            this.btnGreeting.Size = new System.Drawing.Size(75, 23);
            this.btnGreeting.TabIndex = 2;
            this.btnGreeting.Text = "ทักทาย";
            this.btnGreeting.UseVisualStyleBackColor = true;
            this.btnGreeting.Click += new System.EventHandler(this.btnGreeting_Click);
            this.btnGreeting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGreeting_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(296, 125);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "จบการทำงาน";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 274);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGreeting);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "โปรแกรมแรกกับ VC#";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGreeting;
        private System.Windows.Forms.Button btnExit;
    }
}

