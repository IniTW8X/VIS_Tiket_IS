using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Kategorie
    {
        public static int LEN_ATTR_nazev = 30;
        public static int LEN_ATTR_popis = 200;

        public int kat_ID { get; set; }
        public String nazev { get; set; }
        public String popis { get; set; }
        public int aktivni { get; set; }
    }
}
