
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMeasure = new System.Windows.Forms.Label();
            this.nudSampleNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHigTreshold = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLowTreshold = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabControl1.Location = new System.Drawing.Point(1, -5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 789);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listMeasures);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.lblMeasure);
            this.tabPage1.Controls.Add(this.nudSampleNum);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.nudHigTreshold);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nudLowTreshold);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 760);
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
            this.listMeasures.Location = new System.Drawing.Point(34, 50);
            this.listMeasures.Name = "listMeasures";
            this.listMeasures.Size = new System.Drawing.Size(248, 478);
            this.listMeasures.TabIndex = 9;
            this.listMeasures.UseCompatibleStateImageBehavior = false;
            this.listMeasures.View = System.Windows.Forms.View.Details;
            this.listMeasures.SelectedIndexChanged += new System.EventHandler(this.listMeasures_SelectedIndexChanged);
            // 
            // column1
            // 
            this.column1.Text = "Station";
            this.column1.Width = 120;
            // 
            // column2
            // 
            this.column2.Text = "Measure Name";
            this.column2.Width = 184;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(425, 314);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMeasure
            // 
            this.lblMeasure.AutoSize = true;
            this.lblMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasure.ForeColor = System.Drawing.Color.Green;
            this.lblMeasure.Location = new System.Drawing.Point(311, 41);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Size = new System.Drawing.Size(96, 25);
            this.lblMeasure.TabIndex = 7;
            this.lblMeasure.Text = "Measure";
            // 
            // nudSampleNum
            // 
            this.nudSampleNum.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSampleNum.Location = new System.Drawing.Point(544, 219);
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
            this.label3.Location = new System.Drawing.Point(317, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sample Number";
            // 
            // nudHigTreshold
            // 
            this.nudHigTreshold.Location = new System.Drawing.Point(544, 163);
            this.nudHigTreshold.Name = "nudHigTreshold";
            this.nudHigTreshold.Size = new System.Drawing.Size(135, 22);
            this.nudHigTreshold.TabIndex = 4;
            this.nudHigTreshold.ValueChanged += new System.EventHandler(this.nudHigTreshold_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "High Treshold";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Low Treshold";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudLowTreshold
            // 
            this.nudLowTreshold.Location = new System.Drawing.Point(544, 123);
            this.nudLowTreshold.Name = "nudLowTreshold";
            this.nudLowTreshold.Size = new System.Drawing.Size(135, 22);
            this.nudLowTreshold.TabIndex = 1;
            this.nudLowTreshold.ValueChanged += new System.EventHandler(this.nudLowTreshold_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 760);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 796);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listMeasures;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.ColumnHeader column2;
        private System.Windows.Forms.TabPage tabPage2;
    }
}