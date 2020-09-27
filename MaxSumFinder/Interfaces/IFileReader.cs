using System.Collections.Generic;

namespace MaxSumFinder.Interfaces
{
    public interface IFileReader
    {
        public List<string> TextObject { get; set; }

        public void ReadFile(string filePath)
        {

        }
    }
}
