using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace sharpC.osad._2
{
    class Program
	{
		static void Main(string[] args)
		{
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
            }

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
		}

	}
}