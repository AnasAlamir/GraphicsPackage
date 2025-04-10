using System.Drawing;
using System.Security.Cryptography;

namespace GraphicsPackage
{
    public class DDA
    {
        public static void DrowLine(Point point1, Point point2)
        {
            int dx = point2.X - point1.X;
            int dy = point2.Y - point1.Y;
            int steps;
            if (Math.Abs(dx) > Math.Abs(dy))
            {
                steps = Math.Abs(dx);
            }
            else
            {
                steps = Math.Abs(dy);
            }
            double xIncrement = 0;
            double yIncrement = 0;
            if (steps != 0)
            {
                xIncrement = (double)dx / steps;
                yIncrement = (double)dy / steps;
            }
            double xCurrunt = point1.X;
            double yCurrunt = point1.Y;
            for (int i = 0; i < steps + 1; i++)
            {
                //same result
                //Utility.PutPoint((int) (point1.X + i * xIncrement), (int) (point1.Y + i * yIncrement));

                Utility.PutPoint((int)Math.Round(xCurrunt), (int)Math.Round(yCurrunt));
                xCurrunt += xIncrement;
                yCurrunt += yIncrement;
            }
            Console.SetCursorPosition(0, Math.Max(point1.Y, point2.Y) + 1);
        }

    }
}
