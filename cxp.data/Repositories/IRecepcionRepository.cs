using cxp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repositories
{
   public interface IRecepcionRepository
    {
        Task<IEnumerable<PedidoRecepcion>> GetAll();
        Task<bool> Recibir(int id);
    }
}
