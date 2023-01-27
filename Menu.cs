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
using PoseidoneDataCleaner.Classes.Interfaces;
using PoseidoneDataCleaner.Classes.Templates;
using System.Reflection;

namespace PoseidoneDataCleaner
{
    public partial class frmMenu : Form
    {
        ListView checkedList;
        List<Classes.Templates.MeasureAndId> checkeditems = new List<Classes.Templates.MeasureAndId>();
        List<Classes.Templates.MeasureAndId> items;
        List<Classes.StatisticsTools.SampleStatistic> settingsOveritems = new List<Classes.StatisticsTools.SampleStatistic>();
        List<Thread> threads = new List<Thread>();


        string station = "";
        string measureName = "";

        List<Classes.Templates.Sample>[] samples;
        List<List<Classes.Templates.Sample>> originalValules = new List<List<Classes.Templates.Sample>>();

        DirectoryInfo dInfo;
        bool threadLoading = false;
        bool messageshown = false;

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

            
            Classes.DbInteraction.MenervaDbComponent menervaDbComponent = new Classes.DbInteraction.MenervaDbComponent();
            Classes.DbInteraction.DbInteractor dbInteractor = new Classes.DbInteraction.DbInteractor(new OdbcConnection(Program.dsnconnection));
          

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
            samples = new List<Classes.Templates.Sample>[0];

            int z = 0; 

            while(z < checkeditems.Count)
            {
                MeasureAndId sboccodesangue = checkeditems.ElementAt(z);
                z++;
                threads.Add(new Thread(() => GetSamples(menervaDbComponent, sboccodesangue)));
                

            }
          
            foreach(Thread t in threads)
            {
                t.Start();
            }

            foreach (Thread t in threads)
            {
                t.Join();
            }

            MessageBox.Show("Samples correctly loaded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var chart = crtData.ChartAreas[0];
            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;


            

        }


        #region EVENTS
        private void listMeasures_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal nudHiTresh = nudHigTreshold.Value;
            decimal nudLowTresh = nudLowTreshold.Value;
            decimal nudSample = nudSampleNum.Value;
            decimal nudRepetions = nudMedianFilterRepetions.Value;

        

            string[] subs = { " - " };
            crtData.Titles.Clear();
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
                nudMedianFilterRepetions.Value = 1;

                //Fill graph
                int index = 0;
                foreach(List<Classes.Templates.Sample> sampless in samples)
                {

                    if ((sampless.Count <= 0) || (sampless.ElementAt(0).stationName == listMeasures.SelectedItems[0].SubItems[0].Text && sampless.ElementAt(0).name == listMeasures.SelectedItems[0].SubItems[1].Text))
                    {


                    }
                    else
                    {
                        index++;
                    }


                }

                    var selectedObject = samples[index];

                //crtData.Titles.Add(selectedObject[0].stationName + " - " + selectedObject[0].name);
                //for (int i = 0; i < crtData.Series[0].Points.Count; i++)
                //{
                //    crtData.Series[0].Points.RemoveAt(i);
                //}
                //for (int i = 0; i < selectedObject.Count; i++)
                //{
                //    crtData.Series[0].Points.AddY(selectedObject[i].value);

                //}



