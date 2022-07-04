using Microsoft.AspNetCore.Mvc;
using thegame.Game.MapRepository;
using thegame.Services;

namespace thegame.Controllers
{
    [Route("api/games")]
    public class GamesController : Controller
    {
        private ISessionRepository sessionRepository;

        public GamesController(ISessionRepository sessionRepository)
        {
            this.sessionRepository = sessionRepository;
        }

        [HttpPost]
        public IActionResult Index()
        {
            
            var map = sessionRepository.CreateSession();
            return Ok(ParserDto.ParseGameMap(map));
        }
    }
}
