#pragma checksum "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9f5044ba305e2349052b0200b86c7d20006d782"
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
#line 4 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Login.razor"
using cxp.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Login.razor"
using cxp.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/login.css\" rel=\"stylesheet\">\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "id", "info-section");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 19 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Login.razor"
         if (_isVisible)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.AddMarkupContent(8, "<div class=\"alert alert-danger\" role=\"alert\" id=\"alert\" style=\"text-align: center;\">\r\n\r\n                <p>  Contraseña o Correo Incorrectos , intente de nuevo </p>\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Login.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "\r\n        <img id=\"logo\" src=\"../img/logo.svg\" alt=\"Logo\">\r\n        ");
            __builder.AddMarkupContent(10, "<h2 id=\"bienvenida\">CXP</h2>\r\n        ");
            __builder.AddMarkupContent(11, "<p id=\"description\" style=\"text-align: center;\">\r\n            Registro de Cuentas por Pagar!\r\n        </p>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "id", "login-section");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "form");
            __builder.AddAttribute(17, "id", "signin-form");
            __builder.AddAttribute(18, "style", "flex-direction:column; width: 100%; display: flex; justify-content:center; align-items:center;");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.AddMarkupContent(20, "<h1 id=\"titulo\" style=\"margin-bottom: 15px;\">Iniciar Sesión</h1>\r\n            ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "email");
            __builder.AddAttribute(23, "class", "form-control");
            __builder.AddAttribute(24, "id", "inputEmail");
            __builder.AddAttribute(25, "style", "height: 50px; width: 90%; margin-bottom: 20px;");
            __builder.AddAttribute(26, "aria-describedby", "inputGroup-sizing-default");
            __builder.AddAttribute(27, "placeholder", "Correo");
            __builder.AddAttribute(28, "required", true);
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Login.razor"
                                                                            us.email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => us.email = __value, us.email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "password");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "id", "inputPassword");
            __builder.AddAttribute(36, "style", "height: 50px; width: 90%; margin-bottom: 15px;");
            __builder.AddAttribute(37, "aria-describedby", "inputGroup-sizing-default");
            __builder.AddAttribute(38, "placeholder", "Contraseña");
            __builder.AddAttribute(39, "required", true);
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Login.razor"
                                                                                  us.password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => us.password = __value, us.password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "style", " text-align: center; margin-left: auto; margin-right: auto;");
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "type", "button");
            __builder.AddAttribute(48, "class", "btnLogin");
            __builder.AddAttribute(49, "id", "agregar");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Login.razor"
                                                                              log

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, "Iniciar Sesión");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Login.razor"
       
    private bool _isVisible = false;
    usuario us = new usuario();
    protected async void log()
    {

        var res = await LS.OnPostAsync(us.email, us.password);
        if (res.Count()>0)
        {

            await JSRuntime.InvokeVoidAsync("localStorage.setItem", "login", res.First().id_usuario
            );
            await JSRuntime.InvokeVoidAsync("localStorage.setItem", "name", res.First().nombre +" "+ res.First().apellido           );

            uriHelper.NavigateTo("/Menu", forceLoad: true);

        }
        else
        {
            _isVisible = true;
            StateHasChanged();


        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogin LS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
    }
}
#pragma warning restore 1591
