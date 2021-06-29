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
        //private Levels levels = new Levels();
        
        [HttpPost]
        public IActionResult Index([FromRoute] string gameId)
        {
            // if (!levels.LevelsDict.ContainsKey(gameId)) 
            //     return BadRequest();
            
            return Ok(TestData.AGameDto(gameId));
        }
    }
}