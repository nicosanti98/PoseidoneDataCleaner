using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoseidoneDataCleaner.Classes.Templates;

namespace PoseidoneDataCleaner
{
    public partial class MainForm : Form
    {
        public OdbcConnection connection { get; set; }
        internal List<MeasureAndId> ItemsToPass { get => itemsToPass; set => itemsToPass = value; }

        private List<Classes.Templates.MeasureAndId> itemsToPass;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDsnConnect_Click(object sender, EventArgs e)
        {
            Form newForm = new DSNConnectionForm(this);
            newForm.Show();
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            frmMenu menuForm = new frmMenu(this.checkedList, this.itemsToPass);
            menuForm.Show();
            this.Hide();

        }
    }


    
}
