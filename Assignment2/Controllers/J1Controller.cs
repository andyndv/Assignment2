using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public int Menu(int burger,int drink, int side, int dessert) 
        {

            int burgerCal;
            int drinkCal;
            int sideCal;
            int dessertCal;

            string invalidMessage = "Invalid input";

            if (burger == 1)
            {
                burgerCal = 461;

            }
            else if (burger == 2)
            {

                burgerCal = 431;

            }
            else if (burger == 3)
            {

                burgerCal = 420;

            }
            else if (burger == 4)
            {

                burgerCal = 0;
            }
            else {

                return invalidMessage;
            }


            if (drink == 1)
            {
                drinkCal = 130;

            }
            else if (drink == 2)
            {

                drinkCal = 160;

            }
            else if (drink == 3)
            {

                drinkCal = 118;

            }
            else if (drink == 4)
            {

                drinkCal = 0;
            }
            else
            {

                return invalidMessage;
            }


            if (side == 1)
            {
                sideCal = 100;

            }
            else if (side == 2)
            {

                sideCal = 57;

            }
            else if (side == 3)
            {

                sideCal = 70;

            }
            else if (side == 4)
            {

                sideCal = 0;
            }
            else
            {

                return invalidMessage;
            }


            if (dessert == 1)
            {
                dessertCal = 167;

            }
            else if (dessert == 2)
            {

                dessertCal = 266;

            }
            else if (dessert == 3)
            {

                dessertCal = 75;

            }
            else if (dessert == 4)
            {

                dessertCal = 0;
            }
            else
            {

                return invalidMessage;
            }
            int totalCal = burgerCal + drinkCal + sideCal + dessertCal;

            string message = "Your total calorie count is " + totalCal;

            return message;
        }
    }
}
