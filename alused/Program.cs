using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.alused
{
    public class Program
    {
        static void Main1()
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

            õpetaja.Kirjelda();
            õpilane.Kirjelda();
        }
    }
}
