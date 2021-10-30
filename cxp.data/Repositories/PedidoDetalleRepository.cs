using cxp.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repository
{
    public class PedidoDetalleRepository : IPedidoDetalleRepository
    {
        private string ConnectionString;
        public PedidoDetalleRepository(string connecctionString)
        {
            ConnectionString = connecctionString;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        public async Task<bool> DeleteDetallePedidoAll(long id)
        {
            var db = dbConnection();

            var sql = @"DELETE FROM Detalle_P
                        WHERE  ID_Pedido = @id";
            var result = await db.ExecuteAsync(sql.ToString(),new{Id = id});
            return result > 0;
        }
        public async Task<bool> DeletePedidoDetalle(long id, int iddetalle)
        {
            var db = dbConnection();

            var sql = @"DELETE FROM Detalle_P
                        WHERE  ID_Pedido = @id
                        AND    ID_Detalle_P = @iddetalle";
            var result = await db.ExecuteAsync(sql.ToString(),
                new { Id = id,
                      IDdetalle = iddetalle});
            return result > 0;
        }

        public async Task<IEnumerable<PedidoDetalle>> GetAllPedidoDetalle()
        {
            var db = dbConnection();

            var sql = @"SELECT * FROM Detalle_P";
            try
            {
                return await db.QueryAsync<PedidoDetalle>(sql.ToString(), new { });

            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
                throw;
            }
        }

        public async Task<PedidoDetalle> GetPedidoDetalles(long id, int idDetalle)
        {
            var db = dbConnection();

            var sql = @"SELECT a.No_Factura as idpedido,
                               a.Fecha as fechaFactura,
	                           b.ID_Producto as idproducto,
                               b.ID_Detalle_P as iddetalle,
	                           b.Descripcion as descripcion,
	                           b.Cantidad as cantidad, 
	                           c.Nombre as NombreProveedor,
	                           concat(d.Nombre,' ',d.Apellido_P) NombreUsuario,
	                           (SELECT e.Nombre_P FROM Producto e WHERE b.ID_Producto = e.ID_Producto)  as NombreProducto
                        FROM   Pedido a
                        LEFT JOIN Detalle_P b ON b.ID_Pedido = a.No_Factura
                        INNER JOIN Proveedor c ON a.ID_Proveedor = c.ID_Proveedor
                        INNER JOIN Usuario d ON A.ID_Usuario = d.ID_Usuario
                        WHERE ID_Pedido    = @id
                        AND   ID_Detalle_P = @idDetalle";
            try 
            {
                return await db.QueryFirstOrDefaultAsync<PedidoDetalle>(sql.ToString(), new { Id = id, idDetalle = idDetalle });

            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public async Task<bool> InsertPedidoDetalle(PedidoDetalle pedido)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Detalle_P(ID_Pedido, ID_Producto, Descripcion, Cantidad)
                        VALUES(@idpedido, @idproducto, @descripcion, @cantidad)";
            try
            {
                var result = await db.ExecuteAsync(sql.ToString(),
                    new { pedido.idpedido, 
                          pedido.idproducto, 
                          pedido.descripcion , 
                          pedido.cantidad });

                return result > 0;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> UpdatePedidoDetalle(PedidoDetalle pedido)
        {
            var db = dbConnection();

            var sql = @"UPDATE Detalle_P 
                           SET ID_Producto  = @ID_Producto,
                               Descripcion  = @Descripcion,
                               Cantidad     = @Cantidad
                        WHERE  ID_Detalle_P = @id
                        AND    ID_Pedido    = @ID_Pedido";
            try
            {
                var result = await db.ExecuteAsync(sql.ToString(),
                    new
                    {
                        pedido.idproducto,
                        pedido.descripcion,
                        pedido.cantidad,
                        pedido.idpedido,
                        pedido.iddetalle
                    });

                return result > 0;
            }
            catch
            {
                throw;
            }
        }
        public async Task<PedidoDetalle> GetDetallePedido(long id)
        {
            var db = dbConnection();

            var sql = @"SELECT a.No_Factura as idpedido, a.Fecha as fechaFactura, a.ID_Proveedor, c.Nombre as NombreProveedor, a.Total as totalFactura, 
                               b.ID_Detalle_P as iddetalle, b.Cantidad as cantidad, b.Descripcion as descripcion, 
	                           b.ID_Pedido, b.ID_Producto as idproducto, d.Nombre_P, (b.Cantidad * d.Precio) as total
                        FROM   Pedido a
                        LEFT JOIN Detalle_P b on b.ID_Pedido = a.No_Factura
                        LEFT JOIN Proveedor c on a.ID_Proveedor = c.ID_Proveedor
                        LEFT JOIN Producto d on b.ID_Producto = d.ID_Producto 
                        WHERE  No_Factura = @id";
            try
            {
                return await db.QueryFirstOrDefaultAsync<PedidoDetalle>(sql.ToString(), new { Id = id });

            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
                throw;
            }
        }
        public async Task<IEnumerable<PedidoDetalle>> GetListaPedidoDetalle(long id)
        {
            var db = dbConnection();
            //Agregar datos para que salga en pedido
            var sql = @"SELECT a.ID_Pedido as idpedido,
                               a.ID_Producto as idproducto,
                               a.ID_Detalle_P as iddetalle,
	                           Nombre_P as NombreProducto,
	                           Cantidad as cantidad,
	                           Precio as PrecioProd,
	                           Precio*Cantidad  as total
                        FROM   Detalle_P a
                        LEFT JOIN Producto b ON b.ID_Producto = a.ID_Producto
                        WHERE ID_Pedido = @id";
            return await db.QueryAsync<PedidoDetalle>(sql.ToString(), new { Id = id });
        }

        
    }
}
