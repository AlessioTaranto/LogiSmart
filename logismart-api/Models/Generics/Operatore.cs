using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSmart.Api.Models.Generics
{
    // TODO pattern validation
    // TODO CLeanup
    public class Operatore
    {
        public long Id { get; set; }


        public long AziendaId { get; set; }

        public required Azienda Azienda { get; set; }

        public long? MansioneId { get; set; }
        public Mansione? Mansione { get; set; }


        [Required]
        public required string Nome { get; set; }

        public DateTime DataDiNascita { get; set; }

        public SessoOperatore Sesso { get; set; }

        public enum SessoOperatore
        {
            UOMO = 0,
            DONNA = 1,
        }

        [Required]
        public required string LuogoDiNascita { get; set; }

        [Required]
        public required string IndirizzoDiDomicilio { get; set; }

        [Required]
        public required string CodiceFiscale { get; set; }

        [Required]
        public required string NumeroContatto { get; set; }

        [Required]
        public required string Mail { get; set; }

        [Required]
        public required string Pec { get; set; }

        [Required]
        public required bool Attivo { get; set; }

        public string? CodiceOperatore { get; set; }
    }
}
