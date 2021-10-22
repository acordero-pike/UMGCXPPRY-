using cxp.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace cxp.Data.Dapper.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private string ConneciontString;
        public ProveedorRepository(string connectionString)
        {
            ConneciontString = connectionString;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConneciontString);
        }

        public async Task<bool> DeleteProveedor(int id)
        {
            var db = dbConnection();

            var sql = @"DELETE FROM Proveedor where ID_Proveedor = @id";
            var result = await db.ExecuteAsync(sql.ToString(),
                new { Id = id });
            return result > 0;
        }

        public async Task<IEnumerable<proveedor>> GetAllProveedor()
        {
            var db = dbConnection();
            var sql = @"SELECT Nombre, Descripcion, Direccion, Telefono, Tiempo
                        FROM Proveedor ";
            return await db.QueryAsync<proveedor>(sql.ToString(), new { });
        }

        public async Task<proveedor> GetProveedorDetails(int id)
        {
            var db = dbConnection();
            var sql = @"SELECT Nombre, Descripcion, Direccion, Telefono, Tiempo 
                        FROM Proveedor 
                        WHERE ID_Proveedor = @id";
            return await db.QueryFirstOrDefaultAsync<proveedor>(sql.ToString(),
                new { Id = id });
        }

        public async Task<bool> InsertProveedor(proveedor prov)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Proveedor(Nombre, Descripcion, Direccion, Telefono, Tiempo)
                        VALUES(@Nombre, @Descripcion, @Direccion, @Telefono, @Tiempo)";

            var result = await db.ExecuteAsync(sql.ToString(),
                new { prov.Nombre, prov.Descripcion, prov.Direccion, prov.Telefono, prov.Tiempo }
                );

            return result > 0;


        }

        public async Task<bool> UpdateProveedor(proveedor prov)
        {
            var db = dbConnection();
            var sql = @"UPDATE [dbo].[Proveedor]
                        SET Nombre = @Nombre, 
                            Descripcion = @Descripcion,
                            Direccion = @Direccion,
                            Telefono = @Telefono,
                            Tiempo = @Tiempo
                        WHERE ID_Proveedor = @id";
            var result = await db.ExecuteAsync(sql.ToString(),
                new { prov.Nombre, prov.Descripcion, prov.Direccion, prov.Telefono, prov.Tiempo, prov.ID_Proveedor });
            return result > 0;
        }

    }
}
