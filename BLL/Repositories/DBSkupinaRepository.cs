using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using System.Collections.ObjectModel;

namespace BLL.Repositories
{
    public class DBSkupinaRepository : SkupinaRepository 
    {
        SkupinaMapper sm;

        public DBSkupinaRepository()
        {
            this.sm = new SkupinaMapper();
        }

        public Collection<Skupina> getSkupiny()
        {
            return sm.selectAll();
        }
    }
}
