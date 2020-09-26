using System.Collections.Generic;

namespace MaxSumFinder.Interfaces
{
    public interface IFileProcessor
    {
        public int MaxSumLine { get; set; }
        public double MaxLineSum { get; set; }
        public List<double> LineList { get; set; }
        public List<int> BadLines { get; set; }

        public void ProcessFile(List<string> textObject)
        { 
        
        }
    }
}
