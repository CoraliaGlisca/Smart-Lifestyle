#pragma checksum "C:\Users\Cora\source\repos\SmartLifestyle\SmartLifestyle\Views\MealPlan\ChatBot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec9dbf50d159dd592942beb8dc571aee5ec5564b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MealPlan_ChatBot), @"mvc.1.0.view", @"/Views/MealPlan/ChatBot.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec9dbf50d159dd592942beb8dc571aee5ec5564b", @"/Views/MealPlan/ChatBot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a02371139b2d61eb5dd2fcf05258c5c51921065", @"/Views/_ViewImports.cshtml")]
    public class Views_MealPlan_ChatBot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chatbot.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chatbot.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec9dbf50d159dd592942beb8dc571aee5ec5564b4142", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <script src=""https://code.jquery.com/jquery-2.2.4.min.js"" integrity=""sha256-BbhdlvQf/xTY9gja0Dq3HiwQF8LaCRTXxZKRutelT44="" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/unibox/1.15.0/js/unibox.min.js""></script>
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/unibox/1.15.0/css/unibox.min.css"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec9dbf50d159dd592942beb8dc571aee5ec5564b4833", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec9dbf50d159dd592942beb8dc571aee5ec5564b5932", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <title>Chatbot</title>
    <style>

        #demo {
            /*background-color: #ffffff;*/
            width: 80%;
            max-width: 1000px;
            margin-left: auto;
            margin-right: auto;
            padding: 20px;
            background-color: #F8F8F8;
            border: 1px solid #ccc;
            box-shadow: 0 0 10px #999;
            line-height: 1.4em;
            font: 13px helvetica,arial,freesans,clean,sans-serif;
            color: black;
            border-radius: 25px;
        }

            #demo input {
                padding: 8px;
                font-size: 14px;
                border: 1px solid #ddd;
                width: 400px;
            }

        .button {
            display: inline-block;
            background-color: #50723C;
            color: #fff;
            padding: 8px;
            cursor: pointer;
            float: right;
        }

        #chatBotCommandDescription {
            display: none;
            ");
                WriteLiteral("margin-bottom: 20px;\r\n        }\r\n\r\n        input:focus {\r\n            outline: none;\r\n        }\r\n\r\n        .chatBotChatEntry {\r\n            display: none;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec9dbf50d159dd592942beb8dc571aee5ec5564b8994", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" type=""text/css"" href=""../css/chatbot.css"" />

    <div id=""demo"">
        <p>Ask <i>smartypants</i> whatever you desire!</p>

        <div id=""chatBotCommandDescription""></div>
        <input id=""humanInput"" type=""text"" placeholder=""Say something"" />

        <div class=""button"" onclick=""if (!ChatBot.playConversation(sampleConversation,4000)) {alert('conversation already running');};"">Play sample conversation!</div>
        <div class=""button"" onclick=""$('#chatBotCommandDescription').slideToggle();"" style=""margin-right:10px"">What can I say?</div>

        <div style=""clear: both;"">&nbsp;</div>

        <div id=""chatBot"">
            <div id=""chatBotThinkingIndicator""></div>
            <div id=""chatBotHistory""></div>
        </div>
    </div>


    <script>

        var apiKey = '061ae7be95124e3a8d22ce08d7d628c9';
        var spoon = ChatBot.Engines.spoonacular(apiKey);

        var sampleConversation = [
            ""donuts"",
            ""no cream"",
  ");
                WriteLiteral(@"          ""with sprinkles"",
            ""more"",
            ""more like the second"",
            ""ok, tell me a joke""
        ];
        var config = {
            botName: 'smartypants',
            inputs: '#humanInput',
            inputCapabilityListing: true,
            engines: [spoon],
            addChatEntryCallback: function (entryDiv, text, origin) {
                entryDiv.delay(200).slideDown();
            }
        };
        ChatBot.init(config);

        $('#humanInput').unibox({
            // use the suggest URL from the spoonacular engine
            suggestUrl: spoon.getSuggestUrl(),
            // minimum number of characters before the suggests shows
            minChars: 1,
            enterCallbackResult: function () { },
        });

    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591