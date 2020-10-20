#pragma checksum "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41bcf8643ef56bda597ba8d76cbe794264924923"
// <auto-generated/>
#pragma warning disable 1591
namespace Hand_In_2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\_Imports.razor"
using Hand_In_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\_Imports.razor"
using Hand_In_2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
using Hand_In_2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
using Hand_In_2.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
using Hand_In_2.Data.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by user First Name: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
                                                               (arg) => FilterByFirstName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width: 50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddMarkupContent(10, "\r\n    Filter by user Last Name: ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
                                                              (arg) => FilterByLastName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "style", "width: 50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "table");
            __builder.AddAttribute(18, "class", "table");
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.AddMarkupContent(20, @"<thead>
    <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Hair color</th>
        <th>Eye color</th>
        <th>Age</th>
        <th>Weight</th>
        <th>Height</th>
        <th>Sex</th>
        <th>JobTitle</th>
    </tr>
    </thead>
    ");
            __builder.OpenElement(21, "tbody");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 35 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
     foreach (var item in adults)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 38 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
                 item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 39 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
                 item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 40 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
                 item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 41 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
                 item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 42 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
                 item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 43 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
                 item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 44 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
                 item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 45 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
                 item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 46 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
                 item.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "td");
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
                                    () => RemoveAdult(item.FirstName, item.LastName)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "\r\n                    <i class=\"oi oi-trash\" style=\"color: red\"></i>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "td");
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
                                    () => UpdateAdult(item.FirstName, item.LastName)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "\r\n                    Update\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 58 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor"
       
    private IList<Adult> adults;
    private string filterByFirstName, filterByLastName, age;
    private ClaimsPrincipal _claimsPrincipal;

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        _claimsPrincipal = authState.User;
        adults = AdultsService.getAllAdults();
    }

    private void RemoveAdult(string firstName, string lastName)
    {
        adults = AdultsService.RemoveAdult(firstName, lastName);
    }

    private void UpdateAdult(string firstName, string lastName)
    {
        AppDataToUpdateAdult.adult = adults.First(t => t.FirstName.Equals(firstName) && t.LastName.Equals(lastName));
        NavigationManager.NavigateTo("/updateAdult");
    }

    private void FilterByFirstName(ChangeEventArgs changeEventArgs)
    {
        filterByFirstName = changeEventArgs.Value.ToString();
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        adults = AdultsService.getAllAdults().Where((t => filterByFirstName != null && t.FirstName.StartsWith(filterByFirstName, StringComparison.OrdinalIgnoreCase) && (filterByLastName != null && t.LastName.StartsWith(filterByLastName, StringComparison.OrdinalIgnoreCase)))).ToList();
    }

    private void FilterByLastName(ChangeEventArgs changeEventArgs)
    {
        filterByLastName = changeEventArgs.Value.ToString();
        ExecuteFilter();
    }

    private void FilterByMinAge(object o)
    {
        throw new NotImplementedException();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppDataToUpdateAdult AppDataToUpdateAdult { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsService AdultsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591