using cxp.data.Repositories;
using cxp.Data;
using cxp.Interfaces;
using cxp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Services
{
    public class Abonoservices : IAbono
    {
        private readonly SqlConfiguration _configuration;
        private IAbonoRepository _abRepository;
        public Abonoservices(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _abRepository = new AbonoRespository(configuration.ConnectionString);
        }


        public Task<bool> Deletepaga(int id)
        {
            return _abRepository.Deletepaga(id);
        }

        public Task<IEnumerable<Abonos>> Getall(long id)
        {
            return _abRepository.Getall(id);
        }
        public Task<Abonos> GetDetails(int id)
        {
            return _abRepository.GetDetails(id);
        }
        public Task<bool> Savepaga(Abonos AB)
        {
            if(AB.ID_Cargo_Abono>0)
            {
                return _abRepository.Editpaga(AB);

            }
            else
            {
                return _abRepository.Savepaga(AB);

            }
        }
    }
}
