using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Learn.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {

          private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { Id = 1, Name = "Paul"}
            };
        public List<Character> AddCharacters(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
             return characters;
        }

        public Character GetCharacterById(int id)
        {
             return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}