using MaxSumFinder.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MaxSumFinder
{
    class Program
    {



        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IInputPromt, ConsoleInputPromt>()
                .AddSingleton<IFileReader, FileReader>()
                .AddSingleton<IFileProcessor, FileProcessor>()
                .BuildServiceProvider();

            var inputPromt = serviceProvider.GetService<IInputPromt>();
            var fileProcessor = serviceProvider.GetService<IFileProcessor>();
            var fileReader = serviceProvider.GetService<IFileReader>();


            if (args[0] is string)
            {
                fileReader.ReadFile(args[0]);
            }
            else
            {
                fileReader.ReadFile();
            }

            Console.ReadLine();
        }
    }
}

//TODO Предоставляется файл (путь к файлу необходимо или запросить у пользователя при старте программы,
//или взять из параметров командной строки, если они указаны).

//В каждой строке набор чисел (через запятую, дробный разделитель точка). 

//Вывести номер строки с максимальной суммой элементов. 

//Номера строк, в которых встречаются не числовые элементы ("бракованные строки") вывести отдельным списком.