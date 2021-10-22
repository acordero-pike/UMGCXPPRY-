using cxp.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repositories
{
   public class AbonoRespository : IAbonoRepository
    {
        private string ConneciontString;
        public AbonoRespository(string connectionString)
        {
            ConneciontString = connectionString;
        }
        protected SqlConnection DbConnection()
        {
            return new SqlConnection(ConneciontString);
        }
        public async Task<bool> Deletepaga(int id)
        {
            var db = DbConnection();
            var sql = @"EXEC dtlpagar @id";

            var res = await db.ExecuteAsync(sql.ToString(), new { id = id });
            return res > 0;
            ;
        }

        public async Task<Abonos> GetDetails(int id)
        {
            var db = DbConnection();
            var sql = @"EXEC getpagar @id";

            return await db.QueryFirstOrDefaultAsync<Abonos>(sql.ToString(),
                new { id = id });

        }

        public async Task<bool> Editpaga(Abonos AB)
        {
            var db = DbConnection();
            var sql = @"EXEC editpagar  @idd  ,@id  , @monto , @fecha  , @tipo, @boleta";

            var res = await db.ExecuteAsync(sql.ToString(), new { idd=AB.ID_Cargo_Abono, id=AB.No_Factura,monto=AB.Cantidad_cargo_Abono, fecha=AB.Fecha_Pago.ToShortDateString(),tipo=AB.Tipo_C_A , boleta=AB.No_Boleta});
            return res > 0;
        }

        public async Task<IEnumerable<Abonos>> Getall(int id)
        {
            var db = DbConnection();
            var sql = @"EXEC pagos @id";

            return await db.QueryAsync<Abonos>(sql.ToString(), new { id= id });

            ;
        }

        public async Task<bool> Savepaga(Abonos AB)
        {
            var db = DbConnection();
            var sql = @"EXEC pagar  @id  , @monto , @fecha  , @tipo, @boleta";

            var res = await db.ExecuteAsync(sql.ToString(), new {  id = AB.No_Factura, monto = AB.Cantidad_cargo_Abono, fecha = AB.Fecha_Pago.Date, tipo = AB.Tipo_C_A , boleta=AB.No_Boleta });
            return res > 0;
        }
    }
}
