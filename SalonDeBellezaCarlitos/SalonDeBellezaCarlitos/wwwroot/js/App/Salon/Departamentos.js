function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
}

function GuardarModalCreate() {
    var depa_Codigo = $('#depa_Codigo').val();
    var depa_Descripcion = $('#depa_Descripcion').val();

    $("#lbl_depa_Codigo").attr('hidden', true);
    $("#lbl_depa_Descripcion").attr('hidden', true);

    if (depa_Codigo != "" && depa_Descripcion != "") {
        $("#formCreate").submit();

    } else {
        if (depa_Codigo == "") {
            $("#lbl_depa_Codigo").attr('hidden', false);
        }
        if (depa_Descripcion == "") {
            $("#lbl_depa_Descripcion").attr('hidden', false);
        }
    }

}