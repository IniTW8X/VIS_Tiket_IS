using DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface TiketRepository
    {
        int saveTiket(Tiket t);
        int getLastID();
        Collection<Tiket> getNewTikets();
        Tiket getDetails(int t_ID);
        int updateTiket(Tiket t);
        Collection<Tiket> getExpiredTikets();

    }
}
