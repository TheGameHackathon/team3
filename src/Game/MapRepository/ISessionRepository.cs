using System;

namespace thegame.Game.MapRepository
{
    public interface ISessionRepository
    {
        public GameStatus CreateSession();
        public GameStatus GetSession(Guid gameId);
    }
}
