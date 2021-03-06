#pragma checksum "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44e69e03b3a51e917beab92856d3ebb1fac37db8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkoutPlan_Workouts), @"mvc.1.0.view", @"/Views/WorkoutPlan/Workouts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e69e03b3a51e917beab92856d3ebb1fac37db8", @"/Views/WorkoutPlan/Workouts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a02371139b2d61eb5dd2fcf05258c5c51921065", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkoutPlan_Workouts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartLifestyle.BusinessLogic.Models.WholeWorkoutRoutineDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WorkoutPlan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowWorkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-button3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
  
    ViewData["Title"] = "Workouts Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3 style=""text-align:center""><i>Your workout routine</i></h3>
<div class=""row"">
    <div class=""col-md-6"">
        <div class=""card2"" style="" width: 80%; margin: 15px auto 15px; padding: 16px; height:99%; background-color: #C8D8EA; border-radius: 25px; margin:1.5em;"">
            <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 429, "\"", 472, 1);
#nullable restore
#line 10 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
WriteAttributeValue("", 435, "/images/" + @Model.workout1.Image, 435, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <div class=\"container\" style=\"text-align:center\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                  Write(Model.workout1.Exercise);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-subtitle\">Equipment: ");
#nullable restore
#line 13 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                               Write(Model.workout1.Equipment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Exercise Type: ");
#nullable restore
#line 14 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                               Write(Model.workout1.ExerciseType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Major Mucle: ");
#nullable restore
#line 15 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                             Write(Model.workout1.MajorMuscle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\" style=\"white-space: nowrap;overflow: hidden; text-overflow: ellipsis;\r\n                               max-width: 400px;\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
               Write(Model.workout1.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44e69e03b3a51e917beab92856d3ebb1fac37db87024", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                     WriteLiteral(Model.workout1.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""col-md-6"">
        <div class=""card2"" style="" width: 80%; margin: 15px auto 15px; padding: 16px; height:99%; background-color: #C8D8EA; border-radius: 25px; margin:1.5em"">
            <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 1660, "\"", 1703, 1);
#nullable restore
#line 28 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
WriteAttributeValue("", 1666, "/images/" + @Model.workout2.Image, 1666, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <div class=\"container\" style=\"text-align:center\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 30 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                  Write(Model.workout2.Exercise);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-subtitle\">Equipment: ");
#nullable restore
#line 31 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                               Write(Model.workout2.Equipment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Exercise Type: ");
#nullable restore
#line 32 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                               Write(Model.workout2.ExerciseType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Major Mucle: ");
#nullable restore
#line 33 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                             Write(Model.workout2.MajorMuscle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\" style=\"white-space: nowrap;overflow: hidden; text-overflow: ellipsis;\r\n                               max-width: 400px;\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
               Write(Model.workout2.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44e69e03b3a51e917beab92856d3ebb1fac37db812114", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                     WriteLiteral(Model.workout2.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
    </div>
    <div class=""col-md-6"">
        <div class=""card2"" style="" width: 80%; margin: 15px auto 15px; padding: 16px; height:99%; background-color: #C8D8EA; border-radius: 25px; margin:1.5em"">
            <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 2787, "\"", 2830, 1);
#nullable restore
#line 45 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
WriteAttributeValue("", 2793, "/images/" + @Model.workout3.Image, 2793, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <div class=\"container\" style=\"text-align:center\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 47 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                  Write(Model.workout3.Exercise);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-subtitle\">Equipment: ");
#nullable restore
#line 48 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                               Write(Model.workout3.Equipment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Exercise Type: ");
#nullable restore
#line 49 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                               Write(Model.workout3.ExerciseType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Major Mucle: ");
#nullable restore
#line 50 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                             Write(Model.workout3.MajorMuscle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\" style=\"white-space: nowrap;overflow: hidden; text-overflow: ellipsis;\r\n                               max-width: 400px;\">\r\n                    ");
#nullable restore
#line 53 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
               Write(Model.workout3.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44e69e03b3a51e917beab92856d3ebb1fac37db817172", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                     WriteLiteral(Model.workout3.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
    </div>
    <div class=""col-md-6"">
        <div class=""card2"" style="" width: 80%; margin: 15px auto 15px; padding: 16px; height:99%; background-color: #C8D8EA; border-radius: 25px; margin:1.5em"">
            <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 3914, "\"", 3957, 1);
