#pragma checksum "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Registration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cb2f87816e6128889f96f30c0c8e8c67448c518"
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "form-group");
                __builder2.AddAttribute(5, "style", "display: flex;justify-content: center");
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.AddMarkupContent(7, "<label>User name:</label>\r\n            ");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "type", "text");
                __builder2.AddAttribute(10, "placeholder", "user name");
                __builder2.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Registration.razor"
                                                                    _username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddAttribute(17, "style", "display: flex;justify-content: center");
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.AddMarkupContent(19, "<label>City:</label>\r\n            ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "type", "text");
                __builder2.AddAttribute(22, "placeholder", "city");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Registration.razor"
                                                               _city

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _city = __value, _city));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddAttribute(29, "style", "display: flex;justify-content: center");
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.AddMarkupContent(31, "<label>Password</label>\r\n            ");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "type", "password");
                __builder2.AddAttribute(34, "placeholder", "password");
                __builder2.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Registration.razor"
                                                                       _password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _password = __value, _password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "style", "color: red;display: flex;justify-content: center");
                __builder2.AddContent(41, 
#nullable restore
#line 23 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Registration.razor"
                                                                       _errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "style", "display: flex;justify-content: center");
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\Registration.razor"
                              PerformRegister

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(48, "Register");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
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
