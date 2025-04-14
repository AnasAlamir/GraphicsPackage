using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class DDA
    {
        public static void DrawLine(Graphics graphics, Point point1, Point point2, Point center)
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
                graphics.FillRectangle(Brushes.Black, (((int)Math.Round(xCurrunt) * 5) + center.X), (((int)Math.Round(yCurrunt) * -5) + center.Y), 5, 5);
                
                xCurrunt += xIncrement;
                yCurrunt += yIncrement;
            }
        }
        public static void DrawLineAxis(Graphics graphics, Point point1, Point point2)
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
                graphics.FillRectangle(Brushes.Black, (int)Math.Round(xCurrunt), (int)Math.Round(yCurrunt), 1, 1);

                xCurrunt += xIncrement;
                yCurrunt += yIncrement;
            }
        }

    }
}
