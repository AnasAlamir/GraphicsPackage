using System.Drawing;

namespace GraphicsPackage
{
    public class Shear
    {
        public static Point ShearPoint(Point point, double shx, double shy)
        {
            int x = (int)(point.X + shx * point.Y);
            int y = (int)(point.Y + shy * point.X);
            return new Point(x, y);
        }
    }
}
