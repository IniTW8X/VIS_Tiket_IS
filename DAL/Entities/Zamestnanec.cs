using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Zamestnanec
    {
        public static int LEN_ATTR_jmeno = 20;
        public static int LEN_ATTR_prijmeni = 20;
        public static int LEN_ATTR_pozice = 20;
        public static int LEN_ATTR_poznamka = 200;

        public int z_ID { get; set; }
        public String jmeno { get; set; }
        public String prijmeni { get; set; }
        public DateTime datum_narozeni { get; set; }
        public String pozice { get; set; }
        public int platova_trida { get; set; }
        public int Oddeleni_o_ID { get; set; }
        public String poznamka { get; set; }
    }
}
