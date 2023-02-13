using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_core.Models
{
    public class AttrezzaturaDiLavoro
    {
        public long Id { get; set; }    

        public long IdAreaMagazzino { get; set; }

        public long? IdOperatore { get; set; }

        public bool Attivo { get; set; }

        public string NomeAttrezzatura { get; set; }

        public DateTime DataUltimaModifica { get; set; }

        public DateTime DataCreazione { get; set; }


    }
}
