#pragma checksum "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f5c0a9b7e1832f2768ce9c5660d65bd3e5f8fb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Marks_Details), @"mvc.1.0.view", @"/Views/Marks/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Marks/Details.cshtml", typeof(AspNetCore.Views_Marks_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f5c0a9b7e1832f2768ce9c5660d65bd3e5f8fb9", @"/Views/Marks/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e49c656068098f7e337bc75b602c0c98c205a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Marks_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OMGT_Lab1.Models.Mark>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(71, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Mark</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(190, 40, false);
#line 14 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(230, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(276, 36, false);
#line 18 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(312, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(358, 41, false);
#line 22 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Range));

#line default
#line hidden
            EndContext();
            BeginContext(399, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(445, 37, false);
#line 26 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Range));

#line default
#line hidden
            EndContext();
            BeginContext(482, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(528, 47, false);
#line 30 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumericMark));

#line default
#line hidden
            EndContext();
            BeginContext(575, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(621, 43, false);
#line 34 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumericMark));

#line default
#line hidden
            EndContext();
            BeginContext(664, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(710, 52, false);
#line 38 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StandartizedMark));

#line default
#line hidden
            EndContext();
            BeginContext(762, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(808, 48, false);
#line 42 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Details.cshtml"
       Write(Html.DisplayFor(model => model.StandartizedMark));

#line default
#line hidden
            EndContext();
            BeginContext(856, 47, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(904, 58, false);
#line 48 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.MarkId }));

#line default
#line hidden
            EndContext();
            BeginContext(962, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(971, 40, false);
#line 49 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OMGT_Lab1.Models.Mark> Html { get; private set; }
    }
}
#pragma warning restore 1591