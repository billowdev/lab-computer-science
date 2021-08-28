
namespace DemoForLoop
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
            this.txtOut = new System.Windows.Forms.TextBox();
            this.btnLoopForward = new System.Windows.Forms.Button();
            this.btnLoopBackward = new System.Windows.Forms.Button();
            this.btnChangeStepLoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOut
            // 
            this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(210, 12);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(578, 426);
            this.txtOut.TabIndex = 0;
            // 
            // btnLoopForward
            // 
            this.btnLoopForward.Location = new System.Drawing.Point(13, 42);
            this.btnLoopForward.Name = "btnLoopForward";
            this.btnLoopForward.Size = new System.Drawing.Size(154, 31);
            this.btnLoopForward.TabIndex = 1;
            this.btnLoopForward.Text = "วนซ้ำแบบเดินหน้า";
            this.btnLoopForward.UseVisualStyleBackColor = true;
            this.btnLoopForward.Click += new System.EventHandler(this.btnLoopForward_Click);
            // 
            // btnLoopBackward
            // 
            this.btnLoopBackward.Location = new System.Drawing.Point(13, 89);
            this.btnLoopBackward.Name = "btnLoopBackward";
            this.btnLoopBackward.Size = new System.Drawing.Size(154, 31);
            this.btnLoopBackward.TabIndex = 1;
            this.btnLoopBackward.Text = "วนซ้ำแบบถอยหลัง";
            this.btnLoopBackward.UseVisualStyleBackColor = true;
            this.btnLoopBackward.Click += new System.EventHandler(this.btnLoopBackward_Click);
            // 
            // btnChangeStepLoop
            // 
            this.btnChangeStepLoop.Location = new System.Drawing.Point(13, 136);
            this.btnChangeStepLoop.Name = "btnChangeStepLoop";
            this.btnChangeStepLoop.Size = new System.Drawing.Size(154, 31);
            this.btnChangeStepLoop.TabIndex = 1;
            this.btnChangeStepLoop.Text = "ปรับ Step การวนซ้ำ";
            this.btnChangeStepLoop.UseVisualStyleBackColor = true;
            this.btnChangeStepLoop.Click += new System.EventHandler(this.btnChangeStepLoop_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeStepLoop);
            this.Controls.Add(this.btnLoopBackward);
            this.Controls.Add(this.btnLoopForward);
            this.Controls.Add(this.txtOut);
            this.Name = "FrmMain";
            this.Text = "ตัวอย่างการใช้งานคำสั่ง for";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button btnLoopForward;
        private System.Windows.Forms.Button btnLoopBackward;
        private System.Windows.Forms.Button btnChangeStepLoop;
    }
}

