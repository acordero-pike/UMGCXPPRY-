using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using cxp.Model;
using Dapper;

namespace cxp.data
{
        public class TipoProductoRepository : ITipoProductoRepository
        {
            private string ConnectionString;
            public TipoProductoRepository(string connectionString)
            {
                ConnectionString = connectionString;
            }
            protected SqlConnection dbConnection()
            {
                return new SqlConnection(ConnectionString);
            }

            public async Task<bool> DeleteTipoProducto(int id)
            {
                var db = dbConnection();

                var sql = @"Delete From Tipo_Producto where ID_Tipo_Producto = @id";
                var resulado = await db.ExecuteAsync(sql.ToString(), new { Id= id });
                return resulado > 0;
            }

            public async Task<IEnumerable<TipoProducto>> GetAllTipoProducto()
            {
                var db = dbConnection();
                var sql = @"SELECT ID_Tipo_Producto as IDTipoProducto , Nombre_Producto as NombreProducto FROM Tipo_Producto";

                return await db.QueryAsync<TipoProducto>(sql.ToString(), new { });
            }

            public async Task<TipoProducto> GetTipoProductoDetails(int id)
            {
                var db = dbConnection();
                var sql = @"SELECT ID_Tipo_Producto as IDTipoProducto, Nombre_Producto as NombreProducto  FROM Tipo_Producto WHERE ID_Tipo_Producto = @id";

                return await db.QueryFirstOrDefaultAsync<TipoProducto>(sql.ToString(), new { id = id });
            }

            public async Task<bool> InsertTipoProducto(TipoProducto tipoProducto)
            {
                var db = dbConnection();

                var sql = @"INSERT INTO Tipo_Producto(Nombre_Producto)
                        VALUES(@NombreProducto)";

                var result = await db.ExecuteAsync(sql.ToString(),
                    new { tipoProducto.NombreProducto }
                    );

                return result > 0;

            }

            public async Task<bool> UpdateTipoProducto(TipoProducto tipoProducto)
            {
                var db = dbConnection();
                var sql = @"UPDATE [Tipo_Producto]
                        SET Nombre_Producto = @NombreProducto
                        WHERE ID_Tipo_Producto = @Id";
                var result = await db.ExecuteAsync(sql.ToString(),
                    new { tipoProducto.NombreProducto, Id = tipoProducto.IDTipoProducto});
                return result > 0;
            }
        
        }  
    }



