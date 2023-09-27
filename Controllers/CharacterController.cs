
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Learn.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        //mock character that can return to the client
        private static Character knight = new Character();

        //recieve our game character
        public IActionResult Get() {
            return Ok(knight);
            //currently everythig looks confusing lol            
        }

    }
}