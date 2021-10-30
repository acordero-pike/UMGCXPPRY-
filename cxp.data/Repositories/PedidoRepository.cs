using cxp.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private string ConnectionString;
        public PedidoRepository(string connecctionString)
        {
            ConnectionString = connecctionString;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public async Task<bool> DeletePedido(long id)
        {
            var db = dbConnection();

            var sql = @"DELETE FROM Pedido
                        WHERE  No_Factura = @id";
            var result = await db.ExecuteAsync(sql.ToString(),
                new { Id = id });
            return result > 0;
        }

        public async Task<IEnumerable<Pedidos>> GetAllPedido()
        {
            var db = dbConnection();
            Console.WriteLine("estado coneccion " + db.State);
            var sql = @"SELECT No_Factura as NoFactura, Fecha, 
                               a.ID_Usuario as IDUsuario, c.Nombre as NombreUsuario, 
                               a.ID_Proveedor as IDProveedor, b.Nombre as NombreProveedor,
                               Total
                        FROM   Pedido a
                        INNER JOIN Proveedor b ON a.ID_Proveedor = b.ID_Proveedor
                        INNER JOIN Usuario c ON a.ID_Usuario = c.ID_Usuario";
            try
            {
                return await db.QueryAsync<Pedidos>(sql.ToString(), new { });
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
                throw;
            }
            //return lista;
        }

        public async Task<IEnumerable<Pedidos>> GetPedidoDetalles(long id)
        {
            var db = dbConnection();

            var sql = @"SELECT No_Factura as NoFactura, Fecha, 
                               a.ID_Usuario as IDUsuario, c.Nombre as NombreUsuario, 
                               a.ID_Proveedor as IDProveedor, b.Nombre as NombreProveedor,
                               Total
                        FROM   Pedido a
                        INNER JOIN Proveedor b ON a.ID_Proveedor = b.ID_Proveedor
                        INNER JOIN Usuario c ON a.ID_Usuario = c.ID_Usuario
                        WHERE No_Factura = @id";
            return await db.QueryAsync<Pedidos>(sql.ToString(), new { Id = id });
        }

        public async Task<bool> InsertPedido(Pedidos pedido)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Pedido(No_Factura, Fecha, ID_Usuario, ID_Proveedor, Total)
                        VALUES(@NoFactura,@Fecha, @IDUsuario, @IDProveedor, @Total)";
            try
            {
                var result = await db.ExecuteAsync(sql.ToString(),
                    new { pedido.NoFactura,
                          pedido.Fecha, 
                          pedido.IDUsuario, 
                          pedido.IDProveedor, 
                          pedido.Total });

                return result > 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Insert " + ex.Message);
                throw;
            }
        }

        public async Task<bool> UpdatePedido(Pedidos pedido)
        {
            var db = dbConnection();

            var sql = @"UPDATE Pedido
                        SET    Fecha = @Fecha, 
                               ID_Usuario = @ID_Usuario, 
                               ID_Proveedor = @ID_Proveedor , 
                               Total = @Total
                        WHERE No_Factura = @No_Factura";
            try
            {
                var result = await db.ExecuteAsync(sql.ToString(),
                    new { pedido.Fecha, pedido.IDUsuario, pedido.IDProveedor, pedido.Total, pedido.NoFactura });

                return result > 0;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> UpdateMonto(long id)
        {
            var db = dbConnection();

            var sql = @"UPDATE Pedido
                        SET    Total = (SELECT SUM(b.Cantidad*c.Precio) FROM Detalle_P b inner join Producto c ON b.ID_Producto = c.ID_Producto WHERE ID_Pedido = No_Factura)
                        WHERE  No_Factura = @No_Factura";
            try
            {
                var result = await db.ExecuteAsync(sql.ToString(),
                    new { No_Factura = id });

                return result > 0;
            }
            catch
            {
                throw;
            }
        }
    }
}
