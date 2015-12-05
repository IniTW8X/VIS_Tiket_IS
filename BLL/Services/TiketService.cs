using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// data mappaer, repository, service layer, (dependency injection)
namespace BLL
{
    public class TiketService
    {
        TiketRepository tr;

        public TiketService()
        {
            tr = new DBTiketRepository();
        }

        public int getNewTiketID()
        {
            return tr.getLastID() + 1;
        }


        public DateTime calculateDeadline(DateTime dt, int priority)
        {
            if (priority == 1) dt = dt.AddDays(1);
            else if (priority == 2) dt = dt.AddDays(2);
            else if (priority == 3) dt = dt.AddDays(3);
            return dt;
        }

        public DateTime getDateTimeNow()
        {
            DateTime now = DateTime.Now;
            return now;
        }


        public int createNewTicket(String nazev, String popis, int priorita, int Kategorie_kat_ID)
        {
            Tiket t = new Tiket();
            t.nazev = nazev;
            t.popis = popis;
            t.priorita = priorita;
            t.vytvoreno = getDateTimeNow();
            t.lhuta = calculateDeadline(t.vytvoreno, priorita);
            t.status = "Novy";
            t.uzav_pozn = "";
            t.Zamestnanec_z_ID = 1; // default (prihlaseny) zamestnanec
            t.Kategorie_kat_ID = Kategorie_kat_ID;
            t.Skupina_skup_ID = 1; //default admin skupina

            return tr.saveTiket(t);
        }

        public List<String> getListOfAdminTikets()
        {
            List<String> ls = new List<String>();

            foreach (Tiket t in tr.getNewTikets())
            {
                ls.Add(t.t_ID + " - " + t.nazev);
            }
            return ls;
        }

        public String getDetailOfTiket(int t_ID)
        {
            Tiket t = new Tiket();
            t = tr.getDetails(t_ID);
            String s = t.nazev + ";" + t.popis + ";" + t.Kategorie_kat_ID;
            return s;
        }

        public int assignTiketToGroup(int t_ID, int skup_ID)
        {
            Tiket t = new Tiket();
            t = tr.getDetails(t_ID);
            t.Skupina_skup_ID = skup_ID;
            return tr.updateTiket(t);
        }

        public List<String> getListOfExpiredTikets()
        {
            List<String> ls = new List<String>();

            foreach (Tiket t in tr.getExpiredTikets())
            {
                ls.Add(t.t_ID + " - " + t.nazev + " - " + t.Zamestnanec_z_ID);
            }
            return ls;
        }
    }
}
