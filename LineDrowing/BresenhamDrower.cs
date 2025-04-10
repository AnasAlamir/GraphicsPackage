using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LineDrowing
{
    internal class BresenhamDrower
    {
        public static void DrowBresenham()
        {
            int value = 10;
            Point point1 = new Point(10 + value, 3 + value);
            Point point2 = new Point(10 + value, 40 + value);
            Point point3 = new Point(20 + value, 20 + value);
            Point point4 = new Point(100 + value, 0 + value);
            Point point5 = new Point(40 + value, 50 + value);

            Bresenham.DrowLine(point1, point2);
            Bresenham.DrowLine(point1, point4);
            Bresenham.DrowLine(point1, point3);
            Bresenham.DrowLine(point2, point3);
            Bresenham.DrowLine(point2, point5);
            Bresenham.DrowLine(point3, point4);
            Bresenham.DrowLine(point3, point5);
            Bresenham.DrowLine(point4, point5);

            Utility.PutPointWithSymbol(point1, "p1");
            Utility.PutPointWithSymbol(point2, "p2");
            Utility.PutPointWithSymbol(point3, "p3");
            Utility.PutPointWithSymbol(point4, "p4");
            Utility.PutPointWithSymbol(point5, "p5");
        }
    }
}
