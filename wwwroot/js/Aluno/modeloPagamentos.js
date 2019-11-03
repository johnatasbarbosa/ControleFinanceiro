var meses = ["Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"];

function Plano(plano){
    var self = this;
    self.id = ko.observable(plano ? plano.id : 0);
    self.quantidadeDias = ko.observable(plano ? plano.quantidadeDias : 0);
    self.valor = ko.observable(plano ? plano.valor : 0);
}

function Ciclo(ciclo){
    var self = this;
    self.id = ko.observable(ciclo ? ciclo.id : 0);
    self.dataInicio = ko.observable(ciclo ? ciclo.dataInicio : 0);
    self.dataFinal = ko.observable(ciclo ? ciclo.dataFinal : 0);
    self.nomeProfessor = ko.observable(ciclo ? ciclo.professor.nome : 0);
    self.valorPromocional = ko.observable(ciclo ? ciclo.valorPromocional : 0);
    self.ativo = ko.observable(ciclo ? ciclo.ativo : 0);

    self.plano = ko.observable(ciclo ? new Plano(ciclo.plano) : new Plano());
}

function Mes(mes){
    var self = this;
    self.id = ko.observable(mes ? mes.id : 0);
    self.data = ko.observable(mes ? new Date(mes.data) : new Date());
    self.pago = ko.observable(mes ? mes.pago : false);
    self.diaPagamento = ko.observable(mes ? mes.diaPagamento : null);
    self.ativo = ko.observable(mes ? mes.ativo : false);

    self.nome = ko.computed(function(){
        return meses[self.data().getMonth()];
    })
    self.ano = ko.computed(function(){
        return (self.data().getYear() + 1900).toString();
    })
}

function Aluno(aluno){
    var self = this;
    self.id = ko.observable(aluno ? aluno.id : 0);
    self.nome = ko.observable(aluno ? aluno.nome : 0);
    self.plano = ko.observable(aluno ? aluno.plano : 0);

    self.meses = ko.observableArray([]);
}

function PagamentosViewModel(){
    var self = this;

    self.meses = ko.observableArray([]);

    self.mes = ko.observable();
    self.abrirModalDadosMes = function(mes){
        // var index = self.meses.indexOf(pVM.mes);
        self.mes(mes);
        $('#dadosMes').modal('show');
    }
    self.pagar = function(mes){
        var newMes = ko.toJS(mes);
        newMes.pago = true;
        self.salvarMes(newMes);
    }
    self.desfazerPagamento = function(mes){
        var newMes = ko.toJS(mes);
        newMes.pago = false;
        self.salvarMes(newMes);
    }
    self.ativar = function(mes){
        var newMes = ko.toJS(mes);
        newMes.ativo = true;
        self.salvarMes(newMes);
    }
    self.desativar = function(mes){
        var newMes = ko.toJS(mes);
        newMes.ativo = false;
        self.salvarMes(newMes);
    }

    self.salvando = ko.observable();
    self.salvarMes = function(mes){
        console.log(mes.pago, mes.ativo);
        console.log(ko.toJSON(mes));
        self.salvando(true);
        var url = urlSalvarMes;
        $.ajax({
            url: url,
            // data: JSON.stringify({ mes: alunoModel.meses[0] }),
            data: ko.toJSON(mes),
            success: function (result, status) {
                if (result.success) {
                    toastr['success'](result.message);
                    console.log(self.mes().pago(), self.mes().ativo());
                    console.log(mes.pago, mes.ativo);
                    if(self.mes().pago() == false && mes.pago){
                        self.mes().diaPagamento(new Date());
                    }
                    if(self.mes().pago() && mes.pago == false){
                        self.mes().diaPagamento(null);
                    }
                    self.mes().pago(mes.pago);
                    if(self.mes().ativo() && mes.ativo == false){
                        self.mes().diaPagamento(null);
                        self.mes().pago(false);
                    }
                    self.mes().ativo(mes.ativo);
                    $('#dadosMes').modal('hide');
                } else {
                    toastr['error'](result.message);
                }
                self.salvando(false);
            },
            type: 'POST',
            contentType: 'application/json',
            dataType: 'json'
        })
    }

    self.carregarMeses = function(meses){
        console.log("meses", meses);
        meses.forEach(function(mes){
            self.meses.push(new Mes(mes));
        })
    }
    self.carregarMeses(alunoModel.meses);
}

var pVM = new PagamentosViewModel();
ko.applyBindings(pVM);
