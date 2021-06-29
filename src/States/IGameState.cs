using System;
using thegame.MapPrimitives;
using thegame.Models;

namespace thegame.State
{
    public interface IGameState
    {
        public int Id { get; set; }
        public Cell[] Map{ get; set; }
        public GameDto Game{ get; set; }
    }
}