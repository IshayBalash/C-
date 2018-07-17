using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication4.Models;
using System.Net.Http.Formatting;

namespace WebApplication4.Controllers
{
    public class PersonController : ApiController
    {
        // GET: api/Person
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Person/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Person
        public HttpResponseMessage Post([FromBody] Person personparam)
        {
            int NumOfDigits = personparam.Id.Length;
            for (int i = NumOfDigits; i < 9; i++)
            {
                personparam.Id= 0 + personparam.Id;
            }
            if (ModelState.IsValid)
            {
                Person returnValue=new Person();
                returnValue.Id = personparam.Id;
                returnValue.PersonName = personparam.PersonName;

                return new HttpResponseMessage(HttpStatusCode.Created) { Content=new ObjectContent<Person>(returnValue,new JsonMediaTypeFormatter()) };
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
