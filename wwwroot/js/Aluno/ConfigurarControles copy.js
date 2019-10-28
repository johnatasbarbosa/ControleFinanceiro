function configurarControles() {
    $("button[data-acao=Incluir]").click(abrirModalNovo);
    moment.locale('pt-br');
    var grid = $("#grid-data").bootgrid({
        ajax: true,
        columnSelection: false,
        url: rotaListar,
        labels: {
            search: ResourcesLayout.Pesquisar,
            infos: ResourcesLayout.MostrandoDeAteEntradas,
            loading: ResourcesLayout.Carregando + "...",
            noResults: ResourcesLayout.NenhumResultadoEncontrado,
            refresh: ResourcesLayout.Atualizar
        },
        post: function (){
            var ddlTiposVisita = document.getElementById("TiposVisita");
            var tipoVisitaSelecionada = ddlTiposVisita ? ddlTiposVisita.options[ddlTiposVisita.selectedIndex].value : '';
            return {
                tipoVisita: tipoVisitaSelecionada
            };
        },
        templates: {
            search:
                "<div class='search form-group'>"+
                    "<div class='input-group'>" + 
                        "<span class='icon fa input-group-addon fa-filter'></span>" + 
                         enumTiposVisita + 
                     "</div>" +
                 "</div>" +
                 "<div class='search form-group'>" + 
                    "<div class='input-group'>" +
                        "<span class='icon glyphicon input-group-addon glyphicon-search'></span>" +
                        "<input type='text' class='search-field form-control placeholder='" + ResourcesLayout.Selecione + "'>"+
                    "</div>" +
                "</div>"
            },
        formatters: {
            "commands": function (column, row) {
                if (row.Ativa && moment(row.Validade).diff(moment().hours(23).minutes(59).seconds(59), 'days') >= 0)
                    return "<button type='button' title='" + ResourcesLayout.Editar + "' class='btn btn-sm btn-default command-edit' href='javascript:void(0)' data-row-id='" + row.Id + "'><span class='fa fa-edit'></span></button>&nbsp" +
                        "<button type='button' title='" + ResourcesLayout.FinalizarVisita + "' class='btn btn-sm btn-danger command-encerrar' href='javascript:void(0)' data-row-id='" + row.Id + "'><span class='fa fa-user-times'></span></button>";
                else
                    return "<button type='button' title='" + ResourcesLayout.Visualizar + "' class='btn btn-sm btn-default command-visualizar' href='javascript:void(0)' data-row-id='" + row.Id + "'><span class='fa fa-search'></span></button>&nbsp"+
                        "<button type='button' title='" + ResourcesLayout.FinalizarVisita + "' class='btn btn-sm btn-danger command-encerrar' href='javascript:void(0)' data-row-id='" + row.Id + "' disabled><span class='fa fa-user-times'></span></button>";
            },
            "visitante": function (column, row) {
                return row.Visitante.Nome;
            },
            "dataInicio": function (column, row) {
                return moment(row.DataEntrada).format("DD/MM/YYYY");
            },
            "dataFim": function (column, row) {
                return moment(row.Validade).format("DD/MM/YYYY");
            },
            "status": function (column, row) {
                if(row.Concluida)
                    return "<span class='fa fa-circle' style='color:#337ab7'></span>";
                else if(row.Encerrada)
                    return "<span class='fa fa-circle' style='color:#d43f3a'></span>";
                else if (moment(row.Validade).diff(moment().hours(23).minutes(59).seconds(59), 'days') < 0)
                    return "<span class='fa fa-circle' style='color:#eea236'></span>";
                else if (row.Ativa)
                    return "<span class='fa fa-circle' style='color:#4cae4c'></span>";
            },
            //"salas": function (column, row) {
            //    var salas = "";
            //    row.VisitaSalas.forEach(function (s, i, a) {
            //        salas += s.Sala.Nome.substring(0, 5);
            //        i < a.length-1 ? salas += ", " : "";
            //    })
            //    return salas;
            //}
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