using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using cxp.Model;

namespace cxp.data
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetAllProducto();
        Task<Producto> GetProductoDetails(int id);
        Task<bool> InsertProducto(Producto Producto);
        Task<bool> UpdateProducto(Producto Producto);
        Task<bool> DeleteProducto(int id);




    }

}
