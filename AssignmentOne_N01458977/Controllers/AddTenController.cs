using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentOne_N01458977.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method returns an int when receiving a get request
        /// <example> GET api/addten/5 </example>
        /// </summary>
        /// <returns>15</returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
