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
    public class PedidoService : IPedidoService
    {
        private readonly SqlConfiguration _configuration;
        private IPedidoRepository _pedidoRepository;

        public PedidoService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _pedidoRepository = new PedidoRepository(configuration.ConnectionString);
        }
        public Task<bool> DeletePedido(int id)
        {
           return _pedidoRepository.DeletePedido(id);
        }

        public Task<IEnumerable<Pedidos>> GetAllPedido()
        {
            return _pedidoRepository.GetAllPedido();
        }

        public Task<IEnumerable<Pedidos>> GetPedidoDetalles(int id)
        {
            return _pedidoRepository.GetPedidoDetalles(id);
        }

        public Task<bool> InsertPedido(Pedidos pedido)
        {
            return _pedidoRepository.InsertPedido(pedido);
        }

        public Task<bool> UpdateMonto(int id)
        {
            return _pedidoRepository.UpdateMonto(id);
        }

        public Task<bool> UpdatePedido(Pedidos pedido)
        {
            return _pedidoRepository.UpdatePedido(pedido);
        }
    }
}
