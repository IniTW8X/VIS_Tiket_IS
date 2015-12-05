using BLL;
using BLL.Services;
using DAL;
using DAL.Entities;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIS_projekt
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());

            //TiketService ts = new TiketService();
            //NotifikaceService ns = new NotifikaceService();




            //Console.WriteLine(ts.getNewTiketID());
            //Console.WriteLine(ts.createNewTicket("nazev", "popis", 3, 1)); // pokud vrati 1 tak vse OK
            //foreach (String b in ts.getListOfAdminTikets())
            //Console.WriteLine(b);
            //Console.WriteLine(ts.getDetailOfTiket(1));
            //Console.WriteLine(ts.assignTiketToGroup(3, 2)); // jestli 1 tak vse OK
            //Console.WriteLine(ns.createNewNotification("textdsjahndans", 1, 1));
            //foreach (String b in ts.getListOfExpiredTikets())
            //Console.WriteLine(b);



            //Tiket
            //TiketMapper tm = new TiketMapper();
            // insert
            // Tiket t1 = new Tiket();
            //t1.nazev = "ahoj";
            // t1.popis = "popis";
            // t1.priorita = 1;
            // t1.vytvoreno = new DateTime(2012, 7, 15); ;
            // t1.lhuta = new DateTime(2012, 7, 15); ;
            // t1.status = "popis";
            // t1.uzav_pozn = "popis";
            // t1.Zamestnanec_z_ID = 1;
            // t1.Kategorie_kat_ID = 1;
            // t1.Skupina_skup_ID = 1;
            // tm.insert(t1);
            //update
            //t1.t_ID = 3;
            //t1.status = "Novy";
            //tm.update(t1);
            //Tiket t2 = tm.selectOne(1);
            //Console.WriteLine(t2.nazev);
            //Collection<Tiket> tiks1 = tm.selectAll();
            //foreach (Tiket b in tiks1)
            //Console.WriteLine(b.t_ID + "\t" + b.nazev);

            //Kategorie
            //KategorieMapper km = new KategorieMapper();
            //Kategorie k = new Kategorie();
            //k.nazev = "updated";
            //k.popis = "test2";
            //k.aktivni = 1;
            //k.kat_ID = 1002;
            //km.update(k);
            //k = km.selectOne(1);
            //Console.WriteLine(k.nazev);
            //Collection<Kategorie> kats1 = km.selectAll();
            //foreach (Kategorie b in kats1)
            //    Console.WriteLine(b.kat_ID + "\t" + b.nazev);

            //Zamestnanec
            //ZamestnanecMapper zm = new ZamestnanecMapper();
            //Zamestnanec z = new Zamestnanec();
            //z.jmeno = "petr2";
            //z.prijmeni = "luna";
            //z.datum_narozeni = new DateTime(2012, 1, 1);
            //z.pozice = "neco";
            //z.platova_trida = 1;
            //z.Oddeleni_o_ID = 1;
            //z.poznamka = "";
            //z.z_ID = 1;
            //zm.insert(z);
            //zm.update(z);
            //z = zm.selectOne(1);
            //Console.WriteLine(z.jmeno);
            //Collection<Zamestnanec> zams = zm.selectAll();
            //foreach (Zamestnanec b in zams)
            //    Console.WriteLine(b.z_ID + "\t" + b.jmeno);

            //Oddeleni
            //OddeleniMapper om = new OddeleniMapper();
            //Oddeleni o = new Oddeleni();
            //o.nazev = "test2";
            //o.pocet_zamestnancu = 1;
            //o.poznamka = "";
            //o.o_ID = 1002;
            //om.insert(o);
            //om.update(o);
            //o = om.selectOne(1);
            //Console.WriteLine(o.nazev);
            //Collection<Oddeleni> ods = om.selectAll();
            //foreach (Oddeleni b in ods)
            //   Console.WriteLine(b.o_ID + "\t" + b.nazev);

            //Notifikace
            //NotifikaceMapper nm = new NotifikaceMapper();
            //Notifikace n = new Notifikace();
            //n.text = "ahoj";
            //n.Zamestnanec_z_ID = 1;
            //n.Tiket_t_ID = 1;
            //nm.insert(n);
            //Collection<Notifikace> nots = nm.selectAll();
            //foreach (Notifikace b in nots)
            //    Console.WriteLine(b.n_ID + "\t" + b.text);

            //Skupina
            //SkupinaMapper sm = new SkupinaMapper();
            //Skupina s = new Skupina();
            //Collection<Skupina> skups = sm.selectAll();
            //foreach (Skupina b in skups)
            //    Console.WriteLine(b.skup_ID + "\t" + b.nazev);



            Console.WriteLine("OK");

        }
    }
}
