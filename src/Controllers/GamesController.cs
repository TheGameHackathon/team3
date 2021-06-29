using System;
using Microsoft.AspNetCore.Mvc;
using thegame.Infrastructure;
using thegame.Models;
using thegame.Services;

namespace thegame.Controllers
{
    [Route("api/games/{gameId}")]
    public class GamesController : Controller
    {
        private Levels levels = new Levels();
        
        [HttpPost]
        public IActionResult Index([FromRoute] Guid gameId)
        {
            if (!levels.LevelsDict.ContainsKey(gameId)) 
                return BadRequest();

            var field = levels.LevelsDict[gameId];

            var cells = new CellDto[0][];
            var isFinished = false;
            var score = 0;
            
            return Ok(new GameDto(cells, true, true, cells[0].Length, cells.Length, Guid.Empty, isFinished, score));
        }
    }
}