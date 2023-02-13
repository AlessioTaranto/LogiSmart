using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_api.Models
{
    public class SlotAreaMagazzino
    {
        public long Id { get; set; }

        public AreaMagazzino AreaMagazzino { get; set; }

        public Operatore Operatore { get; set; }

        public string Codice { get; set; }

        public string? Descrizione { get; set; }

        public DateTime DataCreazione { get; set; }
    }
}
