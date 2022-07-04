using FluentAssertions;
using NUnit.Framework;
using thegame.Game;
using thegame.Game.Models;
using thegame.Models;
using thegame.Services;

namespace thegame.Tests
{
    [TestFixture]
    public class GameTests
    {
        private GameMap gameMap;
        private GameStatus gameStatus;
        private GamesRepository repo = new GamesRepository();
        private int countBoxes = 0;
        private GameDto gameDto;

        [SetUp]
        public void SetUp()
        {
            gameMap = repo.ParseLevel();
            gameStatus = new GameStatus(gameMap, Status.ContinueGame);
            for (int x = 0; x < gameMap.map.GetLength(0); x++)
            {
                for (int y = 0; y < gameMap.map.GetLength(1); y++)
                {
                    if ((gameMap.map[x, y] != null &&  gameMap.map[x,y].Image.Equals("box")))
                        countBoxes++;
                }
            }
        }

        private GameDto GetGameDto()
        {
            return  ParserDto.ParseGameMap(gameStatus);
        }

        [Test]
        public void CheckMap_AfterParsing()
        {
            gameMap.Should().NotBeNull();
        }

        [Test]
        public void CheckCountStorages_AfterParsing()
        {
            gameMap.storages.Should().HaveCount(7);
        }

        [Test]
        public void BoxAndStoragesEqualCount_AfterParsing()
        {
            gameMap.storages.Should().HaveCount(countBoxes);
        }

        [Test]
        public void CheckSizeGameDto_AfterParsingMap()
        {
            GetGameDto().Cells.Should().HaveCount(gameMap.map.Length);
        }

        [Test]
        public void CheckStatusGameDto_AfterParsingMap()
        {
            GetGameDto().IsFinished.Should().Be(gameStatus.Status == Status.Vin);
        }
    }
}