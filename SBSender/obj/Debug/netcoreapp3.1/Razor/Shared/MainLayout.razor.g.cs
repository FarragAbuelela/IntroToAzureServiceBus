#pragma checksum "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "68229949978c4aef582e8746ed87bcd12c7872871de53bfa53ad9adcf7dfefe0"
// <auto-generated/>
#pragma warning disable 1591
namespace SBSender.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\_Imports.razor"
using SBSender;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\_Imports.razor"
using SBSender.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<global::SBSender.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\r\n        ");
#nullable restore
#line 13 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\Shared\MainLayout.razor"
__builder.AddContent(13, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591