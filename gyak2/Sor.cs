using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak2
{
    internal class Sor
    {
        public int Darab { get; set; }
        public string Ertek { get; set; }

        public decimal Meret { get; set; }

        public Sor(int darab,string ertek, decimal meret)
        {
            Darab = darab;
            Ertek = ertek;
            Meret = meret;
        }
    }
}
