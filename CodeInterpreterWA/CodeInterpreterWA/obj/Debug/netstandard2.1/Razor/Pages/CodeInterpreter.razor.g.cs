#pragma checksum "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\Pages\CodeInterpreter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "179455a438f91b0668c920a315acbc40f81c23ac"
// <auto-generated/>
#pragma warning disable 1591
namespace CodeInterpreterWA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/interpreter")]
    public partial class CodeInterpreter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Interpreter</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddAttribute(3, "style", "height: 600px;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-6 h-100");
            __builder.OpenElement(6, "textarea");
            __builder.AddAttribute(7, "class", "form-control h-100");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\Pages\CodeInterpreter.razor"
                                                    _markdownCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _markdownCode = __value, _markdownCode));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\t");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-6 h-100");
            __builder.AddContent(13, 
#nullable restore
#line 10 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\Pages\CodeInterpreter.razor"
          (MarkupString)@Markdig.Markdown.ToHtml(_markdownCode)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\Pages\CodeInterpreter.razor"
       
	string _markdownCode = string.Empty;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
