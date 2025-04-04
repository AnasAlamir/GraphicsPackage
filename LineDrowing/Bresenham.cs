using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDrowing
{
    public class Bresenham
    {
        public static void DrowLine(Point point1, Point point2)
        {
            int dx = point2.X - point1.X;
            int dy = point2.Y - point1.Y;
            if (dx != 0)
            {
                int y = point1.Y;
                int p = 2 * dy - dx;//Decision Parameter
                for (int i = 0; i < dx + 1; i++)
                {
                    Utility.PutPoint(point1.X + i, y);
                    if (p >= 0)
                    {
                        y++;
                        p = p + 2 * dy - 2 * dx;
                    }
                    else
                        p = p + 2 * dy;
                }
            }
            Console.SetCursorPosition(0, Math.Max(point1.Y, point2.Y) + 1);
        }
    }
}
