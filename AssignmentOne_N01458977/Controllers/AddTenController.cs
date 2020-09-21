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
        // GET api/AddTen/5
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
