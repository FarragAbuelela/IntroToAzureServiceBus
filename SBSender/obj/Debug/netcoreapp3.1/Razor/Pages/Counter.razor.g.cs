#pragma checksum "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\Pages\Counter.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a01f942b5f980398b9991ceaf1a8993f848782231f152d365255e51dde915d61"
// <auto-generated/>
#pragma warning disable 1591
namespace SBSender.Pages
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
#nullable restore
#line 5 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\Pages\Counter.razor"
__builder.AddContent(3, currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591