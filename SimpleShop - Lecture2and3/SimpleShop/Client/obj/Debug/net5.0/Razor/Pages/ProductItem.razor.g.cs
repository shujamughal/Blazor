#pragma checksum "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ProductItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ad0fc9e44ba1a9134e9ba0ffe4d8ebd6acf19a9"
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
    public partial class ProductItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "width: 18rem;");
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "height", "150");
            __builder.AddAttribute(5, "width", "150");
            __builder.AddAttribute(6, "src", 
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ProductItem.razor"
                                        ProductImage(Product.Catagory)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.OpenElement(10, "h5");
            __builder.AddAttribute(11, "class", "card-title");
            __builder.AddContent(12, 
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ProductItem.razor"
                                Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "class", "card-text");
            __builder.AddContent(16, 
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ProductItem.razor"
                                Product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "class", "card-text");
            __builder.AddContent(20, 
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ProductItem.razor"
                                Product.Catagory

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-footer");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "class", 
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ProductItem.razor"
                        ButtonClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ProductItem.razor"
                           async()=> await SelectedProduct.InvokeAsync(Product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, 
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ProductItem.razor"
                 ButtonTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Admin\Documents\GitHub\Blazor\SimpleShop - Lecture2\SimpleShop\Client\Pages\ProductItem.razor"
      
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
