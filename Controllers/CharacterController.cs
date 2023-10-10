using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Learn.Controllers
{
    // [ApiController]
    // [Route("api/[controller]")]
    // public class CharacterController : ControllerBase
    // {
    //     //mock character that can return to the client
    //     //private static Character knight = new Character();

    //     private static List<Character> characters = new List<Character>{
    //         new Character(),
    //         new Character { Id = 1, Name = "Paul"}
    //         };
    //     //recieve our game character    
    //     [HttpGet("GetAll")]
    //     public ActionResult<List<Character>> Get() {
    //         return Ok(characters);
    //         //currently everything looks confusing lol
    //     }

    //     [HttpGet("{id}")]
        
    //     public ActionResult<Character> GetSingle(int id) {
    //         return Ok(characters.FirstOrDefault(c => c.Id == id));
    //     }

    //     [HttpPost]
    //     public ActionResult<List<Character>> AddCharacter(Character newCharacter) {
    //         characters.Add(newCharacter);
    //         return Ok(characters);
    //     }
    // }

    //Step 1 mark the controller class

    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> Characters = new List<Character>{
            new Character(),
            new Character {Id = 1 ,Name = "Paul"}
        };

        [HttpGet("GetAll")]
        //specify the type of data returning
        public ActionResult<List<Character>> Get() {
            return Ok(Characters);
        }
        
        [HttpGet("{id}")]
        //specify the type of data returning
        public ActionResult<Character> GetSingle(int id) {
            return Ok(Characters.FirstOrDefault(c => c.Id == id));
        }
    }
}