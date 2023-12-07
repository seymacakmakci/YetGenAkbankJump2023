using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace SingletonExample
{
    public class Configuration
    {
        private static Configuration instance;

        public static Configuration GetInstance()
        {
            if (instance is null)
                instance = new Configuration();

            return instance;
        }

        public string GetValue(string key)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            configurationBuilder.SetBasePath(path);
            configurationBuilder.AddJsonFile("Configuration.json");

            IConfiguration configuration = configurationBuilder.Build();

            return configuration.GetSection(key).Value;
        }

        private Configuration()
        {
            Console.WriteLine("Instance Created!");
        }
    }
}

