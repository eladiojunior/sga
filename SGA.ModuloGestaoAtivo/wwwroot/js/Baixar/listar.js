Listar = {
    CarregarLista: function () {
        Global.MostrarLoading(true);
        $.ajax({
            cache: false,
            type: "POST",
            url: urlRoot + "/Baixar/ListarAtivos",
            dataType: "json",
            success: function (result) {
                Global.MostrarLoading(false);
                if (result.hasErro) {
                    Global.ExibirMensagem(result.erros, true);
                    return;
                }
                $("div.lista-ativos").html(result.model);
                $("a.baixar-ativo").click(function () {
                    var id = $(this).data("id");
                    Global.SubmitActionPost("CarregarBaixar", "Baixar", { "idAtivo": id });
                });
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