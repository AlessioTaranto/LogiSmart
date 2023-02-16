using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogiSmart.Api.Models
{
    public class Magazzino
    {
        public long Id { get; set; }

        [Required]
        public required string Nome { get; set; }

        [Required]
        public required string Indirizzo { get; set; }

        [Required]
        public required string NumeroTelefono { get; set; }

        [Required]
        public required string Mail { get; set; }

        public required List<Mansione> Mansioni { get; set; }

        public required List<Azienda> Azienda { get; set; }

        public required List<AreaMagazzino> AreaMagazzino { get; set; }

        public required List<Operatore> Operatori { get; set; }
    }
}