#pragma checksum "C:\Users\Admin\Documents\GitHub\Blazor\BlazorEventCallbackExample\BlazorEventCallbackExample\Controls\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8377fd0035a1c30e002513633f737d0ff05e2b6e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorEventCallbackExample.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorEventCallbackExample\BlazorEventCallbackExample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorEventCallbackExample\BlazorEventCallbackExample\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorEventCallbackExample\BlazorEventCallbackExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorEventCallbackExample\BlazorEventCallbackExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorEventCallbackExample\BlazorEventCallbackExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorEventCallbackExample\BlazorEventCallbackExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorEventCallbackExample\BlazorEventCallbackExample\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorEventCallbackExample\BlazorEventCallbackExample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorEventCallbackExample\BlazorEventCallbackExample\_Imports.razor"
using BlazorEventCallbackExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorEventCallbackExample\BlazorEventCallbackExample\_Imports.razor"
using BlazorEventCallbackExample.Shared;

#line default
#line hidden
#nullable disable
    public partial class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ChildComponent</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorEventCallbackExample\BlazorEventCallbackExample\Controls\ChildComponent.razor"
                   MyMethod

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Click ME");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorEventCallbackExample\BlazorEventCallbackExample\Controls\ChildComponent.razor"
       

    [Parameter]
    public EventCallback<string> OnClickCallback { get; set; }

    private void MyMethod() {

        OnClickCallback.InvokeAsync("I am sending data from child");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
