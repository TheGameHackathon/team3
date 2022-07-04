using thegame.Game;
using thegame.Models;

namespace thegame.Services
{
    public class ParserDto
    {
        public static GameDto ParseGameMap(GameStatus status)
        {
            CellDto[] cells = new CellDto[status.map.map.GetLength(1)+ status.map.map.GetLength(0)];

            foreach(var e in status.map.map)
            {
                
            }


            return new GameDto(cells, 
                true, 
                false, 
                status.map.map.GetLength(1), 
                status.map.map.GetLength(0), 
                status.Id, 
                status.status == Game.Models.Status.Vin, 
                status.Score);
        }
    }
}
