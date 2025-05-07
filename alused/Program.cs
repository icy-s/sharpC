using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.alused
{
    class Program
    {
        static void Main()
        {
            Õpetaja õpetaja = new Õpetaja
            {
                Nimi = "Mari Maasikas",
                Sünniaasta = 1985,
                Tunnitasu = 20,
                TunnidNädalas = 25
            };

            Õpilane õpilane = new Õpilane
            {
                Nimi = "Juku Jänes",
                Sünniaasta = 2010,
                Kool = "Tallinna Reaalkool",
                Klass = 9
            };

            Director director = new Director
            {
                Nimi = "Ants Antson",
                Sünniaasta = 1970,
                Tunnitasu = 30,
                TunnidNädalas = 20,
                Lisatasu = 500
            };

            Üliõpilane tudeng = new Üliõpilane
            {
                Nimi = "Kaisa Kask",
                Sünniaasta = 2002,
                Kool = "TÜ",
                Klass = 1,
                Eriala = "Informaatika"
            };


            õpetaja.Kirjelda();
            õpilane.Kirjelda();
            director.Kirjelda();
            tudeng.Kirjelda();
        }
    }
}
