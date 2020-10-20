#pragma checksum "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41bcf8643ef56bda597ba8d76cbe794264924923"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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