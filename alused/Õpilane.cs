using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.alused
{
    public class Õpilane : Isik1
    {
        public string Kool {  get; set; }
        public int Klass { get; set; }

        public override void Kirjelda()
        {
            Console.WriteLine($"{Nimi} on {Vanus}-aastane õpilane, õpib {Kool} {Klass}. klassis.");
        }
    }
}
