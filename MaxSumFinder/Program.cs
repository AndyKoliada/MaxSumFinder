using MaxSumFinder.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MaxSumFinder
{
    class Program
    {
        static void Main(string[] args)
        {   
            using (var serviceProvider = SetupDI())
            {
                serviceProvider.GetService<App>().Run(args);
            }
        }

        private static ServiceProvider SetupDI()
        {
            var services = new ServiceCollection();

            services.AddTransient<IFileReader, FileReader>();
            services.AddTransient<IInputPromt, ConsoleInputPromt>();
            services.AddTransient<IFileProcessor, FileProcessor>();
            services.AddTransient<IPrinter, ConsoleOutput>();

            services.AddTransient<App>();

            return services.BuildServiceProvider();
        }
    }
}

//Предоставляется файл (путь к файлу необходимо или запросить у пользователя при старте программы,
//или взять из параметров командной строки, если они указаны).

//В каждой строке набор чисел (через запятую, дробный разделитель точка). 

//Вывести номер строки с максимальной суммой элементов. 

//Номера строк, в которых встречаются не числовые элементы ("бракованные строки") вывести отдельным списком.