using cxp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repository
{
    public interface IPedidoDetalleRepository
    {
        Task<bool> DeleteDetallePedidoAll(long id);
        Task<IEnumerable<PedidoDetalle>> GetAllPedidoDetalle();
        Task<PedidoDetalle> GetPedidoDetalles(long id, int idDetalle);
        Task<bool> InsertPedidoDetalle(PedidoDetalle pedido);
        Task<bool> UpdatePedidoDetalle(PedidoDetalle pedido);
        Task<bool> DeletePedidoDetalle(long id, int iddetalle);
        Task<PedidoDetalle> GetDetallePedido(long id);
        Task<IEnumerable<PedidoDetalle>> GetListaPedidoDetalle(long id);
    }
}
