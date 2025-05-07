using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharpC.alused
{
    public class Õpetaja : Isik1, ITööline, IHindaja
    {
        public double Tunnitasu { get; set; }
        public int TunnidNädalas { get; set; }

        //используем абстрактную функцию из абстрактного класса 
        public virtual double ArvutaPalk() // убрал override чтобы не было ошибок - почему?
        {   
            return Tunnitasu * TunnidNädalas * 4; // плата за месяц (4 недели)
        }

        public virtual void Hinda(string hinne)
        {

        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Õpetaja {Nimi}, vanus {Vanus}, teenib kuus {ArvutaPalk():F2}€");
        }
    }
}