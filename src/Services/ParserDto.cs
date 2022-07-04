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
            //CellDto[] cells = new CellDto[status.Map.map.GetLength(1)+ status.Map.map.GetLength(0)];
            List<CellDto> list = new List<CellDto>();
            int id = 1;
            foreach(var e in status.Map.map)
            {
                list.Add(new CellDto((id++).ToString(), new VectorDto(e.Y, e.X), e.Image, "", 0));
            }

            foreach (var storage in status.Map.storages)
            {
                list.Add(new CellDto(id.ToString(), new VectorDto(storage.Y, storage.X),
                    storage.Image, "", 10));
                id++;
            }

            return new GameDto(list.ToArray(),
                true, 
                false, 
                status.Map.map.GetLength(1), 
                status.Map.map.GetLength(0), 
                status.Id, 
                status.Status == Game.Models.Status.Vin, 
                status.Score);
        }

        //private static CellDto GetCell(IEntity e)
        //{
        //    //if(e is IStatic)
        //    //    return new CellDto("1", new VectorDto(e.X, e.Y), "color3", "", 0);
        //    //return new CellDto("1", new VectorDto(e.X, e.Y), e.Image, "-", 1);
        //}
    }
}
