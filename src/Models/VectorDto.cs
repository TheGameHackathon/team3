using thegame.MapPrimitives;

namespace thegame.Models
{
    public class VectorDto
    {
        public VectorDto(int x, int y)
        {
            X = x;
            Y = y;
        }

        public VectorDto()
        {
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}