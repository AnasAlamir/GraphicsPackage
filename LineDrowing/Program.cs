using GraphicsPackage;
using System.Drawing;

namespace GraphicsPackage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //need to be drown from middle of the screen
            DDADrower.DrowDDA();

            BresenhamDrower.DrowBresenham();

            Elipse.DrawElipse(new Point(20, 10), 5, 5);
            Circle.DrawCircle(10, new Point(20, 20));

            Point point = new Point(20, 10);
            Utility.PutPointWithSymbol(point, "O");

            Point scaledPoint = Scale.ScalePoint(point, 2, 3);
            Utility.PutPointWithSymbol(scaledPoint, "S");
            //not sure if this is correct
            Point rotatedPoint = Rotation.RotatePoint(point, Math.PI / -6);
            Utility.PutPointWithSymbol(rotatedPoint, "R");

            Point transelatedPoint = Translation.TranslatePoint(point, 2, 3);
            Utility.PutPointWithSymbol(transelatedPoint, "T");
            //not sure if this is correct
            Point sheardPoint = Shear.ShearPoint(point, 2, 2);
            Utility.PutPointWithSymbol(sheardPoint, "Sh");

            //give error as it need the start to be drown from middle of the screen
            //Point reflectedPoint = Reflection.ReflectPointOverOrigin(point);
            //Utility.PutPointWithSymbol(reflectedPoint, "Rf");


            Console.SetCursorPosition(0, 60);
        }
    }
}
