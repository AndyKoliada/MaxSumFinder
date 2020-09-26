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
        public List<double> LineList { get; set; }
        public List<int> BadLines { get; set; }

        double currentSumLine;
        string[] tryLine;
        bool lineIsValid = true;

        public void ProcessFile(List<string> textObject)
        {
            LineList = new List<double>();
            BadLines = new List<int>();

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
                            Console.WriteLine(validNumber);
                            if (currentSumLine < LineList.Sum())
                            {
                                currentSumLine += LineList.Sum();
                            }
                        }
                        else
                        {
                            BadLines.Add(i+1);
                            lineIsValid = false;
                        }
                        
                        lineIsValid = false;
                    }
                }

                MaxLineSum += LineList.Sum();

            }
        }
    }
}
