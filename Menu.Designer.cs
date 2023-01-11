
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.cbNotNull = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigTreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowTreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 641);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(582, 615);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Median Filter";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.btnGenerateFile.Location = new System.Drawing.Point(477, 527);
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
            this.lblMeasure.Location = new System.Drawing.Point(106, 21);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(582, 615);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(22, 542);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
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
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 647);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigTreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowTreshold)).EndInit();
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
    }
}