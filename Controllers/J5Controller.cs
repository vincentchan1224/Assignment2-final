using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_final.Controllers
{/// <summary>
/// CCC 2016 J5:Tandem Bicycle!
/// There are N citizens from Dmojistan and Pegland. They must be assigned to pairs so each pair contains one person form
/// Dmojistan and one person from Pegland. If a pair jave speeds a and b, the bike speed of the pair is max(a,b),
/// the total speed is the sum of the N individule bike speeds.
/// Question1 for minimum total speed and Question2 for the maximum total speed
/// For the question one, the minimun total speed should be a total of N combination of Close Number.
/// Therefore, we need to sort the speed of these two citizens of group. Then We need to assgin two close number 
/// together. If the index i is index of speed in the two lists of different city. The speed of a group
/// should be euqal to Max(d[i],p[i])
/// Vice Versa, the maximum total speed should be a total of N combination with the greatest difference number.
///  If the index i is index of speed in the two lists of different city. The speed of a group
/// should be euqal to Max(d[i],p[line-i-1])
/// </summary>
/// <param name="question">1 for minimum total speed and 2 for the maximum total speed</param>
/// <param name="line">The total lines contans N(1<=N<=100)</param>
/// <param name="d">d is a string contain N space-separated integers: the speeds of the citizens of Dmojistan d</param>
/// <param name="p">p is a string contain N space-separated integers: the speeds of the citizens of Pegland p</param>
/// <returns>The maximum or minimum total speed that answers the {question} asked</returns>
/// <example>
/// Get api/J5/distance/1/3/5 1 4/6 2 4
/// "12"
/// </example>
/// <example>
/// Get api/J5/distance/2/3/5 1 4/6 2 4
/// "15
/// </example>
/// <example>
/// Get api/J5/distance/2/5/202 177 189 589 102/17 78 1 496 540
/// "2016"
/// </example>
    public class J5Controller : ApiController
    {
        [HttpGet]
        [Route("api/J5/distance/{question}/{line}/{d}/{p}")]
        public int distance(int question, int line, string d, string p)
        {
            ///Use the List to store the input value of citizens' speed, then sort by sort()
            ///the first element is the minimun value among that list, vice versa
            string[] dInput = d.Split(' ');
            List<int> dLine = new List<int>();
            for (int i = 0; i < dInput.Length; i++) { dLine.Add(int.Parse(dInput[i])); }
            dLine.Sort();
            string[] pInput = p.Split(' ');
            List<int> pLine = new List<int>();
            for (int i = 0; i < pInput.Length; i++) { pLine.Add(int.Parse(pInput[i])); }
            pLine.Sort();
            int result = 0;
            if (question == 1)
            {

                for (int i = 0; i < line; i++)
                {
                    result += Math.Max(dLine[i], pLine[i]);
                }
            }

            if (question == 2)
            {

                for (int i = 0; i < line; i++)
                {
                    result += Math.Max(dLine[i], pLine[line - i - 1]);
                }
            }

            return result;
        }
    }
}
