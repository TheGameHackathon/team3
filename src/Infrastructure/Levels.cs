using System;
using System.Collections.Generic;

namespace thegame.Infrastructure
{
    public class Levels
    {
        public Dictionary<string, string> LevelsDict { get; }

        public Levels()
        {
            LevelsDict = new Dictionary<string, string>
            {
                {
                    "level0", @"##########
#*.*.*B*.#
#.B.B.B..#
#........#
#...P....#
#........#
##########"
                },
                {
                    "level1", @"##########
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