﻿using logismart_core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_core.Models
{
    public class Azienda
    {
        public long Id { get; set; }w

        public string Nome { get; set; }

        public string Indirizzo { get;  set; }

        public string NumeroContatto { get; set; }

        public string Mail { get; set; }

        public string PartitaIva { get; set; }

        public string? CodiceUnivoco { get; set; }

        public string? Pec { get; set; }

        public DateTime DataCreazione { get; set; }
    }
}
