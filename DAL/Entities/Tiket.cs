using System;

namespace DAL
{
    public class Tiket
    {

        public static int LEN_ATTR_nazev = 50;
        public static int LEN_ATTR_popis = 200;
        public static int LEN_ATTR_status = 20;
        public static int LEN_ATTR_uzav_pozn = 200;

        public int t_ID { get; set; }
        public String nazev { get; set; }
        public String popis { get; set; }
        public int priorita { get; set; }
        public DateTime vytvoreno { get; set; }
        public DateTime lhuta { get; set; }
        public String status { get; set; }
        public String uzav_pozn { get; set; }
        public int Zamestnanec_z_ID { get; set; }
        public int Kategorie_kat_ID { get; set; }
        public int Skupina_skup_ID { get; set; }
    }
}
