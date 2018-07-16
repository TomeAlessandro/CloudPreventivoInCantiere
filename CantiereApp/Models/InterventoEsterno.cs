using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CantiereApp.Models
{
    public class InterventoEsterno
    {
        public string NomeCliente { get; set; }
        public string Luogo { get; set; }
        public DateTime Data { get; set; }
        public string Lavoro { get; set; }
    }

    public class NuovoInterventoEsterno
    {
        public string NomeCliente { get; set; }
        public string Luogo { get; set; }
        public string Lavoro { get; set; }
        public string Note { get; set; }
        public string Foto { get; set; }
    }
}
