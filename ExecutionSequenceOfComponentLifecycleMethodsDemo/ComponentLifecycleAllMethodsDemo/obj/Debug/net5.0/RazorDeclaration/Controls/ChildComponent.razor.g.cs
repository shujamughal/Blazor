// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ComponentLifecycleAllMethodsDemo.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\ComponentLifecycleAllMethodsDemo\ComponentLifecycleAllMethodsDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\ComponentLifecycleAllMethodsDemo\ComponentLifecycleAllMethodsDemo\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ComponentLifecycleAllMethodsDemo\ComponentLifecycleAllMethodsDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\ComponentLifecycleAllMethodsDemo\ComponentLifecycleAllMethodsDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\ComponentLifecycleAllMethodsDemo\ComponentLifecycleAllMethodsDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\source\repos\ComponentLifecycleAllMethodsDemo\ComponentLifecycleAllMethodsDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\source\repos\ComponentLifecycleAllMethodsDemo\ComponentLifecycleAllMethodsDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\source\repos\ComponentLifecycleAllMethodsDemo\ComponentLifecycleAllMethodsDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\source\repos\ComponentLifecycleAllMethodsDemo\ComponentLifecycleAllMethodsDemo\_Imports.razor"
using ComponentLifecycleAllMethodsDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\ComponentLifecycleAllMethodsDemo\ComponentLifecycleAllMethodsDemo\_Imports.razor"
using ComponentLifecycleAllMethodsDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\source\repos\ComponentLifecycleAllMethodsDemo\ComponentLifecycleAllMethodsDemo\_Imports.razor"
using ComponentLifecycleAllMethodsDemo.Controls;

#line default
#line hidden
#nullable disable
    public partial class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\Admin\source\repos\ComponentLifecycleAllMethodsDemo\ComponentLifecycleAllMethodsDemo\Controls\ChildComponent.razor"
       
    [Parameter]
    public int count { get; set; }
    void ClickMeMethod()
    {

        Console.WriteLine("----------Child :Click Me Method------------");
    }

    public override Task SetParametersAsync(ParameterView parameters)
    {
        Console.WriteLine("Child : SetParametersAsync");
        return base.SetParametersAsync(parameters);
    }
    protected override void OnInitialized()
    {
        Console.WriteLine("Child : OnInitialized");
        base.OnInitialized();
    }
    protected override Task OnInitializedAsync()
    {
        Console.WriteLine("Child : OnInitializedAsync");

        return base.OnInitializedAsync();
    }
    protected override void OnParametersSet()
    {
        Console.WriteLine("Child : OnParametersSet");

        base.OnParametersSet();
    }
    protected override Task OnParametersSetAsync()
    {
        Console.WriteLine("Child : OnParametersSetAsync");

        return base.OnParametersSetAsync();
    }
    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine("Child : OnAfterRender");

        base.OnAfterRender(firstRender);
    }
    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        Console.WriteLine("Child : OnAfterRenderAsync");

        return base.OnAfterRenderAsync(firstRender);
    }
    protected override bool ShouldRender()
    {
        Console.WriteLine("Child : ShouldRender");

        return base.ShouldRender();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
