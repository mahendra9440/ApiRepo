using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiProject.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> names = new List<string>() { "Mahendra", "Chinmayi", "Lohith" };

        public IEnumerable<string> GetName()
        {
            return names;
        }

        public string GetNameById(int id)
        {
            return names[id];
        }

        public void PostAddName([FromBody]string value)
        {
            names.Add(value);
        }

        public void putUpdatName(int id, [FromBody]string value)
        {
            names[id] = value;
        }

        public void DelteNameById(int id)
        {
            names.RemoveAt(id);
        }
    }
}
