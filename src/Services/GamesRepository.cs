using System.Collections.Generic;
using thegame.Game.Models;

namespace thegame.Services;

public class GamesRepository
{
    private const string Level1Static =
        @"__XXXXX_
XXX___X_
X0____X_
XXX__0X_
X0XX__X_
X_X_0_XX
X__0__0X
X___0__X
XXXXXXXX";

    private const string Level1Dynamic =
        @"________
________
__P1____
____1___
_____1__
_____1__
________
_1__111_
________
________";

    private List<IEntity> ParseLevel()
    {
        var entities = new List<IEntity>();
        foreach (var staticObject in Level1Static)
        {
            switch (staticObject)
            {
                case '_':
                    //entities.Add(new Empty());
                    break;
                case 'X':
                    break;
                case '0':
                    break;
            }
        }

        foreach (var dynamicObject in Level1Static)
        {
            switch (dynamicObject)
            {
                case '1':
                    break;
                case 'P':
                    break;
            }
        }

        return entities;
    }
}
