#pragma checksum "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf2d4cbbb0b6723125f26d918c3465f7bf31a91"
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
#line 1 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\_Imports.razor"
using SimpleShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\_Imports.razor"
using SimpleShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\_Imports.razor"
using SimpleShop.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-group");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\Pages\Index.razor"
     foreach (var product in Catalog.Products)
    {


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<SimpleShop.Client.Pages.ProductItem>(2);
            __builder.AddAttribute(3, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SimpleShop.Shared.Product>(
#nullable restore
#line 6 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\Pages\Index.razor"
                               product

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 7 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Admin\source\repos\SimpleShop\SimpleShop\Client\Pages\Index.razor"
       

    private Catalog Catalog { get; set; } = new Catalog
    {

        Products = new List<Product> {
        new Product(1,"Table",98,Catagory.Furniture),
        new Product(1,"Jeans",45,Catagory.Cloth),
        new Product(1,"Football",190,Catagory.Sport),
        }

    };


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
