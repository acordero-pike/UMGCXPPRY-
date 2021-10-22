using cxp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<usuario>> GetAllUsuario();
        Task<usuario> GetDetails(int id_usuario);
        Task<bool> DeleteUsuario(int id_usuario);
        Task<bool> SaveUsuario(usuario usu);
    }
}
