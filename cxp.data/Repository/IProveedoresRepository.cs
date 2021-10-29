using cxp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repository
{
    public interface IProveedoresRepository
    {
        Task<IEnumerable<proveedores>> GetAllProveedor();
        Task<IEnumerable<proveedores>> GetProveedorDetalles(int id);
        Task<bool> InsertProveedor(proveedores rproveedor);
        Task<bool> UpdateProveedor(proveedores rproveedor);
        Task<bool> DeleteProveedor(int id);
    }
}
