using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Threading;
using System.Data.Odbc;
using static System.Net.WebRequestMethods;
using System.Security.AccessControl;
using System.Security.Principal;

namespace PoseidoneDataCleaner
{
    public partial class frmMenu : Form
    {
        ListView checkedList;
        List<Classes.Templates.MeasureAndId> checkeditems = new List<Classes.Templates.MeasureAndId>();
        List<Classes.Templates.MeasureAndId> items;
        List<Classes.StatisticsTools.SampleStatistic> settingsOveritems = new List<Classes.StatisticsTools.SampleStatistic>();
        string station = "";
        string measureName = "";
        List<Classes.Templates.Sample>[] samples;
        Thread t;
        DirectoryInfo dInfo;

        int lenghtProgressBar = 0;
        int ValueProgressBar = 0;
        bool generatefile = false;
        bool generationEnd = false;
        string labelText = "";

        public frmMenu(ListView dataSelected, List<Classes.Templates.MeasureAndId> items)
        {
            InitializeComponent();

            lblProgress.Hide();
            pbGeneratingFile.Hide();
            //Data to consider
            this.checkedList = dataSelected;
            this.items = items;

            if (listMeasures.SelectedItems.Count <= 0)
            {

            }
            for (int i = 0; i < dataSelected.CheckedItems.Count; i++)
            {
                this.listMeasures.Items.Add(dataSelected.CheckedItems[i].Text);
                this.listMeasures.Items[i].SubItems.Add(dataSelected.CheckedItems[i].SubItems[1]);

                Classes.Templates.MeasureAndId checkeditem = new Classes.Templates.MeasureAndId();

                checkeditem.stationName = (dataSelected.CheckedItems[i].Text);
                checkeditem.name = (dataSelected.CheckedItems[i].SubItems[1].Text);

                checkeditem.id = items.Find(x => x.stationName == checkeditem.stationName && x.name == checkeditem.name).id;

                checkeditems.Add(checkeditem);

            }

            t = new Thread(new ThreadStart(GetSamples));
            t.Start();

        }


        #region EVENTS
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


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (fbdPath.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbdPath.SelectedPath))
            {
                Program.FolderPath = fbdPath.SelectedPath + "\\dati";
                System.IO.Directory.CreateDirectory(Program.FolderPath);

                dInfo = new DirectoryInfo(Program.FolderPath);
                DirectorySecurity dSecurity = dInfo.GetAccessControl();
                dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
                dInfo.SetAccessControl(dSecurity);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            t.Abort();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            //GenerateFile();
            Thread tGen = new Thread(new ThreadStart(GenerateFile));
            tGen.Start();

        }



        #endregion



        #region METHODS/FUNCTIONS
        private void GetSamples()
        {
            samples = new List<Classes.Templates.Sample>[checkeditems.Count];
            Classes.DbInteraction.MenervaDbComponent menervaDbComponent = new Classes.DbInteraction.MenervaDbComponent();
            Classes.DbInteraction.DbInteractor dbInteractor = new Classes.DbInteraction.DbInteractor(new OdbcConnection(Program.dsnconnection));


            for (int i = 0; i < this.checkeditems.Count; i++)
            {
                samples[i] = menervaDbComponent.GetSamples(new OdbcConnection(Program.dsnconnection), checkeditems.ElementAt(i).id, DateTime.Parse("2021-01-01"), DateTime.Parse("2022-01-01"), cbNotNull.Checked);

                for (int j = 0; j < samples[i].Count; j++)
                {
                    samples[i].ElementAt(j).stationName = checkeditems[i].stationName;
                    samples[i].ElementAt(j).name = checkeditems[i].name;
                }
            }

            MessageBox.Show("Samples correctly loaded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public void GenerateFile()
        {
            StreamWriter sw;
            generatefile = true;
            bool createDirectory = true;
            DirectoryInfo Directorystation = dInfo;
            string measName = "";
            

            if (Directory.Exists(dInfo.ToString()))
            {
                if (t.ThreadState == ThreadState.Stopped)
                {
                    //il folder path cambia ogni volta che cambia la stazione e che cambia la misura.
                    for (int i = 0; i < samples.Length; i++)
                    {
                        lenghtProgressBar = samples[i].Count;

                        for (int j = 0; j < samples[i].Count; j++)
                        {
                            if (createDirectory)
                            {  
                                System.IO.Directory.CreateDirectory(dInfo.ToString() + "\\" + samples[i].ElementAt(j).stationName);
                                Directorystation = new DirectoryInfo(dInfo.ToString() + "\\" + samples[i].ElementAt(j).stationName);
                                measName = "\\" + samples[i].ElementAt(j).name + ".txt";

                                DirectorySecurity dsecStation = Directorystation.GetAccessControl();
                                dsecStation.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
                                Directorystation.SetAccessControl(dsecStation);
                            }


                            labelText = "Generating " + samples[i].ElementAt(j).stationName + "\\" + samples[i].ElementAt(j).name + ".txt";

                            if (!System.IO.File.Exists(Directorystation.ToString() + measName))
                            {
                                sw = new StreamWriter(Directorystation.ToString() + measName);
                            }
                            else
                            {
                                createDirectory = false;
                                sw = new StreamWriter(Directorystation.ToString() + measName, true);
                            }

                            sw.WriteLine(samples[i].ElementAt(j).stationName + "-" + samples[i].ElementAt(j).datetime + "-" + samples[i].ElementAt(j).value);

                            sw.Close();

                            ValueProgressBar = j + 1;
                        }
                        createDirectory = true;

                    }

                    generatefile = false;
                    generationEnd = true;
                }
                else
                {
                    MessageBox.Show("Wait until samples are fully loaded", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            
            if (generatefile)
            {
                if (pbGeneratingFile.Maximum == 0)
                {
                    pbGeneratingFile.Show();
                    lblProgress.Text = labelText;
                    lblProgress.Show();
                    pbGeneratingFile.Maximum = lenghtProgressBar;
                }
                else
                {
                    pbGeneratingFile.Maximum = lenghtProgressBar;
                    lblProgress.Text = labelText;
                    pbGeneratingFile.Value = ValueProgressBar;
                }
            }
            else
            {
                pbGeneratingFile.Value = 0;
                pbGeneratingFile.Hide();
                lblProgress.Hide();
                if (generationEnd)
                {
                    MessageBox.Show("File correctly created.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }

            

            


        
        }
    }
}
