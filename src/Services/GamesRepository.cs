using System;
using System.Collections.Generic;
using thegame.Game;
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
        @"========
========
==P1====
====1===
====1===
========
=1=111==
========
========";

    private const string EmptyColor = "";

    public GameMap ParseLevel()
    {
        var l1StaticSplited = Level1Static.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        var l1DynamicSplited = Level1Dynamic.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        if (l1StaticSplited.Length == 0 || l1DynamicSplited.Length == 0) return new GameMap();

        var width = l1StaticSplited[0].Length;
        var height = l1StaticSplited.Length;

        var entities = new IEntity[height, width];
        var storages = new List<Storage>();

        for (var i = 0; i < height; i++)
        {
            for (var j = 0; j < width; j++)
            {
                var newEntity = Parse(l1StaticSplited[i][j], i, j, out var isStorage);

                if (isStorage)
                {
                    storages.Add((Storage)newEntity);
                    entities[i, j] = new Empty(i, j, EmptyColor);
                }
                else entities[i, j] = newEntity;

                if (l1DynamicSplited[i][j] == '=') continue;

                var newEntityDynamic = Parse(l1DynamicSplited[i][j], i, j, out var _);
                entities[i, j] = newEntityDynamic;
            }
        }

        return new GameMap(entities, storages);
    }

    private IEntity Parse(char x, int i, int j, out bool isStorage)
    {
        isStorage = false;

        switch (x)
        {
            case '_':
                return new Empty(i, j, EmptyColor);
            case 'X':
                return new Wall(i, j, "wall");
            case '0':
                isStorage = true;
                return new Storage(i, j, "target");
            case '1':
                return new Box(i, j, "box")
                {
                    ZIndex = 10
                };
            case 'P':
                return new Player(i, j, "player")
                {
                    ZIndex = 10
                };
        }

        return new Empty(i, j, EmptyColor);
    }
}
