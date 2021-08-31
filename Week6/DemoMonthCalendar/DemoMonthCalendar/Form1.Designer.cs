
namespace DemoMonthCalendar
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
            this.DemoMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // DemoMonthCalendar
            // 
            this.DemoMonthCalendar.BoldedDates = new System.DateTime[] {
        new System.DateTime(2021, 9, 1, 0, 0, 0, 0),
        new System.DateTime(2021, 9, 3, 0, 0, 0, 0)};
            this.DemoMonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.DemoMonthCalendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.DemoMonthCalendar.Location = new System.Drawing.Point(0, 0);
            this.DemoMonthCalendar.MinDate = new System.DateTime(1800, 12, 25, 0, 0, 0, 0);
            this.DemoMonthCalendar.Name = "DemoMonthCalendar";
            this.DemoMonthCalendar.ShowWeekNumbers = true;
            this.DemoMonthCalendar.TabIndex = 2;
            this.DemoMonthCalendar.TodayDate = new System.DateTime(2021, 8, 31, 0, 0, 0, 0);
            this.DemoMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DemoMonthCalendar_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 716);
            this.Controls.Add(this.DemoMonthCalendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar DemoMonthCalendar;
    }
}

