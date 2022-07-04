using System;
using System.Collections.Generic;
using thegame.Models;

namespace thegame.Services
{
    public class TestData
    {
        public static GameDto AGameDto(VectorDto movingObjectPosition)
        {
            var repo = new GamesRepository();
            var level = repo.ParseLevel();

            var width = level.map.GetLength(0);
            var height = level.map.GetLength(1);
            // var width = 10;
            // var height = 8;
            // var testCells = new[]
            // {
            //     new CellDto("1", new VectorDto(2, 4), "color1", "", 0),
            //     new CellDto("2", new VectorDto(5, 4), "color1", "", 0),
            //     new CellDto("3", new VectorDto(3, 1), "color2", "", 20),
            //     new CellDto("4", new VectorDto(1, 0), "color2", "", 20),
            //     new CellDto("5", movingObjectPosition, "color4", "☺", 10),
            // };

            var testCells = new List<CellDto>();
            var id = 1;

            for (var j = 0; j < height; j++)
            {
                for (var i = 0; i < width; i++)
                {
                    if (level.map[i, j] == null) continue;
                testCells.Add(new CellDto(id.ToString(), new VectorDto(i, j), level.map[i, j].Image, "", 0));
                id++;
                }
            }

            return new GameDto(testCells.ToArray(), true, true, width, height, Guid.Empty, movingObjectPosition.X == 0,
                movingObjectPosition.Y);
        }
    }
}
