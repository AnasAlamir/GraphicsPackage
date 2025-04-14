using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPackage
{
    public class Circle
    {
        public static void DrawCircle(int radius, Point center)
        {
            int x = 0;
            int y = radius;
            int p = 1 - radius;
            CirclePoints(x, y, center);
            while (y > x)
            {
                if (p < 0)
                {
                    p += 2 * x + 3;
                }
                else
                {
                    p += 2 * (x - y) + 5;
                    y--;
                }
                x++;
                CirclePoints(x, y, center);
            }
        }

        private static void CirclePoints(int x, int y, Point center)
        {
            Utility.PutPoint(center.X + x, center.Y + y);
            Utility.PutPoint(center.X - x, center.Y + y);
            Utility.PutPoint(center.X + x, center.Y - y);
            Utility.PutPoint(center.X - x, center.Y - y);
            Utility.PutPoint(center.X + y, center.Y + x);
            Utility.PutPoint(center.X - y, center.Y + x);
            Utility.PutPoint(center.X + y, center.Y - x);
            Utility.PutPoint(center.X - y, center.Y - x);
        }
    }
}
