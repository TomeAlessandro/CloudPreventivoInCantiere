using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CantiereApp.Models
{
    public class Cantiere
    {
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public string Luogo { get; set; }
    }

    public class NuovoIntervento
    {
        public string NomeCliente { get; set; }
        public string Luogo { get; set; }
        public string Tipologia { get; set; }
        public string Lavoro { get; set; }
        public string Note { get; set; }
        public decimal Prezzo { get; set; }
        public string Foto { get; set; }
    }
}
