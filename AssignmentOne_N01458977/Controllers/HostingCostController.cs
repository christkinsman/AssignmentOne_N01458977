using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Razor.Tokenizer.Symbols;

namespace AssignmentOne_N01458977.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/HostingCost/5
        public IEnumerable<string> Get(float id)
        {
            float fortnights = (float)Math.Floor( id / 14 );
            //The idea to add one to fornights in the subtotal "(fortnights + 1) * (float)5.50",
            //was discussed in class on 19/16/2020.
            float subTotal = (fortnights + 1) * (float)5.50;
            float HST = (subTotal * (float)1.13) - subTotal;
            float total = subTotal + HST;

            //I use ".ToString("c2")" which I found here - https://stackoverflow.com/a/6356381
            return new string[] { 
                                  fortnights + " fortnights at $5.50/FN = " + subTotal.ToString("c2") + " CAD",
                                  "HST 13% = " + HST.ToString("c2") + " CAD",
                                  "Total = " + total.ToString("c2") + " CAD" 
                                };
        }
    }
}
