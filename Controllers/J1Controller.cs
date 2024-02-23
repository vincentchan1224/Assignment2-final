using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_final.Controllers
{ 
/// <param name="burger">integer representing the index burger choice</param>
/// <param name="drink">integer representing the index burger choice</param>
/// <param name="side">integer representing the index burger choice</param>
/// <param name="dessert">integer representing the index burger choice</param>
/// <returns>A string: Your total calorie count is {value}</returns>
/// <example>
/// Get api/J1/Menu/4/4/4/4
/// Your total calorie count is 0
/// </example>
/// <example>
/// // Get api/J1/Menu/1/2/3/4
/// Your total calorie count is 691
/// </example>

    public class J1Controller : ApiController
{
    [HttpGet]
    [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
    public string Menu(int burger, int drink, int side, int dessert)
    {

        int[] burgerC = { 461, 431, 420, 0 };
        int[] drinkC = { 130, 160, 118, 0 };
        int[] sideC = { 100, 57, 70, 0 };
        int[] dessertC = { 167, 266, 75, 0 };

        int totalCalories = burgerC[burger - 1] + drinkC[drink - 1] + sideC[side - 1] + dessertC[dessert - 1];

        return $"Your total calorie count is {totalCalories}";
    }

}
}