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
            System.Console.Write("Lines with not numerical chars: ");

            if (BadLines.Count == 0)
            {
                System.Console.Write("none");
            }

            else
            {
                for (int i = 0; i < BadLines.Count; i++)
                {

                    if (BadLines[i] != 0)
                    {
                        System.Console.Write(BadLines[i]);
                        if (i < BadLines.Count - 2)
                        {
                            System.Console.Write(", ");
                        }
                    }
                }

                System.Console.WriteLine();
            }
        }

    }
}
