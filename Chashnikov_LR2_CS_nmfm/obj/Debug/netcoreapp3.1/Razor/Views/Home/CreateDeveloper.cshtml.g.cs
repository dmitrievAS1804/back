#pragma checksum "C:\Users\dcd_b\Desktop\Chashnikov_LR2_CS_nmfm\Views\Home\CreateDeveloper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb4896ca01cd8e331959040b1820c8ef4bb95926"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateDeveloper), @"mvc.1.0.view", @"/Views/Home/CreateDeveloper.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb4896ca01cd8e331959040b1820c8ef4bb95926", @"/Views/Home/CreateDeveloper.cshtml")]
    public class Views_Home_CreateDeveloper : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chashnikov_LR2_CS.Models.Developer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dcd_b\Desktop\Chashnikov_LR2_CS_nmfm\Views\Home\CreateDeveloper.cshtml"
  
    ViewData["Title"] = "CreateDeveloper";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>CreateDeveloper</h1>

<h4>Developer</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""CreateDeveloper"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Age"" class=""control-label""></label>
                <input asp-for=""Age"" class=""form-control"" />
                <span asp-validation-for=""Age"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Company"" class=""control-label""></label>
                <input asp-for=""Company"" class=""form-control"" />
                <span asp-validation-for=""Company"" class=""text-danger""></span>
    ");
            WriteLiteral("        </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\dcd_b\Desktop\Chashnikov_LR2_CS_nmfm\Views\Home\CreateDeveloper.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chashnikov_LR2_CS.Models.Developer> Html { get; private set; }
    }
}
#pragma warning restore 1591
