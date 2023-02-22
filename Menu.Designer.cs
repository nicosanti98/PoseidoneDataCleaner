
namespace PoseidoneDataCleaner
{
    partial class frmMenu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.crtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMedianFilterRepetions = new System.Windows.Forms.NumericUpDown();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pbGeneratingFile = new System.Windows.Forms.ProgressBar();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbNotNull = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.listMeasures = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGenerateFile = new System.Windows.Forms.Button();
            this.lblMeasure = new System.Windows.Forms.Label();
            this.nudSampleNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHigTreshold = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLowTreshold = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSubSampling = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.listMeasurestab2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedianFilterRepetions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigTreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowTreshold)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 816);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.crtData);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.nudMedianFilterRepetions);
            this.tabPage1.Controls.Add(this.lblProgress);
            this.tabPage1.Controls.Add(this.pbGeneratingFile);
            this.tabPage1.Controls.Add(this.btnBack);
            this.tabPage1.Controls.Add(this.cbNotNull);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.listMeasures);
            this.tabPage1.Controls.Add(this.btnGenerateFile);
            this.tabPage1.Controls.Add(this.lblMeasure);
            this.tabPage1.Controls.Add(this.nudSampleNum);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.nudHigTreshold);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nudLowTreshold);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(581, 790);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Median Filter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // crtData
            // 
            chartArea1.Name = "ChartArea1";
            this.crtData.ChartAreas.Add(chartArea1);
            this.crtData.Location = new System.Drawing.Point(24, 504);
            this.crtData.Margin = new System.Windows.Forms.Padding(2);
            this.crtData.Name = "crtData";
            this.crtData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.crtData.Series.Add(series1);
            this.crtData.Size = new System.Drawing.Size(522, 236);
            this.crtData.TabIndex = 15;
            this.crtData.Text = "Samples Chart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Filter applications number";
            // 
            // nudMedianFilterRepetions
            // 
            this.nudMedianFilterRepetions.Location = new System.Drawing.Point(192, 205);
            this.nudMedianFilterRepetions.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMedianFilterRepetions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMedianFilterRepetions.Name = "nudMedianFilterRepetions";
            this.nudMedianFilterRepetions.Size = new System.Drawing.Size(101, 20);
            this.nudMedianFilterRepetions.TabIndex = 13;
            this.nudMedianFilterRepetions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(189, 742);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(35, 13);
            this.lblProgress.TabIndex = 12;
            this.lblProgress.Text = "TEXT";
            // 
            // pbGeneratingFile
            // 
            this.pbGeneratingFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbGeneratingFile.Location = new System.Drawing.Point(192, 760);
            this.pbGeneratingFile.Maximum = 0;
            this.pbGeneratingFile.Name = "pbGeneratingFile";
            this.pbGeneratingFile.Size = new System.Drawing.Size(185, 23);
            this.pbGeneratingFile.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 28);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbNotNull
            // 
            this.cbNotNull.AutoSize = true;
            this.cbNotNull.Location = new System.Drawing.Point(385, 83);
            this.cbNotNull.Name = "cbNotNull";
            this.cbNotNull.Size = new System.Drawing.Size(128, 17);
            this.cbNotNull.TabIndex = 10;
            this.cbNotNull.Text = "Set NULL values to 0";
            this.cbNotNull.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(24, 755);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 28);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // listMeasures
            // 
            this.listMeasures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1,
            this.column2});
            this.listMeasures.FullRowSelect = true;
            this.listMeasures.HideSelection = false;
            this.listMeasures.Location = new System.Drawing.Point(24, 261);
            this.listMeasures.Margin = new System.Windows.Forms.Padding(2);
            this.listMeasures.Name = "listMeasures";
            this.listMeasures.Size = new System.Drawing.Size(523, 240);
            this.listMeasures.TabIndex = 9;
            this.listMeasures.UseCompatibleStateImageBehavior = false;
            this.listMeasures.View = System.Windows.Forms.View.Details;
            this.listMeasures.SelectedIndexChanged += new System.EventHandler(this.listMeasures_SelectedIndexChanged);
            // 
            // column1
            // 
            this.column1.Text = "Station";
            this.column1.Width = 257;
            // 
            // column2
            // 
            this.column2.Text = "Measure Name";
            this.column2.Width = 184;
            // 
            // btnGenerateFile
            // 
            this.btnGenerateFile.Location = new System.Drawing.Point(460, 755);
            this.btnGenerateFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateFile.Name = "btnGenerateFile";
            this.btnGenerateFile.Size = new System.Drawing.Size(86, 28);
            this.btnGenerateFile.TabIndex = 8;
            this.btnGenerateFile.Text = "Generate File";
            this.btnGenerateFile.UseVisualStyleBackColor = true;
            this.btnGenerateFile.Click += new System.EventHandler(this.btnGenerateFile_Click);
            // 
            // lblMeasure
            // 
            this.lblMeasure.AutoSize = true;
            this.lblMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasure.ForeColor = System.Drawing.Color.Green;
            this.lblMeasure.Location = new System.Drawing.Point(106, 39);
            this.lblMeasure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Size = new System.Drawing.Size(0, 20);
            this.lblMeasure.TabIndex = 7;
            // 
            // nudSampleNum
            // 
            this.nudSampleNum.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSampleNum.Location = new System.Drawing.Point(192, 171);
            this.nudSampleNum.Margin = new System.Windows.Forms.Padding(2);
            this.nudSampleNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSampleNum.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSampleNum.Name = "nudSampleNum";
            this.nudSampleNum.ReadOnly = true;
            this.nudSampleNum.Size = new System.Drawing.Size(101, 20);
            this.nudSampleNum.TabIndex = 6;
            this.nudSampleNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sample Number";
            // 
            // nudHigTreshold
            // 
            this.nudHigTreshold.Location = new System.Drawing.Point(192, 127);
            this.nudHigTreshold.Margin = new System.Windows.Forms.Padding(2);
            this.nudHigTreshold.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudHigTreshold.Name = "nudHigTreshold";
            this.nudHigTreshold.Size = new System.Drawing.Size(101, 20);
            this.nudHigTreshold.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "High Treshold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Low Treshold";
            // 
            // nudLowTreshold
            // 
            this.nudLowTreshold.Location = new System.Drawing.Point(192, 85);
            this.nudLowTreshold.Margin = new System.Windows.Forms.Padding(2);
            this.nudLowTreshold.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLowTreshold.Name = "nudLowTreshold";
            this.nudLowTreshold.Size = new System.Drawing.Size(101, 20);
            this.nudLowTreshold.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.btnSubSampling);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.nudMinutes);
            this.tabPage2.Controls.Add(this.nudHours);
            this.tabPage2.Controls.Add(this.listMeasurestab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(581, 790);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SubSampling";
            // 
            // btnSubSampling
            // 
            this.btnSubSampling.Location = new System.Drawing.Point(34, 150);
            this.btnSubSampling.Name = "btnSubSampling";
            this.btnSubSampling.Size = new System.Drawing.Size(118, 42);
            this.btnSubSampling.TabIndex = 16;
            this.btnSubSampling.Text = "Start SubSampling Procedure";
            this.btnSubSampling.UseVisualStyleBackColor = true;
            this.btnSubSampling.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Minutes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Take samples every:";
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(32, 79);
            this.nudMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(120, 20);
            this.nudMinutes.TabIndex = 12;
            this.nudMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(32, 51);
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(120, 20);
            this.nudHours.TabIndex = 11;
            // 
            // listMeasurestab2
            // 
            this.listMeasurestab2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listMeasurestab2.FullRowSelect = true;
            this.listMeasurestab2.HideSelection = false;
            this.listMeasurestab2.Location = new System.Drawing.Point(29, 275);
            this.listMeasurestab2.Margin = new System.Windows.Forms.Padding(2);
            this.listMeasurestab2.Name = "listMeasurestab2";
            this.listMeasurestab2.Size = new System.Drawing.Size(523, 240);
            this.listMeasurestab2.TabIndex = 10;
            this.listMeasurestab2.UseCompatibleStateImageBehavior = false;
            this.listMeasurestab2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Station";
            this.columnHeader1.Width = 257;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Measure Name";
            this.columnHeader2.Width = 184;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(581, 790);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Enabled = true;
            this.timerProgressBar.Interval = 1;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 815);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedianFilterRepetions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigTreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowTreshold)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nudLowTreshold;
        private System.Windows.Forms.Label lblMeasure;
        private System.Windows.Forms.NumericUpDown nudSampleNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHigTreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateFile;
        private System.Windows.Forms.ListView listMeasures;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.ColumnHeader column2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private System.Windows.Forms.CheckBox cbNotNull;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ProgressBar pbGeneratingFile;
        private System.Windows.Forms.Timer timerProgressBar;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMedianFilterRepetions;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtData;
        private System.Windows.Forms.ListView listMeasurestab2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSubSampling;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.NumericUpDown nudHours;
    }
}