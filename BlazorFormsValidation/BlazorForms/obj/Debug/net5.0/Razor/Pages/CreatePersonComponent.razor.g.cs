#pragma checksum "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\Pages\CreatePersonComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aa149ea68e0e625b8f486e15b1bd4c191eac026"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForms.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\_Imports.razor"
using BlazorForms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\_Imports.razor"
using BlazorForms.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cp")]
    public partial class CreatePersonComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreatePersonComponent</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\Pages\CreatePersonComponent.razor"
    person.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "h1");
            __builder.AddContent(5, 
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\Pages\CreatePersonComponent.razor"
     status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\Pages\CreatePersonComponent.razor"
                  person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\Pages\CreatePersonComponent.razor"
                                         FormSubmitted

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\Pages\CreatePersonComponent.razor"
                                                                         MyFun

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.AddMarkupContent(16, "<label for=\"Name\">Name : </label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "id", "name");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\Pages\CreatePersonComponent.razor"
                                      person.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.Name = __value, person.Name))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __Blazor.BlazorForms.Pages.CreatePersonComponent.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\Pages\CreatePersonComponent.razor"
                              ()=> person.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(25, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(26, "<label for=\"Age\">Age : </label>\r\n    ");
                __Blazor.BlazorForms.Pages.CreatePersonComponent.TypeInference.CreateInputNumber_1(__builder2, 27, 28, "age", 29, 
#nullable restore
#line 13 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\Pages\CreatePersonComponent.razor"
                                       person.Age

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.Age = __value, person.Age)), 31, () => person.Age);
                __builder2.AddMarkupContent(32, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(33, "<label for=\"Email\">Email : </label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "id", "email");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\Pages\CreatePersonComponent.razor"
                                       person.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => person.Email = __value, person.Email))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => person.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n    <br>\r\n    <input type=\"submit\" value=\"Save\">");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Admin\Documents\GitHub\Blazor\BlazorFormsValidation\BlazorForms\Pages\CreatePersonComponent.razor"
       
    string status = "Form is not submitted";
    void MyFun() {
        status = "There are some errors and this data should not be submitted to server.";
    }
    void FormSubmitted() {
        status = "Form is submitted";

    }
    Person person = new Person {
        Name = "Ali",
        Age = 4,
        Email = "ali@gmail.com"
    };

    public class Person {
        [Required]
        [StringLength(10, ErrorMessage ="Name is too long")]
        public string Name { get; set; }
        [Required]
        [Range(18,80,ErrorMessage ="Age must be between 18 and 80")]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorForms.Pages.CreatePersonComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
