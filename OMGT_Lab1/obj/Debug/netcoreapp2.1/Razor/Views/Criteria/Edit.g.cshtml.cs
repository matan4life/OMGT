#pragma checksum "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61defb2568694e6dee7e14957365d471fe4b7e5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Criteria_Edit), @"mvc.1.0.view", @"/Views/Criteria/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Criteria/Edit.cshtml", typeof(AspNetCore.Views_Criteria_Edit))]
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
#line 1 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
using OMGT_Lab1.Models.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61defb2568694e6dee7e14957365d471fe4b7e5c", @"/Views/Criteria/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e49c656068098f7e337bc75b602c0c98c205a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Criteria_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OMGT_Lab1.Models.Criterion>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
            BeginContext(107, 21, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(163, 23, false);
#line 14 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(190, 71, true);
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>Criterion</h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(262, 64, false);
#line 19 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(326, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(333, 42, false);
#line 20 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
Write(Html.HiddenFor(model => model.CriterionId));

#line default
#line hidden
            EndContext();
            BeginContext(375, 42, true);
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(418, 93, false);
#line 23 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
   Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(511, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(559, 93, false);
#line 25 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
       Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(652, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(667, 82, false);
#line 26 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(749, 70, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(820, 93, false);
#line 31 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
   Write(Html.LabelFor(model => model.Type, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(913, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(961, 128, false);
#line 33 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
       Write(Html.DropDownList("Type", new SelectList(Enum.GetValues(typeof(CriteriaType))), htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1104, 82, false);
#line 34 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Type, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 70, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1257, 98, false);
#line 39 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
   Write(Html.LabelFor(model => model.OptimType, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1403, 140, false);
#line 41 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
       Write(Html.DropDownList("OptimalityType", new SelectList(Enum.GetValues(typeof(OptimalityType))), htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1543, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1558, 87, false);
#line 42 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.OptimType, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 70, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1716, 93, false);
#line 47 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
   Write(Html.LabelFor(model => model.Unit, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1809, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1857, 122, false);
#line 49 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
       Write(Html.DropDownList("Units", new SelectList(Enum.GetValues(typeof(Units))), htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1979, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1994, 82, false);
#line 50 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Unit, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2076, 70, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(2147, 98, false);
#line 55 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
   Write(Html.LabelFor(model => model.ScaleType, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2245, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(2293, 132, false);
#line 57 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
       Write(Html.DropDownList("ScaleTypes", new SelectList(Enum.GetValues(typeof(ScaleTypes))), htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2425, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(2440, 87, false);
#line 58 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.ScaleType, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2527, 221, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 68 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(2751, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2765, 40, false);
#line 71 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Criteria\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2805, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
