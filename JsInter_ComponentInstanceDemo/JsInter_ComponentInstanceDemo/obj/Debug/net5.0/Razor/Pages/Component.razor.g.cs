#pragma checksum "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_ComponentInstanceDemo\JsInter_ComponentInstanceDemo\Pages\Component.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11d2536a0a0a1af2dd7f79f0f0bb90d0d7ecc3a2"
// <auto-generated/>
#pragma warning disable 1591
namespace JsInter_ComponentInstanceDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_ComponentInstanceDemo\JsInter_ComponentInstanceDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_ComponentInstanceDemo\JsInter_ComponentInstanceDemo\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_ComponentInstanceDemo\JsInter_ComponentInstanceDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_ComponentInstanceDemo\JsInter_ComponentInstanceDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_ComponentInstanceDemo\JsInter_ComponentInstanceDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_ComponentInstanceDemo\JsInter_ComponentInstanceDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_ComponentInstanceDemo\JsInter_ComponentInstanceDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_ComponentInstanceDemo\JsInter_ComponentInstanceDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_ComponentInstanceDemo\JsInter_ComponentInstanceDemo\_Imports.razor"
using JsInter_ComponentInstanceDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_ComponentInstanceDemo\JsInter_ComponentInstanceDemo\_Imports.razor"
using JsInter_ComponentInstanceDemo.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/c1")]
    public partial class Component : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddMarkupContent(1, "\r\n    Message: ");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_ComponentInstanceDemo\JsInter_ComponentInstanceDemo\Pages\Component.razor"
              message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.AddMarkupContent(4, "<button onclick=\"JSFunction(\'my value\')\"> Call JS Method</button>");
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\JsInter_ComponentInstanceDemo\JsInter_ComponentInstanceDemo\Pages\Component.razor"
       
    private static Func<string, string> action;

    private string message = "Select the button.";

    protected override void OnInitialized()
    {
        action = DotNetFunction;
    }


    private string DotNetFunction(string name)
    {
        message = $"{name}, DotNetFunction Called!";
        StateHasChanged();

        return message;
    }

    [JSInvokable]
    public static string FunctionCaller(string name)
    {
        return action.Invoke(name);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
