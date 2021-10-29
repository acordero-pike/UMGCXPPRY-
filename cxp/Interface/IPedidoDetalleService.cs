using cxp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Interface
{
    public interface IPedidoDetalleService
    {
        Task<IEnumerable<PedidoDetalle>> GetAllPedidoDetalle();
        Task<PedidoDetalle> GetPedidoDetalles(int id, int idDetalle);
        Task<bool> InsertPedidoDetalle(PedidoDetalle pedido);
        Task<bool> UpdatePedidoDetalle(PedidoDetalle pedido);
        Task<bool> DeletePedidoDetalle(int id, int iddetalle);
        Task<bool> DeleteDetallePedidoAll(int id);
        Task<PedidoDetalle> GetDetallePedido(int id);
        Task<IEnumerable<PedidoDetalle>> GetListaPedidoDetalle(int id);

    }
}
