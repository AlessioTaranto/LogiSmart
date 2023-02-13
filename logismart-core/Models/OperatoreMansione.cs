using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_core.Models
{
    public class OperatoreMansione
    {
        public long Id { get; set; }

        public long IdOperatore { get; set; }

        public long IdMansione { get; set; }

        public DateTime DataCreazione { get; set; }
    }
}
