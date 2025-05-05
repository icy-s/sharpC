﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.madu
{
    internal class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, string sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
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
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}