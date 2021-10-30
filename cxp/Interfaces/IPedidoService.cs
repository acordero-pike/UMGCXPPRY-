using cxp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Interfaces
{
    public interface IPedidoService
    {
        Task<IEnumerable<Pedidos>> GetAllPedido();
        Task<IEnumerable<Pedidos>> GetPedidoDetalles(int id);
        Task<bool> InsertPedido(Pedidos pedido);
        Task<bool> UpdatePedido(Pedidos pedido);
        Task<bool> UpdateMonto(long id);
        Task<bool> DeletePedido(long id);
    }
}
