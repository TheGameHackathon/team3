using System;
using thegame.MapConstructor;
using thegame.Models;

namespace thegame.State
{
    public interface IGameState
    {
        public int Id { get; set; }
        public Cell[][] Map{get; set; }
    }
}