using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cxp.Model;
using System.Data.SqlClient;
using cxp.Data;
using cxp.data;
using cxp.Interfaces;



namespace cxp.Services
{
    public class TipoProductoService : ITipoProductoService
    {
        
            private readonly SqlConfiguration _configuration;
            private ITipoProductoRepository _TipoProductoRepository;
            public TipoProductoService(SqlConfiguration configuration)
            {
                _configuration = configuration;
                _TipoProductoRepository = new TipoProductoRepository(configuration.ConnectionString);
            }
            public Task<bool> DeleteTipoProducto(int id)
            {
                return _TipoProductoRepository.DeleteTipoProducto(id);
            }

            public Task<IEnumerable<TipoProducto>> GetAllTipoProducto()
            {
                return _TipoProductoRepository.GetAllTipoProducto();
            }

            public Task<TipoProducto> GetTipoProductoDetails(int id)
            {
                return _TipoProductoRepository.GetTipoProductoDetails(id);
            }

            public Task<bool> SaveTipoProducto(TipoProducto tipoProducto)
            {
                if (tipoProducto.IDTipoProducto == 0)
                    return _TipoProductoRepository.InsertTipoProducto(tipoProducto);
                else
                    return _TipoProductoRepository.UpdateTipoProducto(tipoProducto);
            }
    }
}

