using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using thegame.Infrastructure;
using thegame.Models;
using thegame.State;

namespace thegame.Services
{
    public class GamesRepository: IGamesRepository
    {
        private GameState GameState { get; set; }

        public void UpdateState(KeyboardButtons button)
        {
            
            return;
        }
    }
}