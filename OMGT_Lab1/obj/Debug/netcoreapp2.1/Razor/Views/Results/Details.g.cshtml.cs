#pragma checksum "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Results\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f50d2a61ac1758e39735dbf830e27759f8054f4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Results_Details), @"mvc.1.0.view", @"/Views/Results/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Results/Details.cshtml", typeof(AspNetCore.Views_Results_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f50d2a61ac1758e39735dbf830e27759f8054f4f", @"/Views/Results/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e49c656068098f7e337bc75b602c0c98c205a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Results_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OMGT_Lab1.Models.Result>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Results\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(73, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Result</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(194, 41, false);
#line 14 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Results\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Range));

#line default
#line hidden
            EndContext();
            BeginContext(235, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(281, 37, false);
#line 18 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Results\Details.cshtml"
       Write(Html.DisplayFor(model => model.Range));

#line default
#line hidden
            EndContext();
            BeginContext(318, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(364, 53, false);
#line 22 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Results\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AlternativeWeight));

#line default
#line hidden
            EndContext();
            BeginContext(417, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(463, 49, false);
#line 26 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Results\Details.cshtml"
       Write(Html.DisplayFor(model => model.AlternativeWeight));

#line default
#line hidden
            EndContext();
            BeginContext(512, 47, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(560, 60, false);
#line 32 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Results\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.ResultId }));

#line default
#line hidden
            EndContext();
            BeginContext(620, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(629, 40, false);
#line 33 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Results\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(669, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OMGT_Lab1.Models.Result> Html { get; private set; }
    }
}
#pragma warning restore 1591