#pragma checksum "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c4671af2a94544e198627e8e21d0925d3bab3fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Marks_Create), @"mvc.1.0.view", @"/Views/Marks/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Marks/Create.cshtml", typeof(AspNetCore.Views_Marks_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4671af2a94544e198627e8e21d0925d3bab3fb", @"/Views/Marks/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e49c656068098f7e337bc75b602c0c98c205a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Marks_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OMGT_Lab1.Models.Mark>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(70, 23, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(128, 23, false);
#line 12 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(155, 82, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Mark</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(238, 64, false);
#line 17 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(302, 48, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(351, 103, false);
#line 19 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
       Write(Html.LabelFor(model => model.Criterion.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(454, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(510, 139, false);
#line 21 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
           Write(Html.DropDownList("CriterionId", (IEnumerable<SelectListItem>)ViewData["CriterionId"], "", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(649, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(668, 99, false);
#line 22 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Criterion.CriterionId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(767, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(854, 93, false);
#line 27 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(947, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1003, 93, false);
#line 29 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1115, 82, false);
#line 30 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1284, 94, false);
#line 35 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
       Write(Html.LabelFor(model => model.Range, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1378, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1434, 94, false);
#line 37 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
           Write(Html.EditorFor(model => model.Range, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1547, 83, false);
#line 38 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Range, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1630, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1717, 100, false);
#line 43 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
       Write(Html.LabelFor(model => model.NumericMark, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1817, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1873, 100, false);
#line 45 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
           Write(Html.EditorFor(model => model.NumericMark, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1973, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1992, 89, false);
#line 46 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.NumericMark, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2081, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2168, 105, false);
#line 51 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
       Write(Html.LabelFor(model => model.StandartizedMark, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2273, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2329, 105, false);
#line 53 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
           Write(Html.EditorFor(model => model.StandartizedMark, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2434, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2453, 94, false);
#line 54 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.StandartizedMark, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2547, 255, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 64 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
}

#line default
#line hidden
            BeginContext(2805, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2819, 40, false);
#line 67 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2859, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2889, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 71 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Marks\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
