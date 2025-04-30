using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC
{
    public abstract class Isik1
    {
        // инкапсуляция - приватное поле, публичное свойство
        private int sünniaasta;

        public string Nimi { get; set; }
        public int Sünniaasta
        {
            get { return sünniaasta; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    sünniaasta = value;
            }
        }

        // рассчитанное свойство (только getter, то есть не производится изменения значения set)
        public int Vanus => DateTime.Now.Year - sünniaasta;

        // абстрактный метод - должен быть реализован в подклассах, потому что у каждого человека свое собственное описание
        public abstract void Kirjelda();
    }
}