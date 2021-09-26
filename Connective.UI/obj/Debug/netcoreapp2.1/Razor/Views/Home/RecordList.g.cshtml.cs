#pragma checksum "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48b7cc4d240a4bdc8867df6d54e4442a2b9ae579"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RecordList), @"mvc.1.0.view", @"/Views/Home/RecordList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RecordList.cshtml", typeof(AspNetCore.Views_Home_RecordList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48b7cc4d240a4bdc8867df6d54e4442a2b9ae579", @"/Views/Home/RecordList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf7d9a9b87f0f07d8e5830b4634bdd4508fc17d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RecordList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Connective.Data.Model.ApiParameters>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
  
    ViewData["Title"] = "RecordList";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var SortingFilter = TempData["SortingFilter"] as List<SelectListItem>;
    var recordlist = TempData["recordList"] as List<Connective.Data.Model.ApiStructure.Record>;
    var result = TempData["result"];

#line default
#line hidden
            BeginContext(349, 46, true);
            WriteLiteral("<div class=\"row\" style=\"margin-top:20px;\">\r\n\r\n");
            EndContext();
#line 11 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
     if (result != null)
    {
        

#line default
#line hidden
#line 13 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
         if (Convert.ToInt32(result) == 1)
        {

#line default
#line hidden
            BeginContext(483, 64, true);
            WriteLiteral("            <h1 style=\"color:aquamarine;\">işlem başarılı.</h1>\r\n");
            EndContext();
#line 16 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(583, 62, true);
            WriteLiteral("            <h1 style=\"color:darkred;\">işlem başarısız.</h1>\r\n");
            EndContext();
#line 20 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
        }

#line default
#line hidden
#line 20 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
         
    }

