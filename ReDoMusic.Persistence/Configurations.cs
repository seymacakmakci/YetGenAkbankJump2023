﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoMusic.Persistence
{
    public static class Configurations
    {
        public static string GetString(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\ReDoMusic\\Infrastructure\\ReDoMusic.Persistence";

            configurationManager.SetBasePath(path);
            configurationManager.AddJsonFile("Private_Informations.json");
            return configurationManager.GetSection("ConnectionStrings: PostgreSQL").Value;
        }
    }
}
