using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_api.Models
{
    public class Operatore
    {
        public long Id { get; set; }

        public Azienda Azienda { get; set; }

        public string Nome { get; set; }

        public DateTime DataDiNascita { get; set; }

        public SessoOperatore Sesso { get; set; }

        public enum SessoOperatore
        {
            UOMO = 0,
            DONNA = 1,
        }

        public string LuogoDiNascita { get; set; }

        public string IndirizzoDiDomicilio { get; set; }

        public string CodiceFiscale { get; set; }

        public string NumeroContatto { get; set; }

        public string Mail { get; set; }

        public string Pec { get; set; }

        public string CodiceOperatore { get; set; }

        public DateTime DataCrazione { get; set; }
    }
}
