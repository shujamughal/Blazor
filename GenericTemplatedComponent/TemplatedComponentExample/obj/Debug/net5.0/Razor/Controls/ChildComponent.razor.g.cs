#pragma checksum "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\Controls\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a8d9af6abd0280ed878079a5989a882605b14c8"
// <auto-generated/>
#pragma warning disable 1591
namespace TemplatedComponentExample.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\_Imports.razor"
using TemplatedComponentExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\_Imports.razor"
using TemplatedComponentExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\_Imports.razor"
using TemplatedComponentExample.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\_Imports.razor"
using TemplatedComponentExample.Models;

#line default
#line hidden
#nullable disable
    public partial class ChildComponent<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ChildComponent</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\Controls\ChildComponent.razor"
     foreach (TItem p in Items)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\Controls\ChildComponent.razor"
         MySection(p)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\Controls\ChildComponent.razor"
                     
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<br>\r\n    <br>\r\n    <br>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Admin\Documents\GitHub\Blazor\GenericTemplatedComponent\TemplatedComponentExample\Controls\ChildComponent.razor"
       

           
    [Parameter]
    public List<TItem> Items { get; set; }


    [Parameter]
    public RenderFragment<TItem> MySection { get; set; }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
