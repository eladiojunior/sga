Editar = {
    InitEditar: function () {
        $("form.form-editar").submit(function () {
            Editar.Gravar();
            return false;
        });
    },
    Gravar: function () {
        $.ajax({
            cache: false,
            type: "POST",
            url: urlRoot + "/Ativo/Gravar",
            dataType: "json",
            data: $("form.form-editar").serialize(),
            success: function (result) {
                if (result.hasErro) {
                    Global.ExibirMensagem(result.erros, true);
                    return;
                }
                Global.ExibirConfirmacao("Alteração realizada", "Ativo atualizado com sucesso, deseja voltar a lista?", Editar.VoltarLista, null, "alertaEdicaoAtivo");
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
    Editar.InitEditar();
});