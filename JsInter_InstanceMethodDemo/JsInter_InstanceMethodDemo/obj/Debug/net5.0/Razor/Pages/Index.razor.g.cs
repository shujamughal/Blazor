#pragma checksum "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_InstanceMethodDemo\JsInter_InstanceMethodDemo\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b5fa25e0b4db0124741b9158122206e310369b8"
// <auto-generated/>
#pragma warning disable 1591
namespace JsInter_InstanceMethodDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_InstanceMethodDemo\JsInter_InstanceMethodDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_InstanceMethodDemo\JsInter_InstanceMethodDemo\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_InstanceMethodDemo\JsInter_InstanceMethodDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_InstanceMethodDemo\JsInter_InstanceMethodDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_InstanceMethodDemo\JsInter_InstanceMethodDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_InstanceMethodDemo\JsInter_InstanceMethodDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_InstanceMethodDemo\JsInter_InstanceMethodDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_InstanceMethodDemo\JsInter_InstanceMethodDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_InstanceMethodDemo\JsInter_InstanceMethodDemo\_Imports.razor"
using JsInter_InstanceMethodDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_InstanceMethodDemo\JsInter_InstanceMethodDemo\_Imports.razor"
using JsInter_InstanceMethodDemo.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_InstanceMethodDemo\JsInter_InstanceMethodDemo\Pages\Index.razor"
                  MyMethod

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Click Me to call class method from js");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_InstanceMethodDemo\JsInter_InstanceMethodDemo\Pages\Index.razor"
       

    private async Task MyMethod()
    {
        Models.Person p = new Models.Person { Name = "Shuja" };

        await jsRuntime.InvokeVoidAsync("CallClassMethod", DotNetObjectReference.Create(p));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
