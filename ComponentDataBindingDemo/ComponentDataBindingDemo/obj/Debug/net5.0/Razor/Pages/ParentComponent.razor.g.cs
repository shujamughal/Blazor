#pragma checksum "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\Pages\ParentComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85efeea8e084894394278cbd6824a33b33ebd456"
// <auto-generated/>
#pragma warning disable 1591
namespace ComponentDataBindingDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\_Imports.razor"
using ComponentDataBindingDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\_Imports.razor"
using ComponentDataBindingDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\_Imports.razor"
using ComponentDataBindingDemo.Controls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pc")]
    public partial class ParentComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ParentComponent</h3>\r\n");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\Pages\ParentComponent.razor"
     Number

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\Pages\ParentComponent.razor"
                  UpdateValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Update Value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenComponent<ComponentDataBindingDemo.Controls.ChildComponent>(8);
            __builder.AddAttribute(9, "ParnetNumber", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\Pages\ParentComponent.razor"
                                     Number

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "myEventCallback1", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Number = __value, Number))));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\ComponentDataBindingDemo\ComponentDataBindingDemo\Pages\ParentComponent.razor"
       

    private int Number { get; set; } = 1;

    void UpdateValue() {

        Number = Number + 1;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591