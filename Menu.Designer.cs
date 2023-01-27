
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.crtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedianFilterRepetions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigTreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowTreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 1004);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(777, 975);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Median Filter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Filter applications number";
            // 
            // nudMedianFilterRepetions
            // 
            this.nudMedianFilterRepetions.Location = new System.Drawing.Point(256, 252);
            this.nudMedianFilterRepetions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nudMedianFilterRepetions.Size = new System.Drawing.Size(135, 22);
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
            this.lblProgress.Location = new System.Drawing.Point(252, 913);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(44, 17);
            this.lblProgress.TabIndex = 12;
            this.lblProgress.Text = "TEXT";
            // 
            // pbGeneratingFile
            // 
            this.pbGeneratingFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbGeneratingFile.Location = new System.Drawing.Point(256, 935);
            this.pbGeneratingFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbGeneratingFile.Maximum = 0;
            this.pbGeneratingFile.Name = "pbGeneratingFile";
            this.pbGeneratingFile.Size = new System.Drawing.Size(247, 28);
            this.pbGeneratingFile.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(8, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 34);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbNotNull
            // 
            this.cbNotNull.AutoSize = true;
            this.cbNotNull.Location = new System.Drawing.Point(513, 102);
            this.cbNotNull.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNotNull.Name = "cbNotNull";
            this.cbNotNull.Size = new System.Drawing.Size(164, 21);
            this.cbNotNull.TabIndex = 10;
            this.cbNotNull.Text = "Set NULL values to 0";
            this.cbNotNull.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(32, 929);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(115, 34);
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
            this.listMeasures.Location = new System.Drawing.Point(32, 321);
            this.listMeasures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listMeasures.Name = "listMeasures";
            this.listMeasures.Size = new System.Drawing.Size(696, 294);
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
            this.btnGenerateFile.Location = new System.Drawing.Point(613, 929);
            this.btnGenerateFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateFile.Name = "btnGenerateFile";
            this.btnGenerateFile.Size = new System.Drawing.Size(115, 34);
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
            this.lblMeasure.Location = new System.Drawing.Point(141, 48);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Size = new System.Drawing.Size(0, 25);
            this.lblMeasure.TabIndex = 7;
            // 
            // nudSampleNum
            // 
            this.nudSampleNum.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSampleNum.Location = new System.Drawing.Point(256, 210);
            this.nudSampleNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.nudSampleNum.Size = new System.Drawing.Size(135, 22);
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
            this.label3.Location = new System.Drawing.Point(32, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sample Number";
            // 
            // nudHigTreshold
            // 
            this.nudHigTreshold.Location = new System.Drawing.Point(256, 156);
            this.nudHigTreshold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudHigTreshold.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudHigTreshold.Name = "nudHigTreshold";
            this.nudHigTreshold.Size = new System.Drawing.Size(135, 22);
            this.nudHigTreshold.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "High Treshold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Low Treshold";
            // 
            // nudLowTreshold
            // 
            this.nudLowTreshold.Location = new System.Drawing.Point(256, 105);
            this.nudLowTreshold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudLowTreshold.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLowTreshold.Name = "nudLowTreshold";
            this.nudLowTreshold.Size = new System.Drawing.Size(135, 22);
            this.nudLowTreshold.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(777, 975);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(777, 975);
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
            // crtData
            // 
            chartArea1.Name = "ChartArea1";
            this.crtData.ChartAreas.Add(chartArea1);
            this.crtData.Location = new System.Drawing.Point(32, 620);
            this.crtData.Name = "crtData";
            this.crtData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.crtData.Series.Add(series1);
            this.crtData.Size = new System.Drawing.Size(696, 290);
            this.crtData.TabIndex = 15;
            this.crtData.Text = "Samples Chart";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 1003);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedianFilterRepetions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigTreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowTreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtData)).EndInit();
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
    }
}