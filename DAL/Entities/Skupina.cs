using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Skupina
    {
        public static int LEN_ATTR_nazev = 50;

        public int skup_ID { get; set; }
        public String nazev { get; set; }
        public DateTime datum_zalozeni { get; set; }
        public List<Zamestnanec> zamestnanci { get; set; }

    }
}
