using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using thegame.Infrastructure;
using thegame.MapPrimitives;
using thegame.Models;
using thegame.State;

namespace thegame.Services
{
    public class GamesRepository : IGamesRepository
    {
        private IGameState _state;
        private IMapper _mapper;

        public GamesRepository(IMapper mapper)
        {
            _mapper = mapper;
            var game = TestData.AGameDto("");
            _state = new GameState{ Map = GetCellsFromMap(game), Game = game };
        }
        
        public void UpdateState(Vector moveDirection)
        {
            var playerCell = _state.Map.First(c => c.Type == GameElements.Player);
            var nextPlayerPos = playerCell.Pos + moveDirection;

            var destinationCell = _state.Map.Where(x => x.Pos == nextPlayerPos).ToList();
            if (destinationCell.Any(x => x.Type == GameElements.Wall)) 
                return;
            if (destinationCell.Any(x => x.Type == GameElements.Box))
            {
                var boxCell = _state.Map.First(c => c.Type == GameElements.Box && c.Pos == nextPlayerPos);
                var nextBoxPos = nextPlayerPos + moveDirection;
                var nextDestinationCell = _state.Map.Where(x => x.Pos == nextBoxPos).ToList();
                if (nextDestinationCell.Any(x => x.Type == GameElements.Wall || x.Type == GameElements.Box) ) 
                    return;

                boxCell.Pos = nextBoxPos;
            }

            playerCell.Pos = nextPlayerPos;
            
            _state.Game.Cells = _state.Map.Select(x => new CellDto
            {
                Id = x.Id,
                ZIndex = x.ZIndex,
                Pos= new VectorDto(x.Pos.X, x.Pos.Y),
                Type = x.Type
            }).ToArray();
        }

        public GameDto GetGame() => _state.Game;

        private Cell[] GetCellsFromMap(GameDto game)
        {
            var result = new List<Cell>();
            foreach (var cell in game.Cells) 
                result.Add(_mapper.Map<Cell>(cell));

            return result.ToArray();
        }
    }
}