#pragma checksum "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed8d4a8cb4be28c70e7133a977e0177d9b4f5cb5"
// <auto-generated/>
#pragma warning disable 1591
namespace AuthorizationDemo.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\_Imports.razor"
using AuthorizationDemo.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\_Imports.razor"
using AuthorizationDemo.Client.Shared;

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
            __builder.OpenComponent<AuthorizationDemo.Client.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "ul");
#nullable restore
#line 11 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\Pages\Index.razor"
         foreach (var item in context.User.Claims) { 

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(7, "li");
                __builder2.AddContent(8, 
#nullable restore
#line 12 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\Pages\Index.razor"
             item.Type

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(9, ", value: ");
                __builder2.AddContent(10, 
#nullable restore
#line 12 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\Pages\Index.razor"
                                item.Value

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 13 "C:\Users\Admin\source\repos\AuthorizationDemo\AuthorizationDemo\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
