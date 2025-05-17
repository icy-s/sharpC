using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpC.kangelane
{
    class SuperKangelane : Kangelane
    {
        public double Osavus;

        public SuperKangelane(string nimi, string asukoht) : base(nimi, asukoht)
        {
            Random random = new Random();
            Osavus = 1.0 + random.NextDouble() * (5.0 - 1.0);  // [1.0, 5.0)
        }
        public override int Paasta(int ohus)
        {
            return (int)(0.9 * ohus + Osavus);
        }
        public override string Vormiriietus()
        {
            return "Leegikindel kostüüm, holograafiline visiir, jõuvälja kindad, gravitatsioonivabad saapad";
        }

        public override string Tervitus()
        {
            return "Tere! Olen superkangelane, õiglus ei maga – mina ka mitte!";
        }

        public override string ToString()
        {
            return $"""
            Superkangelase andmed:
            Nimi: {nimi}
            Asukoht: {asukoht}
            Osavus: {Osavus:F2}
            Vormiriietus: {Vormiriietus()}
            Tervitus: {Tervitus()}
            Missiooni staatus: {MissiooniStaatus()}
            """;
        }


    }
}
