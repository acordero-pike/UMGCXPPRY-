using cxp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cxp.Data.Dapper.Repositories
{
    public interface IProveedorRepository
    {
        Task<IEnumerable<proveedor>> GetAllProveedor();
        Task<proveedor> GetProveedorDetails(int id);
        Task<bool> InsertProveedor(proveedor prov);
        Task<bool> UpdateProveedor(proveedor prov);
        Task<bool> DeleteProveedor(int id);

    }
}
