using cxp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Interface
{
    public interface IProveedorService
    {
        Task<IEnumerable<proveedores>> GetAllProveedor();
        Task<IEnumerable<proveedores>> GetProveedorDetalles(int id);
        Task<bool> InsertProveedor(proveedores rproveedor);
        Task<bool> UpdateProveedor(proveedores rproveedor);
        Task<bool> DeleteProveedor(int id);
    }
}
