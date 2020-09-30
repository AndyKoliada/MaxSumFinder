using MaxSumFinder.Interfaces;

namespace MaxSumFinder
{
    class App
    {
        private readonly IInputPromt inputPromt;
        private readonly IFileReader fileReader;
        private readonly IFileProcessor fileProcessor;
        private readonly IPrinter printer;

        public App(IInputPromt inputPromt, IFileReader fileReader, IFileProcessor fileProcessor, IPrinter printer)
        {
            this.inputPromt = inputPromt;
            this.fileReader = fileReader;
            this.fileProcessor = fileProcessor;
            this.printer = printer;
        }

        public void Run(string[] args)
        {
            if (args.Length == 0)
            {
                inputPromt.InputPromt();
                fileReader.ReadFile(inputPromt.FilePath);
                fileProcessor.ProcessFile(fileReader.TextObject);
                printer.Print(fileProcessor.MaxSumLine);
                printer.Print(fileProcessor.BadLines);
            }
            else
            {
                fileReader.ReadFile(args[0]);
                fileProcessor.ProcessFile(fileReader.TextObject);
                printer.Print(fileProcessor.MaxSumLine);
                printer.Print(fileProcessor.BadLines);
            }
        }
    }
}
