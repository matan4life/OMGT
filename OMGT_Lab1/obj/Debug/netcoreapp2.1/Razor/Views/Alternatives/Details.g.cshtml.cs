#pragma checksum "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Alternatives\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9af74c1a0c69154255a715ec4b11633ad55810a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alternatives_Details), @"mvc.1.0.view", @"/Views/Alternatives/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alternatives/Details.cshtml", typeof(AspNetCore.Views_Alternatives_Details))]
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
#line 1 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\_ViewImports.cshtml"
using OMGT_Lab1;

#line default
#line hidden
#line 2 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\_ViewImports.cshtml"
using OMGT_Lab1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9af74c1a0c69154255a715ec4b11633ad55810a1", @"/Views/Alternatives/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e49c656068098f7e337bc75b602c0c98c205a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Alternatives_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OMGT_Lab1.Models.Alternative>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Alternatives\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(78, 125, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Alternative</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(204, 51, false);
#line 14 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Alternatives\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AlternativeName));

#line default
#line hidden
            EndContext();
            BeginContext(255, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(301, 47, false);
#line 18 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Alternatives\Details.cshtml"
       Write(Html.DisplayFor(model => model.AlternativeName));

#line default
#line hidden
            EndContext();
            BeginContext(348, 47, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(396, 65, false);
#line 24 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Alternatives\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.AlternativeId }));

#line default
#line hidden
            EndContext();
            BeginContext(461, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(470, 40, false);
#line 25 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Alternatives\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(510, 8, true);
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OMGT_Lab1.Models.Alternative> Html { get; private set; }
    }
}
#pragma warning restore 1591
