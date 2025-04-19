using System.Drawing;

namespace GraphicsPackage
{
    //public class Rotation
    //{
    //    public static Point RotatePoint(Point point, double angle)
    //    {
    //        double radians = angle * Math.PI / 100;
    //        int x = (int)(point.X * Math.Cos(radians) - point.Y * Math.Sin(radians));
    //        int y = (int)(point.X * Math.Sin(radians) + point.Y * Math.Cos(radians));
    //        return new Point(x, y);
    //    }
    //}
    public class Rotation
    {

        public static (double x, double y) RotatePoint(double x, double y, double angleDegrees)
        {

            double theta = angleDegrees * Math.PI / 180.0;


            double xPrime = x * Math.Cos(theta) - y * Math.Sin(theta);
            double yPrime = x * Math.Sin(theta) + y * Math.Cos(theta);

            return (xPrime, yPrime);
        }
    }
}
