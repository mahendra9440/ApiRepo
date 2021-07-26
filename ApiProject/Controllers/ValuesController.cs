using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiProject.Controllers
{
    /// <summary>
    /// Values Controller
    /// </summary>
    public class ValuesController : ApiController
    {
        static List<string> names = new List<string>() { "Mahendra", "Chinmayi", "Lohith" };

        /// <summary>
        /// Get All Names
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetName()
        {
            return names;
        }

        /// <summary>
        /// Get Name By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetNameById(int id)
        {
            return names[id];
        }

        /// <summary>
        /// Insert Name
        /// </summary>
        /// <param name="value"></param>
        public void PostAddName([FromBody]string value)
        {
            names.Add(value);
        }

        /// <summary>
        /// Update Name
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void putUpdatName(int id, [FromBody]string value)
        {
            names[id] = value;
        }

        /// <summary>
        /// Delete Name
        /// </summary>
        /// <param name="id"></param>
        public void DelteNameById(int id)
        {
            names.RemoveAt(id);
        }
    }
}
