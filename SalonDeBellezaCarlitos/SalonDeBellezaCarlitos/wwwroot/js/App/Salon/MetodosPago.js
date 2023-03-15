function AbrirModalCreate()
{
    $("#modalCreate").appendTo('body').modal('show');
}

function GuardarModalCreate() {
    var metp_Descripcion = $('#metp_Descripcion').val();

    $("#lbl_metp_Descripcion").attr('hidden', true);

    if (metp_Descripcion != "") {
        $("#formCreate").submit();

    } else {
        if (metp_Descripcion == "") {
            $("#lbl_metp_Descripcion").attr('hidden', false);
        }
    }

}