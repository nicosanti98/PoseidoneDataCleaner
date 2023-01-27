using Microsoft.Win32.SafeHandles;
using PoseidoneDataCleaner.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PoseidoneDataCleaner.Classes.StatisticsTools
{
    class Filter
    {

        public Filter()
        {
             
        }

        public List<Classes.Templates.Sample>[] MedianFilter(List<StatisticsTools.SampleStatistic> settings, List<Classes.Templates.Sample>[] samples, int number)
        {
            SampleStatistic sampleStatistic = new SampleStatistic();
            double[] value;
            int WindowSize = 0;
            List<Classes.Templates.Sample>[] originalSamples = samples;
            List<Classes.Templates.Sample>[] newList = new List<Templates.Sample>[samples.Length];
            List<Classes.Templates.Sample>[] newArr = new List<Templates.Sample>[0];
            newList.Initialize();
            newArr.Initialize();
            for (int i = 0; i < number; i++)
            {
                for(int j = 0; j < originalSamples.Length; j++)
                {
                    sampleStatistic = GetSettingsById(samples[j].ElementAt(0), settings);
                    //value = new double[sampleStatistic.SamplesRange];
                    WindowSize = sampleStatistic.SamplesRange;
                    newList[j] = new List<Templates.Sample>();
                    List<Classes.Templates.Sample> zeros = new List<Templates.Sample>();
                    zeros = addZerosToList(originalSamples[j], WindowSize);
                    int w = 0;
                    for (int z = WindowSize; z < (zeros.Count - WindowSize) ; z++)
                    {
                        // oggetto attuale[z] - Classes.Templates.Sample newItem;
                        
                        Classes.Templates.Sample newItem;

                        var Window = zeros.GetRange(z - (int)(WindowSize /2), WindowSize);
                        Window = Window.OrderBy(x => x.value).ToList();

                        newItem = Window.ElementAt((int)(Window.Count / 2));
                        originalSamples[j].ElementAt(w).value = newItem.value;

                        newList[j].Add(originalSamples[j].ElementAt(w));
                        w++;
                    }                        

                    //var sboccodesangue = newArr.ToList<List<Classes.Templates.Sample>>();
                    originalSamples[j] = newList[j];
                    //sboccodesangue.Add(newList[j]);
                    //newArr = sboccodesangue.ToArray();
                }
                
            }


            
            return originalSamples;
        }

        private List<Classes.Templates.Sample> addZerosToList(List<Classes.Templates.Sample> list, int WindowSize)
        {

            List<Classes.Templates.Sample> zeros = new List<Templates.Sample>();
            for (int w = 0; w < WindowSize; w++)
            {
                Classes.Templates.Sample item = new Templates.Sample();
                item.value = 0;
                zeros.Add(item);
            }
            zeros.AddRange(list);
            for (int w = 0; w < WindowSize; w++)
            {
                Classes.Templates.Sample item = new Templates.Sample();
                item.value = 0;
                zeros.Add(item);
            }

            return zeros;
        }
        private SampleStatistic GetSettingsById(Classes.Templates.Sample sample, List<StatisticsTools.SampleStatistic> settings )
        {
            SampleStatistic sampleStatistic = new SampleStatistic();

            sampleStatistic = settings.Find( x => x.sample.id == sample.id );

            return sampleStatistic;

        }

    }
}
