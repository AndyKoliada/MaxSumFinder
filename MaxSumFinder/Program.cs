using MaxSumFinder.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace MaxSumFinder
{
    class Program
    {
        static void Main(string[] args)
        {   
            //setting up DI (registering services)
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IInputPromt, ConsoleInputPromt>()
                .AddSingleton<IFileReader, FileReader>()
                .AddSingleton<IFileProcessor, FileProcessor>()
                .AddSingleton<IPrinter, ConsoleOutput>()
                .BuildServiceProvider();
            
            //calling registered services from serviceProvider
            var inputPromt = serviceProvider.GetService<IInputPromt>();
            var fileReader = serviceProvider.GetService<IFileReader>();
            var fileProcessor = serviceProvider.GetService<IFileProcessor>();
            var consoleOutput = serviceProvider.GetService<IPrinter>();



            //fileReader.ReadFile("C:\\Users\Andy\1.txt");
            if (args.Length != 0)
            {
                fileReader.ReadFile(args[0]);
            }
            else
            {
                inputPromt.InputPromt();
                fileReader.ReadFile(inputPromt.FilePath);
            }
            //Console.WriteLine("File reading OK");
            fileProcessor.ProcessFile(fileReader.TextObject);
            consoleOutput.Print(fileProcessor.MaxSumLine);
            consoleOutput.Print(fileProcessor.BadLines);
            Console.ReadLine();
        }
    }
}

//TODO Предоставляется файл (путь к файлу необходимо или запросить у пользователя при старте программы,
//или взять из параметров командной строки, если они указаны).

//В каждой строке набор чисел (через запятую, дробный разделитель точка). 

//Вывести номер строки с максимальной суммой элементов. 

//Номера строк, в которых встречаются не числовые элементы ("бракованные строки") вывести отдельным списком.