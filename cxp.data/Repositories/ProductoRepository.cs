using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using cxp.Model;
using Dapper;



namespace cxp.data
{
    public class ProductoRepository : IProductoRepository
    {
        private string ConnectionString;
        public ProductoRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public async Task<bool> DeleteProducto(int id)
        {
            var db = dbConnection();

            var sql = @"Delete From Producto where ID_Producto = @id";
            var resulado = await db.ExecuteAsync(sql.ToString(), new { Id = id });
            return resulado > 0;
        }

        public async Task<IEnumerable<Producto>> GetAllProducto()
        {
            var db = dbConnection();
            var sql = @"SELECT ID_Producto as IDProducto, Nombre_P as NombreP, ID_Tipo_Producto as IDTipoProducto ,Stock,Precio FROM Producto";

            return await db.QueryAsync<Producto>(sql.ToString(), new { });
        }

        public async Task<Producto> GetProductoDetails(int id)
        {
            var db = dbConnection();
            var sql = @"SELECT ID_Producto as IDProducto, Nombre_P as NombreP, ID_Tipo_Producto as IDTipoProducto ,Stock,Precio FROM Producto WHERE ID_Producto = @id";

            return await db.QueryFirstOrDefaultAsync<Producto>(sql.ToString(), new { id = id });
        }

        public async Task<bool> InsertProducto(Producto producto)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Producto(Nombre_P,ID_Tipo_Producto,Stock,Precio)
                        VALUES(@NombreP, @IDTipoProducto, @Stock, @Precio)";

            var result = await db.ExecuteAsync(sql.ToString(),
                new { producto.NombreP, producto.IDTipoProducto, producto.Stock, producto.Precio }
                );

            return result > 0;

        }

        public async Task<bool> UpdateProducto(Producto producto)
        {
            var db = dbConnection();
            var sql = @"UPDATE [Producto]
                        SET Nombre_P = @NombreP,
                            ID_Tipo_Producto = @IDTipoProducto,
                            Stock = @Stock,
                            Precio = @Precio
                        WHERE ID_Producto = @Id";
            var result = await db.ExecuteAsync(sql.ToString(),
                new { producto.NombreP, producto.IDTipoProducto, producto.Stock, producto.Precio, Id = producto.IDProducto});
            return result > 0;
        }









    }
}
