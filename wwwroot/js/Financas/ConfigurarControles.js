var meses = ["Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"];

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
                console.log(row);
                return "<button type='button' title='" + "Visualizar" + "' class='btn btn-sm btn-default command-visualizar' href='javascript:void(0)' data-row-id='" + row + "'><span class='fa fa-search'></span></button>";
            },
            "mes": function (column, row) {
                var mes = new Date(row).getMonth();
                return mes ? meses[mes] : "";
            },
            "ano": function (column, row) {
                return new Date(row).getUTCFullYear();
            }
        }
    }).on("loaded.rs.jquery.bootgrid", function () {
        /* Executes after data is loaded and rendered */
        grid.find(".command-visualizar").on("click", function (e) {
            var id = $(this).data("row-id");            
            var url = urlVisualizar + "/{id}";            

            url = url.replace("{id}", id);

            console.log(url);
            $("#abreModal").load(url);
            $('#myModal').modal('show');
        })
    });
}