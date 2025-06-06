﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Ellipse
    {
        private Graphics graphics;
        private Point centerOfPanel;
        private void PutPoint(int x, int y)
        {
            this.graphics.FillRectangle(Brushes.Blue, (((x) * 5) + this.centerOfPanel.X), ((y * -5) + this.centerOfPanel.Y), 5, 5);
        }

        private void DrawSymmetricPoints(int x, int y, Point center)
        {
            PutPoint(center.X + x, center.Y + y);
            PutPoint(center.X - x, center.Y + y);
            PutPoint(center.X + x, center.Y - y);
            PutPoint(center.X - x, center.Y - y);
        }

        public void DrawEllipse(Graphics graphics, Point center, int rx, int ry, Point centerOfPanal)
        {
            this.graphics = graphics;
            this.centerOfPanel = centerOfPanal;
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
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GUI
//{
//    public class Elipse
//    {
//        private Graphics graphics;
//        private Point centerOfPanel;
//        private void PutPoint(int x, int y)
//        {
//            this.graphics.FillRectangle(Brushes.Blue, (((x) * 5) + this.centerOfPanel.X), ((y * -5) + this.centerOfPanel.Y), 5, 5);
//        }

//        // Function to plot the Circle points in all four quadrants
//        private void ElipsePoints(int x, int y, Point center)
//        {
//            PutPoint(center.X + x, center.Y + y); // 1st quadrant
//            PutPoint(center.X - x, center.Y + y); // 2nd quadrant
//            PutPoint(center.X + x, center.Y - y); // 3rd quadrant
//            PutPoint(center.X - x, center.Y - y); // 4th quadrant
//        }

//        // Midpoint Circle Algorithm to draw an Circle
//        public void DrawElipse(Graphics graphics,Point center, int a, int b, Point centerOfPanal)
//        {
//            this.graphics = graphics;
//            this.centerOfPanel = centerOfPanal;
//            int x = 0,
//                y = b;
//            int aSquared = a * a;
//            int bSquared = b * b;
//            int twoASquared = 2 * aSquared;
//            int twoBSquared = 2 * bSquared;
//            int p1 = bSquared - (aSquared * b) + (aSquared / 4);
//            int p2 =
//                (bSquared * (x + 1)) * (x + 1) + aSquared * (y - 1) * (y - 1) - aSquared * bSquared;

//            // Region 1: when the Circle is wider along the X-axis (a > b)
//            while (twoBSquared * x <= twoASquared * y)
//            {
//                ElipsePoints(x, y, center); // Plot the points

//                x++;

//                if (p1 < 0)
//                    p1 += twoBSquared * x + bSquared;
//                else
//                {
//                    y--;
//                    p1 += twoBSquared * x - twoASquared * y + bSquared;
//                }
//            }

//            // Region 2: when the Circle is taller along the Y-axis (b > a)
//            p2 = bSquared * (x + 1) * (x + 1) + aSquared * (y - 1) * (y - 1) - aSquared * bSquared;

//            while (y >= 0)
//            {
//                ElipsePoints(x, y, center); // Plot the points

//                y--;

//                if (p2 > 0)
//                    p2 += aSquared * y - aSquared;
//                else
//                {
//                    x++;
//                    p2 += twoBSquared * x + aSquared * y - aSquared;
//                }
//            }
//        }
//    }
//}
