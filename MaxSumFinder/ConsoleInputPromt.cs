using MaxSumFinder.Interfaces;
using System;

namespace MaxSumFinder
{
    public class ConsoleInputPromt : IInputPromt
    {
        string filePath;
        public string FilePath { get; set; }

        public ConsoleInputPromt(string filePath)
        {
            InputPromt();
            this.FilePath = filePath;
        }


        public void InputPromt()
        {
            Console.WriteLine(new string('#', 50));
            Console.WriteLine("     This programm can output the number of\n     line in which the sum of elements is max");
            Console.WriteLine(new string('#', 50));
            Console.WriteLine();
            Console.WriteLine("     Please, input path to your text file: ");
            filePath = Console.ReadLine();
        }
    }
}
