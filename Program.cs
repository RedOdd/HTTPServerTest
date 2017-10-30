using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;

namespace HTTPServer
{
    public class Program
    {
        public static string citizensText;
        public static string citizensJSON;
        public static IList<Citizen> citizens;
        public static IList<Citizen> citizenToView = new List<Citizen>();

        public static void Main(string[] args)
        {
            Load();
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();

        public static void Load()
        {
            FileStream file = new FileStream("BaseOfCitizens.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader streamReader = new StreamReader(file);
            citizensText = streamReader.ReadToEnd();
            streamReader.Close();
            citizens = JsonConvert.DeserializeObject<Citizen[]>(citizensText);
            for (int count = 0; count < 5; count++)
            {
                citizenToView.Add(new Citizen(citizens[count].ID, citizens[count].Name, citizens[count].Sex));
            }
        }
    }
}
