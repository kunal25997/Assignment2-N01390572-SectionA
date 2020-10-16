using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace Assignment2_N01390572_SectionA.Controllers
{
    public class AdaptedJ2Controller : ApiController
    {
        [Route("api/AdaptedJ2/DiceGame/{m}/{n}")]
        [HttpGet]

        public string DiceGame(int m, int n)
        {
            int count = 0;
            string message = "";
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if ((i+j) == 10)
                    {
                        count++;
                    }
                }
            }
                
            message = "There are " + " " + count.ToString() + " " + "ways to get the sum 10";
            return message;
        }
    }
}
