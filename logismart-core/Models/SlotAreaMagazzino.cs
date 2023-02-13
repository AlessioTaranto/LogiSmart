using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_core.Models
{
    public class SlotAreaMagazzino
    {
        public long Id { get; set; }

        public long IdAreaMagazzino { get; set; }

        public long IdOperatore { get; set; }   

        public string Codice { get; set; }

        public string? Descrizione { get; set; }

        public DateTime DataCreazione { get; set; }
    }
}
