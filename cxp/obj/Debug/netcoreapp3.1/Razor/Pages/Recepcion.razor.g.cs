#pragma checksum "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77a0cd2eee7b356b615c8f4039d2590e7336276e"
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
#line 3 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Receptor_pagador))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Recepcion_Pedidos")]
    public partial class Recepcion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/lista.css\" rel=\"stylesheet\">\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "style", "text-align: center;");
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 11 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
     if (PPS == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 14 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "    <br>\r\n    <br>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(8, "<h1 class=\"titulo\">Recibir Pedidos</h1>\r\n    <br>\r\n    <br>\r\n    <br>\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "table-responsive");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table table-light table-bordered");
            __builder.AddAttribute(14, "style", "text-align: center;");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.AddMarkupContent(16, @"<thead class=""table"" style=""background-color: #021329; color: white;"">
                <tr>
                    <th>Pedido</th>
                    <th>Proveedor</th>
                    <th>Deuda</th>
                    <th>Fecha</th>
                    <th></th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(17, "tbody");
            __builder.AddAttribute(18, "id", "lista-equipos");
            __builder.AddAttribute(19, "style", "background-color:#D8D8D8; color: #000;");
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 39 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
                 if (PPS == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                    ");
            __builder.AddMarkupContent(22, "<tr>\r\n                        <td colspan=\"6\"> Sin Datos</td>\r\n                    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"

                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
                     foreach (var ps in PPS)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                        ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 51 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
                                 ps.pedido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 52 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
                                 ps.proveedor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 53 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
                                 ps.deuda

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 54 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
                                 ps.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 55 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
                             if (ps.Recibido == true)
                            {


#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                                ");
            __builder.AddMarkupContent(39, "<td><input class=\"recibido\" type=\"button\" value=\"recibido\" disabled></td>\r\n");
#nullable restore
#line 59 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, "  ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "class", "recibir");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "value", "Recibir");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
                                                                                                      e => recibir( ps.pedido)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 63 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 67 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Recepcion.razor"
       

    private IEnumerable<PedidoRecepcion> PPS;
    protected override async Task OnInitializedAsync()
    {






        try
        {
            PPS = await PP.GetAll();
        }
        catch (Exception)
        {
            throw;
        }


    }
    protected async void recibir(int id)
    {

        var confirmacion = await js.InvokeAsync<bool>("confirmar", "Recibir", "Seguro que desea Recibir el pedido?", "question");
        if (confirmacion)
        {
            await PP.Recibir(id);

            uriHelper.NavigateTo(uriHelper.Uri, forceLoad: true);
        }



    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecepcion PP { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
    }
}
#pragma warning restore 1591
