using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.alused
{
    internal class Üliõpilane : Õpilane
    {
        public string Eriala { get; set; }

        public override void Kirjelda()
        {
            Console.WriteLine($"{Nimi} õpib {Eriala} erialal.");
        }
    }
}
