using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    namespace ASP.NET_Learn.Services.CharacterService
    {
        public interface ICharacterService
        {
            List<Character> GetAllCharacters();

            Character GetCharacterById(int Id);

            List<Character> AddCharacters(Character newCharacter);
            //www
        }
    }