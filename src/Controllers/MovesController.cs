using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using thegame.Game;
using thegame.Game.MapRepository;
using thegame.Models;
using thegame.Services;

namespace thegame.Controllers
{
    [Route("api/games/{gameId}/moves")]
    public class MovesController : Controller
    {
        private readonly ISessionRepository _sessionRepository;

        public MovesController(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        [HttpPost]
        public IActionResult Moves(Guid gameId, [FromBody]UserInputDto userInput)
        {
            var map = _sessionRepository.GetSession(gameId).Map;
            //var game = TestData.AGameDto(userInput.ClickedPos ?? new VectorDto(1, 1));

            //if (userInput.ClickedPos != null)
            //    game.Cells.First(c => c.Type == "color4").Pos = userInput.ClickedPos;


            return Ok(ParserDto.ParseGameMap(new GameStatus(map, Game.Models.Status.ContinueGame)));
        }
    }
}