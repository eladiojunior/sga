Baixar = {
    InitBaixar: function () {
        $("form.form-baixar").submit(function () {
            Global.MostrarLoading(false);
            Global.ExibirConfirmacao("Confirmar Baixa", "Deseja realmente baixar o ativo?", Baixar.Registrar, null, "confirmaBaixarAtivo");
            return false;
        });
    },
    Registrar: function () {
        $.ajax({
            cache: false,
            type: "POST",
            url: urlRoot + "/Baixar/Registrar",
            dataType: "json",
            data: $("form.form-baixar").serialize(),
            success: function (result) {
                if (result.hasErro) {
                    Global.ExibirMensagem(result.erros, true);
                    return;
                }
                Global.ExibirConfirmacao("Baixa registrada", "Baixa do ativo registrada com sucesso, deseja voltar a lista?", Baixar.VoltarLista, Global.LimparCampos($("form.form-baixar")), "alertaBaixarAtivo");
            }, error: function (XMLHttpRequest, textStatus, errorThrown) {
                Global.ExibirMensagem('Erro na solicitação.', true);
            }
        });
    },
    VoltarLista: function () {
        Global.SubmitActionPost("Listar", "Baixar");
    }
};
$(function () {
    Baixar.InitBaixar();
});