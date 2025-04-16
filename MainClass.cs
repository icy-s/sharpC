﻿using System;
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
			// 2. osa (Kordused, massivid, listid, klassid)
			Isik isik1 = new Isik("Juku", 65, "123456789901", "Tallinn");
			isik1.PrindiInfo();
			Isik isik2 = new Isik();
			isik2.Nimi = "Mari";
			isik2.Aadress = "Tartu";
			isik2.Isikukood = "987654321";
			isik2.Sugu = Sugu.Naine;
			isik2.PrindiInfo();

			int i;
			Console.WriteLine("-----for++Massiv-----");
			Isik[] isikud = new Isik[10];
			string[] nimed = new string[10] { "Juku", "Mari", "Kati", "Peeter", "Mati", "Liina", "Katrin", "Andres", "Marko", "Kristi" };
			string[] aadresid = new string[10] { "Tallinn", "Tartu", "Pärnu", "Narva", "Kohtla-Järve", "Viljandi", "Rakvere", "Paide", "Jõhvi", "Kuressaare" };
			for (i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
				//isikud[i] = new Isik();
				Console.Write("Isikukood: ");
				isikud[i] = new Isik
				{
					Nimi = nimed[i],
					Vanus = 50,
					Isikukood = Console.ReadLine(),
					Aadress = aadresid[i],
				};
			}
			
			
			
			
			
	
			for (i = 0; i < 10; i++)
			{
				isikud[i].PrindiInfo();
			}
			Console.WriteLine("-----for-----");
            for (int j = i; j > 0; j--)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("-----while-----");
            while (i > 0)
			{
				Console.WriteLine(i);
				i--;
			}
            Console.WriteLine("-----do-----");
			ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
			{
				Console.WriteLine("Vajuta Backspace");
				key = Console.ReadKey();
			}
			while (key.Key!= ConsoleKey.Backspace);

            // 1. osa (Andmetüübid, if, case, random, alamfunktsioonid
            /*Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Tere!");
			int a = 0;
			string tekst = "Python";
			char taht = 'A';
			double arv = 5.4536237287;
			float arv1 = 2;
			Console.Write("Mis on sinu nimi? ");
			tekst = Console.ReadLine();
			Console.WriteLine("Tere!\n"+tekst);
			Console.WriteLine("Tere!\n {0}",tekst);
			if (tekst.ToLower() == "juku")
			{
				Console.WriteLine("Lähme kinno!");
				try
				{
					Console.WriteLine("{0}\n Kui vana sa oled?", tekst);
					int vanus = int.Parse(Console.ReadLine());
					if (vanus<=0 || vanus>100) // && - and, || - or
                    {
						Console.WriteLine("Viga!");
					}
					else if (vanus > 0 && vanus <= 6)
					{
						Console.WriteLine("Tasuta");
					}
					else if (vanus < 15)
					{
						Console.WriteLine("Lastepilet");
					}
					else if (vanus <= 65)
					{
						Console.WriteLine("Täispilet!");
					}
					else if (vanus <= 100)
					{
						Console.WriteLine("Sooduspilet!");
					}

				}
				catch (Exception e)
				{
					Console.WriteLine(e);
				}
			}
			else
			{
				Console.WriteLine("Olen hõivatud!");
			}




			/*Console.WriteLine("Arv 2: ");
			int arv2 = int.Parse(Console.ReadLine());
			//Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
			arv1 = FunktsioonideClass.Kalkulaator(a, arv2);
			Console.WriteLine(arv1);


            //päivää
            Console.WriteLine("Enter weekday number!");
            //tekst = string.Parse(Console.ReadLine());
            tekst = FunktsioonideClass_1osa.Nadalapaevad(a, tekst);
            Console.WriteLine(tekst);




            /*Console.WriteLine("Switch'i kasutamine");
			Random rnd = new Random();
			a = rnd.Next(1,7);
			Console.WriteLine(a);
			switch (a)
			{
				case 1: tekst = "Esmaspäev";break;
                case 2: tekst = "Teisipäev"; break;
                case 3: tekst = "Kolmapäev"; break;
                case 4: tekst = "Neljapäev"; break;
                case 5: tekst = "Reede"; break;
                case 6: tekst = "Laupäev"; break;
                case 7: tekst = "Pühapäev"; break;

                default:
					tekst = "Tundmatu";
					break;
			}
			*/
            Console.ReadKey();
		}

	}
}