using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    internal class Finanze
    {
        public double Saldo { get; set; }
        public double Entrate { get; set; }
        public double Uscite { get; set; }

       public Finanze() { }
        public Finanze(double saldo)
        {
            Saldo = saldo;
        }
    }
}
