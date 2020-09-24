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
        /// <summary>
        /// This methoid returns a string when receiving a post method
        /// <example> POST api/greeting </example>
        /// </summary>
        /// <returns>"Hello World!"</returns>
        public string POST()
        {
            return "Hello World!";
        }

        /// <summary>
        /// This methid returns a string when receiving a get method
        /// <example> GET api/greeting/5 </example>
        /// </summary>
        /// <returns>"Greetings to 5 people!"</returns>
        public string GET(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
