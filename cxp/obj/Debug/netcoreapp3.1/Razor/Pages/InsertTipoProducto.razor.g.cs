#pragma checksum "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\InsertTipoProducto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06dfc641784dcfe8b990f83ee26b184fa35e8b89"
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
#line 5 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\InsertTipoProducto.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\InsertTipoProducto.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BodegaLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/AgregarTipoProducto")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/AgregarTipoProducto/{Id:int}")]
    public partial class InsertTipoProducto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/add.css\" rel=\"stylesheet\">\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    <br>\r\n    <br>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(4, "<h1 class=\"titulo\">Agregar Tipo de Producto</h1>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "input-group mb-3");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "id", "tipoproducto");
            __builder.AddAttribute(12, "aria-describedby", "inputGroup-sizing-default");
            __builder.AddAttribute(13, "placeholder", "Nombre de Tipo Producto:");
            __builder.AddAttribute(14, "required", true);
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\InsertTipoProducto.razor"
                                  TipoProducto.NombreProducto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TipoProducto.NombreProducto = __value, TipoProducto.NombreProducto));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "text-align: center; margin-left: auto; margin-right: auto;  padding-top: 25px;");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "type", "button");
            __builder.AddAttribute(24, "class", "btn");
            __builder.AddAttribute(25, "id", "agregar");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\InsertTipoProducto.razor"
                                                                 SaveTipoProducto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Agregar");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "class", "btn-dan");
            __builder.AddAttribute(32, "id", "cancelar");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\InsertTipoProducto.razor"
                                                                      CancelTipoProducto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Cancelar");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\InsertTipoProducto.razor"
       
    [Parameter]
    public int Id { get; set; }
    TipoProducto TipoProducto = new TipoProducto();
    protected void CancelTipoProducto()
    {
        NavigationManager.NavigateTo("/TipoProducto");
    }
    protected async Task SaveTipoProducto()
    {
        await TipoProductoService.SaveTipoProducto(TipoProducto);
        NavigationManager.NavigateTo("/TipoProducto");
    }
    protected override async Task OnInitializedAsync()

    {
        if (Id == 0)
        {

        }
        else
        {
            TipoProducto = await TipoProductoService.GetTipoProductoDetails(Id);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITipoProductoService TipoProductoService { get; set; }
    }
}
#pragma warning restore 1591
