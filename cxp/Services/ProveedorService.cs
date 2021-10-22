using cxp.Data;
using cxp.Data.Dapper.Repositories;
using cxp.Model;
using cxp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Services
{
    public class ProveedorService : IProveedorService
    {
        private readonly SqlConfiguration _configuration;
        private IProveedorRepository _proveedorRepository;
        public ProveedorService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _proveedorRepository = new ProveedorRepository(configuration.ConnectionString);
        }
        public Task<bool> DeleteProveedor(int id)
        {
            return _proveedorRepository.DeleteProveedor(id);
        }

        public Task<IEnumerable<proveedor>> GetAllProveedor()
        {
            return _proveedorRepository.GetAllProveedor();
        }

        public Task<proveedor> GetDetails(int id)
        {
            return _proveedorRepository.GetProveedorDetails(id);
        }

        public Task<bool> SaveProveedor(proveedor prov)
        {
            if (prov.id_Proveedor == 0)
                return _proveedorRepository.InsertProveedor(prov);
            else
                return _proveedorRepository.UpdateProveedor(prov);
        }
    }
}
