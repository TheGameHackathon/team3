using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using thegame.Infrastructure;
using thegame.Models;
using thegame.Services;

namespace thegame.Controllers
{
    [Route("api/games/{gameId}/moves")]
    public class MovesController : Controller
    {
        [HttpPost]
        public IActionResult Moves(Guid gameId, [FromBody]UserInputDto userInput)
        {
            var game = TestData.AGameDto(userInput.ClickedPos ?? new VectorDto(1, 1));
            if (userInput.ClickedPos != null)
                game.Cells[0].First(c => c.Type == GameElements.Player).Pos = userInput.ClickedPos;
            return Ok(game);
        }
    }
}