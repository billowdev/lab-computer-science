
namespace DemoDoWhileLoop
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
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.lstShow = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(39, 481);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(412, 41);
            this.btnDoWhile.TabIndex = 0;
            this.btnDoWhile.Text = "Do - While Loop";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // lstShow
            // 
            this.lstShow.FormattingEnabled = true;
            this.lstShow.ItemHeight = 16;
            this.lstShow.Location = new System.Drawing.Point(39, 32);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(412, 420);
            this.lstShow.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 554);
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.btnDoWhile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.ListBox lstShow;
    }
}

