using System.Collections.Generic;
using thegame.Game.Models;

namespace thegame.Game
{
    public class GameMap
    {
        private readonly IEntity[,] Map;
        private readonly List<Storage> Storages;

        public GameMap(IEntity[,] map, List<Storage> storages)
        {
            Map = map;
            Storages = storages;
        }
    }
}
