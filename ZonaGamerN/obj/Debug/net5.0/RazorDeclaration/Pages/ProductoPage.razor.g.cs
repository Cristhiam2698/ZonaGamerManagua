// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ZonaGamerN.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Cristhiam Padilla\source\repos\ZonaGamerN\ZonaGamerN\ZonaGamerN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cristhiam Padilla\source\repos\ZonaGamerN\ZonaGamerN\ZonaGamerN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cristhiam Padilla\source\repos\ZonaGamerN\ZonaGamerN\ZonaGamerN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cristhiam Padilla\source\repos\ZonaGamerN\ZonaGamerN\ZonaGamerN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Cristhiam Padilla\source\repos\ZonaGamerN\ZonaGamerN\ZonaGamerN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Cristhiam Padilla\source\repos\ZonaGamerN\ZonaGamerN\ZonaGamerN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Cristhiam Padilla\source\repos\ZonaGamerN\ZonaGamerN\ZonaGamerN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Cristhiam Padilla\source\repos\ZonaGamerN\ZonaGamerN\ZonaGamerN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Cristhiam Padilla\source\repos\ZonaGamerN\ZonaGamerN\ZonaGamerN\_Imports.razor"
using ZonaGamerN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Cristhiam Padilla\source\repos\ZonaGamerN\ZonaGamerN\ZonaGamerN\_Imports.razor"
using ZonaGamerN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cristhiam Padilla\source\repos\ZonaGamerN\ZonaGamerN\ZonaGamerN\Pages\ProductoPage.razor"
using ZonaGamerN.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/producto")]
    public partial class ProductoPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\Cristhiam Padilla\source\repos\ZonaGamerN\ZonaGamerN\ZonaGamerN\Pages\ProductoPage.razor"
       
    List<Producto> productos = new List<Producto>();
    Producto producto = new Producto();
    string Message = "";

    protected override async Task OnInitializedAsync()
    {
        GetProductos();
    }



    private void GetProductos()
    {
        productos = productoRepositorio.GetProductos();
    }
    private void GetById(int Idproducto)
    {
        producto = productoRepositorio.GetById(Idproducto);
    }
    private void Save()
    {
        var productoObj = new Producto();
        productoObj = productoRepositorio.SaveOrUpdate(producto);
        producto = new Producto();
        GetProductos();
    }
    private void Delete(Producto oProducto)
    {
        Message = productoRepositorio.Delete(oProducto.Id_Producto);
        productos.RemoveAll(x => x.Id_Producto == oProducto.Id_Producto);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ZonaGamerN.IRepositorio.IProductoRepositorio productoRepositorio { get; set; }
    }
}
#pragma warning restore 1591
