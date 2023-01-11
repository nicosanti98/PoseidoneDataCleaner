using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PoseidoneDataCleaner
{
    public partial class frmMenu : Form
    {

        ListView checkedList;
        List<Classes.Templates.MeasureAndId> items;
        List<Classes.StatisticsTools.SampleStatistic> settingsOveritems = new List<Classes.StatisticsTools.SampleStatistic>();
        string station = "";
        string measureName = "";
        bool changes = false;

        public frmMenu(ListView dataSelected, List<Classes.Templates.MeasureAndId> items)
        {
            InitializeComponent();

            //Data to consider
            this.checkedList = dataSelected;
            this.items = items;

            if (listMeasures.SelectedItems.Count <= 0)
            {
                btnGenerateFile.Enabled = false;
            }
            for (int i = 0; i < dataSelected.CheckedItems.Count; i++)
            {


                this.listMeasures.Items.Add(dataSelected.CheckedItems[i].Text);
                this.listMeasures.Items[i].SubItems.Add(dataSelected.CheckedItems[i].SubItems[1]);
            }
        }

        private void listMeasures_SelectedIndexChanged(object sender, EventArgs e)
        {

            decimal nudHiTresh = nudHigTreshold.Value;
            decimal nudLowTresh = nudLowTreshold.Value;
            decimal nudSample = nudSampleNum.Value;

            string[] subs = { " - " };


            if (lblMeasure.Text != "")
            {
                station = lblMeasure.Text.Split(subs, StringSplitOptions.None)[0];
                measureName = lblMeasure.Text.Split(subs, StringSplitOptions.None)[1];
            }


            btnGenerateFile.Enabled = true;
            if (listMeasures.SelectedItems.Count > 0)
            {

                nudHigTreshold.Value = 0;
                nudLowTreshold.Value = 0;
                nudSampleNum.Value = 3;


                lblMeasure.Text = listMeasures.SelectedItems[0].SubItems[0].Text + " - " + listMeasures.SelectedItems[0].SubItems[1].Text;
                if (settingsOveritems.Exists(x => x.sample.stationName == listMeasures.SelectedItems[0].SubItems[0].Text && x.sample.name == listMeasures.SelectedItems[0].SubItems[1].Text))
                {
                    var item = settingsOveritems.Find(x => x.sample.stationName == listMeasures.SelectedItems[0].SubItems[0].Text && x.sample.name == listMeasures.SelectedItems[0].SubItems[1].Text);

                    nudHigTreshold.Value = decimal.Parse(item.highTreshold.ToString());
                    nudLowTreshold.Value = decimal.Parse(item.lowTreshold.ToString());
                    nudSampleNum.Value = decimal.Parse(item.SamplesRange.ToString());
                }

            }
            else
            {
                //Se ci sono modifiche, messagebox che chiede se salvare o no

                if (settingsOveritems.Exists(x => x.sample.stationName == station && x.sample.name == measureName))
                {
                    var item = settingsOveritems.Find(x => x.sample.stationName == station && x.sample.name == measureName);

                    if ((nudHigTreshold.Value == (decimal)item.highTreshold) && (nudLowTreshold.Value == (decimal)item.lowTreshold) && (nudSampleNum.Value == (decimal)item.SamplesRange))
                    {
                        //noop;
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Do you want to save changes?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            SaveSettings(measureName, station);

                        }
                    }
                }
                else
                {
                    if (listMeasures.SelectedItems.Count > 0)
                    {
                        btnGenerateFile.Enabled = true;
                        lblMeasure.Text = listMeasures.SelectedItems[0].SubItems[0].Text + " - " + listMeasures.SelectedItems[0].SubItems[1].Text;
                    }

                    if ((nudHigTreshold.Value != nudHigTreshold.Minimum) || (nudLowTreshold.Value != nudLowTreshold.Minimum) || (nudSampleNum.Value != nudSampleNum.Minimum))
                    {
                        DialogResult dialog = MessageBox.Show("Do you want to save?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialog == DialogResult.Yes)
                        {
                            SaveSettings(measureName, station);

                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {




        }

        public void SaveSettings(string measure, string station)
        {
            bool updated = false;

            Classes.Templates.MeasureAndId item = new Classes.Templates.MeasureAndId();
            item.name = measure;
            item.stationName = station;
            item.id = items.Find(x => x.name == measure && x.stationName == station).id;
            item.stationId = items.Find(x => x.name == measure && x.stationName == station).stationId;



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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
