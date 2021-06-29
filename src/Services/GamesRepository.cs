using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using thegame.Infrastructure;
using thegame.MapPrimitives;
using thegame.State;

namespace thegame.Services
{
    public class GamesRepository : IGamesRepository
    {
        private IGameState _state;

        public GamesRepository(IGameState state)
        {
            _state = state;
        }
        
        public void UpdateState(Vector moveDirection)
        {
            var playerCell = _state.Map.First(c => c.Type == GameElements.Player);
            var nextPlayerPos = playerCell.Pos + moveDirection;

            var destinationCell = _state.Map.First(x => x.Pos == nextPlayerPos);
            if(destinationCell.Type == )



        }
    }
}