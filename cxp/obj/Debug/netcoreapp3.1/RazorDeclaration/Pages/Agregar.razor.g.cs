// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace cxp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\_Imports.razor"
using cxp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\_Imports.razor"
using cxp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Agregar.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Agregar.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Agregar")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Agregar/{Id:int}")]
    public partial class Agregar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Agregar.razor"
       
    [Parameter]
    public int id { get; set; }
    proveedor Proveedor = new proveedor();
    protected void CancelProveedor()
    {
        NavigationManager.NavigateTo("/Proveedores");
    }
    protected async Task SaveProveedor()
    {
        if (id == 0)
        {
        }
        else
        {
            Proveedor = await ProveedorService.GetDetails(id);
        }
        await ProveedorService.SaveProveedor(Proveedor);
        NavigationManager.NavigateTo("/Proveedores");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProveedorService ProveedorService { get; set; }
    }
}
#pragma warning restore 1591
