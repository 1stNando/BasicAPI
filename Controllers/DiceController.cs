using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiceController : ControllerBase
    {
        [HttpGet("{sides}")]
        //count comes from the query parameter, sides comes from the GET request URL
        //We also need to change the int data type associated with Roll() because it will 
        //no longer return a simple "int" digit. Instead it will now implement the use of a List<> to show multiple dice simultaneously rolled. 
        public int Roll(int sides, int count)
        {
            //We added int count to the parameter so we can have MANY die at the same time.
            //Make a space where the multiple "die" rolls can exist. 
            var rolls = new List<int>();

            //Make a random number generator
            var randomNumberGenerator = new Random();

            for (var rollNumber = 0; rollNumber < count; rollNumber++)
            {
                //Next(sides) would make a number between 0 and just less than sides
                //so return that number + 1. Making the range from 1 to a number
                //INCLUDING the value of sides.
                var roll = randomNumberGenerator.Next(sides) + 1;

                rolls.Add(roll);
            }

            return rolls;
        }
    }
}
