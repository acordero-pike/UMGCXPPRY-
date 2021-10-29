using cxp.data.Repository;
using cxp.Data;
using cxp.Interface;
using cxp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Services
{
    public class PedidoDetalleService : IPedidoDetalleService
    {
        private readonly SqlConfiguration _configuration;
        private IPedidoDetalleRepository _pedidoDetalleRepository;

        public PedidoDetalleService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _pedidoDetalleRepository = new PedidoDetalleRepository(configuration.ConnectionString);
        }

        public Task<bool> DeleteDetallePedidoAll(int id)
        {
            return _pedidoDetalleRepository.DeleteDetallePedidoAll(id);
        }

        public Task<bool> DeletePedidoDetalle(int id, int iddetalle)
        {
            return _pedidoDetalleRepository.DeletePedidoDetalle(id, iddetalle);
        }

        public Task<IEnumerable<PedidoDetalle>> GetAllPedidoDetalle()
        {
            return _pedidoDetalleRepository.GetAllPedidoDetalle();
        }

        public Task<PedidoDetalle> GetDetallePedido(int id)
        {
            return _pedidoDetalleRepository.GetDetallePedido(id);
        }

        public Task<IEnumerable<PedidoDetalle>> GetListaPedidoDetalle(int id)
        {
            return _pedidoDetalleRepository.GetListaPedidoDetalle(id);
        }

        public Task<PedidoDetalle> GetPedidoDetalles(int id, int idDetalle)
        {
            return _pedidoDetalleRepository.GetPedidoDetalles(id, idDetalle);
        }

        public Task<bool> InsertPedidoDetalle(PedidoDetalle pedido)
        {
            return _pedidoDetalleRepository.InsertPedidoDetalle(pedido);
        }

        public Task<bool> UpdatePedidoDetalle(PedidoDetalle pedido)
        {
            return _pedidoDetalleRepository.UpdatePedidoDetalle(pedido);
        }
    }
}
