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
#line 5 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Abono.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Abono.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Receptor_pagador))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Abono/{id:long}/{de:float}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Abono/{Ids:int}")]
    public partial class Abono : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\albin\Desktop\UMG CXP PRY\UMGCXPPRY-\cxp\Pages\Abono.razor"
       

    [Parameter]
    public long id { get; set; }
    [Parameter]
    public float de { get; set; }
    [Parameter]
    public int Ids { get; set; }
    private IEnumerable<Pedidopagar> PPS;

    Abonos abon = new Abonos();
    protected void CancelFilm()
    {
        NavigationManager.NavigateTo("/Pagos");
    }
    protected async Task SaveFilm()
    {
        if (abon.Tipo_C_A == null)

        {
            await js.InvokeVoidAsync("alert", "Seleccione un Tipo de Pago!"); // Alert
        }
        else if (abon.Cantidad_cargo_Abono > Convert.ToDecimal(de))
        {
            await js.InvokeVoidAsync("alert", "La cantidad Excede la Deuda , ingrese una cantida igual o menor !"); // Alert

        }
        else if (abon.Cantidad_cargo_Abono  ==0 || abon.Cantidad_cargo_Abono<0)
        {
            await js.InvokeVoidAsync("alert", "La cantidad ingresada es cero o invalida  !"); // Alert

        }
        else
        {
            await Ab.Savepaga(abon);
            NavigationManager.NavigateTo("/Pagos");
        }

    }
    protected override async Task OnInitializedAsync()
    {


        if (Ids != 0)
        {

            abon = await Ab.GetDetails(Ids);
            PPS = await ppd.GetAllPedidopagar();

            foreach (var item in PPS)
            {
                if (item.pedido == abon.No_Factura)
                {
                    var x = Convert.ToDecimal(item.deuda) + abon.Cantidad_cargo_Abono;
                    de = (float)x;
                }
            }


        }
        else
        {
            abon.No_Factura = id;
            abon.Fecha_Pago = DateTime.Now;
        }


    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPedidoPago ppd { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAbono Ab { get; set; }
    }
}
#pragma warning restore 1591
