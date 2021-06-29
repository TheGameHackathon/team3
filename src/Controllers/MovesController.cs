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
            //var game = TestData.AGameDto( new VectorDto(1, 1));

            if (userInput.KeyPressed != null)
            {
                var userPos = game.Cells.First(c => c.Type == GameElements.Player).Pos;
                switch ((KeyboardButtons)userInput.KeyPressed)
                {
                    case KeyboardButtons.Up:
                        game.Cells.First(c => c.Type == GameElements.Player).Pos = new VectorDto(userPos.X , userPos.Y-1);
                        break;
                    case KeyboardButtons.Down:
                        game.Cells.First(c => c.Type == GameElements.Player).Pos = new VectorDto(userPos.X , userPos.Y+1);
                        break;
                    case KeyboardButtons.Right:
                        game.Cells.First(c => c.Type == GameElements.Player).Pos = new VectorDto(userPos.X+1 , userPos.Y);
                        break;
                    case KeyboardButtons.Left:
                        game.Cells.First(c => c.Type == GameElements.Player).Pos = new VectorDto(userPos.X -1, userPos.Y);
                        break;
                }
            }
            return Ok(game);
        }
    }
}