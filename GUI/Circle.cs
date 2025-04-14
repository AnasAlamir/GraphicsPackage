using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Circle
    {
        private Graphics graphics;
        private Point centerOfPanel;
        private void PutPoint(int x, int y)
        {
            this.graphics.FillRectangle(Brushes.Orange, (((x) * 5) + this.centerOfPanel.X), ((y * -5) + this.centerOfPanel.Y), 5, 5);
        }
        public void DrawCircle(Graphics graphics, int radius, Point center, Point centerOfPanel)
        {
            this.graphics = graphics;
            this.centerOfPanel = centerOfPanel;
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

        private  void CirclePoints(int x, int y, Point center)
        {
            PutPoint(center.X + x, center.Y + y);
            PutPoint(center.X - x, center.Y + y);
            PutPoint(center.X + x, center.Y - y);
            PutPoint(center.X - x, center.Y - y);
            PutPoint(center.X + y, center.Y + x);
            PutPoint(center.X - y, center.Y + x);
            PutPoint(center.X + y, center.Y - x);
            PutPoint(center.X - y, center.Y - x);
        }
    }
}

