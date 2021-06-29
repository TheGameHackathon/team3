using System;
using System.Collections.Generic;

namespace thegame.Infrastructure
{
    public class Levels
    {
        public Dictionary<Guid, string> LevelsDict { get; }

        public Levels()
        {
            LevelsDict = new Dictionary<Guid, string>
            {
                {
                    Guid.Parse("level0"), @"##########
#*.*.*B*.#
#.B.B.B..#
#........#
#...P....#
#........#
##########"
                },
                {
                    Guid.Parse("level1"), @"##########
#*.*.*B*.#
#.B.B.B..#
#..#.....#
#.B.P....#
#.*B*B*B*#
##########"
                }
            };
        }
    }
}