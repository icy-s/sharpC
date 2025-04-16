using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC
{
	internal class FunktsioonideClass_2osa
	{
		public static List<string> Sõnad()
		{
            List<string> sonad = new List<string>();
            for (int j = 0; j < 5; j++)
			{
				Console.Write("Nimi: ");
				sonad.Add(Console.ReadLine());
			}
			return sonad;
		}
		public static Isik[] Isikud(int k, string[] nimed, string[] aadressid)
		{
			Isik[] isikud = new Isik[k];

			for (int i = 0; i < k; i++)
			{
				Console.WriteLine(i);
				//isikud[i] = new Isik();
				Console.Write("Isikukood: ");
				isikud[i] = new Isik
				{
					Nimi = nimed[i],
					Vanus = 50,
					Isikukood = Console.ReadLine(),
					Aadress = aadressid[i]
				};
			}
            return isikud;
        }
	}
}
