namespace MaxSumFinder.Interfaces
{
    public interface IInputPromt
    {

        public string FilePath { get; set; }

        public string InputPromt()
        {
            return FilePath;
        }

    }
}
