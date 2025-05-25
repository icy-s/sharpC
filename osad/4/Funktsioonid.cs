using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.osad._4
{
    class Funktsioonid
    {
        public static string filePath = "C:/Users/xicey/source/repos/icy-s/sharpC/osad/4/Kuud.txt";

        public static void KirjutaKuudFaili()
        {
            Console.WriteLine("Kirjutame faili: " + Path.GetFullPath(filePath));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Jaanuar");
                writer.WriteLine("Veebruar");
                writer.WriteLine("Juuni");
            }
        }

        public static List<string> LoeKuudFailist()
        {
            List<string> kuud = new List<string>();
            if (File.Exists(filePath))
            {
                kuud.AddRange(File.ReadAllLines(filePath));
            }
            else
            {
                Console.WriteLine("Faili ei leitud!");
            }
            return kuud;
        }

        public static void KuvadaKuud(List<string> kuud)
        {
            Console.WriteLine("Kuud failist:");
            foreach (string kuu in kuud)
            {
                Console.WriteLine(kuu);
            }
        }

        public static void EemaldaJuuniJaMuudaEsimene(List<string> kuud)
        {
            kuud.Remove("Juuni");

            if (kuud.Count > 0)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Juuni oli eemaldatud!");
                Console.WriteLine($"Esimene kuu oli: {kuud[0]}");
                Console.Write("Sisesta uus kuu esimesele kohale: ");
                string uusKuu = Console.ReadLine();
                kuud[0] = uusKuu;
            }
        }

        public static void OtsiKuu(List<string> kuud)
        {
            Console.Write("Sisesta kuu nimi, mida otsida: ");
            string otsitav = Console.ReadLine();

            if (kuud.Any(k => k.Equals(otsitav, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"Kuu \"{otsitav}\" on olemas.");
            }
            else
            {
                Console.WriteLine("Sellist kuud pole.");
            }
        }

        public static void SalvestaKuud(List<string> kuud)
        {
            File.WriteAllLines(filePath, kuud);
            Console.WriteLine("Andmed on salvestatud faili: " + Path.GetFullPath(filePath));
        }
    }
}