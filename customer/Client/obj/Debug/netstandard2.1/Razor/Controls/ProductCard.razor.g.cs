#pragma checksum "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7fcb712c6172705549d55b1ac84d0b0e7c7b822"
// <auto-generated/>
#pragma warning disable 1591
namespace customer.Client.Controls
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
    public partial class ProductCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>All Products</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-group");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card col");
            __builder.AddAttribute(6, "style", "width: 18rem;");
            __builder.AddMarkupContent(7, "\r\n        <img src=\"/images/football.png\" class=\"card-img-top\" alt=\"...\">\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "h5");
            __builder.AddAttribute(12, "class", "card-title");
            __builder.AddContent(13, 
#nullable restore
#line 7 "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor"
                                    Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "h6");
            __builder.AddContent(16, "Category: ");
            __builder.AddContent(17, 
#nullable restore
#line 8 "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor"
                           Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "class", "card-text");
            __builder.AddContent(21, "Price: ");
            __builder.AddContent(22, 
#nullable restore
#line 9 "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor"
                                         Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, " PKR");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n          \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "card col");
            __builder.AddAttribute(29, "style", "width: 18rem;");
            __builder.AddMarkupContent(30, "\r\n        <img src=\"/images/LED.png\" class=\"card-img-top\" alt=\"...\">\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "card-body");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "h5");
            __builder.AddAttribute(35, "class", "card-title");
            __builder.AddContent(36, 
#nullable restore
#line 16 "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor"
                                    Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "h6");
            __builder.AddContent(39, "Category: ");
            __builder.AddContent(40, 
#nullable restore
#line 17 "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor"
                           Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "p");
            __builder.AddAttribute(43, "class", "card-text");
            __builder.AddContent(44, "Price: ");
            __builder.AddContent(45, 
#nullable restore
#line 18 "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor"
                                         Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(46, " PKR");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n          \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "card col");
            __builder.AddAttribute(52, "style", "width: 18rem;");
            __builder.AddMarkupContent(53, "\r\n        <img src=\"/images/AC.png\" class=\"card-img-top\" alt=\"...\">\r\n        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "card-body");
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "h5");
            __builder.AddAttribute(58, "class", "card-title");
            __builder.AddContent(59, 
#nullable restore
#line 25 "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor"
                                    Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "h6");
            __builder.AddContent(62, "Category: ");
            __builder.AddContent(63, 
#nullable restore
#line 26 "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor"
                           Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.OpenElement(65, "p");
            __builder.AddAttribute(66, "class", "card-text");
            __builder.AddContent(67, "Price: ");
            __builder.AddContent(68, 
#nullable restore
#line 27 "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor"
                                         Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(69, " PKR");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n          \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "card col");
            __builder.AddAttribute(75, "style", "width: 18rem;");
            __builder.AddMarkupContent(76, "\r\n        <img src=\"/images/Mobile.png\" class=\"card-img-top\" alt=\"...\">\r\n        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "card-body");
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.OpenElement(80, "h5");
            __builder.AddAttribute(81, "class", "card-title");
            __builder.AddContent(82, 
#nullable restore
#line 34 "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor"
                                    Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "h6");
            __builder.AddContent(85, "Category: ");
            __builder.AddContent(86, 
#nullable restore
#line 35 "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor"
                           Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.OpenElement(88, "p");
            __builder.AddAttribute(89, "class", "card-text");
            __builder.AddContent(90, "Price: ");
            __builder.AddContent(91, 
#nullable restore
#line 36 "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor"
                                         Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, " PKR");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n          \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\HP USER\source\repos\customer\customer\Client\Controls\ProductCard.razor"
       
    [Parameter]
    public string Title { set; get; }

    [Parameter]
    public string Category { set; get; }

    [Parameter]
    public int Price { set; get; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
