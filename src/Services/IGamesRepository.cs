using System.Collections.Generic;
using thegame.Infrastructure;
using thegame.MapPrimitives;
using thegame.Models;
using thegame.State;

namespace thegame.Services
{
    public interface IGamesRepository 
    {
        void UpdateState(Vector button);
    }
}