﻿using DAL;
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
            //Application.Run(new Form1());
            //Tiket
            // TiketMapper tm = new TiketMapper();
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
            //Collection<Tiket> tiks1 = tm.selectNove();
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
            ///Collection<Zamestnanec> zams = zm.selectAll();
            //foreach (Zamestnanec b in zams)
            //    Console.WriteLine(b.z_ID + "\t" + b.jmeno);



            Console.WriteLine("OK");

        }
    }
}
