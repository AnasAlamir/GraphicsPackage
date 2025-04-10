using System.Drawing;

namespace GraphicsPackage
{
    public class Rotation
    {
        public static Point RotatePoint(Point point, double angle)
        {
            double radians = angle * Math.PI / 100;
            int x = (int)(point.X * Math.Cos(radians) - point.Y * Math.Sin(radians));
            int y = (int)(point.X * Math.Sin(radians) + point.Y * Math.Cos(radians));
            return new Point(x, y);
        }
    }
}
