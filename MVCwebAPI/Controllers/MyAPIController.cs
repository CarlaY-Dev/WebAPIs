using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCwebAPI.Controllers
{
    public class MyAPIController : ApiController
    {
        // GET: api/MyAPI
        public string Get()
        {
            System.Threading.Thread.Sleep(3000);
            return DateTime.Now.ToString();
        }

        // GET: api/MyAPI/5
        public string Get(string name)
        {
            return "hi" + name;
        }

        // POST: api/MyAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MyAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MyAPI/5
        public void Delete(int id)
        {
        }
    }
}
