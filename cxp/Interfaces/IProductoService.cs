using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cxp.Model;

namespace cxp.Interfaces 
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> GetAllProducto();
        Task<Producto> GetProductoDetails(int id);
        Task<bool> DeleteProducto(int id);
        Task<bool> SaveProducto(Producto producto);

    }
}
