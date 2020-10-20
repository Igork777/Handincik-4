#pragma checksum "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\AddAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "824a6d1d44350c6fb06ceedb12a04a8f74421b7e"
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
#line 2 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\AddAdults.razor"
using Hand_In_2.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\AddAdults.razor"
using Hand_In_2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdults")]
    public partial class AddAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "D:\C#\DNP\AuthenticationAndAuthorization\Hand-In-2\Hand-In-2\Pages\AddAdults.razor"
       
    string age, weight, height, eyeColor, hairColor;
    private string ageError, weightError, heightError, firstNameError, lastNameError, sexError, jobTitleError, theSameName;
    private Adult newAdult = new Adult();
    private ValidHairColor _validHairColor = new ValidHairColor();
    private ValidEyeColor _validEyeColor = new ValidEyeColor();

    private void AddNewAdult()
    {
        try
        {
            if (_validHairColor.IsValid(hairColor))
            {
                newAdult.HairColor = hairColor;
            }
            if (_validEyeColor.IsValid(eyeColor))
            {
                newAdult.EyeColor = eyeColor;
            }
            newAdult.Id = AdultsService.getAllAdults().Count;
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsService AdultsService { get; set; }
    }
}
#pragma warning restore 1591