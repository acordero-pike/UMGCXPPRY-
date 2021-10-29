using cxp.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repositories
{
    public  class PedidoPagarRepository : IPedidoPagarRepository
    {
        private string ConneciontString;
        public PedidoPagarRepository(string connectionString)
        {
            ConneciontString = connectionString;
        }
        protected SqlConnection DbConnection()
        {
            return new SqlConnection(ConneciontString);
        }
        

        public async Task<IEnumerable<Pedidopagar>> GetAllPedidopagar()
        {
            var db = DbConnection();
            var sql = @"EXEC verdeuda";

            return await db.QueryAsync<Pedidopagar>(sql.ToString(), new { });
        }

        
    }
}
