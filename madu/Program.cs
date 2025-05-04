﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.madu
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, "-");
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, "-");
            VerticalLine leftLine = new VerticalLine(0, 24, 0, "/");
            VerticalLine rightLine = new VerticalLine(0, 24, 78, "/");
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Console.OutputEncoding = Encoding.UTF8;
            Point p1 = new Point(1, 3, "🐀");
            p1.Draw();

            Point p2 = new Point(4, 5, "🐀");
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 8, "🐀");
            line.Draw();

            Console.ReadLine();
        }
    }
}
