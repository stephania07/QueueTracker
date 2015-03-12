using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QueueTracker.Controllers
{
    public class QueueController : ApiController
    {
        // GET: api/Queue
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Queue/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Queue
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Queue/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Queue/5
        public void Delete(int id)
        {
        }
    }
}
