#pragma checksum "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Ativo\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cdc0186580b53556b2a6f1dc47589ae9a8de17d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ativo_Editar), @"mvc.1.0.view", @"/Views/Ativo/Editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ativo/Editar.cshtml", typeof(AspNetCore.Views_Ativo_Editar))]
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
#line 1 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\_ViewImports.cshtml"
using SGA.ModuloGestaoAtivo;

#line default
#line hidden
#line 2 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\_ViewImports.cshtml"
using SGA.ModuloGestaoAtivo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cdc0186580b53556b2a6f1dc47589ae9a8de17d", @"/Views/Ativo/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b675e2c77aecf8cad3cdad6d876350bfc0bfa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Ativo_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AtivoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Listar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ativo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Voltar para lista de Ativos."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Ativo/editar.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Ativo\Editar.cshtml"
  
    ViewData["Title"] = "Editar Ativo";

#line default
#line hidden
            BeginContext(67, 239, true);
            WriteLiteral("<div class=\"row justify-content-md-center\">\r\n    <div class=\"col-xs-12 col-sm-10\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\"><strong>Editar Ativo</strong></div>\r\n            <div class=\"card-body\">\r\n                ");
            EndContext();
            BeginContext(306, 2038, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdc0186580b53556b2a6f1dc47589ae9a8de17d6157", async() => {
                BeginContext(332, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(355, 25, false);
#line 11 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Ativo\Editar.cshtml"
               Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
                EndContext();
                BeginContext(380, 309, true);
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-xs-12 col-sm-6"">
                            <div class=""form-group"">
                                <label for=""Nome"">Nome do Ativo</label>
                                <input type=""text"" class=""form-control"" name=""Nome""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 689, "\"", 708, 1);
#line 16 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Ativo\Editar.cshtml"
WriteAttributeValue("", 697, Model.Nome, 697, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(709, 401, true);
                WriteLiteral(@" required maxlength=""100"" placeholder=""Nome completo do ativo"">
                            </div>
                        </div>
                        <div class=""col-xs-12 col-sm-4"">
                            <div class=""form-group"">
                                <label for=""Tipo"">Tipo do Ativo</label>
                                <input type=""text"" class=""form-control"" name=""Tipo""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1110, "\"", 1129, 1);
#line 22 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Ativo\Editar.cshtml"
WriteAttributeValue("", 1118, Model.Tipo, 1118, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1130, 476, true);
                WriteLiteral(@" required maxlength=""100"" placeholder=""Carros, tratores, caminhões, máquinas e equipamentos"">
                            </div>
                        </div>
                        <div class=""col-xs-12 col-sm-2"">
                            <div class=""form-group"">
                                <label for=""QtdDiasPeriodoManutencao"">Período Manutenção</label>
                                <input type=""text"" class=""form-control"" name=""QtdDiasPeriodoManutencao""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1606, "\"", 1645, 1);
#line 28 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Ativo\Editar.cshtml"
WriteAttributeValue("", 1614, Model.QtdDiasPeriodoManutencao, 1614, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1646, 458, true);
                WriteLiteral(@" required maxlength=""5"" alt=""numero"" placeholder=""30, 60, 90 dias"">
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-xs-12 col-sm-12"">
                            <div class=""float-right"">
                                <button type=""submit"" class=""btn btn-primary gravar-ativo"">Gravar</button>
                                ");
                EndContext();
                BeginContext(2104, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdc0186580b53556b2a6f1dc47589ae9a8de17d9865", async() => {
                    BeginContext(2213, 6, true);
                    WriteLiteral("Voltar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2223, 114, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
                EndContext();
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
            EndContext();
            BeginContext(2344, 58, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2420, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2426, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdc0186580b53556b2a6f1dc47589ae9a8de17d13225", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 46 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Ativo\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2496, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AtivoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
