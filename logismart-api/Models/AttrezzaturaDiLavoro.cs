using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_api.Models
{
    public class AttrezzaturaDiLavoro
    {
        public long Id { get; set; }

        public AreaMagazzino AreaMagazzino { get; set; }

        public Operatore Operatore { get; set; }

        public bool Attivo { get; set; }

        [Required]
        public string NomeAttrezzatura { get; set; }
    }
}
