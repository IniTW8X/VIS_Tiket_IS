using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public interface NotifikaceRepository
    {
        int saveNotification(Notifikace n);
    }
}
