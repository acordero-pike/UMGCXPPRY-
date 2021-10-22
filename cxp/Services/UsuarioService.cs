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
    public class UsuarioService : IUsuarioService
    {
        private readonly SqlConfiguration _configuration;
        private IUsuarioRepository _usuarioRepository;
        public UsuarioService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _usuarioRepository = new UsuarioRepository(configuration.ConnectionString);
        }
        public Task<bool> DeleteUsuario(int id)
        {
            return _usuarioRepository.DeleteUsuario(id);
        }

        public Task<IEnumerable<usuario>> GetAllUsuario()
        {
            return _usuarioRepository.GetAllUsuario();
        }

        public Task<usuario> GetDetails(int id)
        {
            return _usuarioRepository.GetUsuarioDetails(id);
        }

        public Task<bool> SaveUsuario(usuario usu)
        {
            if (usu.ID_Usuario == 0)
                return _usuarioRepository.InsertUsuario(usu);
            else
                return _usuarioRepository.UpdateUsuario(usu);
        }
    }
}
