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
            if (Math.Abs(dx) > Math.Abs(dy))
            {
                DrowHorizontalLine(point1, point2);
            }
            else
            {
                DrowVirticalLine(point1, point2);
            }
            Console.SetCursorPosition(0, Math.Max(point1.Y, point2.Y) + 1);

        }
        private static void DrowHorizontalLine(Point point1, Point point2)
        {
            if (point1.X > point2.X)
            {
                Point temp = point1;
                point1 = point2;
                point2 = temp;
            }
            int dx = point2.X - point1.X;
            int dy = point2.Y - point1.Y;
            int direction = 1;
            if (dy < 0)
            {
                direction = -1;
                
            }
            dy *= direction;
            if (dx != 0)
            {
                int y = point1.Y;
                int p = 2 * dy - dx;//Decision Parameter
                for (int i = 0; i < dx + 1; i++)
                {
                    Utility.PutPoint(point1.X + i, y);
                    if (p >= 0)
                    {
                        y += direction;
                        p = p + 2 * dy - 2 * dx;
                    }
                    else
                        p = p + 2 * dy;
                }
            }
        }
        private static void DrowVirticalLine(Point point1, Point point2)
        {
            if (point1.Y > point2.Y)
            {
                Point temp = point1;
                point1 = point2;
                point2 = temp;
            }
            int dx = point2.X - point1.X;
            int dy = point2.Y - point1.Y;
            int direction = 1;
            if (dx < 0)
            {
                direction = -1;

            }
            dx *= direction;
            if (dy != 0)
            {
                int x = point1.X;
                int p = 2 * dx - dy;//Decision Parameter
                for (int i = 0; i < dy + 1; i++)
                {
                    Utility.PutPoint(x, point1.Y + i);
                    if (p >= 0)
                    {
                        x += direction;
                        p = p + 2 * dx - 2 * dy;
                    }
                    else
                        p = p + 2 * dx;
                }
            }
        }
    }
}
