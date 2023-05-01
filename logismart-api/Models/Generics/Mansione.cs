using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSmart.Api.Models.Generics
{
    public class Mansione
    {
        public long Id { get; set; }


        public long AreaMagazzinoId { get; set; }
        public required AreaMagazzino AreaMagazzino { get; set; }

        [Required]
        public required string Nome { get; set; }

        public string? Descrizione { get; set; }

        public required List<Attrezzatura> Attrezzature { get; set; }

        public required List<Operatore> Operatori { get; set; }

        public DateTime? DataInizio { get; set; }

        public DateTime? DataFine { get; set; }

        public DateTime? DataInizioPrevisto { get; set; }

        public DateTime? DataFinePrevisto { get; set; }
    }
}
