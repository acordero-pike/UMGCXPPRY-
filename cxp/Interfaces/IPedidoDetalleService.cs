using cxp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Interfaces
{
    public interface IPedidoDetalleService
    {
        Task<IEnumerable<PedidoDetalle>> GetAllPedidoDetalle();
        Task<PedidoDetalle> GetPedidoDetalles(long id, int idDetalle);
        Task<bool> InsertPedidoDetalle(PedidoDetalle pedido);
        Task<bool> UpdatePedidoDetalle(PedidoDetalle pedido);
        Task<bool> DeletePedidoDetalle(long id, int iddetalle);
        Task<bool> DeleteDetallePedidoAll(long id);
        Task<PedidoDetalle> GetDetallePedido(long id);
        Task<IEnumerable<PedidoDetalle>> GetListaPedidoDetalle(long id);

    }
}
