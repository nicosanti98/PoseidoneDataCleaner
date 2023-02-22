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

        public List<List<Classes.Templates.Sample>> MedianFilter(List<StatisticsTools.SampleStatistic> settings, List<List<Classes.Templates.Sample>> samples, int number)
        {
            SampleStatistic sampleStatistic = new SampleStatistic();
            int WindowSize = 0;

            List<List<Classes.Templates.Sample>> originalSamples = samples;
            List<List<Classes.Templates.Sample>> newList = new List<List<Templates.Sample>>();
            List<List<Classes.Templates.Sample>> newArr = new List<List<Templates.Sample>>();

            
            for (int i = 0; i < number; i++)
            {
                for(int j = 0; j < originalSamples.Count; j++)
                {
                    if(originalSamples.ElementAt(j).Count > 0)
                    {
                        float HighTreshold = settings.ElementAt(j).highTreshold;
                        float LowTreshold = settings.ElementAt(j).lowTreshold;
                        sampleStatistic = GetSettingsById(samples[j].ElementAt(0), settings);
                        //value = new double[sampleStatistic.SamplesRange];
                        WindowSize = sampleStatistic.SamplesRange;
                        
                        List<Classes.Templates.Sample> zeros = new List<Templates.Sample>();

                        //Lead all values inside the interval defined by tresholds
                        for(int z = 0; z < originalSamples[j].Count; z++)
                        {
                            if(originalSamples[j][z].value < LowTreshold)
                            {
                                originalSamples[j][z].value = LowTreshold;
                            }
                        
                            if (originalSamples[j][z].value > HighTreshold)
                            {
                                originalSamples[j][z].value = HighTreshold;
                            }

                        }
                        zeros = addZerosToList(originalSamples[j], WindowSize);
                        int w = 0;

                        for (int z = WindowSize; z < (zeros.Count - WindowSize); z++)
                        {
                            
                            // oggetto attuale[z] - Classes.Templates.Sample newItem;

                            Classes.Templates.Sample newItem = new Classes.Templates.Sample();

                            var Window = zeros.GetRange(z - (int)(WindowSize / 2), WindowSize);
                            Window = Window.OrderBy(x => x.value).ToList();

                            newItem = Window.ElementAt((int)(Window.Count / 2));
                            originalSamples[j].ElementAt(w).value = newItem.value;

                            w++;
                        }


                    }
                    

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
