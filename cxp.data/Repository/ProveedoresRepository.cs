using cxp.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repository
{
    public class ProveedoresRepository : IProveedoresRepository
    {
        private string ConnectionString;
        public ProveedoresRepository(string connecctionString)
        {
            ConnectionString = connecctionString;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public async Task<bool> DeleteProveedor(int id)
        {
            var db = dbConnection();
            var sql = @"DELETE Proveedor where ID_Proveedor = @id";

            var result = await db.ExecuteAsync(sql.ToString(),
                new { Id = id });
            return result > 0;
        }

        public async Task<IEnumerable<proveedores>> GetAllProveedor()
        {
            var db = dbConnection();
            var sql = @"SELECT ID_Proveedor as idProveedor, Nombre as nombre, Descripcion as descripcion, 
                               Direccion as direccion, Telefono as telefono, Tiempo as tiempo
                        FROM   Proveedor";
            try
            {
                return await db.QueryAsync<proveedores>(sql.ToString(), new { });
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
                throw;
            }
        }

        public Task<IEnumerable<proveedores>> GetProveedorDetalles(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertProveedor(proveedores rproveedor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProveedor(proveedores rproveedor)
        {
            throw new NotImplementedException();
        }
    }
}
