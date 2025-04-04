using System.Drawing;

namespace LineDrowing
{
    public class Utility
    {
        public static void PutPoint(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("*");
            Console.SetCursorPosition(0, top + 1);
        }
        public static void PutPointWithSymbol(Point point, string symbol)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.WriteLine(symbol);
            Console.SetCursorPosition(0, point.Y + 1);
        }
    }
}
