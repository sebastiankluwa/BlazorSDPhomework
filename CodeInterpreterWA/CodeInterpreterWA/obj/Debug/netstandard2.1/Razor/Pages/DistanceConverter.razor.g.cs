#pragma checksum "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\Pages\DistanceConverter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e72da244f1f042b104f8d14de9a69767e9f841c"
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
    public partial class DistanceConverter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-4");
            __builder.AddMarkupContent(4, "<label>Meters</label>\r\n\t\t");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "number");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "placeholder", "Meters ...");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\Pages\DistanceConverter.razor"
                                                                                  Meters

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Meters = __value, Meters, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\Pages\DistanceConverter.razor"
 if (_inches != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row blockquote mt-5");
            __builder.OpenElement(13, "span");
            __builder.AddContent(14, 
#nullable restore
#line 12 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\Pages\DistanceConverter.razor"
               Meters

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " m equal to ");
            __builder.AddContent(16, 
#nullable restore
#line 12 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\Pages\DistanceConverter.razor"
                                  _inches

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " inches!  ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\Pages\DistanceConverter.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\sebas\Desktop\CodeInterpreterWA\BlazorSDPhomework\CodeInterpreterWA\CodeInterpreterWA\Pages\DistanceConverter.razor"
       
		double? _inches = null;
		double? _meters = null;

	public double? Meters
	{
		get => _meters;
		set
		{
			_meters = value;
			ConvertDistance();
		}
	}

	private void ConvertDistance()
	{
		_inches = Meters / 0.0254d;
	}


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
