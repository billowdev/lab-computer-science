
namespace DemoIfElseIfElse
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
            this.labelScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnCalScore = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(48, 115);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(236, 25);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "ป้อนคะแนน [ระหว่าง 0 - 100]";
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(318, 115);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(123, 30);
            this.txtScore.TabIndex = 1;
            // 
            // btnCalScore
            // 
            this.btnCalScore.Location = new System.Drawing.Point(318, 187);
            this.btnCalScore.Name = "btnCalScore";
            this.btnCalScore.Size = new System.Drawing.Size(123, 30);
            this.btnCalScore.TabIndex = 2;
            this.btnCalScore.Text = "คำนวณเกรด";
            this.btnCalScore.UseVisualStyleBackColor = true;
            this.btnCalScore.Click += new System.EventHandler(this.btnCalScore_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(525, 323);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "จบการทำงาน";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 388);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.labelScore);
            this.Name = "Form1";
            this.Text = "โปรแกรมคำนวณเกรด";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnCalScore;
        private System.Windows.Forms.Button btnClose;
    }
}

