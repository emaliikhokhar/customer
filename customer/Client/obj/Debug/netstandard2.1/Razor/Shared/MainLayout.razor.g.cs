#pragma checksum "C:\Users\HP USER\source\repos\customer\customer\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f68b48d095d8529a771d133e1acac7362f29c98f"
// <auto-generated/>
#pragma warning disable 1591
namespace customer.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP USER\source\repos\customer\customer\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP USER\source\repos\customer\customer\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP USER\source\repos\customer\customer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP USER\source\repos\customer\customer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP USER\source\repos\customer\customer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP USER\source\repos\customer\customer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP USER\source\repos\customer\customer\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP USER\source\repos\customer\customer\Client\_Imports.razor"
using customer.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP USER\source\repos\customer\customer\Client\_Imports.razor"
using customer.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "oi-header");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenComponent<customer.Client.Shared.NavMenu>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content px-4");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.AddContent(14, 
#nullable restore
#line 11 "C:\Users\HP USER\source\repos\customer\customer\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenComponent<customer.Client.Shared.Footer>(20);
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
