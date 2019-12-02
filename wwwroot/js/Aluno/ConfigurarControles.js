function configurarControles() {
    $("button[data-acao=Incluir]").click(abrirModalNovo);
    // moment.locale('pt-br');
    var grid = $("#grid-data").bootgrid({
        ajax: true,
        columnSelection: false,
        url: rotaListar,
        labels: {
            search: "Pesquisar",
            infos: "Mostrando de {{ctx.start}} a {{ctx.end}} de {{ctx.total}} entradas.",
            loading: "Carregando" + "...",
            noResults: "Nenhum Resultado Encontrado",
            refresh: "Atualizar"
        },
        post: function (){
            var ddlStatus = document.getElementById("Status");
            var status = ddlStatus ? ddlStatus.options[ddlStatus.selectedIndex].value : '';

            var ddlSituacao = document.getElementById("Situacao");
            var situacao = ddlSituacao ? ddlSituacao.options[ddlSituacao.selectedIndex].value : '';

            console.log(status, situacao);
            return {
                status: status,
                situacao: situacao
            };
        },
        templates: {
            search:
                "<div class='search form-group'>"+
                    "<div class='input-group'>" + 
                        "<select id='Situacao' class='form-control' onchange='reloadGrid()'>"+
                            "<option value='1'>Todos</option>"+
                            "<option value='2'>Pagamento em dia</option>"+
                            "<option value='3'>Devendo</option>"+
                        "</select>" +
                     "</div>" +
                 "</div>" +
                "<div class='search form-group'>"+
                    "<div class='input-group'>" + 
                        "<select id='Status' class='form-control' onchange='reloadGrid()'>"+
                        "<option value='1'>Ativos</option>"+
                        "<option value='2'>Inativos</option>"+
                        "<option value='3'>Todos</option>"+
                        "</select>" +
                     "</div>" +
                 "</div>" +
                 "<div class='search form-group'>" + 
                    "<div class='input-group'>" +
                        "<span class='icon glyphicon input-group-addon glyphicon-search'></span>" +
                        "<input type='text' class='search-field form-control placeholder='" + "Selecione" + "'>"+
                    "</div>" +
                "</div>"
            },
        formatters: {
            "commands": function (column, row) {
                return "<button type='button' title='" + "Visualizar" + "' class='btn btn-sm btn-default command-visualizar' href='javascript:void(0)' data-row-id='" + row.id + "'><span class='fa fa-search'></span></button>" +
                      "<button type='button' title='" + "Editar" + "' class='btn btn-sm btn-default command-edit' href='javascript:void(0)' data-row-id='" + row.id + "'><span class='fa fa-edit'></span></button>" +
                      "<button type='button' title='" + "Pagamentos" + "' class='btn btn-sm btn-default command-payment' href='javascript:void(0)' data-row-id='" + row.id + "'><span class='fa fa-search'></span></button>";
            },
            "status": function (column, row) {
                if(row.devendo)
                    return "<label class='bg bg-danger'>&nbsp;&nbsp;D&nbsp;&nbsp;</label>"
                return "<label class='bg bg-success'>&nbsp;&nbsp;P&nbsp;&nbsp;</label>"
            },
            "primeiroMes": function (column, row) {
                console.log(row);
                var now = new Date();
                if (row.meses.length >= 3 && row.meses[2].ativo) {
                    if(row.meses[2].pago)
                        return "<input type='checkbox' data-row-id=\"" + row.meses[2].id + "\" class='command-pago' checked>"
                    return "<input type='checkbox' data-row-id=\"" + row.meses[2].id + "\" class='command-pago'>"
                }
                else {
                    return "<input type='checkbox' data-row-id=\"" + row.id + "\" disabled>"
                }
            },
            "segundoMes": function (column, row) {
                var now = new Date();
                if (row.meses.length >= 2 && row.meses[1].ativo) {
                    if(row.meses[1].pago)
                        return "<input type='checkbox' data-row-id=\"" + row.meses[1].id + "\" class='command-pago' checked>"
                    return "<input type='checkbox' data-row-id=\"" + row.meses[1].id + "\" class='command-pago'>"
                }
                else {
                    return "<input type='checkbox' data-row-id=\"" + row.id + "\" disabled>"
                }
            },
            "terceiroMes": function (column, row) {
                var now = new Date();
                if (row.meses.length >= 1 && row.meses[0].ativo) {
                    if(row.meses[0].pago)
                        return "<input type='checkbox' data-row-id=\"" + row.meses[0].id + "\" class='command-pago' checked>"
                    return "<input type='checkbox' data-row-id=\"" + row.meses[0].id + "\" class='command-pago'>"
                }
                else {
                    return "<input type='checkbox' data-row-id=\"" + row.id + "\" disabled>"
                }
            },
            "checkbox": function (column, row) {
                if (row.ativo) {
                    return "<input type='checkbox' data-row-id=\"" + row.id + "\" class='command-ativo' checked>"
                }
                else {
                    return "<input type='checkbox' data-row-id=\"" + row.id + "\" class='command-ativo'>"
                }
            }
        }

    }).on("loaded.rs.jquery.bootgrid", function () {
        /* Executes after data is loaded and rendered */
        grid.find(".command-edit").on("click", function (e) {
            var id = $(this).data("row-id");            
            var url = urlEditar + "/{id}";            

            url = url.replace("{id}", id);

            console.log(url);
            $("#abreModal").load(url);
            $('#myModal').modal('show');
        }).end().find(".command-visualizar").on("click", function (e) {
            var id = $(this).data("row-id");
            var url = urlVisualizar + "/{id}";

            url = url.replace("{id}", id);

            $("#abreModal").load(url);
            $('#myModal').modal('show');
        }).end().find(".command-ativo").change(function (e) {
            var id = $(this).data("row-id");
            var url = urlAtivar + "/{id}";

            url = url.replace("{id}", id);

            $("#abreModal").load(url);
            $('#myModal').modal('show');
            $(this).prop('checked', false); // Unchecks it
        }).end().find(".command-pago").change(function (e) {
            var id = $(this).data("row-id");
            var url = urlPagar + "/{id}";

            url = url.replace("{id}", id);

            $("#abreModal").load(url);
            $('#myModal').modal('show');
            $(this).prop('checked', false); // Unchecks it
        }).end().find(".command-payment").on("click", function (e) {
            var id = $(this).data("row-id");
            var url = urlPagamentos + "/{id}";

            url = url.replace("{id}", id);
            console.log(url);
            window.location.href = url;
        })
    });
}

function reloadGrid(){
    $('#grid-data').bootgrid('reload');
}