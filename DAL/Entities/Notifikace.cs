using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Notifikace
    {
        public static int LEN_ATTR_text = 140;

        public int n_ID { get; set; }
        public String text { get; set; }
        public int Zamestnanec_z_ID { get; set; }
        public int Tiket_t_ID { get; set; }
    }
}
