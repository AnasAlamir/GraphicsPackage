using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPackage
{
    public class Reflection
    {
        public static Point ReflectPointOverX(Point point)
        {
            return new Point(-point.X, point.Y);
        }
        public static Point ReflectPointOverY(Point point)
        {
            return new Point(point.X, -point.Y);
        }
        public static Point ReflectPointOverOrigin(Point point)
        {
            return new Point(-point.X, -point.Y);
        }
    }
}
