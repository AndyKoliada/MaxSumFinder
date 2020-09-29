using MaxSumFinder.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MaxSumFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = ConfigureServices();

            var serviceProvider = services.BuildServiceProvider();

            // calls the Run method in App, which is replacing Main
            serviceProvider.GetService<App>().Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            var config = LoadConfiguration();
            services.AddSingleton(config);

            // required to run the application
            services.AddTransient<App>();

            return services;
        }

        public static IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    //    private static IServiceProvider serviceProvider;

    //    static void Main(string[] args)
    //    {
    //        RegisterServices();
    //        var finder = new MaxSumFinder(serviceProvider);
    //        if (args.Length != 0)
    //        {

    //            finder.Run(args);
    //        }
    //        else
    //        {
    //            finder.Run();
    //        }


    //    }

    //    private static void RegisterServices()
    //    {
    //        //setting up DI (registering services)
    //        var collection = new ServiceCollection()
    //            .AddSingleton<IInputPromt, ConsoleInputPromt>()
    //            .AddSingleton<IFileReader, FileReader>()
    //            .AddSingleton<IFileProcessor, FileProcessor>()
    //            .AddSingleton<IPrinter, ConsoleOutput>();
    //        serviceProvider = collection.BuildServiceProvider();
    //    }
    //}
}

//Предоставляется файл (путь к файлу необходимо или запросить у пользователя при старте программы,
//или взять из параметров командной строки, если они указаны).

//В каждой строке набор чисел (через запятую, дробный разделитель точка). 

//Вывести номер строки с максимальной суммой элементов. 

//Номера строк, в которых встречаются не числовые элементы ("бракованные строки") вывести отдельным списком.