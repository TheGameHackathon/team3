using thegame.MapPrimitives;
using thegame.Models;

namespace thegame.Services
{
    public interface IGamesRepository 
    {
        void UpdateState(Vector vector);
        GameDto GetGame();
    }
}