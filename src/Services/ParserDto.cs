using thegame.Game;
using thegame.Models;

namespace thegame.Services
{
    public class ParserDto
    {
        public static GameDto ParseGameMap(GameStatus status)
        {
            CellDto[] cells = new CellDto[status.Map.map.GetLength(1)+ status.Map.map.GetLength(0)];

            foreach(var e in status.Map.map)
            {
                
            }


            return new GameDto(cells, 
                true, 
                false, 
                status.Map.map.GetLength(1), 
                status.Map.map.GetLength(0), 
                status.Id, 
                status.Status == Game.Models.Status.Vin, 
                status.Score);
        }
    }
}
