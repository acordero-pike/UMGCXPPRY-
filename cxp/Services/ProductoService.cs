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
    public class ProductoService : IProductoService
    {
        private readonly SqlConfiguration _configuration;
        private IProductoRepository _productoRepository;

        public ProductoService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _productoRepository = new ProductoRepository(configuration.ConnectionString);
        }

        public Task<IEnumerable<Productos>> GetAllProductos()
        {
            return _productoRepository.GetAllProductos();
        }

        public Task<Productos> GetProductosDetalles(int id)
        {
            return _productoRepository.GetProductosDetalles(id);
        }
    }
}
