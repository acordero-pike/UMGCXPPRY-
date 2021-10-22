using cxp.data.Repositories;
using cxp.Data;
using cxp.Interfaces;
using cxp.Model;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Services
{
  
    public class RecepcionServicio : IRecepcion
    {
   

        private readonly SqlConfiguration _configuration;
        private IRecepcionRepository _RECRepository;
        public RecepcionServicio(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RECRepository = new RecepcionRepositoy(configuration.ConnectionString);
        }
       
        public Task<IEnumerable<PedidoRecepcion>> GetAll()
        {
            return _RECRepository.GetAll();
        }

        public Task<bool> Recibir(int id)
        {
            return _RECRepository.Recibir(id);
        }
    }
}
