#pragma checksum "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d934d85b1f0af021a0bce241c83d260e65fd20cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LPRs_Edit), @"mvc.1.0.view", @"/Views/LPRs/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LPRs/Edit.cshtml", typeof(AspNetCore.Views_LPRs_Edit))]
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
#line 6 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d934d85b1f0af021a0bce241c83d260e65fd20cc", @"/Views/LPRs/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e49c656068098f7e337bc75b602c0c98c205a20", @"/Views/_ViewImports.cshtml")]
    public class Views_LPRs_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OMGT_Lab1.Models.LPR>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
            BeginContext(105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(205, 19, true);
            WriteLiteral("<h2>Edit</h2>\r\n\r\n\r\n");
            EndContext();
#line 13 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(259, 23, false);
#line 15 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(286, 81, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>LPR</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(368, 64, false);
#line 20 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(432, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(443, 36, false);
#line 21 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
   Write(Html.HiddenFor(model => model.LPRId));

#line default
#line hidden
            EndContext();
            BeginContext(479, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
         if (SignInManager.IsSignedIn(User) && Model.LPRName==User.Identity.Name)
        {
            

#line default
#line hidden
            BeginContext(588, 36, false);
#line 24 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
       Write(Html.HiddenFor(model=>model.LPRName));

#line default
#line hidden
            EndContext();
            BeginContext(626, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(681, 97, false);
#line 26 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
           Write(Html.LabelFor(model => model.LPRRange, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(778, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(842, 97, false);
#line 28 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
               Write(Html.EditorFor(model => model.LPRRange, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(939, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(962, 86, false);
#line 29 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.LPRRange, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 46, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            EndContext();
            BeginContext(1096, 221, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                <div class=\"col-md-offset-2 col-md-10\">\r\n                    <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 38 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1353, 73, true);
            WriteLiteral("            <h4>Sorry, you don\'t have enough permission to do this</h4>\r\n");
            EndContext();
#line 42 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(1437, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 44 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(1452, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1466, 40, false);
#line 47 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OMGT_Lab1.Models.LPR> Html { get; private set; }
    }
}
#pragma warning restore 1591