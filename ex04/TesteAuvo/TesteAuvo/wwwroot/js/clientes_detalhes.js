$(document).ready(function() {

    $("#label-buscar").keyup(function () {
        var value = $("#label-buscar").val();

        $("#lista-contatos .card").each(function () {
            var nome = $(this).attr("nome-contato").valueOf();

            if (nome.includes(value)) {
                $(this).css("display", "flex");
            }
            else {
                $(this).css("display", "none");
            }
        });
    });
});