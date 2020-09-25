using MaxSumFinder.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace MaxSumFinder
{
    class FileReader : IFileReader
    {
        public List<string> TextObject { get; set; }

        void ReadFile(string filePath)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        TextObject.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        
    }
}
