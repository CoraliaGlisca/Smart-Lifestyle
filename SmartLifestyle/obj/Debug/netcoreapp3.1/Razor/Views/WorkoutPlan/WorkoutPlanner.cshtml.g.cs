#pragma checksum "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\WorkoutPlanner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "291c0fd259a137d33bd48253edaf3eb848a3a6c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkoutPlan_WorkoutPlanner), @"mvc.1.0.view", @"/Views/WorkoutPlan/WorkoutPlanner.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\_ViewImports.cshtml"
using SmartLifestyle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\_ViewImports.cshtml"
using SmartLifestyle.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"291c0fd259a137d33bd48253edaf3eb848a3a6c7", @"/Views/WorkoutPlan/WorkoutPlanner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a02371139b2d61eb5dd2fcf05258c5c51921065", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkoutPlan_WorkoutPlanner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartLifestyle.BusinessLogic.Models.WorkoutPlannerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/pplfitness.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 70%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/WorkoutPlan/WorkoutPlanner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\WorkoutPlanner.cshtml"
  
    ViewData["Title"] = "Fitness planner";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\" style=\"text-align:center; padding:10px;\">\r\n    <h2>Workout Planner</h2>\r\n    <hr />\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\WorkoutPlanner.cshtml"
     if (User.Identity.IsAuthenticated)
    {


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291c0fd259a137d33bd48253edaf3eb848a3a6c76966", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-6"">
            <h3>Choose exercise type:</h3>
            <p>
                Cardio
                <input type=""radio"" id=""Cardio"" name=""Cardio"" value=0 checked style=""cursor: pointer"">
                <label for=""Cardio"">no</label>
                <input type=""radio"" id=""Cardio"" name=""Cardio"" value=1 style=""cursor: pointer"">
                <label for=""Cardio""> yes</label>
            </p>
            <p>
                Weight
                <input type=""radio"" id=""Weight"" name=""Weight"" value=0 checked style=""cursor: pointer"">
                <label for=""Weight"">no</label>
                <input type=""radio"" id=""Weight"" name=""Weight"" value=1 style=""cursor: pointer"">
                <label for=""Weight""> yes</label>
            </p>
            <p>
                Plyo
                <input type=""radio"" id=""Plyo"" name=""Plyo"" value=0 checked style=""cursor: pointer"">
                <label for=""Plyo"">no</label>
                <input t");
                WriteLiteral(@"ype=""radio"" id=""Plyo"" name=""Plyo"" value=1 style=""cursor: pointer"">
                <label for=""Plyo""> yes</label>
            </p>
            <p>
                Laps
                <input type=""radio"" id=""Laps"" name=""Laps"" value=0 checked style=""cursor: pointer"">
                <label for=""Laps"">no</label>
                <input type=""radio"" id=""Laps"" name=""Laps"" value=1 style=""cursor: pointer"">
                <label for=""Laps""> yes</label>
            </p>
            <p>
                Machine
                <input type=""radio"" id=""Machine"" name=""Machine"" value=0 checked style=""cursor: pointer"">
                <label for=""Machine"">no</label>
                <input type=""radio"" id=""Machine"" name=""Machine"" value=1 style=""cursor: pointer"">
                <label for=""Machine""> yes</label>
            </p>
        </div>
        <div class=""col-md-6"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "291c0fd259a137d33bd48253edaf3eb848a3a6c79288", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
    </div>
    <h3>Choose exercise equipment:</h3>
    <div class=""row"">
        <div class=""col-md-6"">
            <p>
                Band
                <input type=""radio"" id=""Band"" name=""Band"" value=0 checked style=""cursor: pointer"">
                <label for=""Band"">no</label>
                <input type=""radio"" id=""Band"" name=""Band"" value=1 style=""cursor: pointer"">
                <label for=""Band""> yes</label>
            </p>
            <p>
                Bar
                <input type=""radio"" id=""Bar"" name=""Bar"" value=0 checked style=""cursor: pointer"">
                <label for=""Bar"">no</label>
                <input type=""radio"" id=""Bar"" name=""Bar"" value=1 style=""cursor: pointer"">
                <label for=""Bar""> yes</label>
            </p>
            <p>
                Body Weight
                <input type=""radio"" id=""Body Weight"" name=""Body Weight"" value=0 checked style=""cursor: pointer"">
                <label for=""Body Weight"">no</label>
      ");
                WriteLiteral(@"          <input type=""radio"" id=""Body Weight"" name=""Body Weight"" value=1 style=""cursor: pointer"">
                <label for=""Body Weight""> yes</label>
            </p>
            <p>
                Bosu Ball
                <input type=""radio"" id=""Bosu Balll"" name=""Bosu Balll"" value=0 checked style=""cursor: pointer"">
                <label for=""Bosu Balll"">no</label>
                <input type=""radio"" id=""Bosu Balll"" name=""Bosu Balll"" value=1 style=""cursor: pointer"">
                <label for=""Bosu Balll""> yes</label>
            </p>
            <p>
                Dumbbells
                <input type=""radio"" id=""Dumbbells"" name=""Dumbbells"" value=0 checked style=""cursor: pointer"">
                <label for=""Dumbbells"">no</label>
                <input type=""radio"" id=""Dumbbells"" name=""Dumbbells"" value=1 style=""cursor: pointer"">
                <label for=""Dumbbells""> yes</label>
            </p>
            <p>
                Kettlebells
                <input type=""radio"" id=""Ket");
                WriteLiteral(@"tlebells"" name=""Kettlebells"" value=0 checked style=""cursor: pointer"">
                <label for=""Kettlebells"">no</label>
                <input type=""radio"" id=""Kettlebells"" name=""Kettlebells"" value=1 style=""cursor: pointer"">
                <label for=""Kettlebells""> yes</label>
            </p>
        </div>

        <div class=""col-md-6"">
            <p>
                Landmine
                <input type=""radio"" id=""Landmine"" name=""Landmine"" value=0 checked style=""cursor: pointer"">
                <label for=""Landmine"">no</label>
                <input type=""radio"" id=""Landmine"" name=""Landmine"" value=1 style=""cursor: pointer"">
                <label for=""Landmine""> yes</label>
            </p>
            <p>
                Platform
                <input type=""radio"" id=""Platform"" name=""Platform"" value=0 checked style=""cursor: pointer"">
                <label for=""Platform"">no</label>
                <input type=""radio"" id=""Platform"" name=""Platform"" value=1 style=""cursor: pointer"">");
                WriteLiteral(@"
                <label for=""Platform""> yes</label>
            </p>
            <p>
                Squat Rack
                <input type=""radio"" id=""Squat Rack"" name=""Squat Rack"" value=0 checked style=""cursor: pointer"">
                <label for=""Squat Rack"">no</label>
                <input type=""radio"" id=""Squat Rack"" name=""Squat Rack"" value=1 style=""cursor: pointer"">
                <label for=""Squat Rack""> yes</label>
            </p>
            <p>
                Cable
                <input type=""radio"" id=""Cable"" name=""Cable"" value=0 checked style=""cursor: pointer"">
                <label for=""Cable"">no</label>
                <input type=""radio"" id=""Cable"" name=""Cable"" value=1 style=""cursor: pointer"">
                <label for=""Cable""> yes</label>
            </p>
            <p>
                Medicine Ball
                <input type=""radio"" id=""Medicine Ball"" name=""Medicine Ball"" value=0 checked style=""cursor: pointer"">
                <label for=""Medicine Ball"">no</label");
                WriteLiteral(@">
                <input type=""radio"" id=""Medicine Ball"" name=""Medicine Ball"" value=1 style=""cursor: pointer"">
                <label for=""Medicine Ball""> yes</label>
            </p>
        </div>
    </div>

    <h3>Choose major muscle:</h3>
    <p>
        Arms
        <input type=""radio"" id=""Arms"" name=""Arms"" value=0 checked style=""cursor: pointer"">
        <label for=""Arms"">no</label>
        <input type=""radio"" id=""Arms"" name=""Arms"" value=1 style=""cursor: pointer"">
        <label for=""Arms""> yes</label>
    </p>
    <p>
        Back
        <input type=""radio"" id=""Back"" name=""Back"" value=0 checked style=""cursor: pointer"">
        <label for=""Back"">no</label>
        <input type=""radio"" id=""Back"" name=""Back"" value=1 style=""cursor: pointer"">
        <label for=""Back""> yes</label>
    </p>
    <p>
        Core
        <input type=""radio"" id=""Core"" name=""Core"" value=0 checked style=""cursor: pointer"">
        <label for=""Core"">no</label>
        <input type=""radio"" id=""Core"" name=""");
                WriteLiteral(@"Core"" value=1 style=""cursor: pointer"">
        <label for=""Core""> yes</label>
    </p>
    <p>
        Full Body
        <input type=""radio"" id=""Full Body"" name=""Full Body"" value=0 checked style=""cursor: pointer"">
        <label for=""Full Body"">no</label>
        <input type=""radio"" id=""Full Body"" name=""Full Body"" value=1 style=""cursor: pointer"">
        <label for=""Full Body""> yes</label>
    </p>
    <p>
        Legs
        <input type=""radio"" id=""Legs"" name=""Legs"" value=0 checked style=""cursor: pointer"">
        <label for=""Legs"">no</label>
        <input type=""radio"" id=""Legs"" name=""Legs"" value=1 style=""cursor: pointer"">
        <label for=""Legs""> yes</label>
    </p>

    <p><button type=""submit"" class=""btn btn-outline-button3"">Submit</button></p>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 182 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\WorkoutPlanner.cshtml"

     }

else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            You must be logged in to access this page!\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291c0fd259a137d33bd48253edaf3eb848a3a6c718447", async() => {
                WriteLiteral("Login");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            No account?\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291c0fd259a137d33bd48253edaf3eb848a3a6c719870", async() => {
                WriteLiteral("Register");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 195 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\WorkoutPlanner.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "291c0fd259a137d33bd48253edaf3eb848a3a6c721575", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartLifestyle.BusinessLogic.Models.WorkoutPlannerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
