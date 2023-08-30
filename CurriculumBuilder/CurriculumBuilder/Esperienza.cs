using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumBuilder
{
    internal class Esperienza
    {
        public string Azienda { get; set; }
        public string JobTitle { get; set; }
        public string Inizio { get; set; }
        public string Fine { get; set; }
        public string Descrizione { get; set; }
        public string Compiti { get; set; }

        public Esperienza() { }
        public Esperienza(string azienda, string jobTitle, string inizio, string fine, string descrizione, string compiti)
        {
            Azienda = azienda;
            JobTitle = jobTitle;
            Inizio = inizio;
            Fine = fine;
            Descrizione = descrizione;
            Compiti = compiti;
        }
    }
}
