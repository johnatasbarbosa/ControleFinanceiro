#pragma checksum "C:\Users\johna\source\repos\ControleFinanceiro\Views\Financa\_Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22fbbbb78e2d6841d504010a82c14218cbb6309b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Financa__Visualizar), @"mvc.1.0.view", @"/Views/Financa/_Visualizar.cshtml")]
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
#line 1 "C:\Users\johna\source\repos\ControleFinanceiro\Views\_ViewImports.cshtml"
using ControleFinanceiro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\johna\source\repos\ControleFinanceiro\Views\_ViewImports.cshtml"
using ControleFinanceiro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22fbbbb78e2d6841d504010a82c14218cbb6309b", @"/Views/Financa/_Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fe8908c9ef00d8a2cb6d154b078dc85c3dd6eb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Financa__Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ControleFinanceiro.ViewModels.Financa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Financa\_Visualizar.cshtml"
 using (Html.BeginForm(ViewContext.RouteData.Values["action"].ToString(), ViewContext.RouteData.Values["controller"].ToString(), FormMethod.Post, new { id = "formCrud" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"modal-header\">\r\n        <h3 class=\"modal-title\" id=\"myModalLabel\">Finanças</h3>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Financa\_Visualizar.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 16 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Financa\_Visualizar.cshtml"
       Write(Html.DisplayName("Quantidade de aluno (Pagaram/Total)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 19 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Financa\_Visualizar.cshtml"
       Write(Html.DisplayFor(model => model.QtdAlunosPagarem));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 19 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Financa\_Visualizar.cshtml"
                                                           Write(Html.DisplayFor(model => model.QtdAlunosTotais));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 23 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Financa\_Visualizar.cshtml"
       Write(Html.DisplayName("Valor (Arrecadado/Total)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 26 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Financa\_Visualizar.cshtml"
       Write(Html.DisplayFor(model => model.ValorArrecadado));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 26 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Financa\_Visualizar.cshtml"
                                                          Write(Html.DisplayFor(model => model.ValorTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n");
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <div class=\"modal-footer\">\r\n        <input type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\" value=\"Fechar\">\r\n    </div>\r\n");
#nullable restore
#line 35 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Financa\_Visualizar.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ControleFinanceiro.ViewModels.Financa> Html { get; private set; }
    }
}
#pragma warning restore 1591