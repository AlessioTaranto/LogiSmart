using LogiSmart.Api.Models.Generics;
using System.ComponentModel.DataAnnotations;

namespace LogiSmart.Api.Models.Dto
{
    public class MagazzinoDto
    {
        [Required]
        public required string Nome { get; set; }

        [Required]
        public required string Indirizzo { get; set; }

        [Required]
        public required string NumeroTelefono { get; set; }

        [Required]
        public required string Mail { get; set; }

        public Magazzino ToDbEntity()
            => new()
            {
                Nome = Nome,
                Indirizzo = Indirizzo,
                NumeroTelefono = NumeroTelefono,
                Mail = Mail
            };
    }
}
