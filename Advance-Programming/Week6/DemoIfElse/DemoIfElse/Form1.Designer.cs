
namespace DemoIfElse
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
            this.btnRoom = new System.Windows.Forms.Button();
            this.txtFeedBack = new System.Windows.Forms.TextBox();
            this.labelDoc = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoom
            // 
            this.btnRoom.Location = new System.Drawing.Point(55, 32);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(147, 35);
            this.btnRoom.TabIndex = 0;
            this.btnRoom.Text = "ห้องพัก";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // txtFeedBack
            // 
            this.txtFeedBack.Location = new System.Drawing.Point(55, 139);
            this.txtFeedBack.Name = "txtFeedBack";
            this.txtFeedBack.Size = new System.Drawing.Size(308, 22);
            this.txtFeedBack.TabIndex = 1;
            // 
            // labelDoc
            // 
            this.labelDoc.AutoSize = true;
            this.labelDoc.Location = new System.Drawing.Point(55, 116);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(132, 17);
            this.labelDoc.TabIndex = 2;
            this.labelDoc.Text = "คำแนะนำการให้บริการ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(156, 193);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(131, 35);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK ครับ/ค่ะ";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 312);
            this.Controls.Add(this.labelDoc);
            this.Controls.Add(this.txtFeedBack);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRoom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.TextBox txtFeedBack;
        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.Button btnOK;
    }
}

