using BLL.Repositories;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SkupinaService
    {
        SkupinaRepository sr;

        public SkupinaService()
        {
            sr = new DBSkupinaRepository();
        }

        public List<String> getSkupiny()
        {
            List<String> ls = new List<String>();

            foreach (Skupina s in sr.getSkupiny())
            {
                ls.Add(s.nazev);
            }
            return ls;
        }
    }
}
