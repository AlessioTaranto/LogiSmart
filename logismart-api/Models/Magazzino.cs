using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace logismart_api.Models
{
    public class Magazzino
    {
        public long Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Indirizzo { get; set; }

        [Required]
        public string NumeroTelefono { get; set; }

        [Required]
        public string Mail { get; set; }
    }
}