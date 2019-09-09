Solicitar = {
    InitSolicitar: function () {
        $("form.form-solicitar").submit(function () {
            Solicitar.Registrar();
            return false;
        });
    },
    Registrar: function () {
        $.ajax({
            cache: false,
            type: "POST",
            url: urlRoot + "/Comprar/Solicitar",
            dataType: "json",
            data: $("form.form-solicitar").serialize(),
            success: function (result) {
                if (result.hasErro) {
                    Global.ExibirMensagem(result.erros, true);
                    return;
                }
                Global.ExibirConfirmacao("Solicitação registrada", "Solicitação de compra de novo ativo registrada com sucesso, deseja voltar a lista?", Solicitar.VoltarLista, Global.LimparCampos($("form.form-solicitar")), "alertaSolicitarCompra");
            }, error: function (XMLHttpRequest, textStatus, errorThrown) {
                Global.ExibirMensagem('Erro na solicitação.', true);
            }
        });
    },
    VoltarLista: function () {
        Global.SubmitActionPost("Listar", "Comprar");
    }
};
$(function () {
    Solicitar.InitSolicitar();
});