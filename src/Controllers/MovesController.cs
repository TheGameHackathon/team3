using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using thegame.Infrastructure;
using thegame.MapConstructor;
using thegame.Models;
using thegame.Services;

namespace thegame.Controllers
{
    [Route("api/games/{gameId}/moves")]
    public class MovesController : Controller
    {

        [HttpPost]
        public IActionResult Moves(string gameId, [FromBody]UserInputDto userInput)
        {
            var game = TestData.AGameDto(gameId);

            if (userInput.KeyPressed == default)
                return Ok(game);
            var userPos = GetCellsFromMap(game, GameElements.Player).First().Pos;
                
            switch ((KeyboardButtons)userInput.KeyPressed)
            {
                case KeyboardButtons.Up:
                {
                    GetCellsFromMap(game, GameElements.Player).First().Pos =
                        new VectorDto(userPos.X, userPos.Y - 1);
                    break;
                }
                case KeyboardButtons.Down:
                {
                    GetCellsFromMap(game, GameElements.Player).First().Pos =
                        new VectorDto(userPos.X, userPos.Y + 1);
                    break;
                }
                case KeyboardButtons.Right:
                {
                    GetCellsFromMap(game, GameElements.Player).First().Pos =
                        new VectorDto(userPos.X + 1, userPos.Y);
                    break;
                }
                case KeyboardButtons.Left:
                {
                    GetCellsFromMap(game, GameElements.Player).First().Pos =
                        new VectorDto(userPos.X - 1, userPos.Y);
                    break;
                }
            }
            return Ok(game);
        }

        private CellDto[] GetCellsFromMap(GameDto game, string element)
        {
            var result = new List<CellDto>();
            foreach (var cell in game.Cells)
            {
                if (cell.Type == element)
                    result.Add(cell);
            }

            return result.ToArray();
        }
    }
}