Listar = {
    CarregarLista: function () {
        Global.MostrarLoading(true);
        $.ajax({
            cache: false,
            type: "POST",
            url: urlRoot + "/Comprar/ListarSolicitacoes",
            dataType: "json",
            success: function (result) {
                Global.MostrarLoading(false);
                if (result.hasErro) {
                    Global.ExibirMensagem(result.erros, true);
                    return;
                }
                $("div.lista-solicitacoes").html(result.model);
            }, error: function (XMLHttpRequest, textStatus, errorThrown) {
                Global.MostrarLoading(false);
                Global.ExibirMensagem('Erro na solicitação.', true);
            }
        });
    }
};
$(function () {
    Listar.CarregarLista();
});