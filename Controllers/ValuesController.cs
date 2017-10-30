using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HTTPServer.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            var seriazableSettings = new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore };
            return JsonConvert.SerializeObject(Program.citizenToView,Formatting.Indented,seriazableSettings);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            IList<Citizen> cit = Program.citizens.Where(i => i.ID == id).ToList();
            if (!(cit.Count == 0))
            {
                return JsonConvert.SerializeObject(cit[0]);
            }
            else
            {
                return "Person with this id not found";
            }
        }

        // POST api/values
        [HttpPost]
        public void Post(string id, string name, string sex, int age)
        {
            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(string id, string name, string sex, int age)
        {
            
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
