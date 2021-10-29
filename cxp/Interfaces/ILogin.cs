using cxp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp.Interfaces
{
   public interface ILogin
    {
        Task<IEnumerable<usuario>> OnPostAsync(string name, string pass);
    }
}
