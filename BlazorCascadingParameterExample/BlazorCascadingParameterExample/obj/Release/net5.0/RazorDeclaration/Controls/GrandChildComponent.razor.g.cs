// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCascadingParameterExample.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorCascadingParameterExample\BlazorCascadingParameterExample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorCascadingParameterExample\BlazorCascadingParameterExample\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorCascadingParameterExample\BlazorCascadingParameterExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorCascadingParameterExample\BlazorCascadingParameterExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorCascadingParameterExample\BlazorCascadingParameterExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorCascadingParameterExample\BlazorCascadingParameterExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorCascadingParameterExample\BlazorCascadingParameterExample\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorCascadingParameterExample\BlazorCascadingParameterExample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorCascadingParameterExample\BlazorCascadingParameterExample\_Imports.razor"
using BlazorCascadingParameterExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorCascadingParameterExample\BlazorCascadingParameterExample\_Imports.razor"
using BlazorCascadingParameterExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorCascadingParameterExample\BlazorCascadingParameterExample\_Imports.razor"
using BlazorCascadingParameterExample.Controls;

#line default
#line hidden
#nullable disable
    public partial class GrandChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorCascadingParameterExample\BlazorCascadingParameterExample\Controls\GrandChildComponent.razor"
           
        [CascadingParameter(Name ="m")]
        public string MyMessage { get; set; }

        [CascadingParameter(Name ="a")]
        public int MyAge { get; set; }

        [CascadingParameter(Name ="MYn")]
        public string MyName { get; set; }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591