#pragma checksum "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1b98890ae4e51ab2e5908b031afc8e4608c6a61"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Proveedores")]
    public partial class Proveedores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/lista.css\" rel=\"stylesheet\">\r\n");
#nullable restore
#line 6 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor"
 if (Proveedor == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Cargando...</em></p>\r\n");
#nullable restore
#line 9 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor"

}
else
{



#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddAttribute(5, "style", "text-align: center;");
            __builder.AddMarkupContent(6, "\r\n    <br>\r\n    <br>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(7, "<h1 class=\"titulo\">Lista de Proveedores</h1>\r\n    ");
            __builder.AddMarkupContent(8, "<h3 class=\"titulo\"><a href=\"/Agregar\">Agregar</a></h3>\r\n    <br>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "table-responsive");
            __builder.AddMarkupContent(11, "\r\n\r\n        ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table table-light table-bordered");
            __builder.AddAttribute(14, "style", "text-align: center;");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.AddMarkupContent(16, @"<thead class=""table"" style=""background-color: #021329; color: white;"">
                <tr>
                    <th>Proveedor</th>
                    <th>Descripción</th>
                    <th>Telefono</th>
                    <th>Dirección</th>
                    <th>Tiempo en días</th>
                    <th>Acción</th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(17, "tbody");
            __builder.AddAttribute(18, "id", "lista-equipos");
            __builder.AddAttribute(19, "style", "background-color: #D8D8D8; color: #000;");
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 39 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor"
                 foreach (var proveedor in Proveedor)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 42 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor"
                         proveedor.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 43 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor"
                         proveedor.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 44 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor"
                         proveedor.Direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 45 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor"
                         proveedor.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 46 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor"
                         proveedor.Tiempo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.AddMarkupContent(39, @"<td>
                        <a href=""/Agregar"">
                            <img class=""img-margin"" src=""/img/editar.png"" alt=""Algoritmos"" style=""width: 20px; height: 20px;"">
                        </a>
                        <a href=""/Agregar"">
                            <img class=""img-margin"" src=""/img/eliminar.png"" alt=""Algoritmos"" style=""width: 20px; height: 20px;"">
                        </a>
                    </td>
                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 56 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 61 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\Proveedores.razor"
       

    private IEnumerable<proveedor> Proveedor;
    protected override async Task OnInitializedAsync()
    {

        try
        {
            Proveedor = await ProveedorService.GetAllProveedor();
        }
        catch (Exception)
        {
            throw;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProveedorService ProveedorService { get; set; }
    }
}
#pragma warning restore 1591
