
namespace Multiform
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
            this.btnUser = new System.Windows.Forms.Button();
            this.btnOpinion = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Font = new System.Drawing.Font("Angsana New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(140, 84);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(333, 39);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "รายละเอียดของผู้ใช้งาน";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnOpinion
            // 
            this.btnOpinion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpinion.Font = new System.Drawing.Font("Angsana New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpinion.Location = new System.Drawing.Point(140, 172);
            this.btnOpinion.Name = "btnOpinion";
            this.btnOpinion.Size = new System.Drawing.Size(333, 39);
            this.btnOpinion.TabIndex = 0;
            this.btnOpinion.Text = "ความเห็นของผู้ใช้งาน";
            this.btnOpinion.UseVisualStyleBackColor = true;
            this.btnOpinion.Click += new System.EventHandler(this.btnOpinion_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSummary.Font = new System.Drawing.Font("Angsana New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Location = new System.Drawing.Point(140, 259);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(333, 39);
            this.btnSummary.TabIndex = 0;
            this.btnSummary.Text = "สรุป";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Multiform.Properties.Resources.color_2174065_640;
            this.ClientSize = new System.Drawing.Size(635, 423);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnOpinion);
            this.Controls.Add(this.btnUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "ตัวอย่างแอปพลิเคชันที่ใช้งานหลายฟอร์ม";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnOpinion;
        private System.Windows.Forms.Button btnSummary;
    }
}

