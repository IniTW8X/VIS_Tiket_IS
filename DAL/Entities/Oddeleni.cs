using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Oddeleni
    {
        public static int LEN_ATTR_nazev = 20;
        public static int LEN_ATTR_poznamka = 200;

        public int o_ID { get; set; }
        public String nazev { get; set; }
        public int pocet_zamestnancu { get; set; }
        public String poznamka { get; set; }
    }
}
