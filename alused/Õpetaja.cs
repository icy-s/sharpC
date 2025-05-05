using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.alused
{
    public class Õpetaja : Isik1, ITööline
    {
        public double Tunnitasu { get; set; }
        public int TunnidNädalas { get; set; }

        //используем абстрактную функцию из абстрактного класса 
        public double ArvutaPalk()
        {   // плата за месяц (4 недели)
            return Tunnitasu * TunnidNädalas * 4;
        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Õpetaja {Nimi}, vanus {Vanus}, teenib kuus {ArvutaPalk():F2}€");
        }
    }
}