using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.osad._5
{
        class Arvud_massiiv
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Sisesta arv eraldatud tühikuga (nt: 2 5 9 7):");
                double[] arvud = TekstistArvud(Console.ReadLine());

                if (arvud.Length == 0)
                {
                    Console.WriteLine("Pole ühtegi kehtivat arvu!");
                    return;
                }

                Console.WriteLine($"\nMaksimum: {arvud.Max()}");
                Console.WriteLine($"Miinimum: {arvud.Min()}");
                Console.WriteLine($"Keskmine: {arvud.Average():F2}");
                Console.WriteLine($"Kogusumma: {arvud.Sum()}");

                double keskmine = arvud.Average();
                int suuremadKuiKeskmine = arvud.Count(x => x > keskmine);
                Console.WriteLine($"Arve, mis on suuremad kui keskmine: {suuremadKuiKeskmine}");

                Console.WriteLine("\nSorteeritud arvud:");
                Array.Sort(arvud);
                foreach (var arv in arvud)
                {
                    Console.Write(arv + " ");
                }
                Console.WriteLine();
            }

            static double[] TekstistArvud(string sisend)
            {
                string[] osad = sisend.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                return osad
                    .Select(s =>
                    {
                        if (double.TryParse(s.Replace(',', '.'), out double tulemus))
                            return tulemus;
                        else
                            return double.NaN;
                    })
                    .Where(x => !double.IsNaN(x))
                    .ToArray();
            }
        }
    }