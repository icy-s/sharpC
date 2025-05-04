using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.madu
{
    class HorizontalLine : Figure
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xRight, int y, string sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

                x += GetSymbolWidth(sym); // increment based on symbol width
            }
        }
        private int GetSymbolWidth(string sym)
        {
            // Basic rule: emojis like ❤️ generally take 2 cells
            // You can refine this using Unicode categories if needed
            return (sym.Length > 1 || char.GetUnicodeCategory(sym[0]) == System.Globalization.UnicodeCategory.OtherSymbol) ? 2 : 1;
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}