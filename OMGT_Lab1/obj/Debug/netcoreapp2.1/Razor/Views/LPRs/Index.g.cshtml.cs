#pragma checksum "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20f9651e8409fd0431ed35a00dd89adc31abe245"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LPRs_Index), @"mvc.1.0.view", @"/Views/LPRs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LPRs/Index.cshtml", typeof(AspNetCore.Views_LPRs_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20f9651e8409fd0431ed35a00dd89adc31abe245", @"/Views/LPRs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e49c656068098f7e337bc75b602c0c98c205a20", @"/Views/_ViewImports.cshtml")]
    public class Views_LPRs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OMGT_Lab1.Models.LPR>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(81, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(111, 39, false);
#line 10 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(150, 67, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(218, 43, false);
#line 15 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.LPRName));

#line default
#line hidden
            EndContext();
            BeginContext(261, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(305, 44, false);
#line 18 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.LPRRange));

#line default
#line hidden
            EndContext();
            BeginContext(349, 49, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 23 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(439, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(488, 42, false);
#line 27 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LPRName));

#line default
#line hidden
            EndContext();
            BeginContext(530, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(586, 43, false);
#line 30 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LPRRange));

#line default
#line hidden
            EndContext();
            BeginContext(629, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(685, 56, false);
#line 33 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.LPRId }));

#line default
#line hidden
            EndContext();
            BeginContext(741, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(762, 62, false);
#line 34 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.LPRId }));

#line default
#line hidden
            EndContext();
            BeginContext(824, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(845, 60, false);
#line 35 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.LPRId }));

#line default
#line hidden
            EndContext();
            BeginContext(905, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(948, 12, true);
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OMGT_Lab1.Models.LPR>> Html { get; private set; }
    }
}
#pragma warning restore 1591
