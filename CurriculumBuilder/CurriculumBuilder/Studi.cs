using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumBuilder
{
    internal class Studi
    {
        public string Qualifica { get; set; }
        public string Istituto { get; set; }
        public string Tipo { get; set; }
        public string Inizio { get; set; }
        public string Fine { get; set; }

        public Studi() { }
        public Studi(string qualifica, string istituto, string tipo, string inizio, string fine)
        {
            Qualifica = qualifica;
            Istituto = istituto;
            Tipo = tipo;
            Inizio = inizio;
            Fine = fine;
        }
    }
}
