using System;
using System.Collections.Generic;
using thegame.Game;
using thegame.Game.Models;
using thegame.Models;

namespace thegame.Services
{
    public class ParserDto
    {
        public static GameDto ParseGameMap(GameStatus status)
        {
            List<CellDto> cells = new List<CellDto>();
            id = 1;
            foreach(var e in status.Map.map)
            {
                if (e == null)
                    continue;

                cells.Add(GetCell(e));
            }

            foreach (var storage in status.Map.storages)
            {
                id++;
                cells.Add(new CellDto(id.ToString(), new VectorDto(storage.Y, storage.X),
                    storage.Image, "", 10));
            }


            return new GameDto(cells.ToArray(), 
                true, 
                false, 
                status.Map.map.GetLength(1), 
                status.Map.map.GetLength(0), 
                status.Id, 
                status.Status == Game.Models.Status.Vin, 
                status.Score);
        }

        private static int id;
        private static CellDto GetCell(IEntity e)
        {
            id++;
            return new CellDto(id.ToString(), new VectorDto(e.Y, e.X), e.Image, "", 0);
        }
    }
}
