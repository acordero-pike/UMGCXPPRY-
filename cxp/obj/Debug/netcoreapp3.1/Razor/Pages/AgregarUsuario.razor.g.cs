#pragma checksum "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\AgregarUsuario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b307b046858a9210220da5444696ec4d686042db"
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
#line 3 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\AgregarUsuario.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\AgregarUsuario.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AgregarUsuario")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/AgregarUsuario/{Id:int}")]
    public partial class AgregarUsuario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/add.css\" rel=\"stylesheet\">\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    <br>\r\n    <br>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(4, "<h1 class=\"titulo\">Agregar Usuario</h1>\r\n    <br>\r\n    <br>\r\n\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "input-group mb-3");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "id", "nombre");
            __builder.AddAttribute(12, "aria-describedby", "inputGroup-sizing-default");
            __builder.AddAttribute(13, "placeholder", "Nombre usuario");
            __builder.AddAttribute(14, "required", true);
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\AgregarUsuario.razor"
                                  Usuario.Nombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Usuario.Nombre = __value, Usuario.Nombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "input-group mb-3");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "id", "apellido");
            __builder.AddAttribute(26, "aria-describedby", "inputGroup-sizing-default");
            __builder.AddAttribute(27, "placeholder", "Primer Apellido");
            __builder.AddAttribute(28, "required", true);
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\AgregarUsuario.razor"
                                  Usuario.Apellido_P

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Usuario.Apellido_P = __value, Usuario.Apellido_P));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "input-group mb-3");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "id", "apellido2");
            __builder.AddAttribute(40, "aria-describedby", "inputGroup-sizing-default");
            __builder.AddAttribute(41, "placeholder", "Segundo Apellido");
            __builder.AddAttribute(42, "required", true);
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\AgregarUsuario.razor"
                                  Usuario.Apellido_S

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Usuario.Apellido_S = __value, Usuario.Apellido_S));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "input-group mb-3");
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "text");
            __builder.AddAttribute(52, "class", "form-control");
            __builder.AddAttribute(53, "id", "correo");
            __builder.AddAttribute(54, "aria-describedby", "inputGroup-sizing-default");
            __builder.AddAttribute(55, "placeholder", "Correo Electronico");
            __builder.AddAttribute(56, "required", true);
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\AgregarUsuario.razor"
                                  Usuario.Correo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Usuario.Correo = __value, Usuario.Correo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "input-group mb-3");
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "text");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "id", "tipo");
            __builder.AddAttribute(68, "aria-describedby", "inputGroup-sizing-default");
            __builder.AddAttribute(69, "placeholder", "Tipo de usuario");
            __builder.AddAttribute(70, "required", true);
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\AgregarUsuario.razor"
                                  Usuario.Tipo_Usuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Usuario.Tipo_Usuario = __value, Usuario.Tipo_Usuario));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n    ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "input-group mb-3");
            __builder.AddMarkupContent(77, "\r\n        ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "type", "text");
            __builder.AddAttribute(80, "class", "form-control");
            __builder.AddAttribute(81, "id", "contraseña");
            __builder.AddAttribute(82, "aria-describedby", "inputGroup-sizing-default");
            __builder.AddAttribute(83, "placeholder", "Contraseña");
            __builder.AddAttribute(84, "required", true);
            __builder.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\AgregarUsuario.razor"
                                  Usuario.Contraseña

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Usuario.Contraseña = __value, Usuario.Contraseña));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.AddMarkupContent(89, "<div class=\"alert alert-danger\" id=\"alert\" role=\"alert\" style=\"display: none;\">\r\n        Todos los campos son necesarios!\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "style", "text-align: center; margin-left: auto; margin-right: auto;  padding-top: 25px;");
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.OpenElement(93, "button");
            __builder.AddAttribute(94, "type", "button");
            __builder.AddAttribute(95, "class", "btn");
            __builder.AddAttribute(96, "id", "agregar");
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\AgregarUsuario.razor"
                                                                 SaveUsuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(98, "Agregar");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n        ");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "type", "button");
            __builder.AddAttribute(102, "class", "btn");
            __builder.AddAttribute(103, "id", "cancelar");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\AgregarUsuario.razor"
                                                                  CancelUsuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(105, "Cancelar");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\pamel\OneDrive\Desktop\UMGCXPPRY\UMGCXPPRY-\cxp\Pages\AgregarUsuario.razor"
       
    [Parameter]
    public int id { get; set; }
    usuario Usuario = new usuario();
    protected void CancelUsuario()
    {
        NavigationManager.NavigateTo("/Usuarios");
    }
    protected async Task SaveUsuario()
    {
        await UsuarioService.SaveUsuario(Usuario);
        NavigationManager.NavigateTo("/Usuarios");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUsuarioService UsuarioService { get; set; }
    }
}
#pragma warning restore 1591
