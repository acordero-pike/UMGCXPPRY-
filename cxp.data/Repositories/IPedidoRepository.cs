using cxp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repository
{
    public interface IPedidoRepository
    {
        Task<IEnumerable<Pedidos>> GetAllPedido();
        Task<IEnumerable<Pedidos>> GetPedidoDetalles(long id);
        Task<bool> InsertPedido(Pedidos pedido);
        Task<bool> UpdatePedido(Pedidos pedido);
        Task<bool> UpdateMonto(long id);
        Task<bool> DeletePedido(long id);
    }
}
