Manter = {
    InitManter: function () {
        $("form.form-manter").submit(function () {
            Manter.Registrar();
            return false;
        });
    },
    Registrar: function () {
        $.ajax({
            cache: false,
            type: "POST",
            url: urlRoot + "/Manter/Registrar",
            dataType: "json",
            data: $("form.form-manter").serialize(),
            success: function (result) {
                if (result.hasErro) {
                    Global.ExibirMensagem(result.erros, true);
                    return;
                }
                Global.ExibirConfirmacao("Manutenção registrada", "Manutenção do ativo registrado com sucesso, deseja voltar a lista?", Manter.VoltarLista, Global.LimparCampos($("form.form-manter")), "alertaManterAtivo");
            }, error: function (XMLHttpRequest, textStatus, errorThrown) {
                Global.ExibirMensagem('Erro na solicitação.', true);
            }
        });
    },
    VoltarLista: function () {
        Global.SubmitActionPost("Listar", "Manter");
    }
};
$(function () {
    Manter.InitManter();
});