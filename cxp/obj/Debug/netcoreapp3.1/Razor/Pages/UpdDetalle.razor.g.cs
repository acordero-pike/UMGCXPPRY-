#pragma checksum "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\UpdDetalle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bdb93ace30c6f44b1724d6b9254a78ea811ffe2"
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
#line 5 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\UpdDetalle.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\UpdDetalle.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BodegaLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/actualizadetalle")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/actualizadetalle/{Id:int}/{IdDetalle:int}")]
    public partial class UpdDetalle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/add.css\" rel=\"stylesheet\">\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    <br>\r\n    <br>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(4, "<h1 class=\"titulo\">Actualiza Detalle Pedido </h1>\r\n    <br>\r\n    <br>\r\n\r\n    ");
            __builder.OpenElement(5, "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<th style=\"text-align:initial\"> <strong>Fecha</strong></th>\r\n            ");
            __builder.OpenElement(10, "td");
            __builder.AddAttribute(11, "style", "text-align:right");
            __builder.AddContent(12, 
#nullable restore
#line 30 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\UpdDetalle.razor"
                                          detallePedido.fechaFactura.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.AddMarkupContent(17, "<th style=\"text-align:initial\"><strong>No. Factura</strong></th>\r\n            ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "style", "text-align:right");
            __builder.AddContent(20, 
#nullable restore
#line 34 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\UpdDetalle.razor"
                                          detallePedido.idpedido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.AddMarkupContent(25, "<th style=\"text-align:initial\"><strong>Nombre</strong></th>\r\n            ");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "style", "text-align:right");
            __builder.AddContent(28, 
#nullable restore
#line 38 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\UpdDetalle.razor"
                                          detallePedido.NombreProveedor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.AddMarkupContent(33, "<th style=\"text-align:initial\"><strong>Importe</strong></th>\r\n            ");
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "style", "text-align:right");
            __builder.AddContent(36, 
#nullable restore
#line 42 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\UpdDetalle.razor"
                                          detallePedido.totalFactura

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    <br>\r\n    <br>\r\n\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "input-group mb-3");
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.AddMarkupContent(43, "<span class=\"input-group-addon\">Cantidad </span>\r\n        ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "number");
            __builder.AddAttribute(46, "class", "form-control");
            __builder.AddAttribute(47, "id", "cantidad");
            __builder.AddAttribute(48, "aria-describedby", "inputGroup-sizing-default");
            __builder.AddAttribute(49, "placeholder", "Cantidad");
            __builder.AddAttribute(50, "required", true);
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\UpdDetalle.razor"
                                    detalle.cantidad

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => detalle.cantidad = __value, detalle.cantidad, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "input-group mb-3");
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.AddMarkupContent(58, "<span class=\"input-group-addon\">Codigo Producto</span>\r\n        ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "number");
            __builder.AddAttribute(61, "class", "form-control");
            __builder.AddAttribute(62, "id", "idProducto");
            __builder.AddAttribute(63, "aria-describedby", "inputGroup-sizing-default");
            __builder.AddAttribute(64, "placeholder", "Codigo Producto");
            __builder.AddAttribute(65, "readonly", true);
            __builder.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\UpdDetalle.razor"
                                    detalle.idproducto

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => detalle.idproducto = __value, detalle.idproducto, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "input-group mb-3");
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.AddMarkupContent(73, "<span class=\"input-group-addon\">Nombre Producto</span>\r\n        ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "text");
            __builder.AddAttribute(76, "class", "form-control");
            __builder.AddAttribute(77, "id", "NomProducto");
            __builder.AddAttribute(78, "aria-describedby", "inputGroup-sizing-default");
            __builder.AddAttribute(79, "placeholder", "Nombre Producto");
            __builder.AddAttribute(80, "readonly", true);
            __builder.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\UpdDetalle.razor"
                                  detalle.NombreProducto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => detalle.NombreProducto = __value, detalle.NombreProducto));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.AddMarkupContent(85, "<div class=\"alert alert-danger\" id=\"alert\" role=\"alert\" style=\"display: none;\">\r\n        Todos los campos son necesarios!\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "style", "text-align: center; margin-left: auto; margin-right: auto;  padding-top: 25px;");
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "type", "button");
            __builder.AddAttribute(91, "class", "btn");
            __builder.AddAttribute(92, "id", "agregar");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\UpdDetalle.razor"
                                                                 Guardar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(94, "Guardar");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\UpdDetalle.razor"
       
    [Parameter] public int Id { get; set; }
    [Parameter] public int IdDetalle { get; set; }
    Pedidos pedido = new Pedidos();
    PedidoDetalle detalle = new PedidoDetalle();
    Productos producto = new Productos();
    public List<usuario> lusuarios { get; set; } = new List<usuario>();
    public PedidoDetalle detallePedido = new PedidoDetalle();
    public string MyOption { get; set; }
    public string descripcion = null;
    public string valor = null;
    public string mensaje = null;


    protected override async Task OnInitializedAsync()
    {
        pedido.IDUsuario = 1;
        pedido.Fecha = DateTime.Now;
        detallePedido = await pedidoDetalleService.GetDetallePedido(Id);
        detalle = await pedidoDetalleService.GetPedidoDetalles(Id, IdDetalle);

    }

    protected async Task Guardar()
    {
        Console.WriteLine("proveedor " + pedido.IDProveedor);

        await pedidoDetalleService.UpdatePedidoDetalle(detalle);
        await pedidoService.UpdateMonto(Id);


        navigationManager.NavigateTo("/detalleagregarlist/" + Id);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileUtil futil { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductoService productoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProveedorService proveedorService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPedidoDetalleService pedidoDetalleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPedidoService pedidoService { get; set; }
    }
}
#pragma warning restore 1591
