using System;
using System.Collections.Generic;
using cxp.Interfaces;
using System.Threading.Tasks;
using cxp.Model;
using cxp.Data;
using cxp.data.Repositories;

namespace cxp.Services
{
    public class PedidopagarServicecs : IPedidoPago
    {
        private readonly SqlConfiguration _configuration;
        private IPedidoPagarRepository _PPRepository;
        public PedidopagarServicecs(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _PPRepository = new PedidoPagarRepository(configuration.ConnectionString);
        }
      

        public Task<IEnumerable<Pedidopagar>> GetAllPedidopagar()
        {
            return _PPRepository.GetAllPedidopagar();
        }

       

        
    }
}
