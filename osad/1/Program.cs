using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.osad._1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast!");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
            int arv1 = int.Parse(Console.ReadLine());
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
            Console.ReadLine();
        }
    }


}