                lblMeasure.Text = listMeasures.SelectedItems[0].SubItems[0].Text + " - " + listMeasures.SelectedItems[0].SubItems[1].Text;
                if (settingsOveritems.Exists(x => x.sample.stationName == listMeasures.SelectedItems[0].SubItems[0].Text && x.sample.name == listMeasures.SelectedItems[0].SubItems[1].Text))
                {
                    var item = settingsOveritems.Find(x => x.sample.stationName == listMeasures.SelectedItems[0].SubItems[0].Text && x.sample.name == listMeasures.SelectedItems[0].SubItems[1].Text);

                    nudHigTreshold.Value = decimal.Parse(item.highTreshold.ToString());
                    nudLowTreshold.Value = decimal.Parse(item.lowTreshold.ToString());
                    nudSampleNum.Value = decimal.Parse(item.SamplesRange.ToString());
                    nudMedianFilterRepetions.Value = decimal.Parse(item.medianFilterRepetitions.ToString());

                    

                }
            }
            else
            {
                //Se ci sono modifiche, messagebox che chiede se salvare o no

                if (settingsOveritems.Exists(x => x.sample.stationName == station && x.sample.name == measureName))
                {
                    var item = settingsOveritems.Find(x => x.sample.stationName == station && x.sample.name == measureName);

                    if ((nudHigTreshold.Value == (decimal)item.highTreshold) && (nudLowTreshold.Value == (decimal)item.lowTreshold) && (nudSampleNum.Value == (decimal)item.SamplesRange) && (nudMedianFilterRepetions.Value == (decimal)item.medianFilterRepetitions))
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

                    if ((nudHigTreshold.Value != nudHigTreshold.Minimum) || (nudLowTreshold.Value != nudLowTreshold.Minimum) || (nudSampleNum.Value != nudSampleNum.Minimum) || (nudMedianFilterRepetions.Value != nudMedianFilterRepetions.Minimum))
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
            for(int i = 0; i < threads.Count; i++)
            {
                threads[i].Abort();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            //Thread tGen = new Thread(new ThreadStart(GenerateFile));
            //tGen.Start();ù
            int counter = 0;
            lenghtProgressBar = samples.Length;
            for(int i = 0; i < threads.Count; i++)
            {
                if(threads[i].ThreadState == ThreadState.Stopped)
                {
                    counter++;
                    threadLoading = true;
                }
            }
            if (threadLoading && counter  == threads.Count)
            {
                generatefile = true;
                DirectoryInfo Directorystation = dInfo;

                List<Thread> threads = new List<Thread>();

               

                
                
               
                string path = "";

            

                int j = 0;
                foreach (List<Classes.Templates.Sample> sample in originalValules)
                {
                    if (sample.Count > 0)
                    {
                        if (!(System.IO.Directory.Exists(dInfo.ToString() + "\\" + "Original Data" + "\\" + sample.ElementAt(j).stationName)))
                        {
                            System.IO.Directory.CreateDirectory(dInfo.ToString() + "\\" + "Original Data" + "\\" + sample.ElementAt(j).stationName);
                            Directorystation = new DirectoryInfo(dInfo.ToString() + "\\" + "Original Data" + "\\" + sample.ElementAt(j).stationName);
                            DirectorySecurity dsecStation = Directorystation.GetAccessControl();
                            dsecStation.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
                            Directorystation.SetAccessControl(dsecStation);



                            //new Thread (new ParameterizedThreadStart(myMethod));
                            try
                            {
                                path = dInfo.ToString() + "\\" + "Original Data" + "\\" + sample.ElementAt(0).stationName + "\\" + sample.ElementAt(0).name + ".txt";
                                WriteOnFile(path, sample);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(path + ex.StackTrace);
                            }
                        }
                        else
                        {
                            System.IO.Directory.Delete(dInfo.ToString() + "\\" + "Original Data" + "\\" + sample.ElementAt(j).stationName, true);
                            System.IO.Directory.CreateDirectory(dInfo.ToString() + "\\" + "Original Data" + "\\" + sample.ElementAt(j).stationName);
                            Directorystation = new DirectoryInfo(dInfo.ToString() + "\\" + "Original Data" + "\\" + sample.ElementAt(j).stationName);
                            DirectorySecurity dsecStation = Directorystation.GetAccessControl();
                            dsecStation.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
                            Directorystation.SetAccessControl(dsecStation);



                            //new Thread (new ParameterizedThreadStart(myMethod));
                            try
                            {
                                path = dInfo.ToString() + "\\"+"Original Data"+"\\" + sample.ElementAt(0).stationName + "\\[ORIGINAL]" + sample.ElementAt(0).name + ".txt";
                                WriteOnFile(path, sample);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(path + ex.StackTrace);
                            }

                        }

                    }
                    j++;
                }
                Classes.StatisticsTools.Filter f = new Classes.StatisticsTools.Filter();
                List<Classes.Templates.Sample>[] median = f.MedianFilter(settingsOveritems, samples, (int)nudMedianFilterRepetions.Value);
                samples = median;
                int i = 0; 
                foreach (List<Classes.Templates.Sample> sample1 in samples)
                {
                    if (sample1.Count > 0)
                    {
                        if (!(System.IO.Directory.Exists(dInfo.ToString() + "\\" +sample1.ElementAt(0).stationName)))
                        {
                            System.IO.Directory.CreateDirectory(dInfo.ToString() + "\\" + sample1.ElementAt(0).stationName);
                            Directorystation = new DirectoryInfo(dInfo.ToString() + "\\" + sample1.ElementAt(0).stationName);
                            DirectorySecurity dsecStation = Directorystation.GetAccessControl();
                            dsecStation.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
                            Directorystation.SetAccessControl(dsecStation);



                            //new Thread (new ParameterizedThreadStart(myMethod));
                            try
                            {
                                var path1 = dInfo.ToString() + "\\" + sample1.ElementAt(0).stationName + "\\" + sample1.ElementAt(0).name + ".txt";
                                WriteOnFile(path1, sample1);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(path + ex.StackTrace);
                            }
                        }
                        else
                        {
                         
                            System.IO.Directory.Delete(dInfo.ToString() + "\\" + sample1.ElementAt(0).stationName, true);
                            System.IO.Directory.CreateDirectory(dInfo.ToString() + "\\" + sample1.ElementAt(0).stationName);
                            Directorystation = new DirectoryInfo(dInfo.ToString() + "\\" + sample1.ElementAt(0).stationName);
                            DirectorySecurity dsecStation = Directorystation.GetAccessControl();
                            dsecStation.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
                            Directorystation.SetAccessControl(dsecStation);



                            //new Thread (new ParameterizedThreadStart(myMethod));
                            try
                            {
                                var path1 = dInfo.ToString() + "\\" + sample1.ElementAt(0).stationName + "\\" + sample1.ElementAt(0).name + ".txt";
                                WriteOnFile(path1, sample1);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(path + ex.StackTrace);
                            }

                        }
                        
                    }
                    i++;
                }

                foreach (Thread thread in threads)
                {
                    thread.Start();
                }

            }
            else
            {
                MessageBox.Show("Wait until samples are fully loaded", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            generatefile = false;
            generationEnd = true;
            threadLoading = false; 

        }

        #endregion



        #region METHODS/FUNCTIONS
        private void GetSamples(Classes.DbInteraction.MenervaDbComponent menervaDbComponent, Classes.Templates.MeasureAndId measure)
        {
            List<Classes.Templates.Sample> listofSamples = menervaDbComponent.GetSamples(new OdbcConnection(Program.dsnconnection), measure.id, DateTime.Parse("2021-01-01"), DateTime.Parse("2022-01-01"), cbNotNull.Checked);
            
           
            for (int j = 0; j < listofSamples.Count; j++)
            {
                listofSamples.ElementAt(j).stationName = measure.stationName;
                listofSamples.ElementAt(j).name = measure.name;
            }
            samples = samples.Append(listofSamples).ToArray();
            originalValules.Add(listofSamples);

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
            statItem.medianFilterRepetitions = int.Parse(nudMedianFilterRepetions.Value.ToString());


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


        #endregion

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {

            if (generatefile)
            {

                pbGeneratingFile.Show();
                lblProgress.Text = labelText;
                lblProgress.Show();
                pbGeneratingFile.Maximum = lenghtProgressBar;

                lblProgress.Text = labelText;
                pbGeneratingFile.Value = ValueProgressBar;
            }
            else
            {

                //pbGeneratingFile.Hide();
                //lblProgress.Hide();
                if (generationEnd)
                {
                    generationEnd = false;
                    MessageBox.Show("File correctly created.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void WriteOnFile(string path, List<Classes.Templates.Sample> samples)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(samples.ElementAt(0).stationName);
            sw.WriteLine(samples.ElementAt(0).name + ";") ;
            for (int i = 0; i < samples.Count; i++)
            {
                sw.WriteLine(samples.ElementAt(i).datetime.ToString("G") + ";\t" + samples.ElementAt(i).value);
            }
            sw.Close();
            ValueProgressBar++;
        }




    }
}
