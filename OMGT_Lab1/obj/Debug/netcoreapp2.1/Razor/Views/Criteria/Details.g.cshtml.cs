#pragma checksum "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0319170d644b99f5c0a109155a63732b43850137"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Criteria_Details), @"mvc.1.0.view", @"/Views/Criteria/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Criteria/Details.cshtml", typeof(AspNetCore.Views_Criteria_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0319170d644b99f5c0a109155a63732b43850137", @"/Views/Criteria/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e49c656068098f7e337bc75b602c0c98c205a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Criteria_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OMGT_Lab1.Models.Criterion>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(76, 123, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Criterion</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(200, 40, false);
#line 14 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(240, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(286, 36, false);
#line 18 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(322, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(368, 41, false);
#line 22 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Range));

#line default
#line hidden
            EndContext();
            BeginContext(409, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(455, 37, false);
#line 26 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayFor(model => model.Range));

#line default
#line hidden
            EndContext();
            BeginContext(492, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(538, 42, false);
#line 30 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(580, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(626, 38, false);
#line 34 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(664, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(710, 40, false);
#line 38 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(750, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(796, 36, false);
#line 42 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(832, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(878, 45, false);
#line 46 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OptimType));

#line default
#line hidden
            EndContext();
            BeginContext(923, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(969, 41, false);
#line 50 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayFor(model => model.OptimType));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1056, 40, false);
#line 54 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1142, 36, false);
#line 58 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayFor(model => model.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1224, 45, false);
#line 62 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ScaleType));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1315, 41, false);
#line 66 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
       Write(Html.DisplayFor(model => model.ScaleType));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 47, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(1404, 63, false);
#line 72 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.CriterionId }));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1476, 40, false);
#line 73 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OMGT_Lab1.Models.Criterion> Html { get; private set; }
    }
}
#pragma warning restore 1591