namespace thegame.Game.Models
{
    public class IEntity
    {
        public string Image { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int ZIndex { get; set; }

        public IEntity(int x, int y, string image, int zIndex = 0)
        {
            X = x;
            Y = y;
            Image = image;
            ZIndex = zIndex;
        }
    }
}
