﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_api.Models
{
    public class AreaMagazzino
    {
        public long Id { get; set; }

        public Magazzino Magazzino { get; set; }

        public Operatore ResponsabileArea { get; set; }

        public string Nome { get; set; }

        public string? Descrizione { get; set; }

        public bool Attivo { get; set; }

        public string NumeroContatto { get; set; }

        public string Mail { get; set; }

        public DateTime DataUltimaModifica { get; set; }

        public DateTime DataCreazione { get; set; }
    }
}
