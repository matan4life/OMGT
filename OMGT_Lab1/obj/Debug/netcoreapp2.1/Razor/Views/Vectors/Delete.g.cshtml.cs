#pragma checksum "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c10ab247c5cf1f0111af2157f934281324801ec7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vectors_Delete), @"mvc.1.0.view", @"/Views/Vectors/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vectors/Delete.cshtml", typeof(AspNetCore.Views_Vectors_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10ab247c5cf1f0111af2157f934281324801ec7", @"/Views/Vectors/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e49c656068098f7e337bc75b602c0c98c205a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Vectors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OMGT_Lab1.Models.Vector>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
            BeginContext(72, 148, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Vector</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\"></dl>\r\n\r\n");
            EndContext();
#line 15 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(267, 23, false);
#line 17 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(292, 58, true);
            WriteLiteral("    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(351, 63, false);
#line 20 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Alternative.AlternativeName));

#line default
#line hidden
            EndContext();
            BeginContext(414, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(460, 59, false);
#line 24 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Alternative.AlternativeName));

#line default
#line hidden
            EndContext();
            BeginContext(519, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(565, 55, false);
#line 28 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mark.Criterion.Name));

#line default
#line hidden
            EndContext();
            BeginContext(620, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(666, 51, false);
#line 32 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mark.Criterion.Name));

#line default
#line hidden
            EndContext();
            BeginContext(717, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(761, 24, false);
#line 35 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
       Write(Html.DisplayName("Mark"));

#line default
#line hidden
            EndContext();
            BeginContext(785, 17, true);
            WriteLiteral("\r\n        </dt>\r\n");
            EndContext();
#line 37 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
         if (Model.Mark.Criterion.Type == OMGT_Lab1.Models.Enums.CriteriaType.Quantitative)
        {


#line default
#line hidden
            BeginContext(908, 34, true);
            WriteLiteral("            <dd>\r\n                ");
            EndContext();
            BeginContext(943, 48, false);
#line 41 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Mark.NumericMark));

#line default
#line hidden
            EndContext();
            BeginContext(991, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 43 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1048, 34, true);
            WriteLiteral("            <dd>\r\n                ");
            EndContext();
            BeginContext(1083, 41, false);
#line 47 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Mark.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 49 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
        }

#line default
#line hidden
            BeginContext(1156, 148, true);
            WriteLiteral("\r\n    </dl>\r\n        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
            EndContext();
            BeginContext(1305, 40, false);
#line 54 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 56 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\Vectors\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(1370, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OMGT_Lab1.Models.Vector> Html { get; private set; }
    }
}
#pragma warning restore 1591
