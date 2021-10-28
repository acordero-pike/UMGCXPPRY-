using cxp.data.Repositories;
using cxp.Data;
using cxp.Interfaces;
using cxp.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace cxp.Services
{
    public class LoginService : PageModel, ILogin
    {
        public string ReturnUrl { get; set; }   
        private readonly SqlConfiguration _configuration;
        private ILoginRepository _abRepository;
         
        public LoginService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _abRepository = new LoginRepository(configuration.ConnectionString);
            
        }

        public async  Task<IEnumerable<usuario>> OnPostAsync(string name, string pass)
        {
          
            var x = await _abRepository.OnPostAsync(name, pass);
            if (x.Count()>0)
            {
               

                return x;
            }
            return x;
            
        }
    }
}
