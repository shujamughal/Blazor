// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SimpleShop.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture5_CustomerComponent\SimpleShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture5_CustomerComponent\SimpleShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture5_CustomerComponent\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture5_CustomerComponent\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture5_CustomerComponent\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture5_CustomerComponent\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture5_CustomerComponent\SimpleShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture5_CustomerComponent\SimpleShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture5_CustomerComponent\SimpleShop\Client\_Imports.razor"
using SimpleShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture5_CustomerComponent\SimpleShop\Client\_Imports.razor"
using SimpleShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture5_CustomerComponent\SimpleShop\Client\_Imports.razor"
using SimpleShop.Shared;

#line default
#line hidden
#nullable disable
    public partial class ProductItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture5_CustomerComponent\SimpleShop\Client\Pages\ProductItem.razor"
      
    [Parameter]
    public Product Product { get; set; }

    [Parameter]
    public string ButtonTitle { get; set; }
    [Parameter]
    public string ButtonClass { get; set; }
    [Parameter]
    public EventCallback<Product> SelectedProduct { get; set; }

    private string ProductImage(Catagory catgory) {
        return $"Images/{catgory.ToString().ToLower()}.png";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
