using System.Drawing;

namespace GraphicsPackage
{
    public class Ellipse
    {
        private static void PutPoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('*');
        }

        private static void DrawSymmetricPoints(int x, int y, Point center)
        {
            PutPoint(center.X + x, center.Y + y);
            PutPoint(center.X - x, center.Y + y);
            PutPoint(center.X + x, center.Y - y);
            PutPoint(center.X - x, center.Y - y);
        }

        public static void DrawEllipse(Point center, int rx, int ry)
        {
            int x = 0;
            int y = ry;

            int rxSq = rx * rx;
            int rySq = ry * ry;

            int twoRxSq = 2 * rxSq;
            int twoRySq = 2 * rySq;

            // Region 1
            int px = 0;
            int py = twoRxSq * y;

            int p1 = (int)(rySq - (rxSq * ry) + (0.25 * rxSq));

            while (px < py)
            {
                DrawSymmetricPoints(x, y, center);
                x++;
                px += twoRySq;

                if (p1 < 0)
                {
                    p1 += rySq + px;
                }
                else
                {
                    y--;
                    py -= twoRxSq;
                    p1 += rySq + px - py;
                }
            }

            // Region 2
            int p2 = (int)(rySq * (x + 0.5) * (x + 0.5) + rxSq * (y - 1) * (y - 1) - rxSq * rySq);

            while (y >= 0)
            {
                DrawSymmetricPoints(x, y, center);
                y--;
                py -= twoRxSq;

                if (p2 > 0)
                {
                    p2 += rxSq - py;
                }
                else
                {
                    x++;
                    px += twoRySq;
                    p2 += rxSq - py + px;
                }
            }
        }
    }
}