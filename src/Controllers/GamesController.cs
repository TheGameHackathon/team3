using Microsoft.AspNetCore.Mvc;
using System;
using thegame.Game;
using thegame.Game.MapRepository;
using thegame.Models;
using thegame.Services;

namespace thegame.Controllers
{
    [Route("api/games")]
    public class GamesController : Controller
    {
        private ISessionRepository sessionRepository;

        public GamesController(ISessionRepository sessionRepository)
        {
            this.sessionRepository = sessionRepository;
        }

        [HttpPost]
        public IActionResult Index()
        {
            var map = sessionRepository.CreateSession();
            return Ok(ParserDto.ParseGameMap(map));
        }
    }
}
