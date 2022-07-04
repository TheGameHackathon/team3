using System.Collections.Generic;
using thegame.Game.Models;

namespace thegame.Game
{
    public class GameMap
    {
        private readonly IEntity[,] mapStatic;
        private readonly List<Storage> storages;

        public GameMap() : this(new IEntity[0, 0], new List<Storage>())
        {
        }


        public GameMap(IEntity[,] mapStatic, List<Storage> storages)
        {
            this.mapStatic = mapStatic;
            this.storages = storages;
        }
    }
}
