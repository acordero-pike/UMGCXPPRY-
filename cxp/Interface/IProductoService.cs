using cxp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Interface
{
    public interface IProductoService
    {
        Task<IEnumerable<Productos>> GetAllProductos();
        Task<Productos> GetProductosDetalles(int id);
    }
}
