using cxp.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private string ConnectionString;
        public ProductoRepository(string connecctionString)
        {
            ConnectionString = connecctionString;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public  async Task<IEnumerable<Productos>> GetAllProductos()
        {
            var db = dbConnection();
            Console.WriteLine("estado coneccion " + db.State);
            var sql = @"SELECT ID_Producto as idproducto, Nombre_P as nombreproducto, ID_Tipo_Producto as idtipoproducto, Stock as stock, Precio as precio
                        FROM   Producto";
            try
            {
                return await db.QueryAsync<Productos>(sql.ToString(), new { });

            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
                throw;
            }
        }

        public async Task<Productos> GetProductosDetalles(int id)
        {
            var db = dbConnection();
            Console.WriteLine("estado coneccion " + db.State);
            var sql = @"SELECT ID_Producto as idproducto, Nombre_P as nombreproducto, ID_Tipo_Producto as idtipoproducto, Stock as stock, Precio as precio
                        FROM   Producto
                        WHERE  ID_Producto = @id";
            try
            {
                return await db.QueryFirstOrDefaultAsync<Productos>(sql.ToString(), new { Id = id });

            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
                throw;
            }
        }
    }
}
