using System;
using thegame.Game;
using thegame.Game.Models;
using thegame.Models;

namespace thegame.Services
{
    public class ParserDto
    {
        public static GameDto ParseGameMap(GameStatus status)
        {
            CellDto[] cells = new CellDto[status.Map.map.GetLength(1)+ status.Map.map.GetLength(0)];

            foreach(var e in status.Map.map)
            {
                cells[e.X + e.Y] = GetCell(e);
            }


            return new GameDto(cells, 
                true, 
                false, 
                status.Map.map.GetLength(1), 
                status.Map.map.GetLength(0), 
                status.Id, 
                status.Status == Game.Models.Status.Vin, 
                status.Score);
        }

        private static CellDto GetCell(IEntity e)
        {

            if(e is IStatic)
                return new CellDto("1", new VectorDto(e.X, e.Y), "color1", "", 0);
            return new CellDto("1", new VectorDto(e.X, e.Y), "color2", "", 0);
            //return new CellDto("1", new VectorDto(e.X, e.Y), e.Image, "-", 1);
        }
    }
}
