using MaxSumFinder.Interfaces;
using System.Collections.Generic;

namespace MaxSumFinder
{
    public class ConsoleOutput : IPrinter
    {
        public void Print(int maxSumLineNum)
        {   
            System.Console.Write("Line with the max sum: ");
            System.Console.WriteLine(maxSumLineNum);
        }

        public void Print(List<int> BadLines)
        {
            System.Console.WriteLine("Lines with not numerical chars: ");
            for (int i = 0; i < BadLines.Count; i++)
            {
                System.Console.Write(BadLines[i]);
                if (i != BadLines.Count) System.Console.Write(", ");
                System.Console.WriteLine();
            }

        }

    }
}
