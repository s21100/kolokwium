using kolokwium2b.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2b.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : Controller
    {
        private readonly IDbService _dbService;

        public MusicController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        [Route("/Musician/{id}")]
        public async Task<IActionResult> getMusician(int id) {
            var musician = await _dbService.getMusician(id);

            if (musician == null) {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete]
        [Route("/Musician/{id}")]
        public async Task<IActionResult> deleteMusician(int id)
        {
            var deleted = await _dbService.deleteMusician(id);

            if (!deleted)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
