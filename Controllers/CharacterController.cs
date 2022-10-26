using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CharacterController : ControllerBase
    {
        // private static Character knight = new Character();
        // private static List<Character> characters = new List<Character>{
        //     new Character(),
        //     new Character { Id = 1, Name = "Sam" }
        // };
        

        //public ICharacterService CharacterService { get; }
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
            
        }

        [HttpGet("GetAll")]
        // [Route("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
        {
            // return Ok(knight);
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(int id)
        {
            // return Ok(knight);
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }


    }
}