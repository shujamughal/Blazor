#pragma checksum "C:\Users\Admin\Documents\GitHub\Blazor\JSInterDemo2\JSInterDemo2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a27cfcf5a6a48ed0b95b421d48512de4f18ee5d"
// <auto-generated/>
#pragma warning disable 1591
namespace JSInterDemo2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\Blazor\JSInterDemo2\JSInterDemo2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\Blazor\JSInterDemo2\JSInterDemo2\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\Blazor\JSInterDemo2\JSInterDemo2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\JSInterDemo2\JSInterDemo2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\JSInterDemo2\JSInterDemo2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\Blazor\JSInterDemo2\JSInterDemo2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\JSInterDemo2\JSInterDemo2\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\Blazor\JSInterDemo2\JSInterDemo2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\JSInterDemo2\JSInterDemo2\_Imports.razor"
using JSInterDemo2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\Blazor\JSInterDemo2\JSInterDemo2\_Imports.razor"
using JSInterDemo2.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<JSInterDemo2.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.AddMarkupContent(4, "<p>The value is: <span id=\"s1\"></span></p>\r\n");
            __builder.AddMarkupContent(5, "<button onclick=\"GetNumber(1)\"> Click Here</button>\r\n\r\n");
            __builder.AddMarkupContent(6, "<button onclick=\"GetSR(5)\"> Click Here 2</button>");
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Admin\Documents\GitHub\Blazor\JSInterDemo2\JSInterDemo2\Pages\Index.razor"
       

    [JSInvokable]
    public static int ReturnArray(int index)
    {
        int[] nos = { 10, 20, 30, 40 };
        return nos[index];
    }

    [JSInvokable]
    public static Task<string> CalculateSquareRootAsync(int number)
    {
        var result = Math.Sqrt(number);
        return Task.FromResult($"The square root of {number} is {result}");

    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
