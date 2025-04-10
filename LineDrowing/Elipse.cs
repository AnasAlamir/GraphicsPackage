using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPackage
{
    public class Elipse
    {
        public static void DrawElipse(int radius, Point center)
        {
            int x = 0;
            int y = radius;
            int p = 1 - radius;
            ElipsePoints(x, y, center);
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
                ElipsePoints(x, y, center);
            }
        }

        private static void ElipsePoints(int x, int y, Point center)
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
