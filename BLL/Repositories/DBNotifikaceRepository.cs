using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Repositories
{
    public class DBNotifikaceRepository : NotifikaceRepository
    {
        NotifikaceMapper nm;

        public DBNotifikaceRepository()
        {
            this.nm = new NotifikaceMapper();
        }

        public int saveNotification(Notifikace n)
        {
            return nm.insert(n);
        }
    }
}
