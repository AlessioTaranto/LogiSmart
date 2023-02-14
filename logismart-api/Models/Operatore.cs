using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_api.Models
{
    // TODO pattern validation
    public class Operatore
    {
        public long Id { get; set; }

        public long AziendaId { get; set; }

        public Azienda Azienda { get; set; }



        [Required]
        public string Nome { get; set; }

        public DateTime DataDiNascita { get; set; }

        public SessoOperatore Sesso { get; set; }

        public enum SessoOperatore
        {
            UOMO = 0,
            DONNA = 1,
        }

        [Required]
        public string LuogoDiNascita { get; set; }

        [Required]
        public string IndirizzoDiDomicilio { get; set; }

        [Required]
        public string CodiceFiscale { get; set; }

        [Required]
        public string NumeroContatto { get; set; }

        [Required]
        public string Mail { get; set; }

        [Required]
        public string Pec { get; set; }

        [Required]
        public bool Attivo { get; set; }

        public string CodiceOperatore { get; set; }
    }
}
