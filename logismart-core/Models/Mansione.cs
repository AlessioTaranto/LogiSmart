using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_core.Models
{
    public class Mansione
    {
        public long Id { get; set; }

        public long IdArea { get; set; }  

        public string NomeMansione { get; set; }

        public DateTime DataCreazione { get; set; }
    }
}
