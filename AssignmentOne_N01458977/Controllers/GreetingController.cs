using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentOne_N01458977.Controllers
{
    public class GreetingController : ApiController
    {
        // POST api/Greeting
        public string POST()
        {
            return "Hello World!";
        }

        // GET api/Greeting/5
        public string GET(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
