using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoseidoneDataCleaner
{
    public partial class frmMenu : Form
    {
        enum Saved
        {
            FirstAccess = -1,
            NotSaved = 0,
            Saved = 1

        }
        Saved isSaved = Saved.FirstAccess;
        ListView checkedList;
        List<Classes.Templates.MeasureAndId> items;

        List<Classes.StatisticsTools.SampleStatistic> settingsOveritems = new List<Classes.StatisticsTools.SampleStatistic>(); 

        public frmMenu(ListView dataSelected, List<Classes.Templates.MeasureAndId> items)
        {
            InitializeComponent();

            //Data to consider
            this.checkedList = dataSelected;
            this.items = items;

            if(listMeasures.SelectedItems.Count <= 0)
            {
                btnSave.Enabled = false; 
            }
            for(int i = 0; i < dataSelected.CheckedItems.Count; i++)
            {
               

                this.listMeasures.Items.Add(dataSelected.CheckedItems[i].Text);
                this.listMeasures.Items[i].SubItems.Add(dataSelected.CheckedItems[i].SubItems[1]);
            }
        }

        private void listMeasures_SelectedIndexChanged(object sender, EventArgs e)
        {


            btnSave.Enabled = true;
            if (listMeasures.SelectedItems.Count > 0)
            {
                nudHigTreshold.Value = 0;
                nudLowTreshold.Value = 0;
                nudSampleNum.Value = 3; 
                lblMeasure.Text = listMeasures.SelectedItems[0].SubItems[0].Text + " - " + listMeasures.SelectedItems[0].SubItems[1].Text;
                if (settingsOveritems.Exists(x => x.sample.stationName == listMeasures.SelectedItems[0].SubItems[0].Text && x.sample.name == listMeasures.SelectedItems[0].SubItems[1].Text ))
                {
                    var item = settingsOveritems.Find(x => x.sample.stationName == listMeasures.SelectedItems[0].SubItems[0].Text && x.sample.name == listMeasures.SelectedItems[0].SubItems[1].Text);

                    nudHigTreshold.Value = decimal.Parse(item.highTreshold.ToString());
                    nudLowTreshold.Value = decimal.Parse(item.lowTreshold.ToString());
                    nudSampleNum.Value = decimal.Parse(item.SamplesRange.ToString());
                    

                }

            }
            else
            {
                if (isSaved == Saved.NotSaved)
                {
                    //Se ci sono modifiche, messagebox che chiede se salvare o no
                    MessageBox.Show("DEVI SALVA MNONGOLO!");
                }
                else
                {
                    
                    if (listMeasures.SelectedItems.Count > 0)
                    {
                        btnSave.Enabled = true;
                        lblMeasure.Text = listMeasures.SelectedItems[0].SubItems[0].Text + " - " + listMeasures.SelectedItems[0].SubItems[1].Text;
                    }
                }

                


            }
            isSaved = Saved.NotSaved;






        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool updated = false; 
            isSaved = Saved.Saved;

            //Take the selected item
            string name = this.listMeasures.SelectedItems[0].SubItems[1].Text;
            string stationName = this.listMeasures.SelectedItems[0].SubItems[0].Text;

            Classes.Templates.MeasureAndId item = new Classes.Templates.MeasureAndId();
            item.name = name;
            item.stationName = stationName;
            item.id = items.Find(x => x.name == name && x.stationName == stationName).id;
            item.stationId = items.Find(x => x.name == name && x.stationName == stationName).stationId;

    

            if (settingsOveritems.Exists(x => x.sample.id == item.id))
            {
                settingsOveritems.RemoveAt(settingsOveritems.FindIndex(x => x.sample.id == item.id));
                updated = true; 
            }

            Classes.StatisticsTools.SampleStatistic statItem = new Classes.StatisticsTools.SampleStatistic();
            statItem.sample = item;
            statItem.lowTreshold = float.Parse(nudLowTreshold.Value.ToString());
            statItem.highTreshold = float.Parse(nudHigTreshold.Value.ToString());
            statItem.SamplesRange = int.Parse(nudSampleNum.Value.ToString());

            settingsOveritems.Add(statItem);

            if (updated)
            {
                MessageBox.Show("Values have been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Values have been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nudLowTreshold_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudHigTreshold_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
