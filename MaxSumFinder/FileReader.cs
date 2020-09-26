using MaxSumFinder.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace MaxSumFinder
{
    public class FileReader : IFileReader
    {
        public List<string> TextObject { get; set; } = new List<string>();

        public void ReadFile(string filePath)
        {
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(filePath);
                //Read the first line of text
                var line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    TextObject.Add(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
        
    }
}
