#pragma checksum "C:\Users\johna\source\repos\CF\ControleFinanceiro\Views\Aluno\Pagamentos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dfcd26bb5e087fcbd5cfe3db1b0b41e566bf521"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_Pagamentos), @"mvc.1.0.view", @"/Views/Aluno/Pagamentos.cshtml")]
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
#line 1 "C:\Users\johna\source\repos\CF\ControleFinanceiro\Views\_ViewImports.cshtml"
using ControleFinanceiro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\johna\source\repos\CF\ControleFinanceiro\Views\_ViewImports.cshtml"
using ControleFinanceiro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dfcd26bb5e087fcbd5cfe3db1b0b41e566bf521", @"/Views/Aluno/Pagamentos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fe8908c9ef00d8a2cb6d154b078dc85c3dd6eb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno_Pagamentos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ControleFinanceiro.Models.Aluno>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/AbrirModalNovo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/knockoutjs/knockout-3.5.0.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Aluno/modeloPagamentos.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\johna\source\repos\CF\ControleFinanceiro\Views\Aluno\Pagamentos.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral(@"
    <div class=""col-sm-6"">
        <h1 class=""m-0 text-dark"">Pagamentos</h1>
    </div><!-- /.col -->
    <div class=""col-sm-6"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item active"">Pagamentos</li>
        </ol>
    </div><!-- /.col -->
");
            }
            );
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"box\">\r\n            <div class=\"box-header\">\r\n                <h3>");
#nullable restore
#line 23 "C:\Users\johna\source\repos\CF\ControleFinanceiro\Views\Aluno\Pagamentos.cshtml"
               Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            </div>
            <div class=""box-body"">
                <div class=""row"" data-bind=""foreach: meses"">
                    <div class=""col-md-1"">
                        <button type=""button"" class=""btn"" data-bind=""click: $root.abrirModalDadosMes, css: { 'btn-default' : ativo() == false, 'btn-danger' : ativo() == true && pago() == false, 'btn-success' : ativo() == true && pago() == true }"">
                            <span style=""font-size: 0.9em;"" data-bind=""text: nome""></span>
                        </button>
                    </div>
                </div>
                <!-- <span style=""margin-bottom:2px;"" class=""label"" data-bind=""visible: Status() != 2, text:SerialNumber, css: {'label-warning': Status() == 0, 'label-success': Status() == 1}""></span> -->
            </div><!-- /.box-body -->
        </div>
    </div>
</div>

");
#nullable restore
#line 39 "C:\Users\johna\source\repos\CF\ControleFinanceiro\Views\Aluno\Pagamentos.cshtml"
Write(Html.Partial("_DadosMes"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dfcd26bb5e087fcbd5cfe3db1b0b41e566bf5216621", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dfcd26bb5e087fcbd5cfe3db1b0b41e566bf5217720", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        var rotaListar = \"");
#nullable restore
#line 46 "C:\Users\johna\source\repos\CF\ControleFinanceiro\Views\Aluno\Pagamentos.cshtml"
                     Write(Url.Action("Listar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n        var urlSalvarMes = \"");
#nullable restore
#line 47 "C:\Users\johna\source\repos\CF\ControleFinanceiro\Views\Aluno\Pagamentos.cshtml"
                       Write(Url.Action("SalvarMes"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n\r\n        var alunoModel = JSON.parse(\'");
#nullable restore
#line 49 "C:\Users\johna\source\repos\CF\ControleFinanceiro\Views\Aluno\Pagamentos.cshtml"
                                Write(Json.Serialize(@Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n        console.log(alunoModel);\r\n        var planos = JSON.parse(\'");
#nullable restore
#line 51 "C:\Users\johna\source\repos\CF\ControleFinanceiro\Views\Aluno\Pagamentos.cshtml"
                            Write(Json.Serialize(@ViewBag.Planos));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n        console.log(planos);\r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dfcd26bb5e087fcbd5cfe3db1b0b41e566bf52110135", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ControleFinanceiro.Models.Aluno> Html { get; private set; }
    }
}
#pragma warning restore 1591
