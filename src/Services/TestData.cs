using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.StaticFiles;
using thegame.Infrastructure;
using thegame.MapConstructor;
using thegame.Models;

namespace thegame.Services
{
    public class TestData
    {
        
        private static Levels levels = new Levels();
        private static IMapParser _mapParser = new MapParser();
        public static GameDto AGameDto(Guid gameId)
        {
            var field = levels.LevelsDict[gameId];

            var cells = _mapParser.ParseMap("testMap.txt").Cells;

            var cellsDto = new[]
            {
                new[] {new CellDto("0", new VectorDto(0, 0), "AaA", 12)}
            };
            
            var isFinished = false;
            var score = 0;
            
            return new GameDto(cellsDto, true, true, cells[0].Length, cells.Length, Guid.Empty, isFinished, score);
        }
    }
}