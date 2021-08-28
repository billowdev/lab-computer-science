
namespace DemoNestedIfElse
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
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnEmailSafe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(196, 79);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(156, 38);
            this.btnEmail.TabIndex = 0;
            this.btnEmail.Text = "การใช้งานอีเมล์";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnEmailSafe
            // 
            this.btnEmailSafe.Location = new System.Drawing.Point(196, 158);
            this.btnEmailSafe.Name = "btnEmailSafe";
            this.btnEmailSafe.Size = new System.Drawing.Size(156, 38);
            this.btnEmailSafe.TabIndex = 0;
            this.btnEmailSafe.Text = "ความปลอดภัย";
            this.btnEmailSafe.UseVisualStyleBackColor = true;
            this.btnEmailSafe.Click += new System.EventHandler(this.btnEmailSafe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 301);
            this.Controls.Add(this.btnEmailSafe);
            this.Controls.Add(this.btnEmail);
            this.Name = "Form1";
            this.Text = "โปรดแสดงความคิดเห็น";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnEmailSafe;
    }
}

