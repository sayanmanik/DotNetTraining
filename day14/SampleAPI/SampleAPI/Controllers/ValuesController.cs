using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values

        static List<string> cities = new List<string>(){"Pune","Mumbai","Chennai" };
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            return cities;
        }

        // GET api/values/5
        public string Get(int id)
        {
            //return "value";
            return cities[id];
        }

        // POST api/values
        public void Post(string value)
        {
            cities.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, string value)
        {
            cities[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            cities.RemoveAt(id);
        }
    }
}
