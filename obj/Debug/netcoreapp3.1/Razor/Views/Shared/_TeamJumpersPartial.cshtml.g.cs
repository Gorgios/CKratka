#pragma checksum "D:\SkijumpingTeams\Views\Shared\_TeamJumpersPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac332756206aab177dc20c431e5364ce67a48f85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TeamJumpersPartial), @"mvc.1.0.view", @"/Views/Shared/_TeamJumpersPartial.cshtml")]
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
#nullable restore
#line 1 "D:\SkijumpingTeams\Views\_ViewImports.cshtml"
using SkijumpingTeams;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SkijumpingTeams\Views\_ViewImports.cshtml"
using SkijumpingTeams.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac332756206aab177dc20c431e5364ce67a48f85", @"/Views/Shared/_TeamJumpersPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"162116b75fe6b4b1461d405340288fc2082b7ea6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TeamJumpersPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SkijumpingTeams.Models.Jumper>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"content\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 75, "\"", 110, 1);
#nullable restore
#line 4 "D:\SkijumpingTeams\Views\Shared\_TeamJumpersPartial.cshtml"
WriteAttributeValue("", 81, Url.Content(Model.PhotoLink), 81, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 111, "\"", 117, 0);
            EndWriteAttribute();
            WriteLiteral(" height=\"400\" width=\"300\">\r\n        <h3> Jumper info</h3>\r\n        <p>\r\n            <span>Name:</span>\r\n            ");
#nullable restore
#line 8 "D:\SkijumpingTeams\Views\Shared\_TeamJumpersPartial.cshtml"
       Write(Html.DisplayFor(modelItem => Model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span>");
#nullable restore
#line 9 "D:\SkijumpingTeams\Views\Shared\_TeamJumpersPartial.cshtml"
             Write(Html.DisplayFor(modelItem => Model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n            <span>Birthday:</span>\r\n            ");
#nullable restore
#line 11 "D:\SkijumpingTeams\Views\Shared\_TeamJumpersPartial.cshtml"
       Write(Html.DisplayFor(modelItem => Model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            <span>Full details: </span>\r\n            ");
#nullable restore
#line 13 "D:\SkijumpingTeams\Views\Shared\_TeamJumpersPartial.cshtml"
       Write(Html.ActionLink("Details", "Details", "Jumpers", new { id = Model.ID }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SkijumpingTeams.Models.Jumper> Html { get; private set; }
    }
}
#pragma warning restore 1591
