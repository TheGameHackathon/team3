using System.Collections.Generic;
using thegame.MapPrimitives;
using thegame.Models;

namespace thegame.State
{
    public class GameState : IGameState
    {
        public int Id { get; set; }
        public Cell[] Map { get; set; }

        public GameDto Game { get; set; }
    }
}