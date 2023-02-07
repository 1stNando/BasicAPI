using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    //the controller in bracket bellow is equal to the name of our controller class. Here its HelloWorldController. 
    //ControllerBase is a specialization of a controller base. Able to deserialize/serialize.
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        //The name of the method is simply a variable name..
        //VERB specific what do want to do. We name it for the sake of programmers to understand easily.
        //The last thing we need is to add this VERB as a [GET] request type. 
        [HttpGet]
        public string SayHello()
        {
            return $"Hello, World. {DateTime.Now}";
        }
    }
}
