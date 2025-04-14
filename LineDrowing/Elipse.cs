using System.Drawing;

namespace GraphicsPackage
{
    public class Elipse
    {
        private static void PutPoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('*'); // Plotting a point with '*'
        }

        // Function to plot the Circle points in all four quadrants
        private static void ElipsePoints(int x, int y, Point center)
        {
            PutPoint(center.X + x, center.Y + y); // 1st quadrant
            PutPoint(center.X - x, center.Y + y); // 2nd quadrant
            PutPoint(center.X + x, center.Y - y); // 3rd quadrant
            PutPoint(center.X - x, center.Y - y); // 4th quadrant
        }

        // Midpoint Circle Algorithm to draw an Circle
        public static void DrawElipse(Point center, int a, int b)
        {
            int x = 0,
                y = b;
            int aSquared = a * a;
            int bSquared = b * b;
            int twoASquared = 2 * aSquared;
            int twoBSquared = 2 * bSquared;
            int p1 = bSquared - (aSquared * b) + (aSquared / 4);
            int p2 =
                (bSquared * (x + 1)) * (x + 1) + aSquared * (y - 1) * (y - 1) - aSquared * bSquared;

            // Region 1: when the Circle is wider along the X-axis (a > b)
            while (twoBSquared * x <= twoASquared * y)
            {
                ElipsePoints(x, y, center); // Plot the points

                x++;

                if (p1 < 0)
                    p1 += twoBSquared * x + bSquared;
                else
                {
                    y--;
                    p1 += twoBSquared * x - twoASquared * y + bSquared;
                }
            }

            // Region 2: when the Circle is taller along the Y-axis (b > a)
            p2 = bSquared * (x + 1) * (x + 1) + aSquared * (y - 1) * (y - 1) - aSquared * bSquared;

            while (y >= 0)
            {
                ElipsePoints(x, y, center); // Plot the points

                y--;

                if (p2 > 0)
                    p2 += aSquared * y - aSquared;
                else
                {
                    x++;
                    p2 += twoBSquared * x + aSquared * y - aSquared;
                }
            }
        }
    }
}
