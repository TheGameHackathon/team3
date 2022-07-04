using System;
using System.Collections.Generic;
using thegame.Services;

namespace thegame.Game.MapRepository
{
    public class SessionRepository : ISessionRepository
    {

        private readonly Dictionary<Guid, GameStatus> sessions;

        private GameMap asd;
        private GamesRepository gp;

        public SessionRepository()
        {
            gp = new GamesRepository();
            asd = gp.ParseLevel();
        }

        public GameStatus CreateSession()
        {
            throw new NotImplementedException();
        }

        public GameStatus GetSession(Guid gameId)
        {
            return new GameStatus(asd, Models.Status.ContinueGame);
        }
    }
}
