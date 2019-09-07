Listar = {
    InitLista: function () {
        $("button.filtrar-lista").click(function () {
            Listar.CarregarLista();
        });
        $("button.registrar-ativo").click(function () {
            Global.SubmitActionGet("Registrar", "Ativo");
        });
    },
    CarregarLista: function () {
        Global.MostrarLoading(true);
        $.ajax({
            cache: false,
            type: "POST",
            url: urlRoot + "/Ativo/ListarAtivos",
            dataType: "json",
            data: $("form.form-filtro").serialize(),
            success: function (result) {
                Global.MostrarLoading(false);
                if (result.hasErro) {
                    Global.ExibirMensagem(result.erros, true);
                    return;
                }
                $("div.lista-ativos").html(result.model);
                $("a.editar-ativo").click(function () {
                    var id = $(this).data("id");
                    Global.SubmitActionPost("CarregarEdicao", "Ativo", { "idAtivo": id });
                });
            }, error: function (XMLHttpRequest, textStatus, errorThrown) {
                Global.MostrarLoading(false);
                Global.ExibirMensagem('Erro na solicitação.', true);
            }
        });
    },
};
$(function () {
    Listar.InitLista();
    Listar.CarregarLista();
});