#pragma checksum "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "161ba9e2c8eae51ee53d2b9628341a574d9d731d"
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
#line 4 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BodegaLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/detalleagregarlist")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/detalleagregarlist/{Id:long}")]
    public partial class PedidoDetalleList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/add.css\" rel=\"stylesheet\">\r\n");
#nullable restore
#line 17 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
 if (detallePedido == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Cargando......</p>\r\n");
#nullable restore
#line 20 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\r\n        <br>\r\n        <br>\r\n        <br>\r\n        <br>\r\n        ");
            __builder.AddMarkupContent(7, "<h1 class=\"titulo\">Detalle Pedido </h1>\r\n        <br>\r\n        <br>\r\n        ");
            __builder.OpenElement(8, "table");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<th style=\"text-align:initial\"> <strong>Fecha:   </strong></th>\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddAttribute(14, "style", "text-align:right");
            __builder.AddContent(15, 
#nullable restore
#line 34 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                                              detallePedido.fechaFactura.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.AddMarkupContent(20, "<th style=\"text-align:initial\"><strong>No. Factura:   </strong></th>\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddAttribute(22, "style", "text-align:right");
            __builder.AddContent(23, 
#nullable restore
#line 38 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                                              detallePedido.idpedido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddMarkupContent(28, "<th style=\"text-align:initial\"><strong>Nombre:   </strong></th>\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddAttribute(30, "style", "text-align:right");
            __builder.AddContent(31, 
#nullable restore
#line 42 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                                              detallePedido.NombreProveedor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "tr");
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.AddMarkupContent(36, "<th style=\"text-align:initial\"><strong>Importe:   </strong></th>\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "style", "text-align:right");
            __builder.AddContent(39, 
#nullable restore
#line 46 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                                              detallePedido.totalFactura

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        <br>\r\n        <br>\r\n\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "style", "text-align: center; margin-left: auto; margin-right: auto;  padding-top: 25px;");
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "type", "submit");
            __builder.AddAttribute(48, "class", "btn");
            __builder.AddAttribute(49, "id", "agregar");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                                                                     agregar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Agregar Pedido");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "table-responsive");
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "table");
            __builder.AddAttribute(58, "class", "table table-light table-bordered");
            __builder.AddAttribute(59, "style", "text-align: center;");
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.AddMarkupContent(61, @"<thead class=""table"" style=""background-color: #021329; color: white;"">
                    <tr>
                        <th>Cantidad</th>
                        <th>Id Producto</th>
                        <th>Nombre Producto</th>
                        <th>Total</th>
                        <th></th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(62, "tbody");
            __builder.AddAttribute(63, "id", "lista-equipos");
            __builder.AddAttribute(64, "style", "background-color: #D8D8D8; color: #000;");
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 68 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                     foreach (var pedidoDetalle in lpedidoDetalle)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "                        ");
            __builder.OpenElement(67, "tr");
            __builder.AddMarkupContent(68, "\r\n                            ");
            __builder.OpenElement(69, "td");
            __builder.AddContent(70, 
#nullable restore
#line 71 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                                 pedidoDetalle.cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                            ");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 72 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                                 pedidoDetalle.idproducto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 73 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                                 pedidoDetalle.NombreProducto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                            ");
            __builder.OpenElement(78, "td");
            __builder.AddContent(79, 
#nullable restore
#line 74 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                                  (double)pedidoDetalle.total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                            ");
            __builder.OpenElement(81, "td");
            __builder.AddMarkupContent(82, "\r\n                                ");
            __builder.OpenElement(83, "a");
            __builder.AddAttribute(84, "href", "/actualizadetalle/" + (
#nullable restore
#line 76 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                                                            pedidoDetalle.idpedido

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 76 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                                                                                    pedidoDetalle.iddetalle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(85, "\r\n                                    <img class=\"img-margin\" src=\"/img/editar.png\" alt=\"Algoritmos\" style=\"width: 20px; height: 20px;\">\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                                ");
            __builder.OpenElement(87, "a");
            __builder.AddContent(88, " ");
            __builder.OpenElement(89, "img");
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                                                    e => dtl( @pedidoDetalle.idpedido,pedidoDetalle.iddetalle)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "class", "img-margin");
            __builder.AddAttribute(92, "src", "/img/eliminar.png");
            __builder.AddAttribute(93, "alt", "Algoritmos");
            __builder.AddAttribute(94, "style", "width: 20px; height: 20px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 82 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
#nullable restore
#line 87 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\PedidoDetalleList.razor"
       
    [Parameter] public long Id { get; set; }
    Pedidos pedido = new Pedidos();
    PedidoDetalle detalle = new PedidoDetalle();
    Producto producto = new Producto();
    public List<usuario> lusuarios { get; set; } = new List<usuario>();
    public List<proveedor> lproveedor { get; set; } = new List<proveedor>();
    public List<Producto> lproductos { get; set; } = new List<Producto>();
    public List<PedidoDetalle> lpedidoDetalle { get; set; } = new List<PedidoDetalle>();
    public PedidoDetalle detallePedido = new PedidoDetalle();
    public string MyOption { get; set; }
    public string descripcion = null;
    public string valor = null;
    public string mensaje = null;


    protected override async Task OnInitializedAsync()
    {
        pedido.IDUsuario = 1;
        pedido.Fecha = DateTime.Now;
        lproveedor = (await proveedorService.GetAllProveedor()).ToList();
        lproductos = (await productoService.GetAllProducto()).ToList();
        lpedidoDetalle = (await pedidoDetalleService.GetListaPedidoDetalle(Id)).ToList();
        detallePedido = await pedidoDetalleService.GetDetallePedido(Id);

    }

    private async void Option(ChangeEventArgs e)
    {
        descripcion = null;
        valor = null;

        producto = await productoService.GetProductoDetails(int.Parse(e.Value.ToString()));

        descripcion = producto.NombreP;
        valor = (Convert.ToDecimal(producto.Precio) * detalle.cantidad).ToString();
        detalle.descripcion = descripcion;
        detalle.total = int.Parse(valor);
        detalle.idproducto = producto.IDProducto;
        detalle.idpedido = Id;

        await InvokeAsync(StateHasChanged);
    }


    protected async Task Guardar()
    {
        Console.WriteLine("proveedor " + pedido.IDProveedor);
        var confirmacion = await js.InvokeAsync<bool>("confirmar",
                "Desea agregar otro producto?", "", "Si", "No", "question");

        if (confirmacion)
        {
            await pedidoDetalleService.InsertPedidoDetalle(detalle);
            navigationManager.NavigateTo("/detalleagregar/" + Id);
            await InvokeAsync(StateHasChanged);
        }
        else
        {
            await pedidoDetalleService.InsertPedidoDetalle(detalle);
            navigationManager.NavigateTo("/pedidolista");
        }

        await InvokeAsync(StateHasChanged);
    }

    protected async void dtl(long id, int iddetalle)
    {

        var confirmacion = await js.InvokeAsync<bool>("confirmar", "Eliminar", "Seguro que desea Eliminar este Producto del Pedido?", "question");
        if (confirmacion)
        {

            await pedidoDetalleService.DeletePedidoDetalle(id, iddetalle);
            await pedidoService.UpdateMonto(id);

            navigationManager.NavigateTo(navigationManager.Uri, forceLoad: true);
            //navigationManager.NavigateTo("/pedidolista");
            await InvokeAsync(StateHasChanged);

        }
    }


    protected void agregar()
    {
        navigationManager.NavigateTo("/detalleagregar/" + Id);
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
