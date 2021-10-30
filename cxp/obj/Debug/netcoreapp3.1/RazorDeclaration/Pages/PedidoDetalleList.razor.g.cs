// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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