using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_final.Controllers

{/// <summary>
/// There are two diec with m sides (1,2,3,...,m) and n sides (1,2,3,...,n)
/// This function is to determines how many ways she can roll the value of 10.
/// </summary>
/// <param name="m">the number of sides of the first dice</param>
/// <param name="n">the number of sides of the second dice</param>
/// <returns>the number of ways she can roll the value of 10</returns>
/// <example>
/// Get api/J2/DiceGame/6/8
/// "There are 5 total ways to get the sum 10."
/// </example>
/// <example>
/// Get api/J2/DiceGame/12/4
/// "There are 4 total ways to get the sum 10."
/// </example>
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DIceGame(int m, int n)
        {
            int count = 0;
            for (int i = m; i > 0; i--)
            {

                for (int j = n; j > 0; j--)
                {
                    if (i + j == 10)
                    {
                        count++;
                        break;
                    }
                }
            }

            return $"There are {count} total ways to get the sum 10";
        }
    }
}
