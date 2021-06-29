using System.Collections.Generic;
using thegame.Infrastructure;
using thegame.Models;
using thegame.State;

namespace thegame.Services
{
    public interface IGamesRepository 
    {
        void UpdateState(KeyboardButtons button);
    }
}