#line default
#line hidden
            BeginContext(663, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
     using (Html.BeginForm("RecordList", "Home", FormMethod.Post))
    {

#line default
#line hidden
            BeginContext(740, 110, true);
            WriteLiteral("        <div class=\"col-md-12\" style=\"margin-top:100px\">\r\n            <label>Belirtilen sıradaki kayıttan     ");
            EndContext();
            BeginContext(851, 74, false);
#line 26 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                                               Write(Html.TextBoxFor(model => model.fromIndex, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(925, 66, true);
            WriteLiteral(" </label>\r\n            <label>Belirtilen sıradaki kayıta kadar    ");
            EndContext();
            BeginContext(992, 72, false);
#line 27 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                                                  Write(Html.TextBoxFor(model => model.toIndex, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 13, true);
            WriteLiteral(" </label>\r\n\r\n");
            EndContext();
            BeginContext(1143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1293, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1305, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48deef06ea584347abf36d5e17495eec", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 32 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = SortingFilter;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 32 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.sortOrderString);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1395, 116, true);
            WriteLiteral("\r\n\r\n\r\n\r\n            <button type=\"submit\">\r\n                Kayıtları Getir\r\n            </button>\r\n        </div>\r\n");
            EndContext();
#line 40 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"

    }

#line default
#line hidden
            BeginContext(1520, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
     if (recordlist != null)
    {

#line default
#line hidden
            BeginContext(1559, 77, true);
            WriteLiteral("        <div class=\"col-md-12\" style=\"margin-top:100px;\">\r\n            <ul>\r\n");
            EndContext();
#line 47 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                 foreach (var item in recordlist)
                {




#line default
#line hidden
            BeginContext(1712, 101, true);
            WriteLiteral("                    <li>\r\n                        <label>Lead Owner</label>\r\n                        ");
            EndContext();
            BeginContext(1814, 14, false);
#line 54 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                   Write(item.LeadOwner);

#line default
#line hidden
            EndContext();
            BeginContext(1828, 127, true);
            WriteLiteral("\r\n\r\n                    </li>\r\n                    <li>\r\n                        <label>Owner</label>\r\n                        ");
            EndContext();
            BeginContext(1956, 10, false);
#line 59 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                   Write(item.Owner);

#line default
#line hidden
            EndContext();
            BeginContext(1966, 130, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        <label>First Name</label>\r\n                        ");
            EndContext();
            BeginContext(2097, 14, false);
#line 63 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2111, 29, true);
            WriteLiteral("\r\n                    </li>\r\n");
            EndContext();
            BeginContext(2142, 51, true);
            WriteLiteral("                    <li> <label>Destination</label>");
            EndContext();
            BeginContext(2194, 16, false);
#line 66 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                                              Write(item.Destination);

#line default
#line hidden
            EndContext();
            BeginContext(2210, 104, true);
            WriteLiteral(" </li>\r\n                    <li>\r\n                        <label>Email</label>\r\n                        ");
            EndContext();
            BeginContext(2315, 10, false);
#line 69 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2325, 125, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        <label>Phone</label>\r\n                        ");
            EndContext();
            BeginContext(2451, 10, false);
#line 73 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                   Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2461, 123, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        <label>Fax</label>\r\n                        ");
            EndContext();
            BeginContext(2585, 8, false);
#line 77 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                   Write(item.Fax);

#line default
#line hidden
            EndContext();
            BeginContext(2593, 126, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        <label>Mobile</label>\r\n                        ");
            EndContext();
            BeginContext(2720, 11, false);
#line 81 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                   Write(item.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(2731, 127, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        <label>WebSite</label>\r\n                        ");
            EndContext();
            BeginContext(2859, 12, false);
#line 85 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                   Write(item.WebSite);

#line default
#line hidden
            EndContext();
            BeginContext(2871, 132, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        <label>Lead Source </label>\r\n                        ");
            EndContext();
            BeginContext(3004, 15, false);
#line 89 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                   Write(item.LeadSource);

#line default
#line hidden
            EndContext();
            BeginContext(3019, 132, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        <label> Lead Status</label>\r\n                        ");
            EndContext();
            BeginContext(3152, 15, false);
#line 93 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                   Write(item.LeadStatus);

#line default
#line hidden
            EndContext();
            BeginContext(3167, 129, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        <label>CreatedBy</label>\r\n                        ");
            EndContext();
            BeginContext(3297, 14, false);
#line 97 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                   Write(item.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(3311, 133, true);
            WriteLiteral("\r\n\r\n                    </li>\r\n                    <li>\r\n                        <label>CreatedTime</label>\r\n                        ");
            EndContext();
            BeginContext(3445, 16, false);
#line 102 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                   Write(item.CreatedTime);

#line default
#line hidden
            EndContext();
            BeginContext(3461, 81, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li><label>ModifiedTime</label> ");
            EndContext();
            BeginContext(3543, 17, false);
#line 104 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
                                               Write(item.ModifiedTime);

#line default
#line hidden
            EndContext();
            BeginContext(3560, 8, true);
            WriteLiteral(" </li>\r\n");
            EndContext();
            BeginContext(3570, 75, true);
            WriteLiteral("                    <li>\r\n                        <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3645, "\"", 3705, 1);
#line 107 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
WriteAttributeValue("", 3652, Url.Action("deleteRecord","Home" ,new { id=item.Id}), 3652, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3706, 60, true);
            WriteLiteral(">sil</a>\r\n                        <a class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3766, "\"", 3825, 1);
#line 108 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"
WriteAttributeValue("", 3773, Url.Action("UpdateRecord","Home",new { id=item.Id}), 3773, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3826, 41, true);
            WriteLiteral(">düzenle</a>\r\n                    </li>\r\n");
            EndContext();
#line 110 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"


                }

#line default
#line hidden
            BeginContext(3890, 35, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n");
            EndContext();
#line 115 "C:\Users\burcu\OneDrive\Masaüstü\Hevasen\Connective.UI\Views\Home\RecordList.cshtml"


    }

#line default
#line hidden
            BeginContext(3936, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Connective.Data.Model.ApiParameters> Html { get; private set; }
    }
}
#pragma warning restore 1591