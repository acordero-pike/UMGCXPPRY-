#pragma checksum "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb7c18e0156bde0e3feb222f7fafd21d75664786"
// <auto-generated/>
#pragma warning disable 1591
namespace cxp.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Shared\MainLayout.razor"
 if (_isVisible)
{

}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "header");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "nav");
            __builder.AddAttribute(4, "class", "navbar navbar-expand-sm");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.AddMarkupContent(6, "<button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\"#opciones\">\r\n\r\n                <img src=\"/img/menu.png\" class=\"navh\">\r\n            </button>\r\n\r\n            \r\n            ");
            __builder.AddMarkupContent(7, "<a class=\"navbar-brand\" href=\"/Menu\">\r\n                <img style=\"width: 100px;\" src=\"/img/logo.svg\" width=\"75\" height=\"30\" alt>\r\n            </a>\r\n\r\n            \r\n            ");
            __builder.AddMarkupContent(8, @"<div class=""collapse navbar-collapse"" id=""opciones"">
                <ul class=""navbar-nav"">

                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Menu"">Inicio</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Proveedores"">Proveedores</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href>Productos</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Recepcion_Pedidos"">Recepcion</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href>Pedidos</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Pagos"">Pagos</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Usuarios"">Usuarios</a>
                    </li>

                </ul>

            </div>
           
");
#nullable restore
#line 53 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Shared\MainLayout.razor"
             if (_isVisible)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.AddMarkupContent(10, "<div>\r\n                    <a href=\"/Login\" class=\"nav-link\">Login</a>\r\n                </div>\r\n");
#nullable restore
#line 58 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Shared\MainLayout.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", "/");
            __builder.AddAttribute(16, "class", "nav-link");
            __builder.AddContent(17, 
#nullable restore
#line 62 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Shared\MainLayout.razor"
                                                  data

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Shared\MainLayout.razor"
                                 logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "lass", "nav-link");
            __builder.AddContent(25, "   Log Out ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 67 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Shared\MainLayout.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.AddContent(31, 
#nullable restore
#line 74 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, "    ");
            __builder.AddMarkupContent(33, "<footer>\r\n        <img src=\"/img/logo.svg\" id alt width=\"140\">\r\n    </footer>\r\n");
#nullable restore
#line 78 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Shared\MainLayout.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Shared\MainLayout.razor"
 
    private bool _isVisible = true;
    private string data;
    protected override async Task OnInitializedAsync()
    {

        namea();

    }

    protected async void namea()
    {
        string x = await js.InvokeAsync<string>("localStorage.getItem", "name");
        if (x != null)
        {
            _isVisible = false;
            data = x;
            StateHasChanged();
        }
        else

        {
            uriHelper.NavigateTo("/problema", forceLoad: true);
        }
    }
    protected async void logout()
    {
        await js.InvokeAsync<string>("localStorage.removeItem", "login");
        await js.InvokeAsync<string>("localStorage.removeItem", "name");
        uriHelper.NavigateTo("/", forceLoad: true);

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
    }
}
#pragma warning restore 1591