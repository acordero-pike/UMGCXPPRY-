using cxp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Interfaces
{
   public interface IRecepcion
    {
        Task<IEnumerable<PedidoRecepcion>> GetAll();
        Task<bool> Recibir(int id);
    }
}
