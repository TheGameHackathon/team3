using System;

namespace thegame.MapPrimitives
{
    public class Vector
    {
        
        public int X { get; set; }
        public int Y { get; set; }
        
        public Vector(int x = 0, int y = 0)
        {
            (X, Y) = (x, y);
        }
        
        public override bool Equals(object obj) => obj is Vector other && this == other;
        public static Vector operator +(Vector a, Vector b) => new Vector(a.X + b.X, a.Y + b.Y);
        public static Vector operator -(Vector a, Vector b) => new Vector(a.X - b.X, a.Y - b.Y);
        public static Vector operator -(Vector a) => new Vector(-a.X, -a.Y);
        public static bool operator ==(Vector a, Vector b) => Math.Abs(a.X - b.X) == 0 && Math.Abs(a.Y - b.Y) == 0;
        public static bool operator !=(Vector a, Vector b) => !(a == b);
    }
}