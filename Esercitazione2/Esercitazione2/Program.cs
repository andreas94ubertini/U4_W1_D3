using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Names = { "Marco", "Mario", "Federico", "Anna", "Roberta" };
            Console.WriteLine("Inserisci nome da trovare");
            string ToFind = Console.ReadLine();
            if (Names.Contains(ToFind))
            {
                Console.WriteLine("Trovato " + ToFind);
            }
            else
            {
                Console.WriteLine("Nome non presente nell'array");
            }

            Console.ReadLine();

            Console.WriteLine("Inserisci un numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            int[] Numbers = new int[numero];
            Random rnd = new Random();
            int somma = 0;
            for (int i = 0; i < Numbers.Length; i++) {
                int n = rnd.Next(99);
                Numbers[i] = n;
                Console.WriteLine(Numbers[i]);
                somma += Numbers[i];
            }
            int media = somma / Numbers.Length;
            Console.WriteLine("La somma di tutti i numeri è " + somma);
            Console.WriteLine("La media di tutti i numeri è " + media);
            Console.ReadLine() ;
        }

        
    }
}
