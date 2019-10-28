$.validator.unobtrusive.parse("#formCrud");
$('#btnSalvar').on('click', function (e) {
    e.preventDefault();
    var bt = this;
    //console.log($('form#formCrud').valid());
    if (!$('form#formCrud').valid()) return;
    $(bt).prop("disabled", true);
    console.log($("form#formCrud").serialize());
    var url = rota;
    $.ajax({
        url: url,
        type: 'POST',
        data: $("form#formCrud").serialize(),
        success: function (result) {
            if (result.success) {
                toastr['success'](result.message);
                $('#myModal').modal('hide');
                $(bt).prop("disabled", false);
                $('#grid-data').bootgrid('reload');
            } else {
                toastr['error'](result.message, msgErro);
                $(bt).prop("disabled", false);
            }
        }
    });
});

$('#btnExcluir').on('click', function (e) {
    e.preventDefault();
    var bt = this;
    $(bt).prop("disabled", true);
    var url = rota;
    $.ajax({
        url: url,
        type: 'POST',
        dataType: "json",
        success: function (result) {
            if (result.success) {
                toastr['success'](result.message);
            } else {
                toastr['error'](result.message, msgErro);
            }
            $('#myModal').modal('hide');
            $(bt).prop("disabled", false);
            $('#grid-data').bootgrid('reload');
        }
    });
});

$('#btnAtivar').on('click', function (e) {
    e.preventDefault();
    var bt = this;
    $(bt).prop("disabled", true);
    var url = rota;
    $.ajax({
        url: url,
        type: 'POST',
        dataType: "json",
        success: function (result) {
            if (result.success) {
                toastr['success'](result.message);
            } else {
                toastr['error'](result.message, msgErro);
            }
            $('#myModal').modal('hide');
            $(bt).prop("disabled", false);
            $('#grid-data').bootgrid('reload');
        }
    });
});

$('.OnClickReload').on('click', function (e) {
    $('#grid-data').bootgrid('reload');
});

$('.form-control').on('keydown', function (e) {
    if (e.keyCode == 13) {
        e.preventDefault();
        $('#btnSalvar').click();
    }
});