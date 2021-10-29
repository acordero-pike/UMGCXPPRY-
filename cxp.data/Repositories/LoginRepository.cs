using cxp.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repositories
{
   public class LoginRepository : ILoginRepository
    {
        private string ConneciontString;
        public LoginRepository(string connectionString)
        {
            ConneciontString = connectionString;
        }
        protected SqlConnection DbConnection()
        {
            return new SqlConnection(ConneciontString);
        }
        public async Task<IEnumerable<usuario>> OnPostAsync(string name, string pass)
        {
            var db = DbConnection();
            var sql = @"EXEC cargar  @us , @pas";
             var x = await db.QueryAsync<usuario>(sql.ToString(), new { us = name, pas = pass });
            return await db.QueryAsync<usuario>(sql.ToString(), new { us = name, pas = pass });
        }

      
    }
}
