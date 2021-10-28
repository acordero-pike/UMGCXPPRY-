using cxp.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repositories
{
    public class RecepcionRepositoy : IRecepcionRepository
    {
        private string ConneciontString;
        public RecepcionRepositoy(string connectionString)
        {
            ConneciontString = connectionString;
        }
        protected SqlConnection DbConnection()
        {
            return new SqlConnection(ConneciontString);
        }
        public async Task<IEnumerable<PedidoRecepcion>> GetAll()
        {
            var db = DbConnection();
            var sql = @"EXEC recepecion";

            return await db.QueryAsync<PedidoRecepcion>(sql.ToString(), new { });
        }

        public async Task<bool> Recibir(int id)
        {
            var db = DbConnection();
            var sql = @"EXEC recibido @id";
            var result = await db.ExecuteAsync(sql.ToString(),
           new { id = id }
           );
            return result > 0;

        }
    }
}
