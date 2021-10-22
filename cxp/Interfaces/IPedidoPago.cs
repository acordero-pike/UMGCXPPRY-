using System;
using System.Collections.Generic;
using System.Linq;
using cxp.Model;
using System.Threading.Tasks;

namespace cxp.Interfaces
{
    public interface IPedidoPago
    {
        Task<IEnumerable<Pedidopagar>> GetAllPedidopagar();
       
    }
}
