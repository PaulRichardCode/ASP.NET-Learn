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
        //private static Character knight = new Character();

        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { Name = "Paul"}
            };
        //recieve our game character    
        [HttpGet("GetAll")]
        public ActionResult<Character> Get() {
            return Ok(characters);
            //currently everything looks confusing lol
        }

        [HttpGet]
        public ActionResult<Character> GetSingle() {
            return Ok(characters[0]);
        }
    }
}