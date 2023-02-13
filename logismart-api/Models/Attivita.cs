using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_api.Models
{
    public class Attivita
    {
        public long Id { get; set; }

        public Operatore Operatore { get; set; }

        public Mansione Mansione { get; set; }

        public DateTime? DataInizio { get; set; }

        public DateTime? DataFine { get; set; }

        public DateTime? DataInizioPrevisto { get; set; }

        public DateTime? DataFinePrevisto { get; set; }
    }
}
