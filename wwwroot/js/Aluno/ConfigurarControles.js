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
        // post: function (){
        //     var ddlTiposVisita = document.getElementById("TiposVisita");
        //     var tipoVisitaSelecionada = ddlTiposVisita ? ddlTiposVisita.options[ddlTiposVisita.selectedIndex].value : '';
        //     return {
        //         tipoVisita: tipoVisitaSelecionada
        //     };
        // },
        // templates: {
        //     search:
        //         "<div class='search form-group'>"+
        //             "<div class='input-group'>" + 
        //                 "<span class='icon fa input-group-addon fa-filter'></span>" + 
        //                  enumTiposVisita + 
        //              "</div>" +
        //          "</div>" +
        //          "<div class='search form-group'>" + 
        //             "<div class='input-group'>" +
        //                 "<span class='icon glyphicon input-group-addon glyphicon-search'></span>" +
        //                 "<input type='text' class='search-field form-control placeholder='" + ResourcesLayout.Selecione + "'>"+
        //             "</div>" +
        //         "</div>"
        //     },
        formatters: {
            "commands": function (column, row) {
                // console.log(row);
                return "<button type='button' title='" + "Editar" + "' class='btn btn-sm btn-default command-edit' href='javascript:void(0)' data-row-id='" + row.Id + "'><span class='fa fa-edit'></span></button>&nbsp" +
                    "<button type='button' title='" + "Visualizar" + "' class='btn btn-sm btn-danger command-encerrar' href='javascript:void(0)' data-row-id='" + row.Id + "'><span class='fa fa-user-times'></span></button>";
            },
            "primeiroMes": function (column, row) {
                if (row.Ativo) {
                    return "<input type='checkbox' data-row-id=\"" + row.Id + "\" class='command-ativo' checked>"
                }
                else {
                    return "<input type='checkbox' data-row-id=\"" + row.Id + "\" class='command-ativo'>"
                }
            },
            "checkbox": function (column, row) {
                if (row.Ativo) {
                    return "<input type='checkbox' data-row-id=\"" + row.Id + "\" class='command-ativo' checked>"
                }
                else {
                    return "<input type='checkbox' data-row-id=\"" + row.Id + "\" class='command-ativo'>"
                }
            }
        }

    }).on("loaded.rs.jquery.bootgrid", function () {
        /* Executes after data is loaded and rendered */
        grid.find(".command-edit").on("click", function (e) {
            var id = $(this).data("row-id");            
            var url = urlEditar + "/{id}";
            

            url = url.replace("{id}", id);

            $("#abreModal").load(url);
            $('#myModal').modal('show');
        }).end().find(".command-visualizar").on("click", function (e) {
            var id = $(this).data("row-id");
            var url = urlVisualizar + "/{id}";

            url = url.replace("{id}", id);

            $("#abreModal").load(url);
            $('#myModal').modal('show');
        }).end().find(".command-encerrar").on("click", function (e) {
            var id = $(this).data("row-id");
            var url = urlEncerrar + "/{id}";

            url = url.replace("{id}", id);

            $("#abreModal").load(url);
            $('#myModal').modal('show');
        });
    });
}