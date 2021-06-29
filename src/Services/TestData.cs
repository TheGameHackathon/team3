using System;
using thegame.Infrastructure;
using thegame.Models;

namespace thegame.Services
{
    public class TestData
    {
        private static VectorDto PlayerPosition { get; set ; }
        public static GameDto AGameDto(VectorDto movingObjectPosition)
        {
            PlayerPosition = movingObjectPosition;
            var width = 10;
            var height = 8;
            var testCells = new[]
            {
                new CellDto("1", new VectorDto(2, 4), GameElements.Box, "", 10),
                new CellDto("2", new VectorDto(5, 4), GameElements.Box, "", 10),
                new CellDto("3", new VectorDto(3, 1), GameElements.Target, "", 0),
                new CellDto("4", new VectorDto(1, 0), GameElements.Target, "", 0),
                new CellDto("5", movingObjectPosition, GameElements.Player, "", 20),
            };
            return new GameDto(testCells, true, true, width, height, Guid.Empty, movingObjectPosition.X == 0, movingObjectPosition.Y);
        }
    }
}