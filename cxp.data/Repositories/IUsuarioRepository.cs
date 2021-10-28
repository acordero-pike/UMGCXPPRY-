using cxp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cxp.Data.Dapper.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<usuario>> GetAllUsuario();
        Task<usuario> GetUsuarioDetails(int id);
        Task<bool> InsertUsuario(usuario usu);
        Task<bool> UpdateUsuario(usuario usu);
        Task<bool> DeleteUsuario(int id);

    }
}
