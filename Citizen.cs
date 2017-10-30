using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HTTPServer
{
    public class Citizen
    {
        public string ID;
        public string Name;
        public string Sex;
        [DefaultValue(0)]
        public int Age;
        [JsonConstructor]
        public Citizen(string id, string name,string sex, int age)
        {
            ID = id;
            Name = name;
            Sex = sex;
            Age = age;
        }
        public Citizen(string id, string name, string sex)
        {
            ID = id;
            Name = name;
            Sex = sex;
        }
    }
}
