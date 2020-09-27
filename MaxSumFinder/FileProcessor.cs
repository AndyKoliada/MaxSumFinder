using MaxSumFinder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSumFinder
{
    public class FileProcessor : IFileProcessor
    {
        public int MaxSumLine { get; set; }
        public double MaxLineSum { get; set; }
        public List<double> LineList { get; set; } = new List<double>();
        public List<int> BadLines { get; set; } = new List<int>();

        Dictionary<int, double> processedText = new Dictionary<int, double>();


        public void ProcessFile(List<string> textObject)
        {   
            for (int i = 1; i < textObject.Count; i++)
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
                        badLineBuffer = i + 1;
                    }
                }


                BadLines.Add(badLineBuffer);
                processedText.Add(i, LineList.Sum());
                LineList.Clear();

            }

            MaxLineSum = processedText.Values.Max();
            MaxSumLine = processedText.FirstOrDefault(x => x.Value == MaxLineSum).Key + 1;

        }
    }
}
