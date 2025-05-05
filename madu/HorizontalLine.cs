using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.madu
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, string sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Point p in pList)
            {
                p.Draw();
            }
            Console.ForegroundColor= ConsoleColor.Blue;
        }
    }
}