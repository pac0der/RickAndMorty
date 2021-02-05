using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RickAndMorty.Characters.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickAndMorty.Character.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService ?? throw new ArgumentNullException(nameof(characterService));
        }

        [HttpGet("GetByPage/{page}")]
        public async Task<ActionResult> GetByPageAsync(int page)
        {
            var result = await _characterService.GetByPageAsync(page);
            return Ok(result);
        }

        [HttpGet("GetById/{Id}")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var result = await _characterService.GetByIdAsync(id);
            return Ok(result);
        }
    }
}
