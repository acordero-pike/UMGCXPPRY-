using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp
{
    public enum MsjSweet
    {
        questions, warning, success, info, error
    }
    public class FileUtil
    {
        private readonly IJSRuntime js;
        public FileUtil(IJSRuntime js)
        {
            this.js = js;
        }

        public async Task<object> Mensaje(string titulo, string mensaje, MsjSweet tipo)
        {
            return await js.InvokeAsync<object>("Swal.fire", titulo, mensaje, tipo.ToString());
        }
    }
}
