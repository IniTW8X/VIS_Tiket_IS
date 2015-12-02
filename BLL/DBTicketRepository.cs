using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Mappers;

namespace BLL
{
    class DBTicketRepository : TicketRepository
    {

        TiketMapper mapper;

        public DBTicketRepository()
        {
            this.mapper = new TiketMapper();
        }

        public List<Tiket> findAll()
        {
            throw new NotImplementedException();
        }

        public bool save(Tiket t)
        {
            throw new NotImplementedException();
        }
    }
}
