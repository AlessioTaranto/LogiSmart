using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSmart.Api.Models.Generics
{
    // TODO pattern validation
    public class Azienda
    {
        public long Id { get; set; }

        public long MagazzinoId { get; set; }
        public required Magazzino Magazzino { get; set; }

        [Required]
        public required string Nome { get; set; }

        [Required]
        public required string Indirizzo { get; set; }

        [Required]
        public required string NumeroContatto { get; set; }

        [Required]
        public required string Mail { get; set; }

        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        public required string PartitaIva { get; set; }

        [MinLength(7)]
        [MaxLength(7)]
        public required string? CodiceUnivoco { get; set; }

        public string? Pec { get; set; }

        [Required]
        public bool Attivo { get; set; }
    }
}
