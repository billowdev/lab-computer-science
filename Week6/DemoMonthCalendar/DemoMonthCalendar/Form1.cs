using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.txtShow = new System.Windows.Forms.TextBox();
            //this.txtShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.txtShow.Location = new System.Drawing.Point(48, 488);
            //this.txtShow.Multiline = true;
            //this.txtShow.ReadOnly = true;
            //this.txtShow.Size = new System.Drawing.Size(824, 32);

            //  --------  --------  --------  --------  --------  --------  -------- 

            // -------- Set the calendar location.
            this.DemoMonthCalendar.Location = new System.Drawing.Point(47, 16);
            this.DemoMonthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.DemoMonthCalendar.ShowToday = false;
            // --------  Add dates to BoldedDates array.
            //this.DemoMonthCalendar.BoldedDates = new System.DateTime[] { new System.DateTime(2021, 8, 10, 0, 0, 0, 0) };

            // -------- Add dates to MonthlyBoldedDates array.
            //this.DemoMonthCalendar.MonthlyBoldedDates =
            //   new System.DateTime[] {new System.DateTime(2021, 8, 12, 0, 0, 0, 0),
            //                          new System.DateTime(2021, 8, 14, 0, 0, 0, 0),
            //                          new System.DateTime(2021, 8, 15, 0, 0, 0, 0)};

            //  -------- Configure the calendar to display 3 rows by 4 columns of months.
            //this.DemoMonthCalendar.CalendarDimensions = new System.Drawing.Size(4, 3);

            // Set week to begin on Monday.
            //this.DemoMonthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;

            //  -------- Set the maximum visible date on the calendar to 12/10/2021.
            // this.DemoMonthCalendar.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);

            //  -------- Set the minimum visible date on calendar to 12/31/2022.
            //this.DemoMonthCalendar.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);

            //  -------- Only allow 21 days to be selected at the same time.
            //this.DemoMonthCalendar.MaxSelectionCount = 21;

            //  -------- Do not show the "Today" banner.
            //this.DemoMonthCalendar.ShowToday = false;

            //--------Do not circle today's date.
            //this.DemoMonthCalendar.ShowTodayCircle = false;

            //  -------- Show the week numbers to the left of each week.
            //this.DemoMonthCalendar.ShowWeekNumbers = true;

            // --------------------------------------------------------------------------------------------------

            // Add event handlers for the DateSelected and DateChanged events
            // this.DemoMonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DemoMonthCalendar_DateSelected);
            // this.DemoMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DemoMonthCalendar_DateChanged);

            // Set up how the form should be displayed and add the controls to the form.
            // this.ClientSize = new System.Drawing.Size(920, 566);
            // this.Controls.AddRange(new System.Windows.Forms.Control[] { this.textBox1, this.DemoMonthCalendar });
            // this.Text = "Month Calendar Example";
        }

        private void DemoMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        //private void DemoMonthCalendar_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        //{
        //    // Show the start and end dates in the text box.
        //    this.txtShow.Text = "Date Selected: Start = " +
        //        e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
        //}

        //private void DemoMonthCalendar_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e)
        //{
        //    // Show the start and end dates in the text box.
        //    this.txtShow.Text = "Date Changed: Start =  " +
        //        e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
        //}
    }
    
}
