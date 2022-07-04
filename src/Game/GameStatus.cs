using System;
using thegame.Game.Models;

namespace thegame.Game
{
    public class GameStatus
    {
        public Guid Id;
        public int Score;
        public GameMap map;
        public Status status;

        public GameStatus(GameMap map, Status status)
        {
            this.map = map;
            this.status = status;
        }
    }
}
