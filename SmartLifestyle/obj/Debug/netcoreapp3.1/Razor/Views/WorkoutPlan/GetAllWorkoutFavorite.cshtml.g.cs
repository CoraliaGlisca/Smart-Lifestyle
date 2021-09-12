#pragma checksum "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\GetAllWorkoutFavorite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24c8667918c23eac101f03e113c6692f49f08c3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkoutPlan_GetAllWorkoutFavorite), @"mvc.1.0.view", @"/Views/WorkoutPlan/GetAllWorkoutFavorite.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24c8667918c23eac101f03e113c6692f49f08c3b", @"/Views/WorkoutPlan/GetAllWorkoutFavorite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a02371139b2d61eb5dd2fcf05258c5c51921065", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkoutPlan_GetAllWorkoutFavorite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<SmartLifestyle.Models.Model.FavoriteWorkout>>
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
#line 2 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\GetAllWorkoutFavorite.cshtml"
  
    ViewData["Title"] = "Workout history";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Your saved workouts</h2>\r\n<hr />\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\GetAllWorkoutFavorite.cshtml"
     foreach(var item in Model) 
    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6\">\r\n            <div class=\"card2\" style=\" width: 80%; margin: 15px auto 15px; padding: 16px; height:99%; background-color: #C8D8EA; border-radius: 25px; margin:1.5em;\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 453, "\"", 494, 1);
#nullable restore
#line 14 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\GetAllWorkoutFavorite.cshtml"
WriteAttributeValue("", 459, "/images/" + @item.Workout.Image, 459, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                <div class=\"container\" style=\"text-align:center\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\GetAllWorkoutFavorite.cshtml"
                                      Write(item.Workout.Exercise);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-subtitle\">Equipment: ");
#nullable restore
#line 17 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\GetAllWorkoutFavorite.cshtml"
                                                   Write(item.Workout.Equipment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">Type: ");
#nullable restore
#line 18 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\GetAllWorkoutFavorite.cshtml"
                                          Write(item.Workout.ExerciseType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">Major Mucle: ");
#nullable restore
#line 19 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\GetAllWorkoutFavorite.cshtml"
                                                 Write(item.Workout.MajorMuscle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\" style=\"white-space: nowrap;overflow: hidden; text-overflow: ellipsis;\r\n                               max-width: 400px;\">\r\n                        ");
#nullable restore
#line 22 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\GetAllWorkoutFavorite.cshtml"
                   Write(item.Workout.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24c8667918c23eac101f03e113c6692f49f08c3b7457", async() => {
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
#line 24 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\GetAllWorkoutFavorite.cshtml"
                         WriteLiteral(item.WorkoutId);

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
            WriteLiteral("               \r\n                </div>\r\n             </div>\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\WorkoutPlan\GetAllWorkoutFavorite.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<SmartLifestyle.Models.Model.FavoriteWorkout>> Html { get; private set; }
    }
}
#pragma warning restore 1591
