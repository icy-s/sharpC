using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.osad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Kirjuta 3 kuud faili
            Funktsioonid.KirjutaKuudFaili();

            // 2. Loe kuud listi
            List<string> kuud = Funktsioonid.LoeKuudFailist();

            // 3. Kuva kuud
            Funktsioonid.KuvadaKuud(kuud);

            // 4. Eemalda Juuni, muuda esimene
            Funktsioonid.EemaldaJuuniJaMuudaEsimene(kuud);

            // 5. Kuva uuesti
            Console.WriteLine("\nMuudetud kuud:");
            Funktsioonid.KuvadaKuud(kuud);

            // 6. Otsi kuud
            Funktsioonid.OtsiKuu(kuud);

            // 7. Salvesta muudatused
            Funktsioonid.SalvestaKuud(kuud);
        }
    }
}
