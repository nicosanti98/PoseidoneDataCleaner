using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoseidoneDataCleaner
{
    public partial class DSNConnectionForm : Form
    {
        private OdbcConnection connection { get; set; }
        private MainForm originForm;
        private List<Classes.Templates.MeasureAndId> itemsToPass = new List<Classes.Templates.MeasureAndId>();
        public DSNConnectionForm(MainForm originForm)
        {
            this.originForm = originForm; 
            InitializeComponent();
        }

       

        private void btnConnect_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection("DSN=" + txtDSN.Text + ";Uid=" + txtUser.Text + ";Pwd=" + txtPwd.Text);
            this.connection = conn;

            try
            {
                this.connection.Open();
                MessageBox.Show("Connection succeded!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Hide();
                this.originForm.connection = this.connection;
                this.originForm.label2.Text = "Connected to database: "+this.connection.Database;
                this.connection.Close();
                Classes.DbInteraction.MenervaDbComponent menervaDb = new Classes.DbInteraction.MenervaDbComponent();
                List<Classes.Templates.MeasureAndId> idandnames = menervaDb.getMeasureIdAndNames(this.connection);
                ListViewItem item = new ListViewItem();
                for(int i = 0; i < idandnames.Count; i++)
                {
                    this.originForm.checkedList.Items.Add(idandnames.ElementAt(i).stationName);
                    this.originForm.checkedList.Items[i].SubItems.Add(idandnames.ElementAt(i).name);
                }
                this.originForm.ItemsToPass = idandnames;


                             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
