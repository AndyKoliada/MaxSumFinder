using MaxSumFinder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSumFinder
{
    public class FileProcessor : IFileProcessor
    {
        public double MaxSumLineCount { get; set; }
        public List<double> LineList { get; set; }
        public List<int> BadLines { get; set; }
        string[] tryLine;
        bool lineIsValid = true;
        int maxSumLine;

        public void ProcessFile(List<string> textObject)
        {
            for(int i = 0; i < textObject.Count; i++)
            {
                lineIsValid = true;
                double validNumber;
                tryLine = textObject[i].Split(',');
                
                while (lineIsValid)
                {
                    foreach (string num in tryLine)
                    {
                        if (Double.TryParse(num, out validNumber))
                        {
                            LineList.Add(validNumber);
                        }
                        else
                        {
                            BadLines.Add(i);
                            lineIsValid = false;
                        }
                    }
                }

                MaxSumLineCount += LineList.Sum();


                
            }
        }
    }
}
