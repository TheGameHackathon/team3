using System;
using thegame.Game.Models;

namespace thegame.Game
{
    public class GameStatus
    {
        public Guid Id;
        public int Score;
        public GameMap Map;
        public Status Status;

        public GameStatus(GameMap map, Status status)
        {
            this.Map = map;
            this.Status = status;
        }
    }
}
