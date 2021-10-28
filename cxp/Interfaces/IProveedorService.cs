using cxp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Interfaces
{
    public interface IProveedorService
    {
        Task<IEnumerable<proveedor>> GetAllProveedor();
        Task<proveedor> GetDetails(int id_Proveedor);
        Task<bool> DeleteProveedor(int id_Proveedor);
        Task<bool> SaveProveedor(proveedor prov);
    }
}
