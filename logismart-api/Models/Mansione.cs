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

        public string NomeMansione { get; set; }

        public DateTime DataCreazione { get; set; }
    }
}
