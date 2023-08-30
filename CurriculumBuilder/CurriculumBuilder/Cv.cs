using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumBuilder
{
    internal class Cv
    {
        public InformazioniPersonali Info { get; set; }
        public List<Studi> StudiEffettuati { get; set; }
        public List<Impiego> Impieghi { get; set; }

        public void GetCv()
        {
            Console.WriteLine("***************Inizio Curriculum*******************");
            Console.WriteLine("Il Curriculum di "+ Info.Nome + " " + Info.Cogome);
            Console.WriteLine("Email "+ Info.Email + " Telefono: " + Info.Telefono);
            Console.WriteLine();
            foreach (Studi studio in StudiEffettuati)
            {
                Console.WriteLine("***************Inizio Studio*******************");
                Console.WriteLine("Data di inizio " + studio.Inizio + " Data di fine" + studio.Fine);
                Console.WriteLine("Istituto: " + studio.Istituto);
                Console.WriteLine("Tipo: " + studio.Tipo);
                Console.WriteLine("Qualifica: " + studio.Qualifica);
                Console.WriteLine("***************Fine Studio*********************");
            }
            Console.WriteLine();
            foreach (Impiego impiego in Impieghi)
            {
                Console.WriteLine("***************Inizio Impiego*******************");
                Console.WriteLine("Data di inizio " + impiego.Esperienza.Inizio + " Data di fine" + impiego.Esperienza.Fine);
                Console.WriteLine("Azienda: " + impiego.Esperienza.Azienda);
                Console.WriteLine("Ruolo: " + impiego.Esperienza.JobTitle);
                Console.WriteLine("Descrizione: " + impiego.Esperienza.Descrizione);
                Console.WriteLine("***************Fine Impiego*********************");

            }

        }

    }

}
