using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_api.Models
{
    public class AreaMagazzino
    {
        public long Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string? Descrizione { get; set; }

        public bool Attivo { get; set; }

        [Required]
        public string NumeroContatto { get; set; }

        [Required]
        public string Mail { get; set; }
    }
}
