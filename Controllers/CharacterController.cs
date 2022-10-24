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
        public ActionResult<List<Character>> Get()
        {
            // return Ok(knight);
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            // return Ok(knight);
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            return Ok(_characterService.AddCharacter(newCharacter));
        }


    }
}