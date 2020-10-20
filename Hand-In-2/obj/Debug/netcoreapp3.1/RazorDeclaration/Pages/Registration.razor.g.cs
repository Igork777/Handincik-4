#pragma checksum "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Registration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cb2f87816e6128889f96f30c0c8e8c67448c518"
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
#line 2 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Registration.razor"
using Hand_In_2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Registration.razor"
using Hand_In_2.Data.Impl;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registration")]
    public partial class Registration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Registration.razor"
       
    private string _username;
    private string _city;
    private string _password;
    private string _errorMessage;

    public async Task PerformRegister()
    {
        _errorMessage = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateRegistration(_username, _city, _password);
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            _errorMessage = e.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
