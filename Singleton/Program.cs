using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Configuration configurationService = Configuration.GetInstance();
            Configuration.GetInstance();
            Configuration.GetInstance();
            Configuration.GetInstance();
            Configuration.GetInstance();

            var postgresConnectionString = configurationService.GetValue("ConnectionStrings:PostgreSQL");
            Console.WriteLine($"PostgreSQL Connection String: {postgresConnectionString}");
        }
    }
}
