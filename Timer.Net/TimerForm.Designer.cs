namespace Timer.Net
{
    partial class TimerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.timerUI = new System.Windows.Forms.Timer(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPauseResume = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelTime = new System.Windows.Forms.ToolStripLabel();
            this.dataSetTimings = new Timer.Net.DataSet1();
            this.timerRecordingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intervalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intervalDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clockValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButtonCopyCSV = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveCSV = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialogCSV = new System.Windows.Forms.SaveFileDialog();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTimings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerRecordingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timerUI
            // 
            this.timerUI.Interval = 1;
            this.timerUI.Tick += new System.EventHandler(this.timerUI_Tick);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(385, 311);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(544, 356);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(544, 406);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCopyCSV,
            this.toolStripButtonSaveCSV});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(322, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lap Recordings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervalNumberDataGridViewTextBoxColumn,
            this.notationDataGridViewTextBoxColumn,
            this.intervalDurationDataGridViewTextBoxColumn,
            this.clockValueDataGridViewTextBoxColumn,
            this.dateTimeValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.timerRecordingsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(538, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPauseResume,
            this.toolStripButtonRecord,
            this.toolStripButtonReset,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripLabelTime});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(318, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // toolStripButtonPauseResume
            // 
            this.toolStripButtonPauseResume.CheckOnClick = true;
            this.toolStripButtonPauseResume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPauseResume.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPauseResume.Image")));
            this.toolStripButtonPauseResume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPauseResume.Name = "toolStripButtonPauseResume";
            this.toolStripButtonPauseResume.Size = new System.Drawing.Size(69, 22);
            this.toolStripButtonPauseResume.Text = "&Start Timer";
            this.toolStripButtonPauseResume.Click += new System.EventHandler(this.toolStripButtonPauseResume_Click);
            // 
            // toolStripButtonRecord
            // 
            this.toolStripButtonRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRecord.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRecord.Image")));
            this.toolStripButtonRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRecord.Name = "toolStripButtonRecord";
            this.toolStripButtonRecord.Size = new System.Drawing.Size(112, 22);
            this.toolStripButtonRecord.Text = "Record &Lap Interval";
            this.toolStripButtonRecord.Click += new System.EventHandler(this.toolStripButtonRecord_Click);
            // 
            // toolStripButtonReset
            // 
            this.toolStripButtonReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonReset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReset.Image")));
            this.toolStripButtonReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReset.Name = "toolStripButtonReset";
            this.toolStripButtonReset.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonReset.Text = "&Reset";
            this.toolStripButtonReset.Click += new System.EventHandler(this.toolStripButtonReset_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel1.Text = "Current Time:";
            // 
            // toolStripLabelTime
            // 
            this.toolStripLabelTime.Name = "toolStripLabelTime";
            this.toolStripLabelTime.Size = new System.Drawing.Size(0, 22);
            // 
            // dataSetTimings
            // 
            this.dataSetTimings.DataSetName = "DataSet1";
            this.dataSetTimings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timerRecordingsBindingSource
            // 
            this.timerRecordingsBindingSource.DataMember = "TimerRecordings";
            this.timerRecordingsBindingSource.DataSource = this.dataSetTimings;
            // 
            // intervalNumberDataGridViewTextBoxColumn
            // 
            this.intervalNumberDataGridViewTextBoxColumn.DataPropertyName = "Interval Number";
            this.intervalNumberDataGridViewTextBoxColumn.HeaderText = "Interval Number";
            this.intervalNumberDataGridViewTextBoxColumn.Name = "intervalNumberDataGridViewTextBoxColumn";
            this.intervalNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notationDataGridViewTextBoxColumn
            // 
            this.notationDataGridViewTextBoxColumn.DataPropertyName = "Notation";
            this.notationDataGridViewTextBoxColumn.HeaderText = "Notation";
            this.notationDataGridViewTextBoxColumn.Name = "notationDataGridViewTextBoxColumn";
            // 
            // intervalDurationDataGridViewTextBoxColumn
            // 
            this.intervalDurationDataGridViewTextBoxColumn.DataPropertyName = "Interval Duration";
            this.intervalDurationDataGridViewTextBoxColumn.HeaderText = "Interval Duration";
            this.intervalDurationDataGridViewTextBoxColumn.Name = "intervalDurationDataGridViewTextBoxColumn";
            this.intervalDurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clockValueDataGridViewTextBoxColumn
            // 
            this.clockValueDataGridViewTextBoxColumn.DataPropertyName = "Clock Value";
            this.clockValueDataGridViewTextBoxColumn.HeaderText = "Clock Value";
            this.clockValueDataGridViewTextBoxColumn.Name = "clockValueDataGridViewTextBoxColumn";
            this.clockValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTimeValueDataGridViewTextBoxColumn
            // 
            this.dateTimeValueDataGridViewTextBoxColumn.DataPropertyName = "Date/Time Value";
            this.dateTimeValueDataGridViewTextBoxColumn.HeaderText = "Date/Time Value";
            this.dateTimeValueDataGridViewTextBoxColumn.Name = "dateTimeValueDataGridViewTextBoxColumn";
            this.dateTimeValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toolStripButtonCopyCSV
            // 
            this.toolStripButtonCopyCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCopyCSV.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopyCSV.Image")));
            this.toolStripButtonCopyCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopyCSV.Name = "toolStripButtonCopyCSV";
            this.toolStripButtonCopyCSV.Size = new System.Drawing.Size(181, 22);
            this.toolStripButtonCopyCSV.Text = "&Copy .CSV to Clipboard (Report)";
            this.toolStripButtonCopyCSV.Click += new System.EventHandler(this.toolStripButtonCopyCSV_Click);
            // 
            // toolStripButtonSaveCSV
            // 
            this.toolStripButtonSaveCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSaveCSV.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveCSV.Image")));
            this.toolStripButtonSaveCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveCSV.Name = "toolStripButtonSaveCSV";
            this.toolStripButtonSaveCSV.Size = new System.Drawing.Size(129, 22);
            this.toolStripButtonSaveCSV.Text = "S&ave .CSV File (Report)";
            this.toolStripButtonSaveCSV.Click += new System.EventHandler(this.toolStripButtonSaveCSV_Click);
            // 
            // saveFileDialogCSV
            // 
            this.saveFileDialogCSV.DefaultExt = "csv";
            this.saveFileDialogCSV.Filter = "Comma-Seperated Values Files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 406);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "TimerForm";
            this.Text = "Stopwatch Timer";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTimings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerRecordingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerUI;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPauseResume;
        private System.Windows.Forms.ToolStripButton toolStripButtonRecord;
        private System.Windows.Forms.ToolStripButton toolStripButtonReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timerValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clockValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource timerRecordingsBindingSource;
        private DataSet1 dataSetTimings;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopyCSV;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveCSV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCSV;
    }
}

