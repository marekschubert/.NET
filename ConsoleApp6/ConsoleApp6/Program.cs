using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ConsoleApp6
{
    public class Program
    {
        public ILogger GetLogger()
        {
            return new ConsoleLogger();
        }

        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();


            serviceCollection.AddTransient<ILogger, FileLogger>();


            var configurationBuilder = new ConfigurationBuilder();

            configurationBuilder.AddJsonFile("appsettings.json", true);
            
            var configuration = configurationBuilder.Build();

            serviceCollection.AddSingleton<IConfiguration>(configuration);


            // to musi być na końcu, dopóki się nie zbuduje całego serviceProvider, to można budować różne rzeczy,
            // jak np. configuration czy serviceCollection
            // jak już się zbuduje tego providera, to już koniec
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var logger = serviceProvider.GetService<ILogger>();










        }



    }


    public interface ILogger
    {

        void foo();

    }

    public class FileLogger : ILogger
    {
        public void foo()
        {
            throw new NotImplementedException();
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void foo()
        {
            throw new NotImplementedException();
        }
    }


}



