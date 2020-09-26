using System.Collections.Generic;

namespace MaxSumFinder.Interfaces
{
    public interface IPrinter
    {
        public void Print(int maxSumLineNum);

        public void Print(List<int> BadLines);
    }
}
