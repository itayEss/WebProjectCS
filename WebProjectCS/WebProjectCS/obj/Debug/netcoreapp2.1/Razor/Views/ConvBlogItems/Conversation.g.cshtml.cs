#pragma checksum "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cc991836760cc6dfc62df50f0e3e50cc186e473"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ConvBlogItems_Conversation), @"mvc.1.0.view", @"/Views/ConvBlogItems/Conversation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ConvBlogItems/Conversation.cshtml", typeof(AspNetCore.Views_ConvBlogItems_Conversation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cc991836760cc6dfc62df50f0e3e50cc186e473", @"/Views/ConvBlogItems/Conversation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38ac20f9353a8d2660ee36127ad4304330b7a402", @"/Views/_ViewImports.cshtml")]
    public class Views_ConvBlogItems_Conversation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebProjectCS.Models.BlogItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BlogItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
  
    ViewData["Title"] = "Index";



#line default
#line hidden
            BeginContext(126, 36, true);
            WriteLiteral("\r\n<h2>Conversation</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(162, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20a2a61c1eb74cea85a9f98746dba280", async() => {
                BeginContext(245, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
                                                       WriteLiteral(ViewData["ConvID"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(259, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(352, 46, false);
#line 20 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
           Write(Html.DisplayNameFor(model => model.BlogItemID));

#line default
#line hidden
            EndContext();
            BeginContext(398, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(454, 40, false);
#line 23 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(494, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(550, 42, false);
#line 26 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
           Write(Html.DisplayNameFor(model => model.ConvID));

#line default
#line hidden
            EndContext();
            BeginContext(592, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(648, 39, false);
#line 29 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
           Write(Html.DisplayNameFor(model => model.UID));

#line default
#line hidden
            EndContext();
            BeginContext(687, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(743, 43, false);
#line 32 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
           Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(786, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(842, 43, false);
#line 35 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
           Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
            EndContext();
            BeginContext(885, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(941, 45, false);
#line 38 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
           Write(Html.DisplayNameFor(model => model.RelatedID));

#line default
#line hidden
            EndContext();
            BeginContext(986, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1121, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1182, 15, false);
#line 48 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
               Write(item.BlogItemID);

#line default
#line hidden
            EndContext();
            BeginContext(1197, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1265, 9, false);
#line 51 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
               Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1274, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1342, 11, false);
#line 54 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
               Write(item.ConvID);

#line default
#line hidden
            EndContext();
            BeginContext(1353, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1421, 8, false);
#line 57 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
               Write(item.UID);

#line default
#line hidden
            EndContext();
            BeginContext(1429, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1497, 12, false);
#line 60 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
               Write(item.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(1509, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1577, 12, false);
#line 63 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
               Write(item.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1589, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1657, 14, false);
#line 66 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
               Write(item.RelatedID);

#line default
#line hidden
            EndContext();
            BeginContext(1671, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1738, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ab0ff189f02484ea309a0851f1347da", async() => {
                BeginContext(1847, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
                                                                      WriteLiteral(item.BlogItemID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
                                                                                                       WriteLiteral(item.ConvID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1855, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1879, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1be3309d1ba4a028d115652c8641d93", async() => {
                BeginContext(1962, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
                                                                         WriteLiteral(item.BlogItemID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1973, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1997, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01194b7323a64304a8f66ec18b5f7beb", async() => {
                BeginContext(2079, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
                                                                        WriteLiteral(item.BlogItemID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2089, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2113, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60903f5733c649f38a2ddb626236b19d", async() => {
                BeginContext(2226, 7, true);
                WriteLiteral("Comment");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-rid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
                                                                          WriteLiteral(item.BlogItemID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["rid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-rid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["rid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
                                                                                                           WriteLiteral(item.ConvID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2237, 46, true);
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 76 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"




        }

#line default
#line hidden
            BeginContext(2302, 78, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div id=\"blog-data\" class=\"row\">\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2401, 99, true);
                WriteLiteral("\r\n\r\n<script>\r\n        doStuff();\r\n\r\n        function doStuff()\r\n        {\r\n            var model = ");
                EndContext();
                BeginContext(2501, 31, false);
#line 98 "C:\Users\itaye\Documents\Visual Studio 2017\Projects\WebProjectCS\WebProjectCS\Views\ConvBlogItems\Conversation.cshtml"
                   Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
                EndContext();
                BeginContext(2532, 2227, true);
                WriteLiteral(@";

            for(var item in model)
            {
                //console.log(model[item].blogItemID);
                var htmlLine = ""<div class='row solid-borders'>""
                console.log(model[item]);
                htmlLine += builedBlogItem(model[item].blogItemID, model[item].convID,model[item].subject, model[item].message, model[item].uid, model[item].date)
                $.get(""../../../BlogItems/GetAllLeafs/"" + model[item].blogItemID, function (data) {
                    console.log(data);
                    for (bi in data)
                    {
                        console.log(""bi: data"");

                        console.log(data[bi]);

                        htmlLine += builedBlogItem(data[bi].blogItemID, data[bi].convID,data[bi].subject, data[bi].message, data[bi].uid, data[bi].date)

                    }
                    htmlLine += ""</div>"";
                    $('#blog-data').append(htmlLine);
                   
                })
                 ");
                WriteLiteral(@"   .done(function (data) {
                    })
                    .fail(function (data) {
                    })
                    .always(function (data) {
                    });
                

            }

        }

        function builedBlogItem(bid,convID,subject, msg, username,date)
        {
            var tempBlogItem =
                ""<div class='solid-borders blog-item'>"" +
                    date +
                    ""<div class='subject-box'>"" +
                        subject +
                    ""</div>"" +
                    ""<div class='massage-box'>"" +
                        ""<br>""+username+"":<br>""+ msg + ""<br>"" +
                    ""</div>"" +
                    ""<div>"" + 
                        ""<a href='/BlogItems/Edit/"" + bid + ""?cid="" + convID + ""'>Edit</a> |"" +
                        ""<a href='/BlogItems/Details/"" + bid + ""'>Details</a> | "" +
                        ""<a href='/BlogItems/Delete/"" + bid + ""'>Delete</a> | "" +
               ");
                WriteLiteral("         \"<a href=\'/BlogItems/Comment?rid=\" + bid+\"&amp;cid=\"+ convID + \"\'>Comment</a> \" +\r\n            \"</div>\";\r\n            return tempBlogItem;\r\n\r\n        }\r\n\r\n</script>\r\n    ");
                EndContext();
            }
            );
            BeginContext(4762, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebProjectCS.Models.BlogItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
