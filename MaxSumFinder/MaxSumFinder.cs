using MaxSumFinder.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MaxSumFinder
{
    public class MaxSumFinder
    {
        IInputPromt inputPromt;
        IFileReader fileReader;
        IFileProcessor fileProcessor;
        IPrinter printer;


        public MaxSumFinder(IServiceProvider serviceProvider)
        {
            inputPromt = serviceProvider.GetService<IInputPromt>();
            fileReader = serviceProvider.GetService<IFileReader>();
            fileProcessor = serviceProvider.GetService<IFileProcessor>();
            printer = serviceProvider.GetService<IPrinter>();
        }


        public void Run()
        {
            inputPromt.InputPromt();
            fileReader.ReadFile(inputPromt.FilePath);
            fileProcessor.ProcessFile(fileReader.TextObject);
            printer.Print(fileProcessor.MaxSumLine);
            printer.Print(fileProcessor.BadLines);
        }

        public void Run(string[] args)
        {
            fileReader.ReadFile(args[0]);
            fileProcessor.ProcessFile(fileReader.TextObject);
            printer.Print(fileProcessor.MaxSumLine);
            printer.Print(fileProcessor.BadLines);
        }
    }
}
