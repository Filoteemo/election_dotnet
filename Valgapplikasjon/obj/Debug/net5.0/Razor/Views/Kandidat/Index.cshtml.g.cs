#pragma checksum "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "429c1a344e7f5302d12a86f74ac10c057049cc0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kandidat_Index), @"mvc.1.0.view", @"/Views/Kandidat/Index.cshtml")]
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
#line 5 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
using Valgapplikasjon.Areas.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"429c1a344e7f5302d12a86f74ac10c057049cc0d", @"/Views/Kandidat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    public class Views_Kandidat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Valgapplikasjon.Models.BrukerKandidatViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bilder/ArnulfStorseth.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("kandidatformA"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"mittkandidatur_liste\">\r\n    <li> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "429c1a344e7f5302d12a86f74ac10c057049cc0d5648", async() => {
                WriteLiteral("Registrer kandidatur ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 15 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
     foreach (var item in Model)
    {


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
         if (item.kandidaterVm.Id == @UserManager.GetUserId(User))
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "429c1a344e7f5302d12a86f74ac10c057049cc0d7364", async() => {
                WriteLiteral("Endre kandidatur");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                                       WriteLiteral(item.kandidaterVm.KandidatId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n            </li>\r\n            <li>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "429c1a344e7f5302d12a86f74ac10c057049cc0d9609", async() => {
                WriteLiteral("Slett kandidatur");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                                         WriteLiteral(item.kandidaterVm.KandidatId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" <br />\r\n            </li>\r\n            <li><p>Start nominering ");
#nullable restore
#line 28 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ValgVm.StartNominering));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> Slutt nominering ");
#nullable restore
#line 28 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                                                                                                                  Write(Html.DisplayFor(modelItem => item.ValgVm.SluttNominering));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></li>\r\n");
#nullable restore
#line 30 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                                                                                            
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</ul>

    <div class=""mittkandidatur_desktop"">
        <table class=""table table-striped"">
            <tr>
                <th>Email</th>
                <th>Fornavn</th>
                <th>Etternavn</th>
                <th>Ansettelse</th>
                <th>Fakultet</th>
                <th>Institutt</th>
                <th>Campus</th>
                <th>Valg</th>
            </tr>
");
#nullable restore
#line 47 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                 if (item.kandidaterVm.Id == @UserManager.GetUserId(User))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.usersVm.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 53 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.usersVm.Fornavn));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 54 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.usersVm.Etternavn));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 55 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.kandidaterVm.Ansettelse));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 56 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.kandidaterVm.Fakultet));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 57 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.kandidaterVm.Institutt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 58 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.kandidaterVm.Campus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 59 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValgVm.Tittel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 61 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n    <div class=\"mittkandidatur_mobile\">\r\n");
#nullable restore
#line 66 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
             if (item.kandidaterVm.Id == @UserManager.GetUserId(User))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "429c1a344e7f5302d12a86f74ac10c057049cc0d17483", async() => {
                WriteLiteral("\r\n                    <div class=\"kandidatbilde\">\r\n");
#nullable restore
#line 72 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                         if (item.usersVm.Profilbilde != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 2827, "\"", 2904, 2);
                WriteAttributeValue("", 2833, "data:image/*;base64,", 2833, 20, true);
#nullable restore
#line 74 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
WriteAttributeValue("", 2853, Convert.ToBase64String(item.usersVm.Profilbilde), 2853, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 75 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                         if (item.usersVm.Profilbilde == null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "429c1a344e7f5302d12a86f74ac10c057049cc0d19152", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                    <hr>\r\n                    <p>\r\n                        <strong>Fornavn: </strong>");
#nullable restore
#line 83 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.usersVm.Fornavn));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        <strong>Etternavn: </strong>");
#nullable restore
#line 85 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.usersVm.Etternavn));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        <strong>Ansettelse: </strong>");
#nullable restore
#line 87 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                                                Write(Html.DisplayFor(modelItem => item.kandidaterVm.Ansettelse));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        <strong>Fakultet: </strong>");
#nullable restore
#line 89 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.kandidaterVm.Fakultet));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        <strong>Institutt: </strong>");
#nullable restore
#line 91 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.kandidaterVm.Institutt));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        <strong>Campus: </strong>");
#nullable restore
#line 93 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.kandidaterVm.Campus));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                        <strong>Valg: </strong>");
#nullable restore
#line 95 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.ValgVm.Tittel));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <br>\r\n                    </p>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 99 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\sindr\source\repos\Valgapplikasjon\Valgapplikasjon\Views\Kandidat\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ValgapplikasjonUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Valgapplikasjon.Models.BrukerKandidatViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
