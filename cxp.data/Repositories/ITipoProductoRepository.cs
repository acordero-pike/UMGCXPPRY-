using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using cxp.Model;

namespace cxp.data
{
    public interface ITipoProductoRepository
    {
        Task<IEnumerable<TipoProducto>> GetAllTipoProducto();
        Task<TipoProducto> GetTipoProductoDetails(int id);
        Task<bool> InsertTipoProducto(TipoProducto tipoProducto);
        Task<bool> UpdateTipoProducto(TipoProducto tipoProducto);
        Task<bool> DeleteTipoProducto(int id);
    }
}
