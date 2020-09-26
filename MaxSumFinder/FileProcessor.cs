using MaxSumFinder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxSumFinder
{
    public class FileProcessor : IFileProcessor
    {
        public int MaxSumLine { get; set; }
        public double MaxLineSum { get; set; }
        public List<double> LineList { get; set; } = new List<double>();
        public List<int> BadLines { get; set; } = new List<int>();

        Dictionary<int, double> processedText =
    new Dictionary<int, double>();

        //double currentSumLine = 0.0;
        
        //bool lineIsValid = true;

        public void ProcessFile(List<string> textObject)
        {
            for (int i = 0; i < textObject.Count; i++)
            {
                string[] tryLine;
                tryLine = textObject[i].Split(',');
                
                double validDouble;
                int badLineBuffer = 0;

                foreach (var item in tryLine)
                {
                    
                    if (Double.TryParse(item, out validDouble))
                    {
                        LineList.Add(validDouble);
                    }
                    else
                    {
                        badLineBuffer = i;
                    }
                }

                BadLines.Add(badLineBuffer);
                processedText.Add(i, LineList.Sum());

            }

            foreach (var item in processedText)
            {
                if (item.Value < 0)
                {
                    BadLines.Add(item.Key);
                }
                else
                {
                    MaxSumLine = item.Key;
                }
            }
        }
    }
}
