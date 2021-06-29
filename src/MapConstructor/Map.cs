using thegame.MapPrimitives;
using thegame.Models;

namespace thegame.MapConstructor
{
    public class Map
    {
        public Cell[][] Cells { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}