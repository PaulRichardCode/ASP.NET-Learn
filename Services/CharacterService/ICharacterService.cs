using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Learn.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetCharacters();

        Character GetCharacterById(int Id);

    }
}