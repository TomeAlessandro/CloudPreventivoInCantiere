using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CantiereApp.Models
{
    public class Intervento
    {
        [Key]
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public DateTime Data { get; set; }
        public string Luogo { get; set; }
        public string Tipologia { get; set; }
        public string Lavoro { get; set; }
        public string Note { get; set; }
        public decimal Prezzo { get; set; }
        public string Foto { get; set; }
    }
}
