using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPackage
{
    internal class DDADrower
    {
        public static void DrowDDA()
        {
            Point point1 = new Point(10, 3);
            Point point2 = new Point(10, 40);
            Point point3 = new Point(20, 20);
            Point point4 = new Point(100, 0);
            Point point5 = new Point(40, 50);

            DDA.DrowLine(point1, point2);
            DDA.DrowLine(point1, point4);
            DDA.DrowLine(point1, point3);
            DDA.DrowLine(point2, point3);
            DDA.DrowLine(point2, point5);
            DDA.DrowLine(point3, point4);
            DDA.DrowLine(point3, point5);
            DDA.DrowLine(point4, point5);

            Utility.PutPointWithSymbol(point1, "p1");
            Utility.PutPointWithSymbol(point2, "p2");
            Utility.PutPointWithSymbol(point3, "p3");
            Utility.PutPointWithSymbol(point4, "p4");
            Utility.PutPointWithSymbol(point5, "p5");
        }
    }
}
