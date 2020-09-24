using MaxSumFinder.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace MaxSumFinder
{
    class Program
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.Add(new ServiceDescriptor(typeof(IInputPromt), new ConsoleInputPromt()));
            services.Add(new ServiceDescriptor(typeof(IFileReader), new FileReader()));
            services.Add(new ServiceDescriptor(typeof(IFileProcessor), new FileProcessor()));
            services.Add(new ServiceDescriptor(typeof(IPrinter), new ConsoleOutput()));
        }


        static void Main(string[] args)
        {
            var processor = new FileProcessor();
            
            if (args[0] is string)
            {
                var filepath = new Path();
            }
            else
            { 
            
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