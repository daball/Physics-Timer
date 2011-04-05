using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Timer.Net
{
    public partial class TimerForm : Form
    {
        System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();

        /// <summary>
        /// Holds the prior clock tick since the clock started.
        /// </summary>
        DateTime previousTick = DateTime.MinValue;

        /// <summary>
        /// Keeps the clock accumulated value (0-to-current).
        /// </summary>
        TimeSpan accumulatedClock = TimeSpan.Zero;

        public TimerForm()
        {
            InitializeComponent();

            // set the clock to zero
            this.toolStripLabelTime.Text = this.accumulatedClock.ToString();

            // default save to user's documents folder
            saveFileDialogCSV.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        }

        private void timerUI_Tick(object sender, EventArgs e)
        {
            // grab the current time
            DateTime thisTick = DateTime.Now;

            // measure the distance since the last tick
            TimeSpan distance = thisTick.Subtract(this.previousTick);

            // accumulate distance and prior distances
            this.accumulatedClock += distance;

            // print the current clock
            this.toolStripLabelTime.Text = this.accumulatedClock.ToString();

            //store this tick
            this.previousTick = thisTick;
        }

        private void toolStripButtonPauseResume_Click(object sender, EventArgs e)
        {
            //if timer is stopped
            if (!timerUI.Enabled)
            {
                //set primer value
                previousTick = DateTime.Now;

                //start the clock
                timerUI.Start();

                //swap the button text
                this.toolStripButtonPauseResume.Text = "&Stop Timer";
            }
            //if time is started
            else
            {
                //stop the timer
                timerUI.Stop();
                //swap the button text
                this.toolStripButtonPauseResume.Text = "&Start Timer";
            }
        }

        private void toolStripButtonRecord_Click(object sender, EventArgs e)
        {
            //IF AND ONLY IF the timer is running
            if (timerUI.Enabled)
            {
                // grab the current time
                DateTime thisTick = DateTime.Now;

                // measure the distance since the last tick
                TimeSpan distance = thisTick.Subtract(this.previousTick);

                // local only: accumulate distance and prior distances,
                // but don't store this value on top of the object's accumalation
                // (it'll definitely break the clock if you do)
                TimeSpan accumulation = this.accumulatedClock + distance;

                // start with a new data row
                DataRow row = this.dataSetTimings.Tables["TimerRecordings"].NewRow();

                // record the duration since last lap recording
                TimeSpan intervalDuration = TimeSpan.Zero;

                // now see if there was a previous recording
                if (row.Table.Rows.Count > 0)
                {
                    //if so, then grab it's value for "clock value"
                    TimeSpan tsPrevious = TimeSpan.Parse(row.Table.Rows[row.Table.Rows.Count-1]["Clock Value"].ToString());
                    
                    //then subtract this clock value from this one to get the interval distance
                    intervalDuration = accumulation.Subtract(tsPrevious);
                }

                //then record the interval
                row["Interval Number"] = row.Table.Rows.Count + 1; //the length of the Rows collection
                row["Notation"] = "Interval " + (row.Table.Rows.Count+1); //generic note, editable later
                row["Interval Duration"] = intervalDuration.ToString();
                row["Clock Value"] = accumulation.ToString();
                row["Date/Time Value"] = thisTick.ToShortDateString() + " " + thisTick.ToShortTimeString();

                //add row to table
                row.Table.Rows.Add(row);
            }
        }

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            //stop the clock
            timerUI.Stop();
            //reset the object's local storage
            this.previousTick = DateTime.MinValue;
            this.accumulatedClock = TimeSpan.Zero;
            //clear the table
            this.dataSetTimings.Tables["TimerRecordings"].Rows.Clear();
            //reset the button text
            this.toolStripButtonPauseResume.Text = "&Start Timer";
            // update the current clock
            this.toolStripLabelTime.Text = this.accumulatedClock.ToString();
        }

        private string generateCSVReport()
        {
            // used to store the data
            StringBuilder CSVOutput = new StringBuilder();

            // grab the table
            DataTable table = this.dataSetTimings.Tables["TimerRecordings"];

            // add each column
            foreach (DataColumn c in table.Columns)
            {
                CSVOutput.Append(c.Caption + ",");
            }

            // remove the last ','
            CSVOutput.Remove(CSVOutput.Length - 1, 1);

            //cr-lf at end-of-line
            CSVOutput.Append("\r\n");

            // add each row
            foreach (DataRow r in table.Rows)
            {
                for (int c = 0; c < table.Columns.Count; c++)
                {
                    CSVOutput.Append(r[c].ToString() + ",");
                }

                // remove the last ','
                CSVOutput.Remove(CSVOutput.Length - 1, 1);

                //cr-lf at end-of-line
                CSVOutput.Append("\r\n");
            }

            // build the string, remove the last cr-lf, and then bounce
            return CSVOutput.ToString().TrimEnd();
        }

        private void toolStripButtonCopyCSV_Click(object sender, EventArgs e)
        {
            // generate report
            string csvReport = this.generateCSVReport();

            // generate clipboard data with report filed
            DataObject csv_clipbrd_Data = new DataObject();
            csv_clipbrd_Data.SetData(DataFormats.Text, false, csvReport);
            csv_clipbrd_Data.SetData(DataFormats.CommaSeparatedValue, false, csvReport);

            // store to clipboard
            try
            {
                Clipboard.SetDataObject(csv_clipbrd_Data, false, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to store .CSV data report to clipboard. Please use the Save .CSV feature to store your data to a file instead.\n\nMessage: " + ex.Message, "Clipboard Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripButtonSaveCSV_Click(object sender, EventArgs e)
        {
            // generate report
            string csvReport = this.generateCSVReport();

            // ask user for file
            if (saveFileDialogCSV.ShowDialog() == DialogResult.OK)
            {
                // save report to file
                Stream stream = saveFileDialogCSV.OpenFile();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(csvReport);
                writer.Close();
            }
        }
    }
}
