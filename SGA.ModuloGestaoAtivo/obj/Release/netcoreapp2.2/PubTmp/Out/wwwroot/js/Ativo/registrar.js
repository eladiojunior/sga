Registrar = {
    InitRegistrar: function () {
        $("form.form-registrar").submit(function () {
            Registrar.Gravar();
            return false;
        });
    },
    Gravar: function () {
        $.ajax({
            cache: false,
            type: "POST",
            url: urlRoot + "/Ativo/Gravar",
            dataType: "json",
            data: $("form.form-registrar").serialize(),
            success: function (result) {
                if (result.hasErro) {
                    Global.ExibirMensagem(result.erros, true);
                    return;
                }
                Global.ExibirConfirmacao("Registro realizado", "Ativo registrado com sucesso, deseja registrar outro?", Global.LimparCampos($("form.form-registrar")), Registrar.VoltarLista, "alertaRegistroAtivo");
            }, error: function (XMLHttpRequest, textStatus, errorThrown) {
                Global.ExibirMensagem('Erro na solicitação.', true);
            }
        });
    },
    VoltarLista: function () {
        Global.SubmitActionPost("Listar", "Ativo");
    }
};
$(function () {
    Registrar.InitRegistrar();
});