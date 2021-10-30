using cxp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repositories
{
    public interface IAbonoRepository
    {
        Task<IEnumerable<Abonos>> Getall(long id);
        Task<Abonos> GetDetails(int id);

        Task<bool> Deletepaga(int id);
        Task<bool> Savepaga(Abonos AB);
        Task<bool> Editpaga(Abonos AB);
    }
}
