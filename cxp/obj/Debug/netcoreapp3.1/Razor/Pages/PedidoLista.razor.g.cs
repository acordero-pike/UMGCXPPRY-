#pragma checksum "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8762b9dc7f0701128561206c2e555a63af4b472"
// <auto-generated/>
#pragma warning disable 1591
namespace cxp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\_Imports.razor"
using cxp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\_Imports.razor"
using cxp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BodegaLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/pedidolista")]
    public partial class PedidoLista : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/lista.css\" rel=\"stylesheet\">\r\n");
#nullable restore
#line 14 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
 if (lispedidos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Cargando......</p>\r\n");
#nullable restore
#line 17 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddAttribute(6, "style", "text-align: center;");
            __builder.AddMarkupContent(7, "\r\n        <br>\r\n        <br>\r\n        <br>\r\n        <br>\r\n        ");
            __builder.AddMarkupContent(8, "<h1 class=\"titulo\">Listado Pedidos</h1>\r\n        <br>\r\n        <br>\r\n        <br>\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "style", "text-align: center; margin-left: auto; margin-right: auto;  padding-top: 25px;");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "submit");
            __builder.AddAttribute(14, "class", "btn");
            __builder.AddAttribute(15, "id", "agregar");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
                                                                     agregar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Agregar Pedido");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "table-responsive");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table table-light table-bordered");
            __builder.AddAttribute(25, "style", "text-align: center;");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.AddMarkupContent(27, @"<thead class=""table"" style=""background-color: #021329; color: white;"">
                    <tr>
                        <th># Factura</th>
                        <th>Fecha</th>
                        <th>Usuario</th>
                        <th>Proveedor</th>
                        <th>Total</th>
                        <th></th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(28, "tbody");
            __builder.AddAttribute(29, "id", "lista-equipos");
            __builder.AddAttribute(30, "style", "background-color: #D8D8D8; color: #000;");
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 45 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
                     foreach (Pedidos item in lispedidos)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "                        ");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 48 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
                                 item.NoFactura

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 49 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
                                 item.Fecha.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 50 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
                                 item.NombreUsuario

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                            ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 51 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
                                 item.NombreProveedor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 52 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
                                 item.Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                            ");
            __builder.OpenElement(50, "td");
            __builder.AddMarkupContent(51, "\r\n                                ");
            __builder.OpenElement(52, "a");
            __builder.AddAttribute(53, "href", "/detalleagregarlist/" + (
#nullable restore
#line 54 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
                                                              item.NoFactura

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "\r\n                                    <img class=\"img-margin\" src=\"/img/editar.png\" alt=\"Algoritmos\" style=\"width: 20px; height: 20px;\">\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                ");
            __builder.OpenElement(56, "a");
            __builder.AddContent(57, " ");
            __builder.OpenElement(58, "img");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
                                                    e => dtl( item.NoFactura)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "class", "img-margin");
            __builder.AddAttribute(61, "src", "/img/eliminar.png");
            __builder.AddAttribute(62, "alt", "Algoritmos");
            __builder.AddAttribute(63, "style", "width: 20px; height: 20px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 61 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#nullable restore
#line 66 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoLista.razor"
       
    Pedidos itempedido = new Pedidos();
    private IEnumerable<Pedidos> lispedidos;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            lispedidos = await pedidoService.GetAllPedido();
        }
        catch (Exception ex)
        {
            Console.WriteLine("error " + ex.Message);
        }
    }
    protected void agregar()
    {
        navigationManager.NavigateTo("/pedidoagregar");
    }

    protected async void dtl(long id)
    {

        var confirmacion = await js.InvokeAsync<bool>("confirmar", "Eliminar", "Seguro que desea Eliminar el Pedido?", "question");
        if (confirmacion)
        {

            await detalleService.DeleteDetallePedidoAll(id);
            await pedidoService.DeletePedido(id);

            navigationManager.NavigateTo(navigationManager.Uri, forceLoad: true);
            //navigationManager.NavigateTo("/pedidolista");
            await InvokeAsync(StateHasChanged);

        }



    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPedidoDetalleService detalleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPedidoService pedidoService { get; set; }
    }
}
#pragma warning restore 1591
