#pragma checksum "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf437642205ed40e1742603ae5900fd85c67bdf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno__Incluir), @"mvc.1.0.view", @"/Views/Aluno/_Incluir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf437642205ed40e1742603ae5900fd85c67bdf3", @"/Views/Aluno/_Incluir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fe8908c9ef00d8a2cb6d154b078dc85c3dd6eb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno__Incluir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ControleFinanceiro.Models.Aluno>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ConfigurarControlesPost.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
 using (Html.BeginForm(ViewContext.RouteData.Values["action"].ToString(), ViewContext.RouteData.Values["controller"].ToString(), FormMethod.Post, new { id = "formCrud" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"modal-header\">\r\n        <h3 class=\"modal-title\" id=\"myModalLabel\">Novo Aluno</h3>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"form\">\r\n        ");
#nullable restore
#line 14 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 19 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 20 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.TextBoxFor(model => model.Nome, new { @class = "form-control", @maxlength = 100 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 21 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.LabelFor(model => model.DataNascimento, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"input-group date\" id=\"datetimepicker1\" data-target-input=\"nearest\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
                   Write(Html.TextBoxFor(model => model.DataNascimento, new { @class = "form-control",  data_toggle="datetimepicker", data_target="#DataNascimento" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""input-group-append"" data-target=""#DataNascimento"" data-toggle=""datetimepicker"">
                            <div class=""input-group-text""><i class=""fa fa-calendar""></i></div>
                        </div>
                    </div>
                    ");
#nullable restore
#line 36 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.ValidationMessageFor(model => model.DataNascimento, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.LabelFor(model => model.Telefone, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 42 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.TextBoxFor(model => model.Telefone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 43 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.ValidationMessageFor(model => model.Telefone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.LabelFor(model => model.PlanoId, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n                    <div class=\"input-group date\" id=\"datetimepicker1\" data-target-input=\"nearest\">\r\n                    ");
#nullable restore
#line 53 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.DropDownListFor(model => model.PlanoId, new SelectList(ViewBag.Planos, "Id", "QuantidadeDias"), new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""input-group-append"">
                            <div class=""input-group-text"">
                                <span id=""valor""></span>
                            </div>
                        </div>
                    </div>                
                    ");
#nullable restore
#line 60 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.ValidationMessageFor(model => model.PlanoId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 65 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.LabelFor(model => model.ValorPromocional, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 66 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.TextBoxFor(model => model.ValorPromocional, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 67 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.ValidationMessageFor(model => model.ValorPromocional, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 72 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.LabelFor(model => model.DiaPagamento, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 73 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.TextBoxFor(model => model.DiaPagamento, new { @class = "form-control", @type="number", min = 1, max = 31 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 74 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.ValidationMessageFor(model => model.DiaPagamento, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 82 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.LabelFor(model => model.Peso, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 83 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.TextBoxFor(model => model.Peso, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 84 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.ValidationMessageFor(model => model.Peso, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 89 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.LabelFor(model => model.Braco, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 90 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.TextBoxFor(model => model.Braco, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 91 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.ValidationMessageFor(model => model.Braco, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 96 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.LabelFor(model => model.Abs, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 97 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.TextBoxFor(model => model.Abs, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 98 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.ValidationMessageFor(model => model.Abs, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 106 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.LabelFor(model => model.Gluteo, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 107 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.TextBoxFor(model => model.Gluteo, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 108 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.ValidationMessageFor(model => model.Gluteo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 113 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.LabelFor(model => model.Perna, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 114 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.TextBoxFor(model => model.Perna, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 115 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.ValidationMessageFor(model => model.Perna, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 120 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.LabelFor(model => model.IMC, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 121 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.TextBoxFor(model => model.IMC, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 122 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
               Write(Html.ValidationMessageFor(model => model.IMC, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"modal-footer\">\r\n        <input type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\" value=\"Fechar\">\r\n        <button type=\"button\" id=\"btnSalvar\" class=\"btn btn-primary\">Salvar</button>\r\n    </div>\r\n");
#nullable restore
#line 132 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf437642205ed40e1742603ae5900fd85c67bdf319444", async() => {
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
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var rota = \"");
#nullable restore
#line 136 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
           Write(Url.Action("Incluir"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    var msgErro = \'Error\';\r\n\r\n    var planos = JSON.parse(\'");
#nullable restore
#line 139 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Incluir.cshtml"
                        Write(Json.Serialize(@ViewBag.Planos));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
    $(document).ready(function () {
        $('#myModal').on('shown.bs.modal', function () {
            $('input:text:visible:first', this).focus();
        });

        $('#DataNascimento').datetimepicker({
            viewMode: 'years',
            format: 'L'
        });

        $(""#PlanoId"").change(function(e){
            atualizarValorPlano($(this).val());
        })
    });
    function atualizarValorPlano(planoId){
        planos.forEach(function(plano){
            if(plano.id == planoId)
                $(""#valor"").text(""R$ "" + plano.valor);
        })
    }
    atualizarValorPlano($(""#PlanoId"").val());
</script>
");
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
