#pragma checksum "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b09044662490567db8ada863bb2ef15ce4b4f6eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchRecords), @"mvc.1.0.view", @"/Views/Home/SearchRecords.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SearchRecords.cshtml", typeof(AspNetCore.Views_Home_SearchRecords))]
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
#line 1 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\_ViewImports.cshtml"
using Connective.UI;

#line default
#line hidden
#line 2 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\_ViewImports.cshtml"
using Connective.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b09044662490567db8ada863bb2ef15ce4b4f6eb", @"/Views/Home/SearchRecords.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf7d9a9b87f0f07d8e5830b4634bdd4508fc17d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchRecords : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Connective.Data.Model.ApiStructure.Record>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchRecord", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
  
    ViewData["Title"] = "SearchRecords";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var searchedList = TempData["SerchResult"] as List<Connective.Data.Model.ApiStructure.Record>;
    var serchedcriterias = TempData["criteria"];

#line default
#line hidden
            BeginContext(299, 19, true);
            WriteLiteral("<div class=\"row\">\r\n");
            EndContext();
#line 10 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
     if (Model == null)
    {

#line default
#line hidden
            BeginContext(350, 112, true);
            WriteLiteral("        <div class=\"container\">\r\n            <div class=\"col-md-12\" style=\"margin-top:100px;\">\r\n                ");
            EndContext();
            BeginContext(462, 804, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e13be890a7c0415e87d788e172bb49ac", async() => {
                BeginContext(530, 72, true);
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        ");
                EndContext();
                BeginContext(602, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be31e7198bec4390b7fa9336dd36ff72", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 16 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FirstName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(637, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(663, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e75c6c4c5804a64a09e60a6aec19c22", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 17 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FirstName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(692, 100, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
                EndContext();
                BeginContext(792, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ec7b59c72c24cfdb611091508486624", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 20 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LastName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(826, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(852, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f387fd5f49e4b94a96ed2a489459893", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 21 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LastName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(880, 100, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
                EndContext();
                BeginContext(980, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "840c57d85d23416db57c2f81d5b2402e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 24 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LeadOwner);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1015, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1041, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "31332f0daf7d41b984428454ec42546b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 25 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LeadOwner);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1070, 189, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <button type=\"submit\">Verileri Çek</button>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1266, 40, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 34 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
    }

#line default
#line hidden
            BeginContext(1313, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 37 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
     if (searchedList != null)
    {

#line default
#line hidden
            BeginContext(1356, 119, true);
            WriteLiteral("        <div class=\"col-md-12\" style=\"margin-top:100px;\">\r\n            <div class=\"col-md-12\">\r\n                <span> ");
            EndContext();
            BeginContext(1476, 16, false);
#line 41 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
                  Write(serchedcriterias);

#line default
#line hidden
            EndContext();
            BeginContext(1492, 1024, true);
            WriteLiteral(@" </span> süzgecine tutulmuş veriler aşağıdaki gibidir.
            </div>
            <div>
                <table>
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Lead Owner</th>
                            <th>Owner</th>
                            <th>First Name</th>
                            <th>Last Name</th>
                            <th>Destination</th>
                            <th>Email</th>
                            <th>Phone</th>
                            <th>Fax</th>
                            <th>Mobile</th>
                            <th>Web Site</th>
                            <th>Lead Source</th>
                            <th>Lead Status</th>
                            <th>Created By</th>
                            <th>Created Time</th>
                            <th>Modified Time</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 66 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
                         foreach (var item in searchedList)
                        {

#line default
#line hidden
            BeginContext(2604, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2667, 7, false);
#line 69 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2674, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2714, 14, false);
#line 70 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
                           Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2728, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2768, 13, false);
#line 71 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
                           Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2781, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2821, 14, false);
#line 72 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
                           Write(item.LeadOwner);

#line default
#line hidden
            EndContext();
            BeginContext(2835, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2875, 10, false);
#line 73 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
                           Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2885, 77, true);
            WriteLiteral("</td>\r\n                            <td></td>\r\n                        </tr>\r\n");
            EndContext();
#line 76 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
                        }

#line default
#line hidden
            BeginContext(2989, 92, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 81 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\SearchRecords.cshtml"
    }

#line default
#line hidden
            BeginContext(3088, 16, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Connective.Data.Model.ApiStructure.Record> Html { get; private set; }
    }
}
#pragma warning restore 1591