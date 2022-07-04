using System;
using System.Collections.Generic;

namespace thegame.Game.MapRepository
{
    public class SessionRepository : ISessionRepository
    {

        private readonly Dictionary<Guid, GameStatus> sessions;
        public GameStatus CreateSession()
        {
            throw new NotImplementedException();
        }

        public GameStatus GetSession(Guid gameId)
        {
            throw new NotImplementedException();
        }
    }
}
