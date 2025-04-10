using System.Drawing;

namespace LineDrowing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DDADrower.DrowDDA();
            //bresenham only work with one octant
            //BresenhamDrower.DrowBresenham();
        }
    }
}
