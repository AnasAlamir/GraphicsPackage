using System.Drawing;

namespace LineDrowing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point point1 = new Point(10, 3);
            Point point2 = new Point(10, 40);
            Point point3 = new Point(20, 20);
            Point point4 = new Point(100, 0);
            Point point5 = new Point(40, 50);
            ///
            //DDA
            //DDA.DrowLine(point1, point2);
            //DDA.DrowLine(point1, point4);
            //DDA.DrowLine(point1, point3);
            //DDA.DrowLine(point2, point3);
            //DDA.DrowLine(point2, point5);
            //DDA.DrowLine(point3, point4);
            //DDA.DrowLine(point3, point5);
            //DDA.DrowLine(point4, point5);

            //Utility.PutPointWithSymbol(point1, "p1");
            //Utility.PutPointWithSymbol(point2, "p2");
            //Utility.PutPointWithSymbol(point3, "p3");
            //Utility.PutPointWithSymbol(point4, "p4");
            //Utility.PutPointWithSymbol(point5, "p5");
            ///
            ////DDA.DrowLine(new Point(5, 5), new Point(5, 5));//steps = 0
            ///
            //Bresenham
            //int value = 10;
            //point1 = new Point(10 + value, 3 + value);
            //point2 = new Point(10 + value, 40 + value);
            //point3 = new Point(20 + value, 20 + value);
            //point4 = new Point(100 + value, 0 + value);
            //point5 = new Point(40 + value, 50 + value);
            

            //Bresenham.DrowLine(point1, point2);
            //Bresenham.DrowLine(point1, point4);
            //Bresenham.DrowLine(point1, point3);
            //Bresenham.DrowLine(point2, point3);
            //Bresenham.DrowLine(point2, point5);
            //Bresenham.DrowLine(point3, point4);
            //Bresenham.DrowLine(point3, point5);
            //Bresenham.DrowLine(point4, point5);

            //Utility.PutPointWithSymbol(point1, "p11");
            //Utility.PutPointWithSymbol(point3, "p33");
        }
    }
}
