using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSmart.Api.Models
{
    public class AreaMagazzino
    {
        public long Id { get; set; }

        [Required]
        public long MagazzinoId { get; set; }
        public required Magazzino Magazzino { get; set; }

        public List<Mansione> Mansioni { get; set; }

        [Required]
        public required string Nome { get; set; }

        public string? Descrizione { get; set; }

        [Required]
        public bool Attivo { get; set; }

        [Required]
        public required string NumeroContatto { get; set; }

        [Required]
        public required string Mail { get; set; }
    }
}
