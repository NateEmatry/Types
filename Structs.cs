using System.Diagnostics.CodeAnalysis;

namespace Types
{

    /*
        Structs: custom types that are value types.

        Use structs when:

         - They are small
         - Their identity is not separate from their values
         - They don't take up much memory
         - Their size is not large

     */

    // Declaring structs readonly can help if their values are not supposed to change.
    public readonly struct ColorRGB {

        private readonly int _red;
        private readonly int _green;
        private readonly int _blue;

        public ColorRGB(int r, int g, int b) {

            if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255)
                throw new ArgumentOutOfRangeException();

            _red = r;
            _green = g;
            _blue = b;
        }

        public override string ToString()
        {
            byte[] inArray = {(byte)_red, (byte)_green, (byte)_blue};
            return $"#{Convert.ToHexString(inArray)}";
        }
    }

    public struct Point {

        private double _x;
        private double _y;

        public Point(double x, double y) {

            _x = x;
            _y = y;
        }

        public double X => _x;
        public double Y => _y;

        public static bool operator ==(Point p1, Point p2) {
            
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Point p1, Point p2) {

            return p1.X != p2.X || p1.Y != p2.Y;
        }

        public override bool Equals([NotNullWhen(true)] object? obj) {

            return obj is Point p2 && this.X == p2.X && this.Y == p2.Y;
        }

        public override int GetHashCode() {

            return (X, Y).GetHashCode();
        }

        public static Point operator +(Point p1, Point p2) {

            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator -(Point p1, Point p2) {

            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static Point operator *(Point p, int s) {

            return new Point(p.X * s, p.Y * s);
        }

        public static Point operator *(int s, Point p) {

            return new Point(p.X * s, p.Y * s);
        }

        public static Point operator /(Point p, int d) {

            if (d == 0)
                throw new DivideByZeroException();

            return new Point(p.X / d, p.Y / d);
        }

    }
}