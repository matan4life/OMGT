#pragma checksum "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebf79304f82068d377345f9e69a2c34ca25b3489"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LPRs_Delete), @"mvc.1.0.view", @"/Views/LPRs/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LPRs/Delete.cshtml", typeof(AspNetCore.Views_LPRs_Delete))]
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
#line 6 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf79304f82068d377345f9e69a2c34ca25b3489", @"/Views/LPRs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e49c656068098f7e337bc75b602c0c98c205a20", @"/Views/_ViewImports.cshtml")]
    public class Views_LPRs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OMGT_Lab1.Models.LPR>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
            BeginContext(107, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(207, 17, true);
            WriteLiteral("<h2>Delete</h2>\r\n");
            EndContext();
#line 11 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
 if (SignInManager.IsSignedIn(User) && Model.LPRName == User.Identity.Name)
{


#line default
#line hidden
            BeginContext(306, 171, true);
            WriteLiteral("    <h3>Are you sure you want to delete this?</h3>\r\n    <div>\r\n        <h4>LPR</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(478, 43, false);
#line 20 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.LPRName));

#line default
#line hidden
            EndContext();
            BeginContext(521, 57, true);
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(579, 39, false);
#line 24 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.LPRName));

#line default
#line hidden
            EndContext();
            BeginContext(618, 57, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(676, 44, false);
#line 28 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.LPRRange));

#line default
#line hidden
            EndContext();
            BeginContext(720, 57, true);
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(778, 40, false);
#line 32 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.LPRRange));

#line default
#line hidden
            EndContext();
            BeginContext(818, 40, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n\r\n");
            EndContext();
#line 37 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(917, 23, false);
#line 39 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(944, 147, true);
            WriteLiteral("            <div class=\"form-actions no-color\">\r\n                <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n                ");
            EndContext();
            BeginContext(1092, 40, false);
#line 43 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
           Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1132, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 45 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
        }

#line default
#line hidden
            BeginContext(1165, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 48 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1191, 84, true);
            WriteLiteral("    <h4>Sorry, you don\'t have enough permission to do this</h4>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1276, 40, false);
#line 53 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
   Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 55 "C:\Users\Владелец\Desktop\OMGT_Lab1\OMGT_Lab1\Views\LPRs\Delete.cshtml"
}

#line default
#line hidden
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
