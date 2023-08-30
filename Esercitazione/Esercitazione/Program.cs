using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Console.WriteLine("Inserisci nome intestario:");
            persona.Nome = Console.ReadLine();
            Console.WriteLine("Inserisci cognome intestatario:");
            persona.Cognome = Console.ReadLine();
            Console.WriteLine("Inserisci un pin di 4 cifre:");
            int numeroPin = Convert.ToInt32(Console.ReadLine());
            Finanze finanze = new Finanze();
            Console.WriteLine("Effettua un deposito di almeno 1.000 euro per aprire il tuo conto");
            Console.WriteLine("Quanto vuoi depositare?");
            int PrimoDeposito = Convert.ToInt32(Console.ReadLine());
            if (PrimoDeposito < 1000)
            {
                Console.WriteLine("Deposita almeno 1.000 euro per aprire il tuo conto, ricomincia la procedura per favore");

            }
            else
            {
                finanze.Saldo += PrimoDeposito;
                ContoCorrente conto = new ContoCorrente(numeroPin);
                conto.Intestatario = persona;
                conto.Finanze = finanze;


                Console.WriteLine("Ora puoi effettuare operazione di deposito e prelievo");
                bool condition = false;
                Console.WriteLine("Inserisci il pin per continuare");
                int pin = Convert.ToInt32(Console.ReadLine());
                if (pin == numeroPin)
                {
                    condition = true;
                }
                else
                {
                    Console.WriteLine("Pin errato");
                }
                while (condition)
                {
                    Console.WriteLine("Premi 1 per prelevare, 2 per depositare oppure 3 per uscire");
                    string chioce = Console.ReadLine();
                    if (chioce == "1")
                    {
                        Console.WriteLine("Fondi disponibili: " + conto.Finanze.Saldo + " Eur");
                        Console.WriteLine("Quanto desideri prelevare?");
                        double eur = Convert.ToDouble(Console.ReadLine());
                        conto.Preleva(eur);
                    }
                    if (chioce == "2")
                    {
                        Console.WriteLine("Fondi disponibili: " + conto.Finanze.Saldo + " Eur");
                        Console.WriteLine("Quanto desideri depositare?");
                        double eur = Convert.ToDouble(Console.ReadLine());
                        conto.Deposita(eur);
                    }
                    if (chioce == "3")
                    {
                        condition = false;
                        Console.WriteLine("Grazie, arrivederci");
                    }
                }

            }


            Console.ReadLine();
        }
    }
}
