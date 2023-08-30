using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    internal class ContoCorrente
    {
        public Persona Intestatario { get; set; } 
        public Finanze Finanze { get; set; } 
        int NumeroPin { get; set; }
        public ContoCorrente(int numeroPin)
        {
            NumeroPin = numeroPin;
        }

        public void Deposita(double eur)
        {
            Finanze.Saldo += eur;
            Console.WriteLine("Aggiunti " + eur + " Eur sul tuo conto " + Finanze.Saldo);
        }
        public void Preleva(double eur)
        {
            if ((Finanze.Saldo - eur) >= 0)
            {
                Finanze.Saldo -= eur;
                Console.WriteLine("Prelevati " + eur + " Eur sul tuo conto " + Finanze.Saldo);
            }
            else
            {
                Console.WriteLine("Non hai fondi sufficenti per effettuare il prelevo");
            }

        }
    }
}
