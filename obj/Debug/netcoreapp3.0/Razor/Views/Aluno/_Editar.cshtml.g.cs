#pragma checksum "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f59032b128c9fa05565f2323b96e20ab60eed5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno__Editar), @"mvc.1.0.view", @"/Views/Aluno/_Editar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f59032b128c9fa05565f2323b96e20ab60eed5", @"/Views/Aluno/_Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a701db6c00d0d0416fa8af2aa8330b1b93b7d37", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno__Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ControleFinanceiro.Models.Aluno>
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
#line 3 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
 using (Html.BeginForm(ViewContext.RouteData.Values["action"].ToString(), ViewContext.RouteData.Values["controller"].ToString(), FormMethod.Post, new { id = "formCrud" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"modal-header\">\r\n        <h3 class=\"modal-title\" id=\"myModalLabel\">Editar Aluno</h3>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"form\">\r\n        ");
#nullable restore
#line 14 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 20 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 21 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.TextBoxFor(model => model.Nome, new { @class = "form-control", @maxlength = 100 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.LabelFor(model => model.DataNascimento, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"input-group date\" id=\"datetimepicker1\" data-target-input=\"nearest\">\r\n                        <!-- <input type=\"text\" class=\"form-control datetimepicker-input\" data-target=\"#datetimepicker1\"/> -->\r\n                        ");
#nullable restore
#line 33 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
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
#line 38 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.ValidationMessageFor(model => model.DataNascimento, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.LabelFor(model => model.Telefone, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 44 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.TextBoxFor(model => model.Telefone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 45 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.ValidationMessageFor(model => model.Telefone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 53 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.LabelFor(model => model.Ciclo.PlanoId, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n                    <div class=\"input-group date\" id=\"datetimepicker1\" data-target-input=\"nearest\">\r\n                    ");
#nullable restore
#line 55 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.DropDownListFor(model => model.Ciclo.PlanoId, new SelectList(ViewBag.Planos, "Id", "QuantidadeDias"), new {@class = "form-control"}));

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
#line 62 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.ValidationMessageFor(model => model.Ciclo.PlanoId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 67 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.LabelFor(model => model.Ciclo.ValorPromocional, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 68 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.TextBoxFor(model => model.Ciclo.ValorPromocional, new { @class = "form-control", @type="number", min = 1, max = 31 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 69 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.ValidationMessageFor(model => model.Ciclo.ValorPromocional, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 74 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.LabelFor(model => model.DiaPagamento, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 75 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.TextBoxFor(model => model.DiaPagamento, new { @class = "form-control", @type="number", min = 1, max = 31 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 76 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.ValidationMessageFor(model => model.DiaPagamento, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 84 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.LabelFor(model => model.Peso, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 85 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.TextBoxFor(model => model.Peso, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 86 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.ValidationMessageFor(model => model.Peso, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 91 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.LabelFor(model => model.Braco, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 92 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.TextBoxFor(model => model.Braco, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 93 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.ValidationMessageFor(model => model.Braco, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 98 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.LabelFor(model => model.Abs, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 99 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.TextBoxFor(model => model.Abs, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 100 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.ValidationMessageFor(model => model.Abs, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 108 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.LabelFor(model => model.Gluteo, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 109 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.TextBoxFor(model => model.Gluteo, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 110 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.ValidationMessageFor(model => model.Gluteo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 115 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.LabelFor(model => model.Perna, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 116 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.TextBoxFor(model => model.Perna, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 117 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.ValidationMessageFor(model => model.Perna, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-4\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 122 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.LabelFor(model => model.IMC, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 123 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.TextBoxFor(model => model.IMC, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 124 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
               Write(Html.ValidationMessageFor(model => model.IMC, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"modal-footer\">\r\n        <input type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\" value=\"Fechar\">\r\n        <button type=\"button\" id=\"btnSalvar\" class=\"btn btn-primary\">Salvar</button>\r\n    </div>\r\n");
#nullable restore
#line 134 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99f59032b128c9fa05565f2323b96e20ab60eed519853", async() => {
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
#line 138 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
           Write(Url.Action("Editar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    var msgErro = \'Error\';\r\n\r\n    var planos = JSON.parse(\'");
#nullable restore
#line 141 "C:\Users\johna\source\repos\ControleFinanceiro\Views\Aluno\_Editar.cshtml"
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

        $(""#Ciclo_PlanoId"").change(function(e){
            atualizarValorPlano($(this).val());
        })
    });
    function atualizarValorPlano(planoId){
        planos.forEach(function(plano){
            if(plano.id == planoId)
                $(""#valor"").text(""R$ "" + plano.valor);
        })
    }
    atualizarValorPlano($(""#Ciclo_PlanoId"").val());
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