#nullable restore
#line 62 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
WriteAttributeValue("", 3920, "/images/" + @Model.workout4.Image, 3920, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <div class=\"container\" style=\"text-align:center\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 64 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                  Write(Model.workout4.Exercise);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-subtitle\">Equipment: ");
#nullable restore
#line 65 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                               Write(Model.workout4.Equipment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Exercise Type: ");
#nullable restore
#line 66 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                               Write(Model.workout4.ExerciseType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Major Mucle: ");
#nullable restore
#line 67 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                             Write(Model.workout4.MajorMuscle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\" style=\"white-space: nowrap;overflow: hidden; text-overflow: ellipsis;\r\n                               max-width: 400px;\">\r\n                    ");
#nullable restore
#line 70 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
               Write(Model.workout4.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44e69e03b3a51e917beab92856d3ebb1fac37db822230", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                     WriteLiteral(Model.workout4.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
    </div>
    <div class=""col-md-6"">
        <div class=""card2"" style="" width: 80%; margin: 15px auto 15px; padding: 16px; height:99%; background-color: #C8D8EA; border-radius: 25px; margin:1.5em"">
            <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 5041, "\"", 5084, 1);
#nullable restore
#line 79 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
WriteAttributeValue("", 5047, "/images/" + @Model.workout5.Image, 5047, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <div class=\"container\" style=\"text-align:center\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 81 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                  Write(Model.workout5.Exercise);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-subtitle\">Equipment: ");
#nullable restore
#line 82 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                               Write(Model.workout5.Equipment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Exercise Type: ");
#nullable restore
#line 83 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                               Write(Model.workout5.ExerciseType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Major Mucle: ");
#nullable restore
#line 84 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                             Write(Model.workout5.MajorMuscle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\" style=\"white-space: nowrap;overflow: hidden; text-overflow: ellipsis;\r\n                               max-width: 400px;\">\r\n                    ");
#nullable restore
#line 87 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
               Write(Model.workout5.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44e69e03b3a51e917beab92856d3ebb1fac37db827288", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                     WriteLiteral(Model.workout5.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
    </div>
    <div class=""col-md-6"">
        <div class=""card2"" style="" width: 80%; margin: 15px auto 15px; padding: 16px; height:99%; background-color: #C8D8EA; border-radius: 25px; margin:1.5em"">
            <img class=""card-img-top""");
            BeginWriteAttribute("src", " src=\"", 6168, "\"", 6211, 1);
#nullable restore
#line 96 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
WriteAttributeValue("", 6174, "/images/" + @Model.workout6.Image, 6174, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <div class=\"container\" style=\"text-align:center\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 98 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                  Write(Model.workout6.Exercise);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-subtitle\">Equipment: ");
#nullable restore
#line 99 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                               Write(Model.workout6.Equipment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Exercise Type: ");
#nullable restore
#line 100 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                               Write(Model.workout6.ExerciseType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Major Mucle: ");
#nullable restore
#line 101 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                                             Write(Model.workout6.MajorMuscle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\" style=\"white-space: nowrap;overflow: hidden; text-overflow: ellipsis;\r\n                               max-width: 400px;\">\r\n                    ");
#nullable restore
#line 104 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
               Write(Model.workout6.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44e69e03b3a51e917beab92856d3ebb1fac37db832349", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\Workouts.cshtml"
                     WriteLiteral(Model.workout6.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartLifestyle.BusinessLogic.Models.WholeWorkoutRoutineDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
