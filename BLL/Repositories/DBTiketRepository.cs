﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Mappers;
using System.Collections.ObjectModel;

namespace BLL
{
    public class DBTiketRepository : TiketRepository
    {

        TiketMapper tm;

        public DBTiketRepository()
        {
            this.tm = new TiketMapper();
        }

        public int getLastID()
        {
            Collection<Tiket> tics = tm.selectAll();
            return tics.Count();
        }

        public int saveTiket(Tiket t)
        {
            return tm.insert(t);
        }
    }
}
