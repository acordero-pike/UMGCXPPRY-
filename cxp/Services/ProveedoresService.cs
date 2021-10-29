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
    public class ProveedoresService : IProveedorService
    {
        private readonly SqlConfiguration _configuration;
        private IProveedoresRepository _proveedorRepository;

        public ProveedoresService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _proveedorRepository = new ProveedoresRepository(configuration.ConnectionString);
        }
        public Task<bool> DeleteProveedor(int id)
        {
            return _proveedorRepository.DeleteProveedor(id);
        }

        public Task<IEnumerable<proveedores>> GetAllProveedor()
        {
            return _proveedorRepository.GetAllProveedor();
        }

        public Task<IEnumerable<proveedores>> GetProveedorDetalles(int id)
        {
            return _proveedorRepository.GetProveedorDetalles(id);
        }

        public Task<bool> InsertProveedor(proveedores rproveedor)
        {
            return _proveedorRepository.InsertProveedor(rproveedor);
        }

        public Task<bool> UpdateProveedor(proveedores rproveedor)
        {
            return _proveedorRepository.UpdateProveedor(rproveedor);
        }
    }
}
