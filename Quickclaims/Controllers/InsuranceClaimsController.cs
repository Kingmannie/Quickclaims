using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Quickclaims.Controllers
{
    public class InsuranceClaimsController : ApiController
    {
        // GET: api/InsuranceClaims
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/InsuranceClaims/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/InsuranceClaims
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/InsuranceClaims/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/InsuranceClaims/5
        public void Delete(int id)
        {
        }
    }
}
