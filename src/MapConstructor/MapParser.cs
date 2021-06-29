using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper.Configuration.Conventions;
using thegame.Infrastructure;
using thegame.Models;

namespace thegame.MapConstructor
{
    public class MapParser : IMapParser
    {
        public Map ParseMap(string pathToMap)
        {
            var charMap = new List<char[]>();
            var result = new Map();
            // using var mapFile = new StreamReader(pathToMap);
            // while (true)
            // {
            //     var mapLine = mapFile.ReadLine()?.ToCharArray();
            //     if (mapLine != null)
            //         charMap.Add(mapLine);
            //     else
            //         break;
            // }

            charMap = new List<char[]>
            {   
                new []{'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
                new []{'#', '*', '.', '*', '.', '*', 'B', '*', '.', '#'},
                new []{'#', '.', 'B', '.', 'B', '.', 'B', '.', '.', '#'},
                new []{'#', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                new []{'#', '.', '.', '.', 'P', '.', '.', '.', '.', '#'},
                new []{'#', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
                new []{'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
            };
            result.Height = charMap.Count;
            result.Width = charMap[0].Length;
            result.Cells = CreateCellMap(charMap);
            return result;
        }

        private Cell[][] CreateCellMap(List<char[]> charMap)
        {
            var map = new List<List<Cell>>();
            for (var y = 0; y < charMap.Count; y++)
            {
                map.Add(new List<Cell>());
                for (var x = 0; x < charMap[0].Length; x++)
                {
                    map[y].Add(new Cell
                    {
                        Id = $"{x} {y}",
                        Pos = new Vector(x, y),
                        Type = GetEntityType(charMap[y][x]),
                        ZIndex = GetZIndex(charMap[y][x])
                    });
                }
            }

            return map.Select(line => line.ToArray()).ToArray();
        }

        private int GetZIndex(char charEntity)
        {
            return charEntity switch 
            {
                '#' => 100,
                '.' => 0,
                'P' => 10,
                'B' => 20,
                '*' => 5,
                _ => 0
            };
        }

        private string GetEntityType(char charEntity)
        {
            return charEntity switch
            {
                '#' => GameElements.Wall,
                '.' => GameElements.Road,
                'P' => GameElements.Player,
                'B' => GameElements.Box,
                '*' => GameElements.Target,
                _ => null
            };
        }
    }
}