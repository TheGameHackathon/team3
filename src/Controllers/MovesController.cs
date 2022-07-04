using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using thegame.Game;
using thegame.Game.MapRepository;
using thegame.Game.Models;
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

        private int X = 2;
        [HttpPost]
        public IActionResult Moves(Guid gameId, [FromBody]UserInputDto userInput)
        {
            
            var gameStatus = _sessionRepository.GetSession(gameId);
            var map = gameStatus.Map.map;

            /*
            Player player = null;
            int x = 0, y = 0;
            for (var i = 0; i < map.GetLength(0); i++)
            {
                for (var j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] is Player)
                    {
                        player = (Player)map[i, j];
                        x = i;
                        y = j;
                        break;
                    }
                }
            }
            */
            //map[X++, y] = player;

            var game = ParserDto.ParseGameMap(gameStatus);
            return Ok(game);
            /*
            if (userInput.KeyPressed == 87) // W
            {
                player.Y--;
                map[x, y - 1] = player;
                map[x, y] = new Empty(player.X, player.Y, "color1");
            }

            if (userInput.KeyPressed == 65) // A
            {
                player.X--;
                map[x - 1, y] = player;
                map[x, y] = new Empty(player.X, player.Y, "color1");
            }

            if (userInput.KeyPressed == 83) // S
            {
                player.Y++;
                map[x, y + 1] = player;
                map[x, y] = new Empty(player.X, player.Y, "color1");
            }

            if (userInput.KeyPressed == 68) // D
            {
                player.X++;
                map[x + 1, y] = player;
                map[x, y] = new Empty(player.X, player.Y, "color1");
            }
            */
            //var game = ParserDto.ParseGameMap(gameStatus);
            //return Ok(game);
        }
    }
}
