#pragma checksum "C:\MYALLREPOS\StackOverflow\StackOverflow\Views\QandA\AddAnswerForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d0d32c302fcd53b7bc401460ecdb4e403ab8b19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_AddAnswerForm), @"mvc.1.0.view", @"/Views/QandA/AddAnswerForm.cshtml")]
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
#line 1 "C:\MYALLREPOS\StackOverflow\StackOverflow\Views\_ViewImports.cshtml"
using StackOverflow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MYALLREPOS\StackOverflow\StackOverflow\Views\_ViewImports.cshtml"
using StackOverflow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0d32c302fcd53b7bc401460ecdb4e403ab8b19", @"/Views/QandA/AddAnswerForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8a9c337b69d99cdcb44a337b4083ce04d7ae47a", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_AddAnswerForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Answer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\MYALLREPOS\StackOverflow\StackOverflow\Views\QandA\AddAnswerForm.cshtml"
  
    ViewData["Title"] = "AddAnswerForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Add Answer Form</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0d32c302fcd53b7bc401460ecdb4e403ab8b193749", async() => {
                WriteLiteral("\r\n    <input  type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 189, "\"", 206, 1);
#nullable restore
#line 8 "C:\MYALLREPOS\StackOverflow\StackOverflow\Views\QandA\AddAnswerForm.cshtml"
WriteAttributeValue("", 197, Model.Id, 197, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    Username: <input type=\"text\" class=\"form-control\" name=\"Username\" /><br />\r\n    Detail: <input type=\"text\" class=\"form-control\" name=\"Detail\" /><br />\r\n    <input type=\"hidden\" name=\"QuestionId\"");
                BeginWriteAttribute("value", " value=\"", 409, "\"", 434, 1);
#nullable restore
#line 11 "C:\MYALLREPOS\StackOverflow\StackOverflow\Views\QandA\AddAnswerForm.cshtml"
WriteAttributeValue("", 417, Model.QuestionId, 417, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    Posted: <input type=\"datetime\" class=\"form-control\" name=\"Posted\" /><br />\r\n    Upvotes: <input type=\"number\" class=\"form-control\" name=\"Upvotes\"/><br />\r\n    <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\"/>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 120, "/QandA/SaveAnswer?id=", 120, 21, true);
#nullable restore
#line 7 "C:\MYALLREPOS\StackOverflow\StackOverflow\Views\QandA\AddAnswerForm.cshtml"
AddHtmlAttributeValue("", 141, Model.Id, 141, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Answer> Html { get; private set; }
    }
}
#pragma warning restore 1591
