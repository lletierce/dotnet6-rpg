using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    // Ceci est un test
    public interface ICharacterService
    {
        // Task<List<Character>> GetAllCharacters(); => Avant l'ajout du ServiceResponse
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);


    }
}