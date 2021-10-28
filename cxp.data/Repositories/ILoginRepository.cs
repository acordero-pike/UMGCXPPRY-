using cxp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cxp.data.Repositories
{
   public  interface ILoginRepository
    {
        Task<IEnumerable<usuario>> OnPostAsync(string name, string pass);
    }
}
