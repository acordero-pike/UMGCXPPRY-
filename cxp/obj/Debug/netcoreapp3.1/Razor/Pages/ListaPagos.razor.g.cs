#pragma checksum "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ead0ef60b526d80e04233f5e36c256e0e41b937"
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
#line 4 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Receptor_pagador))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListaPagos/{Id:int}")]
    public partial class ListaPagos : Microsoft.AspNetCore.Components.ComponentBase
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
#line 13 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
     if (PPS == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 16 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "    <br>\r\n    <br>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(8, "<h1 class=\"titulo\">Listado de Pagos </h1>\r\n    ");
            __builder.OpenElement(9, "h2");
            __builder.AddContent(10, " Pedido # ");
            __builder.AddContent(11, 
#nullable restore
#line 23 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
                   Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    <br>\r\n    <br>\r\n    <br>\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "table-responsive");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table table-light table-bordered");
            __builder.AddAttribute(18, "style", "text-align: center;");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.AddMarkupContent(20, @"<thead class=""table"" style=""background-color: #021329; color: white;"">
                <tr>
                    <th>Pedido</th>
                    <th>Fecha Pago</th>
                    <th>Tipo Pago</th>
                    <th>Cantidad Pagada</th>
                    <th> No Boleta</th>
                    <th></th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(21, "tbody");
            __builder.AddAttribute(22, "id", "lista-equipos");
            __builder.AddAttribute(23, "style", "background-color:#D8D8D8; color: #000;");
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 43 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
                 if (PPS == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "                    ");
            __builder.AddMarkupContent(26, "<tr>\r\n                        <td colspan=\"6\"> Sin Datos</td>\r\n                    </tr>\r\n");
#nullable restore
#line 48 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"

                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
                     foreach (var ps in PPS)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                        ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 55 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
                                 ps.No_Factura

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 56 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
                                 ps.Fecha_Pago.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 57 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
                                 ps.Tipo_C_A

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 58 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
                                 ps.Cantidad_cargo_Abono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 59 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
                                 ps.No_Boleta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n                            ");
            __builder.OpenElement(45, "td");
            __builder.AddMarkupContent(46, "\r\n                                ");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "href", "/Abono/" + (
#nullable restore
#line 62 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
                                                 ps.ID_Cargo_Abono

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "<button style=\"background-color: #147BC6; width: 50%;\">Editar</button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                                ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "style", "background-color: #147BC6; width: 50%;");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
                                                                                                  e => dtl( ps.ID_Cargo_Abono)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Eliminar");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 68 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\ListaPagos.razor"
       
    [Parameter]
    public int Id { get; set; }
    [Parameter]
    public float deuda { get; set; }
    private IEnumerable<Model.Abonos> PPS;
    protected override async Task OnInitializedAsync()
    {
        try
        {
            PPS = await PP.Getall(Id);
        }
        catch (Exception)
        {
            throw;
        }
    }
    protected async void dtl(int id)
    {

        var confirmacion = await js.InvokeAsync<bool>("confirmar", "Eliminar", "Seguro que desea Eliminar el Pago?", "question");
        if (confirmacion)
        {
            await PP.Deletepaga(id);

            uriHelper.NavigateTo(uriHelper.Uri, forceLoad: true);
        }



    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAbono PP { get; set; }
    }
}
#pragma warning restore 1591
