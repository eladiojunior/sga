#pragma checksum "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\_ListaManutencao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a8857e71508b294f9c070f6f8e5301e323b1d23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manter__ListaManutencao), @"mvc.1.0.view", @"/Views/Manter/_ListaManutencao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manter/_ListaManutencao.cshtml", typeof(AspNetCore.Views_Manter__ListaManutencao))]
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
#line 1 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\_ListaManutencao.cshtml"
using SGA.ModuloGestaoAtivo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a8857e71508b294f9c070f6f8e5301e323b1d23", @"/Views/Manter/_ListaManutencao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b675e2c77aecf8cad3cdad6d876350bfc0bfa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Manter__ListaManutencao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AtivoModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 461, true);
            WriteLiteral(@"<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"" title=""Nome do Ativo."">Nome</th>
            <th scope=""col"" title=""Tipo do ativo."">Tipo</th>
            <th scope=""col"" title=""Período de manutenção (em dias) do Ativo."">Manutenção</th>
            <th scope=""col"" title=""Data de registro da última manutenção no Ativo."">Última</th>
            <th scope=""col"">Ação</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 14 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\_ListaManutencao.cshtml"
         if (Model == null || !Model.Any())
        {

#line default
#line hidden
            BeginContext(579, 95, true);
            WriteLiteral("            <tr><td colspan=\"5\">Nenhum ativo encontrado para o realizar manutenção.</td></tr>\r\n");
            EndContext();
#line 17 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\_ListaManutencao.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 20 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\_ListaManutencao.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(767, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(814, 9, false);
#line 23 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\_ListaManutencao.cshtml"
                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(823, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(855, 9, false);
#line 24 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\_ListaManutencao.cshtml"
                   Write(item.Tipo);

#line default
#line hidden
            EndContext();
            BeginContext(864, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(896, 29, false);
#line 25 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\_ListaManutencao.cshtml"
                   Write(item.QtdDiasPeriodoManutencao);

#line default
#line hidden
            EndContext();
            BeginContext(925, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(958, 89, false);
#line 26 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\_ListaManutencao.cshtml"
                    Write(item.UltimaManutencao.HasValue ? item.UltimaManutencao.Value.ToString("dd/MM/yyyy") : "-");

#line default
#line hidden
            EndContext();
            BeginContext(1048, 73, true);
            WriteLiteral("</td>\r\n                    <td><a href=\"#\" class=\"manter-ativo\" data-id=\"");
            EndContext();
            BeginContext(1122, 7, false);
#line 27 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\_ListaManutencao.cshtml"
                                                             Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1129, 84, true);
            WriteLiteral("\" title=\"Realizar manutenção do ativo.\">Manutenção</a></td>\r\n                </tr>\r\n");
            EndContext();
#line 29 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\_ListaManutencao.cshtml"
            }

#line default
#line hidden
#line 29 "D:\Projetos\GitHub\SGA\SGA.ModuloGestaoAtivo\Views\Manter\_ListaManutencao.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1239, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AtivoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
