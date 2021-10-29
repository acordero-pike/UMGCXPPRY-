using cxp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repository
{
    public interface IUsuariosRepository
    {
        Task<IEnumerable<usuarios>> GetAllUsuarios();
        Task<IEnumerable<usuarios>> GetUsuariosDetalles(int id);
        Task<bool> InsertUsuarios(usuarios rusuarios);
        Task<bool> UpdateUsuarios(usuarios rusuarios);
        Task<bool> DeleteUsuarios(int id);
    }
}
