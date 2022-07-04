using System.Collections.Generic;
using thegame.Game.Models;

namespace thegame.Game
{
    public class GameMap
    {
        public IEntity[,] map { get; private set; }
        public List<Storage> storages { get; private set; }

        public GameMap() : this(new IEntity[0, 0], new List<Storage>())
        {

        }


        public GameMap(IEntity[,] mapStatic, List<Storage> storages)
        {
            this.map = mapStatic;
            this.storages = storages;
        }
    }
}
