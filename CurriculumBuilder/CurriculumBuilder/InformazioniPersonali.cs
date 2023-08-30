using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumBuilder
{
    internal class InformazioniPersonali
    {
        public string Nome { get; set; }
        public string Cogome { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public InformazioniPersonali() { }
        public InformazioniPersonali(string nome, string cogome, string telefono, string email)
        {
            Nome = nome;
            Cogome = cogome;
            Telefono = telefono;
            Email = email;

        }
    }
}
