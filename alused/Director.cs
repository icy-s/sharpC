using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.alused
{
    internal class Director : Õpetaja, ITööline
    {
        public double Lisatasu { get; set; }
        public override double ArvutaPalk()
        {
            return Tunnitasu * TunnidNädalas * 4 + Lisatasu; // плата за месяц (4 недели)
        }
    }
}
