using Ayesha1281246.Repositories;
using Ayesha1281246.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayesha1281246.Factrories
{
    public interface IRepositoryFactory
    {
        IGenericRepository<T> GetRepo<T>() where T:Entity, new();
    }
}
