using thegame.Game.Models;

namespace thegame.Game
{
    public class GameStatus
    {
        GameMap map;
        Status status;
        public GameStatus(GameMap map, Status status)
        {
            this.map = map;
            this.status = status;
        }
    }
}
