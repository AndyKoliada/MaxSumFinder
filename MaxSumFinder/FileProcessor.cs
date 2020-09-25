using MaxSumFinder.Interfaces;
using System;
using System.Collections.Generic;

namespace MaxSumFinder
{
    class FileProcessor : IFileProcessor
    {   
        public int MaxSumLineCount { get; set; }
        public List<double> LineList { get; set; }

        void ProcessFile(List<string> textObject)
        {
            foreach (string line in textObject)
            {
                var validNum = line.Split(',');
                if (Double.TryParse(validNum, out number))
            }
        }
    }
}
