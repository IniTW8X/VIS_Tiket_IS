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
            if (priority == 1) dt.AddDays(1);
            else if (priority == 2) dt.AddDays(2);
            else if (priority == 3) dt.AddDays(3);
            return dt;
        }


        //public bool createNewTicket(..., ..., priority)
        //{
        //    Ticket t = new Ticket();
        //    t.setDeadline(this.calculateDeadline(priority));

        //    return this.repository.save(t);
        //}

    }
}
