using System.Drawing;

namespace LineDrowing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //need to be drown from middle of the screen
            DDADrower.DrowDDA();
            BresenhamDrower.DrowBresenham();
        }
    }
}
