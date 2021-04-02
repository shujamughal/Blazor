#pragma checksum "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ShoppingCart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "695d122717bb09cbb7edfb7e824f80c9b870d891"
// <auto-generated/>
#pragma warning disable 1591
namespace SimpleShop.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\_Imports.razor"
using SimpleShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\_Imports.razor"
using SimpleShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\_Imports.razor"
using SimpleShop.Shared;

#line default
#line hidden
#nullable disable
    public partial class ShoppingCart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ShoppingCart.razor"
     Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ShoppingCart.razor"
 if (Cart.Orders.Any()) {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-group");
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ShoppingCart.razor"
         foreach(var product in Products)
                {


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<SimpleShop.Client.Pages.ProductItem>(4);
            __builder.AddAttribute(5, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SimpleShop.Shared.Product>(
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ShoppingCart.razor"
                                   product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ButtonClass", "btn btn-danger");
            __builder.AddAttribute(7, "ButtonTitle", "Remove");
            __builder.CloseComponent();
#nullable restore
#line 12 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ShoppingCart.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ShoppingCart.razor"
 }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ShoppingCart.razor"
       

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public Cart Cart { get; set; }

    public IEnumerable<Product> Products { get; set; }
    [Parameter]
    public Func<int,Product> GetProductFromId { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        Products = Cart.Orders.Select((id)=>
        GetProductFromId(id));
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
