#pragma checksum "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\App\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac2d282dc7446a967485c90a457f1257a271860d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Contact), @"mvc.1.0.view", @"/Views/App/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/App/Contact.cshtml", typeof(AspNetCore.Views_App_Contact))]
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
#line 1 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\_ViewImports.cshtml"
using WebProjectCS;

#line default
#line hidden
#line 2 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\_ViewImports.cshtml"
using WebProjectCS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac2d282dc7446a967485c90a457f1257a271860d", @"/Views/App/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38ac20f9353a8d2660ee36127ad4304330b7a402", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\App\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(48, 17, false);
#line 4 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\App\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(65, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(77, 19, false);
#line 5 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\App\Contact.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(96, 249, true);
            WriteLiteral("</h3>\r\n\r\n<address>\r\n    One Microsoft Way<br />\r\n    Redmond, WA 98052-6399<br />\r\n    <abbr title=\"Phone\">P:</abbr>\r\n    425.555.0100\r\n</address>\r\n\r\n<address>\r\n    <strong>Support:</strong> <a href=\"mailto:Support@example.com\">Support@example.com  ");
            EndContext();
            BeginContext(346, 20, false);
#line 15 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\App\Contact.cshtml"
                                                                                   Write(ViewBag.sessionvName);

#line default
#line hidden
            EndContext();
            BeginContext(366, 122, true);
            WriteLiteral("</a><br />\r\n    <strong>Marketing:</strong> <a href=\"mailto:Marketing@example.com\">Marketing@example.com</a>\r\n</address>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
