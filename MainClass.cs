using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC
{

    internal class MainClass
	{
		public static void Main(string[] args)
		{
			Console.BackgroundColor = ConsoleColor.Green;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Tere!");
			// 1. osa (Andmetüübid, if, case, random, alamfunktsioonid
			int a = 0;
			string tekst = "Python";
			char taht = 'A';
			double arv = 5.4536237287;
			float arv1 = 2;
			Console.Write("Mis on sinu nimi? ");
			tekst = Console.ReadLine();
			Console.WriteLine("Tere!\n"+tekst);
			Console.WriteLine("Tere!\n {0}",tekst);
			int arv2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
		}

	}
}
