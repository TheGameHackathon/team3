namespace thegame.Game.Models
{
    public class IEntity
    {
        public string Image { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public IEntity(int x, int y, string image)
        {
            X = x;
            Y = y;
            Image = image;
        }
    }
}
