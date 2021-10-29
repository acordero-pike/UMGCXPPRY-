using cxp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repository
{
    public interface IPedidoDetalleRepository
    {
        Task<bool> DeleteDetallePedidoAll(int id);
        Task<IEnumerable<PedidoDetalle>> GetAllPedidoDetalle();
        Task<PedidoDetalle> GetPedidoDetalles(int id, int idDetalle);
        Task<bool> InsertPedidoDetalle(PedidoDetalle pedido);
        Task<bool> UpdatePedidoDetalle(PedidoDetalle pedido);
        Task<bool> DeletePedidoDetalle(int id, int iddetalle);
        Task<PedidoDetalle> GetDetallePedido(int id);
        Task<IEnumerable<PedidoDetalle>> GetListaPedidoDetalle(int id);
    }
}
