using cxp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Interfaces
{
   public interface IAbono
    {
        Task<IEnumerable<Abonos>> Getall(int id);
        Task<Abonos> GetDetails(int id);
        Task<bool> Deletepaga(int id);
        Task<bool> Savepaga(Abonos AB);
    }
}
