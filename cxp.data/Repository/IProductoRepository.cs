using cxp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repository
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Productos>> GetAllProductos();
        Task<Productos> GetProductosDetalles(int id);

    }
}
