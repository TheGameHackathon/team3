using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using thegame.Models;

namespace thegame.Services
{
    public class GamesRepo
    {
        private VectorDto PlayerPosition { get; set; }
        private List<VectorDto> BoxesPosition { get; set; }
        public GamesRepo(VectorDto playerPosition)
        {
            PlayerPosition = playerPosition;
        }
    }
}