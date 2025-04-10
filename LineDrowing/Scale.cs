using System.Drawing;

namespace GraphicsPackage
{
    public class Scale
    {
        public static Point ScalePoint(Point point,double sx, double sy){
            return new Point((int)(point.X*sx),(int)(point.Y*sy));
        }
    }
}