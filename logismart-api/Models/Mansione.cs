using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_api.Models
{
    public class Mansione
    {
        public long Id { get; set; }

        public AreaMagazzino AreaMagazzino { get; set; }

        public List<Operatore> Operatori { get; set; }

        public List<AttrezzaturaDiLavoro> Attrezzature { get; set; }

        public DateTime? DataInizio { get; set; }

        public DateTime? DataFine { get; set; }

        public DateTime? DataInizioPrevisto { get; set; }

        public DateTime? DataFinePrevisto { get; set; }
    }
}
