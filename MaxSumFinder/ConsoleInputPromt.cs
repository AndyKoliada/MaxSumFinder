using MaxSumFinder.Interfaces;
using System;

namespace MaxSumFinder
{
    public class ConsoleInputPromt : IInputPromt
    {
        public string FilePath { get; set; } = "C:\\Users\Andy\1.txt";

        public string InputPromt()
        {
            Console.WriteLine(new string('#', 50));
            Console.WriteLine("     This programm can output the number of\n     line in which the sum of elements is max");
            Console.WriteLine(new string('#', 50));
            Console.WriteLine();
            Console.WriteLine("     Please, input path to your text file: ");
            FilePath = Console.ReadLine();
            return FilePath;
        }
    }
}
