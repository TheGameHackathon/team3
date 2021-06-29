using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.StaticFiles;
using thegame.Infrastructure;
using thegame.MapConstructor;
using thegame.Models;

namespace thegame.Services
{
    public class TestData
    {
        
        //private static Levels levels = new Levels();
        private static IMapParser _mapParser = new MapParser();
        public static GameDto AGameDto(string gameId)
        {
            //var field = levels.LevelsDict[gameId];

            var cells = _mapParser.ParseMap(Directory.GetCurrentDirectory() + "/MapConstructor/testMap.txt").Cells;

            var cellsDto = new List<CellDto>();
            foreach (var cell in cells)
            {
                foreach (var c in cell)
                {
                    cellsDto.Add(new CellDto(
                        c.Id,
                        new VectorDto(c.Pos.X, c.Pos.Y),
                        c.Type,
                        c.ZIndex
                    ));
                }
            }

            var isFinished = false;
            var score = 0;
            
            return new GameDto(cellsDto.ToArray(), true, true, cells[0].Length, cells.Length, Guid.Empty, isFinished, score);
        }
    }
}