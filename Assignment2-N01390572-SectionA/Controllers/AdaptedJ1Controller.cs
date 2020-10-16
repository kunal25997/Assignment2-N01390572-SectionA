using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web.Http;

namespace Assignment2_N01390572_SectionA.Controllers
{
    /// <summary>
    /// <param name = "burger"></param>
    /// <param name = "drink"></param>
    /// <param name = "sidemenu"></param>
    /// <param name = "dessert"></param>
    /// </summary>
    
    
   
    public class AdaptedJ1Controller : ApiController
    {
        [Route("api/AdaptedJ1/GetMenu/{burger}/{drink}/{sidemenu}/{dessert}")]
        [HttpGet]
        public IEnumerable<string> GetMenu(int burger, int drink, int sidemenu, int dessert)
        {
            //Burger Menu 
            int cheeseburger = 461;
            int fishburger = 431;
            int veggieburger = 420;
            int noburger = 0;
            int[] burgermenu = { 0, cheeseburger, fishburger, veggieburger, noburger };


            //Drink Menu
            int softdrink = 130;
            int orangejuice = 160;
            int milk = 118;
            int nodrink = 0;
            int[] drinkmenu = { 0, softdrink, orangejuice, milk, nodrink };

            //Side Order 
            int fries = 100;
            int bakedpotato = 57;
            int chefsalad = 70;
            int nosidemenu = 0;
            int[] sidesmenu = { 0, fries, bakedpotato, chefsalad, nosidemenu };

            //Dessert Menu
            int applepie = 167;
            int sundae = 266;
            int fruitchip = 75;
            int nodessert = 0;
            int[] dessertmenu = { 0, applepie, sundae, fruitchip, nodessert };

            //Getting the total calorie count
            int totalcalorie = burgermenu[burger] + drinkmenu[drink] + sidesmenu[sidemenu] + dessertmenu[dessert];

            //End result of the calorie count
            return new string[] { "Your total calorie count is" + " " + totalcalorie };
        }
    }
}
