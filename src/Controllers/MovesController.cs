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
            var game = TestData.AGameDto( new VectorDto(1, 1));

            if (userInput.KeyPressed != null)
            {
                var userPos = game.Cells.First(c => c.Type == GameElements.Player).Pos;
                switch (userInput.KeyPressed)
                {
                    case 38:
                        game.Cells.First(c => c.Type == GameElements.Player).Pos = new VectorDto(userPos.X , userPos.Y-1);
                        break;
                    case 37:
                        game.Cells.First(c => c.Type == GameElements.Player).Pos = new VectorDto(userPos.X , userPos.Y+1);
                        break;
                    case 39:
                        game.Cells.First(c => c.Type == GameElements.Player).Pos = new VectorDto(userPos.X+1 , userPos.Y);
                        break;
                    case 40:
                        game.Cells.First(c => c.Type == GameElements.Player).Pos = new VectorDto(userPos.X -1, userPos.Y);
                        break;
                }
            }
            return Ok(game);
        }
    }
}