using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_api.Models
{
    // TODO pattern validation
    public class Azienda
    {
        public long Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Indirizzo { get; set; }

        [Required]
        //[RegularExpression("[789][0-9]{9}")]
        public string NumeroContatto { get; set; }

        [Required]
        //[RegularExpression("[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$")]
        public string Mail { get; set; }

        // TODO validazione partita iva estera
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        public string PartitaIva { get; set; }

        [MinLength(7)]
        [MaxLength(7)]
        public string? CodiceUnivoco { get; set; }

        public string? Pec { get; set; }
    }
}
