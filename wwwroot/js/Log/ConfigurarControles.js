function configurarControles() {

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
        // post: function () {
        //     var ddlTipoLog = document.getElementById("TipoLog");
        //     var tipoLogSelecionado = ddlTipoLog ? ddlTipoLog.options[ddlTipoLog.selectedIndex].value : '';
        //     return {
        //         tipoLog: tipoLogSelecionado
        //     };
        // },
        // templates: {
        //     search:
        //             "<div class='search form-group'>" +
        //                 "<div class='input-group'>" +
        //                     "<span class='icon fa input-group-addon fa-filter'></span>" +
        //                     enumTipoLog +
        //                 "</div>" +
        //             "</div>" +
        //             "<div class='search form-group'>" +
        //                 "<div class='input-group'>" +
        //                     "<span class='icon glyphicon input-group-addon glyphicon-search'></span>" +
        //                     "<input type='text' class='search-field form-control' placeholder='" + ResourcesLayout.Pesquisar + "'>" +
        //                 "</div>" +
        //             "</div>"
        // },
        converters: {
            "datetime": {
                to: function (value) { return moment(value).format("L LTS"); }
            }
        },
        formatters: {
            "commands": function (column, row) {
                return "<button type='button' title='" + "Detalhes" + "' class='btn btn-sm btn-default command-details' href='javascript:void(0)' data-row-id='" + row.id + "' ><span class='fa fa-search'></span></button>&nbsp"
            }
        }

    }).on("loaded.rs.jquery.bootgrid", function () {
        /* Executes after data is loaded and rendered */
        grid.find(".command-details").on("click", function (e) {

            var id = $(this).data("row-id");
            var url = urlDetalhes + "/{id}";

            url = url.replace("{id}", id);

            $("#abreModal").load(url);
            $('#myModal').modal('show');
        });
    });
}