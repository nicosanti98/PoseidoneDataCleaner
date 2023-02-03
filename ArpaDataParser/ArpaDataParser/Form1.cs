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

namespace ArpaDataParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string InputPath;
        string OutputPath;

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            dialogInput.Filter = "File di testo|*.txt";

            if(dialogInput.ShowDialog() == DialogResult.OK)
            {
                InputPath = dialogInput.FileName;
                StreamReader sr = new StreamReader(InputPath);
                String stringa = sr.ReadLine().Split(new string[] { "Data: Anno, Mese, Giorno, Ora, Minuto," }, StringSplitOptions.None)[1];
                for (int i = 0; i < stringa.Split(',').Length; i++)
                {
                    listView.Items.Add(stringa.Split(',')[i]);
                }
                sr.Close();


            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            
            if(dialogSave.ShowDialog() == DialogResult.OK)
            {
                OutputPath = dialogSave.SelectedPath;
                Console.WriteLine(OutputPath);
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(InputPath);

            string stringa = sr.ReadLine();
            //Count how much measures are after datetime
            int measuresNum = stringa.Split(new string[] { "Data: Anno, Mese, Giorno, Ora, Minuto," }, StringSplitOptions.None)[1].Split(',').Length;
            List<int> indexes = new List<int>();
            for(int i = 0; i < listView.CheckedIndices.Count; i++)
            {
                indexes.Add(listView.CheckedIndices[i]);
            }

            List<SWandReference> sws = new List<SWandReference>();
            //Create a file for every measure
            for (int i = 0; i < indexes.Count; i++)
            {
                if (File.Exists(OutputPath + "/" + stringa.Split(new string[] { "Data: Anno, Mese, Giorno, Ora, Minuto," }, StringSplitOptions.None)[1].Split(',')[indexes.ElementAt(i)] + ".txt"))
                {
                    File.Delete(OutputPath + "/" + stringa.Split(new string[] { "Data: Anno, Mese, Giorno, Ora, Minuto," }, StringSplitOptions.None)[1].Split(',')[indexes.ElementAt(i)] + ".txt");
                }

                SWandReference item = new SWandReference();
                StreamWriter sw = new StreamWriter(OutputPath + "/" + stringa.Split(new string[] { "Data: Anno, Mese, Giorno, Ora, Minuto," }, StringSplitOptions.None)[1].Split(',')[indexes.ElementAt(i)] + ".txt");
                item.sw = sw;
                item.index = indexes.ElementAt(i);
                sws.Add(item);
                sw.WriteLine(txtStationName.Text);
                sw.WriteLine(stringa.Split(new string[] { "Data: Anno, Mese, Giorno, Ora, Minuto," }, StringSplitOptions.None)[1].Split(',')[indexes.ElementAt(i)].Substring(1)+";");
                //Write on file


            }

            //Create files only for checked measures
            while (!sr.EndOfStream)
            {
                char[] split = { ',' };
                String[] toParse = sr.ReadLine().Split(split);
                RowElement itemToAdd = new RowElement();
                itemToAdd.Year = int.Parse(toParse[1].ToString());
                itemToAdd.Month = int.Parse(toParse[2]);
                itemToAdd.Day = int.Parse(toParse[3]);
                itemToAdd.Hour = int.Parse(toParse[4]);
                itemToAdd.Minute = int.Parse(toParse[5]);

                itemToAdd.ConvertToDateTime();
                int z = 0;
                for(int i = 0; i < toParse.Length-6; i++)
                {
                    if (i == indexes.ElementAt(z))
                    {
                        if(z < indexes.Count-1)
                        {
                            z++;
                        }

                        for(int j = 0; j < sws.Count; j++)
                        {
                            if(sws.ElementAt(j).index == i)
                            {
                                StreamWriter actualSw = sws.ElementAt(j).sw;
                                actualSw.WriteLine(itemToAdd.date + ";\t" + toParse[6 + i].Substring(1));
                            }
                        }
                    }
                }

       
               

              
            }


            for (int i = 0; i < sws.Count; i++)
            {
                sws.ElementAt(i).sw.Close();
            }






        }
    }
}
