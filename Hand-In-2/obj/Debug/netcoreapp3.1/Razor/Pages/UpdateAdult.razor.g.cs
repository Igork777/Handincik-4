#pragma checksum "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69a6d37fa8d79d7dd6f3a9c7ac058c93bb127be9"
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
#line 2 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
using Hand_In_2.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
using Hand_In_2.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
using Hand_In_2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
using Hand_In_2.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/updateAdult")]
    public partial class UpdateAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>UpdateAdult</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                  newAdult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "\r\n        First Name <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "first-name");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                                                newAdult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.FirstName = __value, newAdult.FirstName))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "p");
                __builder2.AddAttribute(19, "style", "color: red");
                __builder2.AddContent(20, 
#nullable restore
#line 17 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                               firstNameError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "\r\n        Last Name <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "id", "last-name");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                                               newAdult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.LastName = __value, newAdult.LastName))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "p");
                __builder2.AddAttribute(33, "style", "color: red");
                __builder2.AddContent(34, 
#nullable restore
#line 22 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                               lastNameError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "\r\n        Hair Color <br>\r\n        ");
                __builder2.OpenElement(40, "select");
                __builder2.AddAttribute(41, "class", "form-control selectpicker");
                __builder2.AddAttribute(42, "style", "width: 300px");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                       hairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hairColor = __value, hairColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenElement(46, "option");
                __builder2.AddAttribute(47, "selected", true);
                __builder2.AddAttribute(48, "disabled", true);
                __builder2.AddAttribute(49, "value", "-1");
                __builder2.AddContent(50, "Choose the hair color");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.OpenElement(52, "option");
                __builder2.AddContent(53, "blond");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.OpenElement(55, "option");
                __builder2.AddContent(56, "red");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.OpenElement(58, "option");
                __builder2.AddContent(59, "brown");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.OpenElement(61, "option");
                __builder2.AddContent(62, "black");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.OpenElement(64, "option");
                __builder2.AddContent(65, "white");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.OpenElement(67, "option");
                __builder2.AddContent(68, "grey");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n            ");
                __builder2.OpenElement(70, "option");
                __builder2.AddContent(71, "blue");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n            ");
                __builder2.OpenElement(73, "option");
                __builder2.AddContent(74, "green");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.OpenElement(76, "option");
                __builder2.AddContent(77, "leverpostej");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group");
                __builder2.AddMarkupContent(83, "\r\n        Eye color <br>\r\n        ");
                __builder2.OpenElement(84, "select");
                __builder2.AddAttribute(85, "class", "form-control selectpicker");
                __builder2.AddAttribute(86, "style", "width: 300px");
                __builder2.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                       eyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eyeColor = __value, eyeColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(89, "\r\n            ");
                __builder2.OpenElement(90, "option");
                __builder2.AddAttribute(91, "selected", true);
                __builder2.AddAttribute(92, "disabled", true);
                __builder2.AddAttribute(93, "value", "-1");
                __builder2.AddContent(94, "Choose the eye color");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.OpenElement(96, "option");
                __builder2.AddContent(97, "brown");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n            ");
                __builder2.OpenElement(99, "option");
                __builder2.AddContent(100, "grey");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n            ");
                __builder2.OpenElement(102, "option");
                __builder2.AddContent(103, "green");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n            ");
                __builder2.OpenElement(105, "option");
                __builder2.AddContent(106, "blue");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.OpenElement(108, "option");
                __builder2.AddContent(109, "amber");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n            ");
                __builder2.OpenElement(111, "option");
                __builder2.AddContent(112, "hazel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n    ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "form-group");
                __builder2.AddMarkupContent(118, "\r\n        Age <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(119);
                __builder2.AddAttribute(120, "id", "age");
                __builder2.AddAttribute(121, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                                         age

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => age = __value, age))));
                __builder2.AddAttribute(123, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => age));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(124, "\r\n        ");
                __builder2.OpenElement(125, "p");
                __builder2.AddAttribute(126, "style", "color: red");
                __builder2.AddContent(127, 
#nullable restore
#line 54 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                               ageError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n\r\n    ");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "form-group");
                __builder2.AddMarkupContent(132, "\r\n        Weight <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(133);
                __builder2.AddAttribute(134, "id", "weight");
                __builder2.AddAttribute(135, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                                            weight

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(136, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => weight = __value, weight))));
                __builder2.AddAttribute(137, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => weight));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(138, "\r\n        ");
                __builder2.OpenElement(139, "p");
                __builder2.AddAttribute(140, "style", "color: red");
                __builder2.AddContent(141, 
#nullable restore
#line 60 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                               weightError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n    ");
                __builder2.OpenElement(144, "div");
                __builder2.AddAttribute(145, "class", "form-group");
                __builder2.AddMarkupContent(146, "\r\n        Height <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(147);
                __builder2.AddAttribute(148, "id", "height");
                __builder2.AddAttribute(149, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                                            height

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(150, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => height = __value, height))));
                __builder2.AddAttribute(151, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => height));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(152, "\r\n        ");
                __builder2.OpenElement(153, "p");
                __builder2.AddAttribute(154, "style", "color: red");
                __builder2.AddContent(155, 
#nullable restore
#line 65 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                               heightError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\r\n    ");
                __builder2.OpenElement(158, "div");
                __builder2.AddAttribute(159, "class", "form-group");
                __builder2.AddMarkupContent(160, "\r\n        Sex <br>\r\n        ");
                __builder2.OpenElement(161, "select");
                __builder2.AddAttribute(162, "class", "form-control selectpicker");
                __builder2.AddAttribute(163, "style", "width: 300px");
                __builder2.AddAttribute(164, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                       newAdult.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(165, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.Sex = __value, newAdult.Sex));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(166, "\r\n            ");
                __builder2.OpenElement(167, "option");
                __builder2.AddAttribute(168, "selected", true);
                __builder2.AddAttribute(169, "disabled", true);
                __builder2.AddAttribute(170, "value", "-1");
                __builder2.AddContent(171, "Choose the sex");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(172, "\r\n            ");
                __builder2.OpenElement(173, "option");
                __builder2.AddContent(174, "\"F\"");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(175, "\r\n            ");
                __builder2.OpenElement(176, "option");
                __builder2.AddContent(177, "\"M\"");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(178, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(179, "\r\n        ");
                __builder2.OpenElement(180, "p");
                __builder2.AddAttribute(181, "style", "color: red");
                __builder2.AddContent(182, 
#nullable restore
#line 74 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                               sexError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(183, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(184, "\r\n    ");
                __builder2.OpenElement(185, "div");
                __builder2.AddAttribute(186, "class", "form-group");
                __builder2.AddMarkupContent(187, "\r\n        Job title <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(188);
                __builder2.AddAttribute(189, "id", "job-title");
                __builder2.AddAttribute(190, "style", "width: 500px");
                __builder2.AddAttribute(191, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 78 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                                               newAdult.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(192, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.JobTitle = __value, newAdult.JobTitle))));
                __builder2.AddAttribute(193, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.JobTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(194, "\r\n        ");
                __builder2.OpenElement(195, "p");
                __builder2.AddAttribute(196, "style", "color: red");
                __builder2.AddContent(197, 
#nullable restore
#line 79 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                               jobTitleError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(198, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(199, "\r\n    ");
                __builder2.OpenElement(200, "div");
                __builder2.AddAttribute(201, "class", "form-group");
                __builder2.AddMarkupContent(202, "\r\n        ");
                __builder2.OpenElement(203, "button");
                __builder2.AddAttribute(204, "class", "btn btn-outline-dark");
                __builder2.AddAttribute(205, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                                                       UpdateAdultPerson

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(206, "Change");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(207, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(208, "\r\n    ");
                __builder2.OpenElement(209, "p");
                __builder2.AddAttribute(210, "style", "color: red");
                __builder2.AddContent(211, 
#nullable restore
#line 84 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
                           theSameName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(212, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\UpdateAdult.razor"
       
    string age, weight, height, eyeColor, hairColor;
    private string ageError, weightError, heightError, firstNameError, lastNameError, sexError, jobTitleError, theSameName;
    private Adult newAdult = new Adult();
    private ValidHairColor _validHairColor = new ValidHairColor();
    private ValidEyeColor _validEyeColor = new ValidEyeColor();

    protected override async Task OnInitializedAsync()
    {
        Adult adult = AppDataToUpdateAdult.adult;
        newAdult.FirstName = adult.FirstName;
        newAdult.LastName = adult.LastName;
        hairColor = adult.HairColor;
        eyeColor = adult.EyeColor;
        age = adult.Age.ToString();
        weight = adult.Weight.ToString(CultureInfo.CurrentCulture);
        height = adult.Height.ToString();
        newAdult.Sex = adult.Sex;
        newAdult.JobTitle = adult.JobTitle;
    }

    private void UpdateAdultPerson()
    {
        try
        {
            AdultsService.RemoveAdult(AppDataToUpdateAdult.adult.FirstName, AppDataToUpdateAdult.adult.LastName);
            if (_validHairColor.IsValid(hairColor))
            {
                newAdult.HairColor = hairColor;
            }
            if (_validEyeColor.IsValid(eyeColor))
            {
                newAdult.EyeColor = eyeColor;
            }

            if (newAdult.FirstName == null)
            {
                firstNameError = "Input the first name";
            }
            else
            {
                firstNameError = "";
            }
            if (newAdult.LastName == null)
            {
                lastNameError = "Input the last name";
            }
            else
            {
                lastNameError = "";
            }
            bool isAgeOk = Int32.TryParse(age, out int resultAge);
            if (!isAgeOk)
            {
                ageError = "Input the number for the age field";
            }
            else if (Int32.Parse(age) < 1)
            {
                ageError = "The age cannot be negative";
            }
            else
            {
                ageError = "";
                newAdult.Age = resultAge;
            }
            bool isWeightOk = float.TryParse(weight, out float resultWeight);
            if (!isWeightOk)
            {
                weightError = "Input the number for the weight field";
            }
            else
            {
                weightError = "";
                newAdult.Weight = resultWeight;
            }
            bool isHeightOk = Int32.TryParse(height, out int resultHeight);
            if (!isHeightOk)
            {
                heightError = "Input the number for the height field";
            }
            else
            {
                heightError = "";
                newAdult.Height = resultHeight;
            }

            if (newAdult.Sex == null)
            {
                sexError = "Sex has to be F or M";
            }
            else
            {
                sexError = "";
            }
            if (newAdult.JobTitle == null)
            {
                jobTitleError = "Input job title";
            }
            else
            {
                jobTitleError = "";
            }

            if (isAgeOk && isHeightOk && isWeightOk && ageError == "" && weightError == "" && heightError == "" && firstNameError == "" && lastNameError == "" && sexError == "" && jobTitleError == "")
            {
                IList<Adult> adults = AdultsService.getAllAdults();
                foreach (Adult adult in adults)
                {
                    if (adult.FirstName.Equals(newAdult.FirstName) && adult.LastName.Equals(newAdult.LastName))
                    {
                        theSameName = "The adult " + newAdult.FirstName + " " + newAdult.LastName + " already exists";
                        return;
                    }
                }
                newAdult.Id = AdultsService.getAllAdults().Count;
                AdultsService.addAdult(newAdult);
                NavigationManager.NavigateTo("/Adults");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppDataToUpdateAdult AppDataToUpdateAdult { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsService AdultsService { get; set; }
    }
}
#pragma warning restore 1591
