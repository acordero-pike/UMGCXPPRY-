using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cxp.Model;

namespace cxp.Interfaces
{
    public interface ITipoProductoService
    {
            Task<IEnumerable<TipoProducto>> GetAllTipoProducto();
            Task<TipoProducto> GetTipoProductoDetails(int id);
            Task<bool> DeleteTipoProducto(int id);
            Task<bool> SaveTipoProducto(TipoProducto tipoProducto);

    }
}

