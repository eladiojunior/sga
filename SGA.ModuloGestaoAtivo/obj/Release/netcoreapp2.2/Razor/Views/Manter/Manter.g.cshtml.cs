#pragma checksum "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\Manter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4da228609b5a6134675f4610cccc9022163ebc17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manter_Manter), @"mvc.1.0.view", @"/Views/Manter/Manter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manter/Manter.cshtml", typeof(AspNetCore.Views_Manter_Manter))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da228609b5a6134675f4610cccc9022163ebc17", @"/Views/Manter/Manter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b675e2c77aecf8cad3cdad6d876350bfc0bfa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Manter_Manter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AtivoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Listar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Voltar para lista de Ativos para manutenção."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-manter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Manter/manter.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\Manter.cshtml"
  
    ViewData["Title"] = "Registrar manutenção de Ativo";

#line default
#line hidden
            BeginContext(84, 256, true);
            WriteLiteral(@"<div class=""row justify-content-md-center"">
    <div class=""col-xs-12 col-sm-10"">
        <div class=""card"">
            <div class=""card-header""><strong>Registrar manutenção de Ativo</strong></div>
            <div class=""card-body"">
                ");
            EndContext();
            BeginContext(340, 2908, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da228609b5a6134675f4610cccc9022163ebc176208", async() => {
                BeginContext(366, 70, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"IdAtivo\" id=\"IdAtivo\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 436, "\"", 453, 1);
#line 11 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\Manter.cshtml"
WriteAttributeValue("", 444, Model.Id, 444, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(454, 297, true);
                WriteLiteral(@" />
                    <div class=""row"">
                        <div class=""col-xs-12 col-sm-8"">
                            <div class=""form-group"">
                                <label for=""Nome"">Nome do Ativo</label>
                                <span class=""form-control bg-light"">");
                EndContext();
                BeginContext(752, 10, false);
#line 16 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\Manter.cshtml"
                                                               Write(Model.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(762, 330, true);
                WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""col-xs-12 col-sm-4"">
                            <div class=""form-group"">
                                <label for=""Tipo"">Tipo do Ativo</label>
                                <span class=""form-control bg-light"">");
                EndContext();
                BeginContext(1093, 10, false);
#line 22 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\Manter.cshtml"
                                                               Write(Model.Tipo);

#line default
#line hidden
                EndContext();
                BeginContext(1103, 1888, true);
                WriteLiteral(@"</span>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-xs-12 col-sm-12""><hr /></div>
                    </div>
                    <div class=""row"">
                        <div class=""col-xs-4 col-sm-2"">
                            <div class=""form-group"">
                                <label for=""Data"">Data da Manutenção</label>
                                <input type=""text"" class=""form-control"" name=""Data"" required alt=""data"" maxlength=""10"" placeholder=""00/00/0000"">
                            </div>
                        </div>
                        <div class=""col-xs-8 col-sm-3"">
                            <div class=""form-group form-check"" style=""margin-top: 40px;"">
                                <input type=""checkbox"" class=""form-check-input"" name=""HasPreventiva"" id=""HasPreventiva"">
                                <label class=""form-check-label"" for=""");
                WriteLiteral(@"HasPreventiva"">Manutenção preventiva?</label>
                            </div>
                        </div>
                        <div class=""col-xs-12 col-sm-7"">
                            <div class=""form-group"">
                                <label for=""Descricao"">Descrição da Manutenção</label>
                                <input type=""text"" class=""form-control"" name=""Descricao"" required maxlength=""250"" placeholder=""Descrição breve da manutenção realizada"">
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-xs-12 col-sm-12"">
                            <div class=""float-right"">
                                <button type=""submit"" class=""btn btn-primary"">Registrar</button>
                                ");
                EndContext();
                BeginContext(2991, 136, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da228609b5a6134675f4610cccc9022163ebc1710488", async() => {
                    BeginContext(3117, 6, true);
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
                BeginContext(3127, 114, true);
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
            BeginContext(3248, 58, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3324, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3330, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da228609b5a6134675f4610cccc9022163ebc1713849", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 63 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\Manter.cshtml"
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
                BeginContext(3401, 2, true);
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
