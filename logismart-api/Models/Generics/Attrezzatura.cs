using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSmart.Api.Models.Generics
{
    public class Attrezzatura
    {
        public long Id { get; set; }

        public bool Attivo { get; set; }

        [Required]
        public required string NomeAttrezzatura { get; set; }

        public long? MansioneId { get; set; }
        public Mansione? Mansione { get; set; }
    }
}
