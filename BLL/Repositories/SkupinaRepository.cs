using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public interface SkupinaRepository
    {
        Collection<Skupina> getSkupiny();
    }
}
