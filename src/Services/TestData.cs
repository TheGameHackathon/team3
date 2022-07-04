using System;
using thegame.Models;

namespace thegame.Services
{
    public class TestData
    {
        public static GameDto AGameDto(VectorDto movingObjectPosition)
        {
            var width = 10;
            var height = 8;
            var testCells = new[]
            {
                new CellDto("1", new VectorDto(2, 4), "color1", "", 0),
                new CellDto("2", new VectorDto(5, 4), "color1", "", 0),
                new CellDto("3", new VectorDto(3, 1), "color2", "", 20),
                new CellDto("4", new VectorDto(1, 0), "color2", "", 20),
                new CellDto("5", movingObjectPosition, "color4", "☺", 10),
            };
            return new GameDto(testCells, true, true, width, height, Guid.Empty, movingObjectPosition.X == 0, movingObjectPosition.Y);
        }
    }
}