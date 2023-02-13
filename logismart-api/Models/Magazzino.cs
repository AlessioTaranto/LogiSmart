using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_api.Models
{
    public class Magazzino
    {
        public long Id { get; set; }

        public Operatore Responsabile { get; set; }

        public string Nome { get; set; }

        public string NumeroContatto { get; set; }

        public string Mail { get; set; }

        public DateTime DataCreazione { get; set; }
    }
}
