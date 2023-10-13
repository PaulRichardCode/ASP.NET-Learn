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

        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
        //recieve our game character    
        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get() {
            return Ok(_characterService.GetAllCharacters());
            //currently everything looks confusing lol
        }

        [HttpGet("{id}")]
        
        public ActionResult<Character> GetSingle(int id) {
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter) {
            return Ok(_characterService.AddCharacters(newCharacter));
        }
      
 
    }
}