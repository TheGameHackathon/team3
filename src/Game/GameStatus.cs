using thegame.Game.Models;

namespace thegame.Game
{
    public class GameStatus
    {
        GameStatus map;
        Status status;
        public GameStatus(GameStatus map, Status status)
        {
            this.map = map;
            this.status = status;
        }
    }
}
