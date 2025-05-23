﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace sharpC.osad
{
    class Program
	{
		static void Main(string[] args)
		{
            // 2. osa (Kordused, massivid, listid, klassid)
            int a = 0;
            {
                Console.WriteLine("Tere tulemast! Sisesta oma nimi: ");
                string eesnimi = Console.ReadLine();
                Console.WriteLine("Tere, " + eesnimi);
                if (eesnimi.ToLower() == "juku")
                {
                    try
                    {
                        Console.WriteLine("Tule minu juurde külla!\nKui vana sa oled?");
                        int vanus = int.Parse(Console.ReadLine());
                        if (vanus <= 0 || vanus > 100)  // && - and, || - or
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
                        else if (vanus >= 15 && vanus < 65)
                        {
                            Console.WriteLine("Täispilet!");
                        }
                        else
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
                    Console.WriteLine("Täna mind kodus pole!");
                }
                /*int arv1 = int.Parse(Console.ReadLine());
                int arv2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
                Console.ReadLine();*/
            }

            Console.WriteLine("Switch'i kasutamine");
            Random rnd = new Random();
            a = rnd.Next(1, 7);
            Console.WriteLine(a);

            Console.WriteLine("Küsin esimese inimese nimi?");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Küsin teise inimese nimi?");
            string nimi2 = Console.ReadLine();
            string tekst1 = FunktsioonideClass_1osa.pinginaabrid(nimi1, nimi2);
            Console.WriteLine(tekst1);


            Console.Write("Sisestage esimese seina pikkus:");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sisestage teise seina pikkus:");
            double b1 = Convert.ToDouble(Console.ReadLine());
            double vastus = FunktsioonideClass_1osa.Korrutamine(a1, b1);
            Console.WriteLine("Põranda pindala on " + vastus);
            Console.Write("Kas soovite remodi teha?");
            string vastus2 = Console.ReadLine();
            if (vastus2.ToLower() == "jah")
            {
                Console.Write("Sisestage kui palju maksab ruutmeeter:");
                double hind = Convert.ToDouble(Console.ReadLine());
                double vastus3 = FunktsioonideClass_1osa.Korrutamine(hind, vastus);
                Console.WriteLine("Põranda vahetamise hind on " + vastus3);
            }
            else
            {
                Console.WriteLine("Aitäh! Head aega!");
            }
            Console.Write("Sisestage alghind: ");
            double alghind = Convert.ToDouble(Console.ReadLine());
            vastus = FunktsioonideClass_1osa.Hinnasoodustus(alghind);
            Console.WriteLine("Soodustusega 30% lõpphind on " + vastus);

            Console.Write("Sisestage toa temperatuur: ");
            int temp = int.Parse(Console.ReadLine());
            vastus2 = FunktsioonideClass_1osa.Temperatuur(temp);
            Console.WriteLine(vastus2);

            Console.Write("Sisestage oma pikkus: ");
            int pikkus = int.Parse(Console.ReadLine());
            vastus2 = FunktsioonideClass_1osa.Pikkus(pikkus);
            Console.WriteLine(vastus2);

            Console.Write("Sisestage oma pikkus: ");
            pikkus = int.Parse(Console.ReadLine());
            Console.Write("Sisestage oma sugu: ");
            string sugu = Console.ReadLine();
            vastus2 = FunktsioonideClass_1osa.PikkusSugu(pikkus, sugu);
            Console.WriteLine(vastus2);

            Console.Write("Kas te soovite osta piima? (jah/ei): ");
            string piim_vastus = Console.ReadLine();
            Console.Write("Kas te soovite osta saia? (jah/ei): ");
            string sai_vastus = Console.ReadLine();
            Console.Write("Kas te soovite osta leiba? (jah/ei): ");
            string leib_vastus = Console.ReadLine();
            string tulemus = FunktsioonideClass_1osa.Pood(piim_vastus, sai_vastus, leib_vastus);
            Console.WriteLine(tulemus);

            Console.ReadKey();




            /*List<string> sonad = FunktsioonideClass_2osa.Sõnad();

			foreach (var item in sonad)
			{
				Console.WriteLine(item);
			}

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
			string[] nimed = new string[10] { "Juku", "Mari", "Kati", "Peeter", "Mati", "Liina", "Katrin", "Andres", "Marko", "Kristi" };
			string[] aadressid = new string[10] { "Tallinn", "Tartu", "Pärnu", "Narva", "Kohtla-Järve", "Viljandi", "Rakvere", "Paide", "Jõhvi", "Kuressaare" };
            Isik[] isikud = FunktsioonideClass_2osa.Isikud(nimed.Length, nimed, aadressid);
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
					Aadress = aadressid[i],
				};
			}
	
			for (i = 0; i < 10; i++)
			{
				isikud[i].PrindiInfo();
			}

			Console.WriteLine("-----for--List-----");
			List<Isik> isikud2 = new List<Isik>();
            for (int j = i-1; j > -1; j--)
            {
                Console.WriteLine(j);
				Isik isik = new Isik
				{
					Nimi = nimed[j],
					Vanus = 50,
					Isikukood = "1111111111",
					Aadress = aadressid[j],
				};
				isikud2.Add(isik);
            }
			foreach (Isik isik in isikud2)
			{
				isik.PrindiInfo();
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
			while (key.Key!= ConsoleKey.Backspace);*/

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