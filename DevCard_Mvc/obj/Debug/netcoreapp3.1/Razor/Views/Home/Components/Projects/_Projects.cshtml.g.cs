#pragma checksum "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\Home\Components\Projects\_Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0bf59fa3bedac294e55542070f4d68d6d0353e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Projects__Projects), @"mvc.1.0.view", @"/Views/Home/Components/Projects/_Projects.cshtml")]
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
#line 1 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\_ViewImports.cshtml"
using DevCard_Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\_ViewImports.cshtml"
using DevCard_Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0bf59fa3bedac294e55542070f4d68d6d0353e9", @"/Views/Home/Components/Projects/_Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de1a09574fcca7cc0cd1ac5dfb072ded2fb18c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Projects__Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DevCard_MVC.Models.Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"featured-section p-3 p-lg-5\">\r\n    <div class=\"container\">\r\n        <h2 class=\"section-title font-weight-bold mb-5\">خاص ترین پروژه ها</h2>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 9 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\Home\Components\Projects\_Projects.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6 mb-5\">\r\n                <div class=\"card project-card\">\r\n                    <div class=\"row no-gutters\">\r\n                        <div class=\"col-lg-4 card-img-holder\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0bf59fa3bedac294e55542070f4d68d6d0353e94785", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 652, "~/assets/images/project/", 652, 24, true);
#nullable restore
#line 15 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\Home\Components\Projects\_Projects.cshtml"
AddHtmlAttributeValue("", 676, item.Image, 676, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""col-lg-8"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">
                                    <a href=""project.html"" class=""theme-link"">
                                       ");
#nullable restore
#line 21 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\Home\Components\Projects\_Projects.cshtml"
                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </h5>\r\n                                <p class=\"card-text\">\r\n                                   ");
#nullable restore
#line 25 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\Home\Components\Projects\_Projects.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"card-text\"><small class=\"text-muted\">سفارش دهنده: ");
#nullable restore
#line 27 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\Home\Components\Projects\_Projects.cshtml"
                                                                                       Write(item.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 33 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\Home\Components\Projects\_Projects.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DevCard_MVC.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
