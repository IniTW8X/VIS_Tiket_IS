using BLL.Repositories;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NotifikaceService
    {
        NotifikaceRepository nr;

        public NotifikaceService()
        {
            nr = new DBNotifikaceRepository();
        }

        public int createNewNotification(String text, int Zamestnanec_z_ID, int Tiket_t_ID)
        {
            Notifikace n = new Notifikace();
            n.text = text;
            n.Zamestnanec_z_ID = Zamestnanec_z_ID;
            n.Tiket_t_ID = Tiket_t_ID;
            return nr.saveNotification(n);
        }

    }
}
