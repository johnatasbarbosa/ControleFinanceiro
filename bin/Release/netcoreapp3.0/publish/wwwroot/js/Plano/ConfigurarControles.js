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
        formatters: {
            "commands": function (column, row) {
                return "<button type='button' title='" + "Editar" + "' class='btn btn-sm btn-default command-edit' href='javascript:void(0)' data-row-id='" + row.id + "'><span class='fa fa-edit'></span></button>";
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
        })
    });
}