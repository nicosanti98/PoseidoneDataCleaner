
namespace PoseidoneDataCleaner
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDsnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.checkedList = new System.Windows.Forms.ListView();
            this.Column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(9, 7);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(448, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Welcome in the Data Normalizer tool. Choose a file .xlsx containing data in Mener" +
    "va db format";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDsnConnect
            // 
            this.btnDsnConnect.Location = new System.Drawing.Point(372, 36);
            this.btnDsnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDsnConnect.Name = "btnDsnConnect";
            this.btnDsnConnect.Size = new System.Drawing.Size(85, 19);
            this.btnDsnConnect.TabIndex = 5;
            this.btnDsnConnect.Text = "Connect DSN";
            this.btnDsnConnect.UseVisualStyleBackColor = true;
            this.btnDsnConnect.Click += new System.EventHandler(this.btnDsnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(206, 496);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(83, 30);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // checkedList
            // 
            this.checkedList.CheckBoxes = true;
            this.checkedList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column1,
            this.Column2});
            this.checkedList.FullRowSelect = true;
            this.checkedList.HideSelection = false;
            this.checkedList.Location = new System.Drawing.Point(11, 118);
            this.checkedList.Margin = new System.Windows.Forms.Padding(2);
            this.checkedList.Name = "checkedList";
            this.checkedList.Size = new System.Drawing.Size(485, 362);
            this.checkedList.TabIndex = 9;
            this.checkedList.UseCompatibleStateImageBehavior = false;
            this.checkedList.View = System.Windows.Forms.View.Details;
            // 
            // Column1
            // 
            this.Column1.Text = "Station";
            this.Column1.Width = 274;
            // 
            // Column2
            // 
            this.Column2.Text = "Measure Name";
            this.Column2.Width = 503;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 554);
            this.Controls.Add(this.checkedList);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDsnConnect);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Normalizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDsnConnect;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ColumnHeader Column1;
        private System.Windows.Forms.ColumnHeader Column2;
        public System.Windows.Forms.ListView checkedList;
    }
}

