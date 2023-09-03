// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\Pages\Index.razor"
using SBShared.Const;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\Pages\Index.razor"
using SBShared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\Pages\Index.razor"
using SBShared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\Pages\Index.razor"
using SBSender.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "F:\DevOps Respositories\IntroToAzureServiceBusSourceCode\SBSender\Pages\Index.razor"
      
    private Person person = new Person();

    // private async Task PublishMessage()
    // {
    //     await queue.SendMessageAsync(person, "personqueue");
    //     person = new Person();
    // }
    private async Task UpdatePersonName(Person person)
    {
        UpdateNameMessageDTO updateName = new UpdateNameMessageDTO()
            {
                PersonId = person.Id,
                NewName = person.Name
            };
        await queue.SendMessageAsync(updateName, "personqueue", Status.UpdatePersonName);
        person = new Person();
    }

    private async Task AddPerson(Person person)
    {
        AddPersonMessageDTO addPerson = new AddPersonMessageDTO()
            {
                PersonId = person.Id,
                Name = person.Name,
                Age = person.Age
            };
        await queue.SendMessageAsync(addPerson, "personqueue", Status.AddPerson);
        person = new Person();
    }

    private async Task DeletePerson(Person person)
    {
        DeletePersonMessageDTO deletePerson = new DeletePersonMessageDTO()
            {
                PersonId = person.Id
            };
        await queue.SendMessageAsync(deletePerson, "personqueue", Status.DeletePerson);
        person = new Person();
    }

    private async Task UpdatePersonAge(Person person)
    {
        UpdateAgeMessageDTO updateAge = new UpdateAgeMessageDTO()
            {
                PersonId = person.Id,
                NewAge = person.Age
            };
        await queue.SendMessageAsync(updateAge, "personqueue", Status.UpdatePersonAge);
        person = new Person();
    }

    private async Task PrintPersonsList()
    {
        PrintPersonsListMessageDTO printPersonsList = new PrintPersonsListMessageDTO(){};
        await queue.SendMessageAsync(printPersonsList, "personqueue",Status.PrintPersonsList);
        person = new Person();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQueueService queue { get; set; }
    }
}
#pragma warning restore 1591