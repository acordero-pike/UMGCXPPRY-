using cxp.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace cxp.Data.Dapper.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string ConneciontString;
        public UsuarioRepository(string connectionString)
        {
            ConneciontString = connectionString;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConneciontString);
        }

        public async Task<bool> DeleteUsuario(int id)
        {
            var db = dbConnection();

            var sql = @"DELETE FROM Usuario where ID_Usuario = @id";
            var result = await db.ExecuteAsync(sql.ToString(),
                new { Id = id });
            return result > 0;
        }

        public async Task<IEnumerable<usuario>> GetAllUsuario()
        {
            var db = dbConnection();
            var sql = @"SELECT Nombre, Apellido_P, Apellido_S, Correo, Tipo_Usuario, Contraseña
                        FROM Usuario ";
            return await db.QueryAsync<usuario>(sql.ToString(), new { });
        }

        public async Task<usuario> GetUsuarioDetails(int id)
        {
            var db = dbConnection();
            var sql = @"SELECT Nombre, Apellido_P, Apellido_S, Correo, Tipo_Usuario, Contraseña 
                        FROM Usuario 
                        WHERE ID_Usuario = @id";
            return await db.QueryFirstOrDefaultAsync<usuario>(sql.ToString(),
                new { Id = id });
        }

        public async Task<bool> InsertUsuario(usuario usu)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Usuario(Nombre, Apellido_P, Apellido_S, Correo, Tipo_Usuario, Contraseña)
                        VALUES(@Nombre, @Apellido_P, @Apellido_S, @Correo, @Tipo_Usuario, @Contraseña)";

            var result = await db.ExecuteAsync(sql.ToString(),
                new { usu.Nombre, usu.Apellido_P, usu.Apellido_S, usu.Correo, usu.Tipo_Usuario, usu.Contraseña }
                );

            return result > 0;


        }

        public async Task<bool> UpdateUsuario( usuario usu)
        {
            var db = dbConnection();
            var sql = @"UPDATE Usuario
                        SET Nombre = @Nombre, 
                            Apellido_P = @Apellido_P,
                            Apellido_S = @Apellido_S,
                            Correo = @Correo,
                            Tipo_Usuario = @Tipo_Usuario,
                            Contraseña = @Contraseña
                        WHERE ID_Usuario = @id";
            var result = await db.ExecuteAsync(sql.ToString(),
                new { usu.Nombre, usu.Apellido_P, usu.Apellido_S, usu.Correo, usu.Tipo_Usuario, usu.Contraseña, usu.ID_Usuario});
            return result > 0;
        }

    }
}
