using cxp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repositories
{
    public  interface IPedidoPagarRepository
    {
        Task<IEnumerable<Pedidopagar>> GetAllPedidopagar();
      
    }
}
