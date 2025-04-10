using System.Drawing;

namespace GraphicsPackage
{
    public class Translation
    {
        public static Point TranslatePoint(Point point, int tx, int ty)
        {
            return new Point(point.X + tx, point.Y + ty);
        }
    }
}
