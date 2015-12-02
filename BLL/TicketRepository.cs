using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface TicketRepository
    {
         List<Tiket> findAll();

         bool save(Tiket t);
    }
}
