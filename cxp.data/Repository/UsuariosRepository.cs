using cxp.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repository
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private string ConnectionString;
        public UsuariosRepository(string connecctionString)
        {
            ConnectionString = connecctionString;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public async Task<bool> DeleteUsuarios(int id)
        {
            var db = dbConnection();
            var sql = @"DELETE Usuario where ID_Usuario = @id";

            var result = await db.ExecuteAsync(sql.ToString(),
                new { Id = id });
            return result > 0;

        }

        public async Task<IEnumerable<usuarios>> GetAllUsuarios()
        {
            var db = dbConnection();
            var sql = @"SELECT ID_Usuario as id_usuario, Nombre as nombre, Apellido_P as apellidop, Apellido_S as apellidos, 
                               Correo as email, ID_Tipo_Usuario as id_tipo_usuario, Contraseña as password
                        FROM   Usuario";

            try
            {
                return await db.QueryAsync<usuarios>(sql.ToString(), new { });
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
                throw;
            }
        }

        public Task<IEnumerable<usuarios>> GetUsuariosDetalles(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertUsuarios(usuarios rusuarios)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUsuarios(usuarios rusuarios)
        {
            throw new NotImplementedException();
        }
    }
}
